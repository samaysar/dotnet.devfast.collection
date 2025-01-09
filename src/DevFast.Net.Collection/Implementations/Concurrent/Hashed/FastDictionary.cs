using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Concurrent.Hashed;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DevFast.Net.Collection.Implementations.Concurrent.Hashed;

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
    private Dictionary<TKey, TValue>[] _data;
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
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.HashedCollectionMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
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
        FixedValues.ProcessorCountWithMinBound,
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
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.HashedCollectionMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastDictionary(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<TKey>? comparer) : this(initialCapacity, concurrencyLevel, comparer, [], true)
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
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.HashedCollectionMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="comparer">Equality comparer for the key</param>
    /// <param name="source">Data to initial the dictionary with</param>
    public FastDictionary(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<TKey>? comparer,
        IReadOnlyDictionary<TKey, TValue> source) : this(comparer, initialCapacity, concurrencyLevel)
    {
        if (source is IFastDictionary<TKey, TValue> fd)
        {
            InitializeEntries(Add, fd);
        }
        else
        {
            InitializeEntries(Add, source);
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastDictionary{TKey, TValue}" /> class that is empty
    /// and has the given <paramref name="initialCapacity"/>, has given <paramref name="concurrencyLevel"/>
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than <paramref name="initialCapacity"/> * <paramref name="concurrencyLevel"/>.
    /// </para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=<see cref="FixedValues.MinInitialCapacity"/> and <paramref name="concurrencyLevel"/> has internal lower bound=<see cref="FixedValues.MinConcurrencyLevel"/>.
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.HashedCollectionMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="initialData">Data to initial the dictionary with</param>
    /// <param name="comparer">Equality comparer for the key</param>
    /// <param name="ignoreDuplicates">When <see langword="true"/> all duplicate keys in the <paramref name="initialData"/> are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.</param>
    public FastDictionary(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<TKey>? comparer,
        IEnumerable<KeyValuePair<TKey, TValue>> initialData,
        bool ignoreDuplicates) : this(comparer, initialCapacity, concurrencyLevel)
    {
        Action<KeyValuePair<TKey, TValue>> lambda = ignoreDuplicates
            ? (pair => this[pair.Key] = pair.Value)
            : (pair => Add(pair));
        InitializeEntries(lambda, initialData);
    }

    private FastDictionary(IEqualityComparer<TKey>? comparer,
        int initialCapacity,
        int concurrencyLevel)
    {
        _comparer = comparer ?? EqualityComparer<TKey>.Default;
        _concurrencyHash = Math.Max(concurrencyLevel, FixedValues.MinConcurrencyLevel).ToPow2HashMask();
        _data = CreateDataSet(initialCapacity, _concurrencyHash + 1, comparer);
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
    /// IMPLEMENTATION NOTES: Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition.
    /// That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// Partition snapshots are created as enumerable visits those. However, space complexity of
    /// this implementation is HIGH due to the fact that all the partitions are visited almost immediately
    /// in order to create a copy of all the keys from all the partitions.
    /// <para>
    /// In order to reduce space complexity, use either <see cref="IFastDictionary{TKey, TValue}.Keys"/>
    /// or <see cref="EnumerableOfKeys"/>.
    /// </para>
    /// </summary>
    public ICollection<TKey> Keys => GetKeyCollection();

    /// <summary>
    /// Gets an <see cref="ICollection{T}"/> that contains the values of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition.
    /// That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// Partition snapshots are created as enumerable visits those. However, space complexity of
    /// this implementation is HIGH due to the fact that all the partitions are visited almost immediately
    /// in order to create a copy of all the keys from all the partitions.
    /// <para>
    /// In order to reduce space complexity, use either <see cref="IFastDictionary{TKey, TValue}.Values"/>
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
#pragma warning disable S1264 // A "while" loop should be used instead of a "for" loop
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
#pragma warning restore S1264 // A "while" loop should be used instead of a "for" loop
            return totCount;
        }
    }

    /// <inheritdoc />
    public bool IsReadOnly => false;

    /// <inheritdoc />
    public int PartitionCount => _data.Length;

    /// <inheritdoc cref="IFastDictionary{TKey, TValue}.Keys"/>
    IEnumerable<TKey> IFastDictionary<TKey, TValue>.Keys => EnumerableOfKeys();

    /// <inheritdoc cref="IFastDictionary{TKey, TValue}.Values"/>
    IEnumerable<TValue> IFastDictionary<TKey, TValue>.Values => EnumerableOfValues();

    /// <inheritdoc cref="IFastDictionary{TKey, TValue}.Keys"/>
    IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => EnumerableOfKeys();

    /// <inheritdoc cref="IFastDictionary{TKey, TValue}.Values"/>
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public void Clear()
    {
        //We do not want to take all locks together
        //this call will provide best-effort clearing on whole collection.
        int i = _data.Length;
#pragma warning disable S1264 // A "while" loop should be used instead of a "for" loop
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
#pragma warning restore S1264 // A "while" loop should be used instead of a "for" loop
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
        _ = Interlocked.Exchange(ref _data, CreateDataSet(initialCapacity, PartitionCount, _comparer));
    }

    /// <inheritdoc />
    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        return Contains(item, null);
    }

    /// <inheritdoc />
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
    public IEnumerable<TKey> EnumerableOfKeysOnPartition(int partitionIndex)
    {
        Dictionary<TKey, TValue> d = _data[partitionIndex];
        Monitor.Enter(d);
        try
        {
            using Dictionary<TKey, TValue>.Enumerator de = d.GetEnumerator();
            while (de.MoveNext())
            {
                yield return de.Current.Key;
            }
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <inheritdoc />
    public IEnumerable<TValue> EnumerableOfValues()
    {
        return new ValueEnumerable(this);
    }

    /// <inheritdoc />
    public IEnumerable<TValue> EnumerableOfValuesOnPartition(int partitionIndex)
    {
        Dictionary<TKey, TValue> d = _data[partitionIndex];
        Monitor.Enter(d);
        try
        {
            using Dictionary<TKey, TValue>.Enumerator de = d.GetEnumerator();
            while (de.MoveNext())
            {
                yield return de.Current.Value;
            }
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <inheritdoc/>
    public IEnumerable<KeyValuePair<TKey, TValue>> EnumerableOnPartition(int partitionIndex)
    {
        Dictionary<TKey, TValue> d = _data[partitionIndex];
        Monitor.Enter(d);
        try
        {
            using Dictionary<TKey, TValue>.Enumerator de = d.GetEnumerator();
            while (de.MoveNext())
            {
                yield return de.Current;
            }
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <summary>
    /// Gets an enumerable collection that contains the <see cref="KeyValuePair{TKey, TValue}"/> of the dictionary.
    /// <para>
    /// IMPLEMENTATION NOTES: Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition
    /// at a time. That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
    /// </summary>
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return new Enumerator(this);
    }

    /// <inheritdoc />
    public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
    {
        return TryGetValue(key, out TValue v) ? v : GetOrAdd(key, valueFactory(key));
    }

    /// <inheritdoc />
    public TValue GetOrAdd(TKey key, TValue value)
    {
        return TryAddCore(key, value, out TValue existingValue) ? value : existingValue;
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

    /// <inheritdoc />
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
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            return d.TryGetValue(item.Key, out TValue v) &&
                      (valueComparer ?? EqualityComparer<TValue>.Default).Equals(v, item.Value) &&
                      d.Remove(item.Key);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore IDE0079 // Remove unnecessary suppression
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    /// <inheritdoc />
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

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue, IEqualityComparer<TValue>? comparer = null)
    {
        comparer ??= EqualityComparer<TValue>.Default;
        Dictionary<TKey, TValue> d = GetPartition(key);
        Monitor.Enter(d);
        try
        {
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            if (d.TryGetValue(key, out TValue v) &&
                comparer.Equals(v, comparisonValue))
            {
                d[key] = newValue;
                return true;
            }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore IDE0079 // Remove unnecessary suppression
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
    /// IMPLEMENTATION NOTES: Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition
    /// at a time. That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
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
        if (position >= 0 && position < PartitionCount)
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

    private static Dictionary<TKey, TValue>[] CreateDataSet(int initialCapacity,
        int totalPartition,
        IEqualityComparer<TKey>? comparer)
    {
        Dictionary<TKey, TValue>[] data = new Dictionary<TKey, TValue>[totalPartition];
        initialCapacity = Math.Max(FixedValues.MinInitialCapacity, initialCapacity / totalPartition);
        for (int i = 0; i < totalPartition; i++)
        {
            data[i] = new Dictionary<TKey, TValue>(initialCapacity, comparer);
        }
        return data;
    }

    private static void InitializeEntries(Action<KeyValuePair<TKey, TValue>> lambda,
        IEnumerable<KeyValuePair<TKey, TValue>> initialData)
    {
        _ = Parallel.ForEach(
                initialData,
                new ParallelOptions { MaxDegreeOfParallelism = FixedValues.ProcessorCountWithMinBound },
                lambda
            );
    }

    private static void InitializeEntries(Action<KeyValuePair<TKey, TValue>> lambda,
        IFastDictionary<TKey, TValue> src)
    {
        _ = Parallel.For(
                0,
                src.PartitionCount,
                new ParallelOptions { MaxDegreeOfParallelism = FixedValues.ProcessorCountWithMinBound },
                i =>
                {
                    foreach (KeyValuePair<TKey, TValue> pair in src.EnumerableOnPartition(i))
                    {
                        lambda(pair);
                    }
                }
            );
    }
}