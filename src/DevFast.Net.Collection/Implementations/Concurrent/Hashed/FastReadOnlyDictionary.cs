using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Concurrent.Hashed;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DevFast.Net.Collection.Implementations.Concurrent.Hashed;

/// <summary>
/// Implementation of dictionary which is fully-constructed during instantiation and
/// cannot be further modified.
/// </summary>
public sealed partial class FastReadOnlyDictionary<TKey, TValue> :
    IFastReadOnlyDictionary<TKey, TValue>
        where TKey : notnull
{
    private readonly Dictionary<TKey, TValue>[] _data;
    private readonly int _concurrencyHash;

    internal FastReadOnlyDictionary(Dictionary<TKey, TValue>[] data)
    {
        _data = data;
        _concurrencyHash = data.Length - 1;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastReadOnlyDictionary{TKey, TValue}" /> class that
    /// contains given <paramref name="items"/>, has the default initial capacity, has default concurrency level,
    /// and uses default Equality comparer for the key.
    /// </summary>
    /// <param name="items">Items that the dictionary will contain</param>
    /// <param name="ignoreDuplicates">When <see langword="true"/> all duplicate keys in the <paramref name="items"/> are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.</param>
    public FastReadOnlyDictionary(
        IEnumerable<KeyValuePair<TKey, TValue>> items,
        bool ignoreDuplicates) : this(EqualityComparer<TKey>.Default, items, ignoreDuplicates)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastReadOnlyDictionary{TKey, TValue}" /> class that
    /// contains given <paramref name="items"/>, has the default initial capacity, has default concurrency level,
    /// and uses the <paramref name="comparer"/> for the key type.
    /// </summary>
    /// <param name="comparer">Equality comparer for the key</param>
    /// <param name="items">Items that the dictionary will contain</param>
    /// <param name="ignoreDuplicates">When <see langword="true"/> all duplicate keys in the <paramref name="items"/> are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.</param>
    public FastReadOnlyDictionary(IEqualityComparer<TKey>? comparer,
        IEnumerable<KeyValuePair<TKey, TValue>> items,
        bool ignoreDuplicates) : this(0, comparer, items, ignoreDuplicates)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastReadOnlyDictionary{TKey, TValue}" /> class that
    /// contains given <paramref name="items"/>, 
    /// and has the given <paramref name="initialCapacity"/>, has given <paramref name="concurrencyLevel"/>
    /// and uses default Equality comparer for the key.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Concurrency level</param>
    /// <param name="items">Items that the dictionary will contain</param>
    /// <param name="ignoreDuplicates">When <see langword="true"/> all duplicate keys in the <paramref name="items"/> are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.</param>
    public FastReadOnlyDictionary(int initialCapacity,
        int concurrencyLevel,
        IEnumerable<KeyValuePair<TKey, TValue>> items,
        bool ignoreDuplicates) :
        this(initialCapacity,
            concurrencyLevel,
            EqualityComparer<TKey>.Default,
            items,
            ignoreDuplicates)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastReadOnlyDictionary{TKey, TValue}" /> class that
    /// contains given <paramref name="items"/>, 
    /// and has the given <paramref name="initialCapacity"/>, has default concurrency level,
    /// and uses the <paramref name="comparer"/> for the key type.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="comparer">Equality comparer for the key</param>
    /// <param name="items">Items that the dictionary will contain</param>
    /// <param name="ignoreDuplicates">When <see langword="true"/> all duplicate keys in the <paramref name="items"/> are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.</param>
    public FastReadOnlyDictionary(int initialCapacity,
        IEqualityComparer<TKey>? comparer,
        IEnumerable<KeyValuePair<TKey, TValue>> items,
        bool ignoreDuplicates) :
        this(initialCapacity,
            FixedValues.ProcessorCountWithMinBound,
            EqualityComparer<TKey>.Default,
            items,
            ignoreDuplicates)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastReadOnlyDictionary{TKey, TValue}" /> class that
    /// contains given <paramref name="items"/>, has the given <paramref name="initialCapacity"/>, 
    /// has given <paramref name="concurrencyLevel"/>
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=<see cref="FixedValues.MinInitialCapacity"/> and <paramref name="concurrencyLevel"/> has internal lower bound=<see cref="FixedValues.MinConcurrencyLevel"/>.
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.HashedCollectionMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
    /// </para>
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="comparer">Equality comparer for the key</param>
    /// <param name="items">Data to initial the dictionary with</param>
    /// <param name="ignoreDuplicates">When <see langword="true"/> all duplicate keys in the <paramref name="items"/> are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.</param>
    public FastReadOnlyDictionary(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<TKey>? comparer,
        IEnumerable<KeyValuePair<TKey, TValue>> items,
        bool ignoreDuplicates)
    {
        _concurrencyHash = Math.Max(concurrencyLevel, FixedValues.MinConcurrencyLevel).ToPow2HashMask();
        _data = CreateDataSet(initialCapacity, _concurrencyHash + 1, comparer ?? EqualityComparer<TKey>.Default);
        if (items is IFastReadOnlyDictionary<TKey, TValue> fd)
        {
            InitializeEntries(fd, Add);
        }
        else
        {
            Action<KeyValuePair<TKey, TValue>> lambda = ignoreDuplicates ? IndexerAdd : Add;
            InitializeEntries(lambda, items);
        }
        Count = _data.Sum(static x => x.Count);
    }

    /// <inheritdoc />
    public TValue this[TKey key] => TryGetValue(key, out TValue? v) ? v : throw new KeyNotFoundException();

    /// <inheritdoc />
    public int PartitionCount => _data.Length;

    /// <inheritdoc />
    public IEnumerable<TKey> Keys => EnumerableOfKeys();

    /// <inheritdoc />
    public IEnumerable<TValue> Values => EnumerableOfValues();

    /// <inheritdoc />
    public int Count { get; }

    /// <inheritdoc />
    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        return Contains(item, null);
    }

    /// <inheritdoc />
    public bool Contains(KeyValuePair<TKey, TValue> item, IEqualityComparer<TValue>? valueComparer)
    {
        return GetPartition(item.Key).TryGetValue(item.Key, out TValue? v) &&
            (valueComparer ?? EqualityComparer<TValue>.Default).Equals(v, item.Value);
    }

    /// <inheritdoc />
    public bool ContainsKey(TKey key)
    {
        return GetPartition(key).ContainsKey(key);
    }

    /// <inheritdoc/>
    public void CopyTo(Span<KeyValuePair<TKey, TValue>> target)
    {
        int idx = 0;
        foreach (KeyValuePair<TKey, TValue> pair in this)
        {
            target[idx++] = pair;
        }
    }

    /// <inheritdoc />
    public int CountInPartition(int partitionIndex)
    {
        return _data[partitionIndex].Count;
    }

    /// <inheritdoc />
    public IEnumerable<TKey> EnumerableOfKeys()
    {
        using IEnumerator<KeyValuePair<TKey, TValue>> de = GetEnumerator();
        while (de.MoveNext())
        {
            yield return de.Current.Key;
        }
    }

    /// <inheritdoc />
    public IEnumerable<TKey> EnumerableOfKeysOnPartition(int partitionIndex)
    {
        using Dictionary<TKey, TValue>.Enumerator de = _data[partitionIndex].GetEnumerator();
        while (de.MoveNext())
        {
            yield return de.Current.Key;
        }
    }

    /// <inheritdoc />
    public IEnumerable<TValue> EnumerableOfValues()
    {
        using IEnumerator<KeyValuePair<TKey, TValue>> de = GetEnumerator();
        while (de.MoveNext())
        {
            yield return de.Current.Value;
        }
    }

    /// <inheritdoc />
    public IEnumerable<TValue> EnumerableOfValuesOnPartition(int partitionIndex)
    {
        using Dictionary<TKey, TValue>.Enumerator de = _data[partitionIndex].GetEnumerator();
        while (de.MoveNext())
        {
            yield return de.Current.Value;
        }
    }

    /// <inheritdoc />
    public IEnumerable<KeyValuePair<TKey, TValue>> EnumerableOnPartition(int partitionIndex)
    {
        using Dictionary<TKey, TValue>.Enumerator de = _data[partitionIndex].GetEnumerator();
        while (de.MoveNext())
        {
            yield return de.Current;
        }
    }

    /// <inheritdoc />
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return new Enumerator(this);
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc />
    public bool TryGetValue(TKey key, out TValue value)
    {
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS8601 // Possible null reference assignment.
        return GetPartition(key).TryGetValue(key, out value);
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore IDE0079 // Remove unnecessary suppression
    }

    private void Add(KeyValuePair<TKey, TValue> item)
    {
        Dictionary<TKey, TValue> d = GetPartition(item.Key);
        Monitor.Enter(d);
        try
        {
            d.Add(item.Key, item.Value);
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    private void IndexerAdd(KeyValuePair<TKey, TValue> item)
    {
        Dictionary<TKey, TValue> d = GetPartition(item.Key);
        Monitor.Enter(d);
        try
        {
            d[item.Key] = item.Value;
        }
        finally
        {
            Monitor.Exit(d);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Dictionary<TKey, TValue> GetPartition(TKey key)
    {
        return _data[key.GetHashCode() & _concurrencyHash];
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

    private static void InitializeEntries(
        IFastReadOnlyDictionary<TKey, TValue> src,
        Action<KeyValuePair<TKey, TValue>> lambda)
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

    private bool TryGetEnumerator(int position, [NotNullWhen(true)] out IEnumerator<KeyValuePair<TKey, TValue>>? enumerator)
    {
        if (position >= 0 && position < PartitionCount)
        {
            enumerator = _data[position].GetEnumerator();
            return true;
        }
        enumerator = default;
        return false;
    }
}
