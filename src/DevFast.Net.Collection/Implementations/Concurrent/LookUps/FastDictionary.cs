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

    /// <inheritdoc />
    public void Clear()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Clear items in the all the partitions.
    /// </summary>
    /// <param name="releaseMemory">If <see langword="true"/>, partitions are recreated to release previously allocated memory.</param>
    public void Clear(bool releaseMemory)
    {
        //We do not want to take all locks together
        //this call will provide best-effort clearing on whole collection.
        for (int i = 0; i < _data.Length; i++)
        {
            Dictionary<TKey, TValue> d = _data[i];
            Monitor.Enter(d);
            try
            {
                if (releaseMemory)
                {
                    _ = Interlocked.CompareExchange(ref _data[i],
                        new Dictionary<TKey, TValue>(_initialCapacity, _comparer),
                        d);
                }
                else
                {
                    d.Clear();
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
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool ContainsKey(TKey key)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Remove(TKey key)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Remove(KeyValuePair<TKey, TValue> item)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool TryGetValue(TKey key, out TValue value)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
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
            if (!d.TryGetValue(key, out existingValue))
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
