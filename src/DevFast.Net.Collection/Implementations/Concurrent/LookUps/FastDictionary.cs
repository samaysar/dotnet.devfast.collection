﻿using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Concurrent.LookUps;

namespace DevFast.Net.Collection.Implementations.Concurrent.LookUps;

/// <summary>
/// Represents a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently.
/// </summary>
/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
public sealed partial class FastDictionary<TKey, TValue> :
    IFastDictionary<TKey, TValue>
        where TKey : notnull
{
    private readonly IEqualityComparer<TKey> _comparer;
    private readonly Dictionary<TKey, TValue>[] _data;
    private readonly int _concurrencyHash;

    /// <summary>
    /// Initializes a new instance of the <see cref="FastDictionary{TKey, TValue}" /> class that is empty and
    /// has the default initial capacity, has default concurrency level,
    /// and uses default Equality comparer for the key.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.
    /// </para>
    /// </summary>
    public FastDictionary() : this(EqualityComparer<TKey>.Default)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastDictionary{TKey, TValue}" /> class that is empty and
    /// has the default initial capacity, has default concurrency level,
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.
    /// </para>
    /// </summary>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastDictionary(IEqualityComparer<TKey>? comparer) : this(0, comparer)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastDictionary{TKey, TValue}" /> class that is empty
    /// and has the given <paramref name="initialCapacity"/>, has given <paramref name="concurrencyLevel"/>
    /// and uses default Equality comparer for the key.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than <paramref name="initialCapacity"/> * <paramref name="concurrencyLevel"/>.
    /// </para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=<see cref="FixedValues.MinInitialCapacity"/> and <paramref name="concurrencyLevel"/> has internal lower bound=<see cref="FixedValues.MinConcurrencyLevel"/>.
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.FastDictionaryMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Concurrency level</param>
    public FastDictionary(int initialCapacity,
        int concurrencyLevel) : this(initialCapacity, concurrencyLevel, EqualityComparer<TKey>.Default)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastDictionary{TKey, TValue}" /> class that is empty and
    /// and has the given <paramref name="initialCapacity"/>, has default concurrency level,
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than <paramref name="initialCapacity"/> * default_concurrency_level.
    /// </para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=<see cref="FixedValues.MinInitialCapacity"/>.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastDictionary(int initialCapacity,
        IEqualityComparer<TKey>? comparer) : this(initialCapacity,
        Environment.ProcessorCount,
        comparer)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastDictionary{TKey, TValue}" /> class that is empty
    /// and has the given <paramref name="initialCapacity"/>, has given <paramref name="concurrencyLevel"/>
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than <paramref name="initialCapacity"/> * <paramref name="concurrencyLevel"/>.
    /// </para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=<see cref="FixedValues.MinInitialCapacity"/> and <paramref name="concurrencyLevel"/> has internal lower bound=<see cref="FixedValues.MinConcurrencyLevel"/>.
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.FastDictionaryMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastDictionary(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<TKey>? comparer)
    {
        _comparer = comparer ?? EqualityComparer<TKey>.Default;
        _concurrencyHash = GetConcurrencyHash(Math.Max(concurrencyLevel, FixedValues.MinConcurrencyLevel));
        _data = new Dictionary<TKey, TValue>[_concurrencyHash];
        initialCapacity = Math.Max(FixedValues.MinInitialCapacity, initialCapacity);
        for (int i = 0; i < _concurrencyHash; i++)
        {
            _data[i] = new Dictionary<TKey, TValue>(initialCapacity, _comparer);
        }
    }

    /// <inheritdoc cref="IDictionary{TKey,TValue}.this" />
    public TValue this[TKey key]
    {
        get => TryGetValue(key, out TValue? v) ? v : throw new KeyNotFoundException();
        set
        {
            Dictionary<TKey, TValue> d = GetPartition(key);
            Monitor.Enter(d);
            try
            {
                d[key] = value;
            }
            finally
            {
                Monitor.Exit(d);
            }
        }
    }

    /// <summary>
    /// Gets an <see cref="ICollection{T}"/> that contains the keys of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
    /// enumeration. Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition.
    /// That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// Partition snapshots are created as enumerable visits those. However, space complexity of
    /// this implementation is HIGH due to the fact that all the partitions are visited almost immediately
    /// in order to create a copy of all the keys from all the partitions.
    /// <para>
    /// In order to reduce space complexity, use either <see cref="IReadOnlyDictionary{TKey, TValue}.Keys"/>
    /// or <see cref="EnumerableOfKeys"/>.
    /// </para>
    /// </summary>
    public ICollection<TKey> Keys => GetKeyCollection();

    /// <summary>
    /// Gets an <see cref="ICollection{T}"/> that contains the values of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
    /// enumeration. Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition.
    /// That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// Partition snapshots are created as enumerable visits those. However, space complexity of
    /// this implementation is HIGH due to the fact that all the partitions are visited almost immediately
    /// in order to create a copy of all the keys from all the partitions.
    /// <para>
    /// In order to reduce space complexity, use either <see cref="IReadOnlyDictionary{TKey, TValue}.Values"/>
    /// or <see cref="EnumerableOfValues"/>.
    /// </para>
    /// </summary>
    public ICollection<TValue> Values => GetValueCollection();

    /// <inheritdoc cref="ICollection{T}.Count" />
    public int Count
    {
        get
        {
            //We do not want to take all locks together
            //this call will provide best-effort count.
            int totCount = 0;
            int i = _data.Length;
            for (; i > 0;)
            {
                Dictionary<TKey, TValue> d = _data[--i];
                Monitor.Enter(d);
                try
                {
                    totCount += d.Count;
                }
                finally
                {
                    Monitor.Exit(d);
                }
            }
            return totCount;
        }
    }

    /// <inheritdoc />
    public bool IsReadOnly => false;

    /// <inheritdoc />
    public int PartitionCount => _data.Length;

    /// <summary>
    /// Gets an enumerable collection that contains the keys of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
    /// enumeration. Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition.
    /// That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
    /// </summary>
    IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => EnumerableOfKeys();

    /// <summary>
    /// Gets an enumerable collection that contains the values of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
    /// enumeration. Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition.
    /// That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
    /// </summary>
    IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => EnumerableOfValues();

    /// <inheritdoc />
    public void Add(TKey key, TValue value)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
            d.Add(key, value);
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <inheritdoc />
    public void Add(KeyValuePair<TKey, TValue> item)
    {
        Add(item.Key, item.Value);
    }

    /// <summary>
    /// Adds <paramref name="key"/>/<paramref name="addValue"/> pair to the collection
    /// if the <paramref name="key"/> does not already exist,
    /// or updates <paramref name="key"/>/value pair by using <paramref name="updateValueFactory"/> lambda
    /// if the <paramref name="key"/> already exists.
    /// </summary>
    /// <param name="key">The key to be added or updated</param>
    /// <param name="addValue">The value to be added</param>
    /// <param name="updateValueFactory">Value generating lambda for an existing key and value</param>
    /// <param name="comparer">Value comparer. If not provided then default implementation will be used.</param>
    /// <returns>The new value for the key. This will be either be <paramref name="addValue" /> (if the key was absent) or the result of <paramref name="updateValueFactory" /> (if the key was present).</returns>
    public TValue AddOrUpdate(TKey key,
        TValue addValue,
        Func<TKey, TValue, TValue> updateValueFactory,
        IEqualityComparer<TValue>? comparer = null)
    {
        while (!TryAddCore(key, addValue, out TValue? existing))
        {
            TValue? newValue = updateValueFactory(key, existing);
            if (TryUpdate(key, newValue, existing, comparer))
            {
                return newValue;
            }
        }

        return addValue;
    }

    /// <summary>
    /// Removes all items from all the partitions; however, allocated memory is retained.
    /// <see cref="Clear(bool)"/> and <see cref="Clear(int)"/>.
    /// </summary>
    public void Clear()
    {
        //We do not want to take all locks together
        //this call will provide best-effort clearing on whole collection.
        int i = _data.Length;
        for (; i > 0;)
        {
            Dictionary<TKey, TValue> d = _data[--i];
            Monitor.Enter(d);
            try
            {
                d.Clear();
            }
            finally
            {
                Monitor.Exit(d);
            }
        }
    }

    /// <inheritdoc />
    public void Clear(bool releaseMemory)
    {
        //We do not want to take all locks together
        //this call will provide best-effort clearing on whole collection.
        if (releaseMemory)
        {
            Clear(0);
        }
        else
        {
            Clear();
        }
    }

    /// <inheritdoc />
    public void Clear(int initialCapacity)
    {
        //We do not want to take all locks together
        //this call will provide best-effort clearing on whole collection.
        int i = _data.Length;
        for (; i > 0;)
        {
            Dictionary<TKey, TValue> d = _data[--i];
            Monitor.Enter(d);
            try
            {
                if (!ReferenceEquals(_data[i], d))
                {
                    _data[i] = new Dictionary<TKey, TValue>(initialCapacity, _comparer);
                }
            }
            finally
            {
                Monitor.Exit(d);
            }
        }
    }

    /// <inheritdoc />
    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        return Contains(item, null);
    }

    /// <summary>
    /// Checks whether given key/value pair is part of current collection using provided <paramref name="valueComparer"/>.
    /// If <paramref name="valueComparer"/> is <see langword="null" />, then <see cref="EqualityComparer{TValue}.Default"/>
    /// will be used.
    /// </summary>
    /// <param name="item">Key value pair to check</param>
    /// <param name="valueComparer">Equality comparer for the value.</param>
    public bool Contains(KeyValuePair<TKey, TValue> item, IEqualityComparer<TValue>? valueComparer)
    {
        bool foundValue;
        TValue? v;
        Dictionary<TKey, TValue> d = GetPartition(item.Key);
        Monitor.Enter(d);
        try
        {
            foundValue = d.TryGetValue(item.Key, out v);
        }
        finally
        {
            Monitor.Exit(d);
        }

        //it is safe to compare value outside of try block
        //this way, we will release the lock quicker!
        return foundValue && (valueComparer ?? EqualityComparer<TValue>.Default).Equals(v, item.Value);
    }

    /// <inheritdoc cref="IDictionary{TKey,TValue}.ContainsKey" />
    public bool ContainsKey(TKey key)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
            return d.ContainsKey(key);
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <inheritdoc />
    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        foreach (KeyValuePair<TKey, TValue> pair in this)
        {
            array[arrayIndex++] = pair;
        }
    }

    /// <inheritdoc />
    public IEnumerable<TKey> EnumerableOfKeys()
    {
        return new KeyEnumerable(this);
    }

    /// <inheritdoc />
    public IEnumerable<TValue> EnumerableOfValues()
    {
        return new ValueEnumerable(this);
    }

    /// <summary>
    /// Gets an enumerable collection that contains the <see cref="KeyValuePair{TKey, TValue}"/> of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
    /// enumeration. Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition
    /// at a time. That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// </summary>
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return new Enumerator(this);
    }

    /// <summary>
    /// Adds a key/value pair to the collection by using the specified function
    /// if the key does not already exist.
    /// Returns the new value, or the existing value if the key exists.</summary>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="valueFactory">The function used to generate a value for the key.</param>
    /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
    public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
    {
        return TryGetValue(key, out TValue? v) ? v : GetOrAdd(key, valueFactory(key));
    }

    /// <summary>
    /// Adds a key/value pair to the collection if the key does not already exist.
    /// Returns the new value, or the existing value if the key exists.
    /// </summary>
    /// <param name="key">Key value.</param>
    /// <param name="value">Value.</param>
    /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
    public TValue GetOrAdd(TKey key, TValue value)
    {
        return TryAddCore(key, value, out TValue? existingValue) ? value : existingValue;
    }

    /// <inheritdoc />
    public bool Remove(TKey key)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
            return d.Remove(key);
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <inheritdoc />
    public bool Remove(KeyValuePair<TKey, TValue> item)
    {
        return Remove(item, null);
    }

    /// <summary>
    /// Removes the given key/value pair from the collection using provided <paramref name="valueComparer"/>.
    /// If <paramref name="valueComparer"/> is <see langword="null" />, then <see cref="EqualityComparer{TValue}.Default"/>
    /// will be used.
    /// </summary>
    /// <param name="item">Key value pair to be removed.</param>
    /// <param name="valueComparer">Equality comparer for the value.</param>
    public bool Remove(KeyValuePair<TKey, TValue> item, IEqualityComparer<TValue>? valueComparer)
    {
        Dictionary<TKey, TValue> d = GetPartition(item.Key);
        Monitor.Enter(d);
        try
        {
            //We do not want to take Remove logic out of this
            //try block, though it is possible (with almost no probability)
            //that by the time we retake the lock on partition,
            //another thread removed the key and re-added with another value!!!
            return d.TryGetValue(item.Key, out TValue? v) &&
                      (valueComparer ?? EqualityComparer<TValue>.Default).Equals(v, item.Value) &&
                      d.Remove(item.Key);
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <summary>
    /// Attempts to add the specified key and value to the collection.
    /// </summary>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="value">The value of the element to add.</param>
    /// <returns> <see langword="true" /> if the key/value pair was added successfully; <see langword="false" /> if the key already exists.</returns>
    public bool TryAdd(TKey key, TValue value)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
#if NETCOREAPP3_0_OR_GREATER
            return d.TryAdd(key, value);
#else
            if (!d.ContainsKey(key))
            {
                d.Add(key, value);
                return true;
            }
            return false;
#endif
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <inheritdoc cref="IDictionary{TKey,TValue}.TryGetValue" />
    public bool TryGetValue(TKey key, out TValue value)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS8601 // Possible null reference assignment.
            return d.TryGetValue(key, out value);
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore IDE0079 // Remove unnecessary suppression
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <summary>
    /// Attempts to remove and return the value that has the specified key.
    /// </summary>
    /// <param name="key">The key of the element to remove and return.</param>
    /// <param name="value">When this method returns, contains the object removed from the collection, or the default value of the <see langword="TValue" /> type if <paramref name="key" /> does not exist.</param>
    /// <returns><see langword="true" /> if the object was removed successfully; otherwise, <see langword="false" />.</returns>
    public bool TryRemove(TKey key, out TValue value)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS8601 // Possible null reference assignment.
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
            return d.Remove(key, out value);
#else
            return d.TryGetValue(key, out value) && d.Remove(key);
#endif
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore IDE0079 // Remove unnecessary suppression
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <summary>
    /// Updates the value associated with <paramref name="key" /> to <paramref name="newValue" />
    /// if the existing value with <paramref name="key" /> is equal to <paramref name="comparisonValue" />.
    /// </summary>
    /// <param name="key">key.</param>
    /// <param name="newValue">Replacement value.</param>
    /// <param name="comparisonValue">Value to compare with the existing key value.</param>
    /// <param name="comparer">Value comparer. If not provided then default implementation will be used.</param>
    /// <returns><see langword="true" /> if the value with <paramref name="key" /> was equal to <paramref name="comparisonValue" /> and was replaced with <paramref name="newValue" />; otherwise, <see langword="false" />.</returns>
    public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue, IEqualityComparer<TValue>? comparer = null)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
            if (d.TryGetValue(key, out TValue? v) &&
                (comparer ?? EqualityComparer<TValue>.Default).Equals(v, comparisonValue))
            {
                d[key] = newValue;
                return true;
            }
            return false;
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <summary>
    /// Gets an enumerable collection that contains the boxed <see cref="KeyValuePair{TKey, TValue}"/> of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
    /// enumeration. Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition
    /// at a time. That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private bool TryAddCore(TKey key,
        TValue newValue,
        out TValue existingValue)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS8601 // Possible null reference assignment.
            if (!d.TryGetValue(key, out existingValue))
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore IDE0079 // Remove unnecessary suppression
            {
                d.Add(key, newValue);
                return true;
            }
            return false;
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private Dictionary<TKey, TValue> GetPartition(TKey key)
    {
        return _data[key.GetHashCode() & _concurrencyHash];
    }

    private bool TryGetPartition(int position, [NotNullWhen(true)] out Dictionary<TKey, TValue>? partition)
    {
        if (position >= 0 && position < _concurrencyHash)
        {
            partition = _data[position];
            return true;
        }
        partition = default;
        return false;
    }

    private ICollection<TKey> GetKeyCollection()
    {
        return EnumerableOfKeys().ToList();
    }

    private ICollection<TValue> GetValueCollection()
    {
        return EnumerableOfValues().ToList();
    }

    private static int GetConcurrencyHash(int concurrencyLevel)
    {
        var currentPow2 = 2;
        while (concurrencyLevel > currentPow2 &&
            currentPow2 < FixedValues.FastDictionaryMaxConcurrencyLevel)
        {
            currentPow2 <<= 1;
        }
        return currentPow2 - 1;
    }
}
