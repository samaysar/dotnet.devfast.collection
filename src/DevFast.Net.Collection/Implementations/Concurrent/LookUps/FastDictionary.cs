using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DevFast.Net.Collection.Implementations.Concurrent.LookUps;

/// <summary>
/// Represents a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently.
/// </summary>
/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
public sealed partial class FastDictionary<TKey, TValue> :
    IDictionary<TKey, TValue>,
    IReadOnlyDictionary<TKey, TValue>
        where TKey : notnull
{
    private readonly IEqualityComparer<TKey> _comparer;
    private readonly Dictionary<TKey, TValue>[] _data;
    private readonly int _concurrencyLevel;

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
    public FastDictionary(IEqualityComparer<TKey> comparer) : this(0, comparer)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastDictionary{TKey, TValue}" /> class that is empty
    /// and has the given <paramref name="initialCapacity"/>, has given <paramref name="concurrencyLevel"/>
    /// and uses default Equality comparer for the key.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than <paramref name="initialCapacity"/> * <paramref name="concurrencyLevel"/>.
    /// </para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=0 and <paramref name="concurrencyLevel"/> has internal lower bound=2.
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
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=0.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastDictionary(int initialCapacity,
        IEqualityComparer<TKey> comparer) : this(initialCapacity,
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
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=0 and <paramref name="concurrencyLevel"/> has internal lower bound=2.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastDictionary(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<TKey> comparer)
    {
        _comparer = comparer ?? EqualityComparer<TKey>.Default;
        _concurrencyLevel = Math.Max(2, concurrencyLevel);
        _data = new Dictionary<TKey, TValue>[_concurrencyLevel];
        initialCapacity = Math.Max(0, initialCapacity);
        for (int i = 0; i < _concurrencyLevel; i++)
        {
            _data[i] = new Dictionary<TKey, TValue>(initialCapacity, _comparer);
        }
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
    public ICollection<TKey> Keys => ((IReadOnlyDictionary<TKey, TValue>)this).Keys.ToList();

    /// <inheritdoc />
    public ICollection<TValue> Values => ((IReadOnlyDictionary<TKey, TValue>)this).Values.ToList();

    /// <inheritdoc />
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
    IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => new KeyEnumerable(this);

    /// <inheritdoc />
    IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => new ValueEnumerable(this);

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

    /// <summary>
    /// Removes all items from all the partitions.
    /// </summary>
    /// <param name="releaseMemory">If <see langword="true"/>, partitions are recreated by releasing previously allocated memory.</param>
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

    /// <summary>
    /// Removes all items from all the partitions.
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the partitions to be re-created.</param>
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
                _ = Interlocked.CompareExchange(ref _data[i],
                    new Dictionary<TKey, TValue>(initialCapacity, _comparer),
                    d);
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
        TValue v;
        Dictionary<TKey, TValue> d = GetPartition(item.Key);
        Monitor.Enter(d);
        try
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            foundValue = d.TryGetValue(item.Key, out v);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
        finally
        {
            Monitor.Exit(d);
        }

        //it is safe to compare value outside of try block
        //this way, we will release the lock quicker!
        return foundValue && (valueComparer ?? EqualityComparer<TValue>.Default).Equals(v, item.Value);
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
    public bool TryGetValue(TKey key, out TValue value)
    {
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            return d.TryGetValue(key, out value);
#pragma warning restore CS8601 // Possible null reference assignment.
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
#pragma warning disable CS8601 // Possible null reference assignment.
            return d.Remove(key, out value);
#pragma warning restore CS8601 // Possible null reference assignment.
#else
            return d.TryGetValue(key, out value) && d.Remove(key);
#endif
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

    /// <inheritdoc />
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
#pragma warning disable CS8601 // Possible null reference assignment.
            if (!d.TryGetValue(key, out existingValue))
#pragma warning restore CS8601 // Possible null reference assignment.
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
        unchecked
        {
            return _data[(uint)key.GetHashCode() % _concurrencyLevel];
        }
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private bool TryGetPartition(int position, [NotNullWhen(true)] out Dictionary<TKey, TValue>? partition)
    {
        if (position >= 0 && position < _concurrencyLevel)
        {
            partition = _data[position];
            return true;
        }
        partition = default;
        return false;
    }
}
