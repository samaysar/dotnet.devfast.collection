using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Concurrent.Hashed;
using System.Collections;
using System.Runtime.CompilerServices;

namespace DevFast.Net.Collection.Implementations.Concurrent.Hashed;

/// <summary>
/// Implementation of thread-safe set.
/// </summary>
public sealed partial class FastSet<T> : IFastSet<T>
    where T : notnull
{
    private readonly IEqualityComparer<T> _comparer;
    private readonly HashSet<T>[] _data;
    private readonly int _concurrencyHash;

    /// <summary>
    /// Initializes a new instance of the <see cref="FastSet{T}"/> class that is empty and
    /// has default initial capacity, has default concurrency level,
    /// and uses default Equality comparer for the key.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.
    /// </para>
    /// </summary>
    public FastSet() : this(EqualityComparer<T>.Default) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastSet{T}" /> class that is empty and
    /// has the default initial capacity, has default concurrency level,
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.
    /// </para>
    /// </summary>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastSet(IEqualityComparer<T> comparer) : this(0, comparer)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastSet{T}" /> class that is empty
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
    public FastSet(int initialCapacity,
        int concurrencyLevel) : this(initialCapacity, concurrencyLevel, EqualityComparer<T>.Default)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastSet{T}" /> class that is empty and
    /// and has the given <paramref name="initialCapacity"/>, has default concurrency level,
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than <paramref name="initialCapacity"/> * default_concurrency_level.
    /// </para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=<see cref="FixedValues.MinInitialCapacity"/>.
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastSet(int initialCapacity,
        IEqualityComparer<T>? comparer) : this(initialCapacity,
        Environment.ProcessorCount,
        comparer)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastSet{T}" /> class that is empty
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
    public FastSet(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<T>? comparer)
    {
        _comparer = comparer ?? EqualityComparer<T>.Default;
        _concurrencyHash = Math.Max(concurrencyLevel, FixedValues.MinConcurrencyLevel).ToConcurrencyHash();
        _data = new HashSet<T>[_concurrencyHash + 1];
        for (int i = 0; i < _concurrencyHash + 1; i++)
        {
#if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            initialCapacity = Math.Max(FixedValues.MinInitialCapacity, initialCapacity);
            _data[i] = new HashSet<T>(initialCapacity, _comparer);
#else
            _data[i] = new HashSet<T>(_comparer);
#endif
        }
    }

    /// <inheritdoc/>
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
                HashSet<T> h = _data[--i];
                Monitor.Enter(h);
                try
                {
                    totCount += h.Count;
                }
                finally
                {
                    Monitor.Exit(h);
                }
            }
#pragma warning restore S1264 // A "while" loop should be used instead of a "for" loop
            return totCount;
        }
    }

    /// <inheritdoc/>
    public bool IsReadOnly => false;

    /// <inheritdoc/>
    public int PartitionCount => _data.Length;

    /// <inheritdoc/>
    public bool Add(T item)
    {
        HashSet<T> h = GetPartition(item);
        Monitor.Enter(h);
        try
        {
            return h.Add(item);
        }
        finally
        {
            Monitor.Exit(h);
        }
    }

    /// <inheritdoc/>
    public void Clear()
    {
        //We do not want to take all locks together
        //this call will provide best-effort clearing on whole collection.
        int i = _data.Length;
#pragma warning disable S1264 // A "while" loop should be used instead of a "for" loop
        for (; i > 0;)
        {
            HashSet<T> h = _data[--i];
            Monitor.Enter(h);
            try
            {
                h.Clear();
            }
            finally
            {
                Monitor.Exit(h);
            }
        }
#pragma warning restore S1264 // A "while" loop should be used instead of a "for" loop
    }

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public void Clear(int initialCapacity)
    {
        //We do not want to take all locks together
        //this call will provide best-effort clearing on whole collection.
        int i = _data.Length;
#pragma warning disable S1264 // A "while" loop should be used instead of a "for" loop
        for (; i > 0;)
        {
            HashSet<T> h = _data[--i];
            Monitor.Enter(h);
            try
            {
                if (ReferenceEquals(_data[i], h))
                {
#if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    initialCapacity = Math.Max(FixedValues.MinInitialCapacity, initialCapacity);
                    _data[i] = new HashSet<T>(initialCapacity, _comparer);
#else
                    _data[i] = new HashSet<T>(_comparer);
#endif
                }
            }
            finally
            {
                Monitor.Exit(h);
            }
        }
#pragma warning restore S1264 // A "while" loop should be used instead of a "for" loop
    }

    /// <inheritdoc/>
    public bool Contains(T item)
    {
        HashSet<T> h = GetPartition(item);
        Monitor.Enter(h);
        try
        {
            return h.Contains(item);
        }
        finally
        {
            Monitor.Exit(h);
        }
    }

    /// <inheritdoc/>
    public void CopyTo(T[] array, int arrayIndex)
    {
        foreach (T val in this)
        {
            array[arrayIndex++] = val;
        }
    }

    /// <inheritdoc/>
    public void ExceptWith(IEnumerable<T> other)
    {
        ExceptWith(other, Token.None, Environment.ProcessorCount);
    }

    /// <inheritdoc/>
    public void ExceptWith(IEnumerable<T> other, Token token, int maxConcurrency)
    {
        if (ReferenceEquals(this, other))
        {
            Clear();
        }
        else
        {
            _ = Parallel.ForEach(
                other,
                new ParallelOptions
                {
                    MaxDegreeOfParallelism = Math.Max(FixedValues.MinConcurrencyLevel, maxConcurrency),
                    CancellationToken = token
                },
                item => Remove(item));
        }
    }

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public void IntersectWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public bool IsProperSubsetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public bool IsProperSupersetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public bool IsSubsetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public bool IsSupersetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public bool Overlaps(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public bool SetEquals(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public void SymmetricExceptWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }
    /// <inheritdoc/>

    public void UnionWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    void ICollection<T>.Add(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }


#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private HashSet<T> GetPartition(T key)
    {
        return _data[key.GetHashCode() & _concurrencyHash];
    }
}
