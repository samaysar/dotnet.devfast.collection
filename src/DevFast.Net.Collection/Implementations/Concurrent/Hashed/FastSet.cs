using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Concurrent.Hashed;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DevFast.Net.Collection.Implementations.Concurrent.Hashed;

/// <summary>
/// Implementation of thread-safe set.
/// </summary>
public sealed partial class FastSet<T> : IFastSet<T>
    where T : notnull
{
    private readonly IEqualityComparer<T> _comparer;
    private HashSet<T>[] _data;
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
    /// <para>
    /// NOTE: <paramref name="initialCapacity"/> is IGNORED for NETSTANDARD2_0 OR LOWER.
    /// </para>
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
    /// <para>
    /// NOTE: <paramref name="initialCapacity"/> is IGNORED for NETSTANDARD2_0 OR LOWER.
    /// </para>
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastSet(int initialCapacity,
        IEqualityComparer<T>? comparer) : this(initialCapacity,
        FixedValues.ProcessorCountWithMinBound,
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
    /// <para>
    /// NOTE: <paramref name="initialCapacity"/> is IGNORED for NETSTANDARD2_0 OR LOWER.
    /// </para>
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="comparer">Equality comparer for the key</param>
    public FastSet(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<T>? comparer) : this(initialCapacity, concurrencyLevel, comparer, [])
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FastSet{T}" /> class that initially contains
    /// items of the <paramref name="initialData"/>,
    /// has the given <paramref name="initialCapacity"/>, has given <paramref name="concurrencyLevel"/>
    /// and uses the <paramref name="comparer"/> for the key type.
    /// <para>
    /// NOTE: Total expected memory allocation is bit more than <paramref name="initialCapacity"/> * <paramref name="concurrencyLevel"/>.
    /// </para>
    /// NOTE: <paramref name="initialCapacity"/> has internal lower bound=<see cref="FixedValues.MinInitialCapacity"/> and <paramref name="concurrencyLevel"/> has internal lower bound=<see cref="FixedValues.MinConcurrencyLevel"/>.
    /// <paramref name="concurrencyLevel"/> has internal upper bound=<see cref="FixedValues.HashedCollectionMaxConcurrencyLevel"/> and always adjusted to the nearest higher power of 2.
    /// <para>
    /// NOTE: <paramref name="initialCapacity"/> is IGNORED for NETSTANDARD2_0 OR LOWER.
    /// </para>
    /// </summary>
    /// <param name="initialCapacity">Initial estimated capacity</param>
    /// <param name="concurrencyLevel">Expected maximum concurrency</param>
    /// <param name="comparer">Equality comparer for the key</param>
    /// <param name="initialData">Initial dataset of the set</param>
    public FastSet(int initialCapacity,
        int concurrencyLevel,
        IEqualityComparer<T>? comparer,
        IEnumerable<T> initialData) : this(comparer, initialCapacity, concurrencyLevel)
    {
        if (initialData is IFastSet<T> fs)
        {
            InitializeEntries(x => Add(x), fs);
        }
        else
        {
            InitializeEntries(x => Add(x), initialData);
        }
    }

    private FastSet(IEqualityComparer<T>? comparer,
        int initialCapacity,
        int concurrencyLevel)
    {
        _comparer = comparer ?? EqualityComparer<T>.Default;
        _concurrencyHash = Math.Max(concurrencyLevel, FixedValues.MinConcurrencyLevel).ToPow2HashMask();
        _data = CreateDataSet(initialCapacity, _concurrencyHash + 1, comparer);
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
        _ = Interlocked.Exchange(ref _data, CreateDataSet(initialCapacity, PartitionCount, _comparer));
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
        ExceptWith(other, Token.None, FixedValues.ProcessorCountWithMinBound);
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
        return new Enumerator(this);
    }

    /// <inheritdoc/>
    public void IntersectWith(IEnumerable<T> other)
    {
        IntersectWith(other, Token.None, FixedValues.ProcessorCountWithMinBound);
    }

    /// <inheritdoc/>
    public void IntersectWith(IEnumerable<T> other, Token token, int maxConcurrency)
    {
        if (ReferenceEquals(this, other) ||
            Count == 0)
        {
            return;
        }
        if (other is ICollection<T> coll &&
            coll.Count == 0)
        {
            Clear();
            return;
        }
        if (other is IReadOnlyCollection<T> ro &&
            ro.Count == 0)
        {
            Clear();
            return;
        }

        FastSet<T> newInstance = new(0, PartitionCount, _comparer);
        _ = Parallel.ForEach(
            other,
            new ParallelOptions
            {
                CancellationToken = token,
                MaxDegreeOfParallelism = Math.Max(FixedValues.MinConcurrencyLevel, maxConcurrency)
            },
            item =>
            {
                if (Contains(item))
                {
                    _ = newInstance.Add(item);
                }
            }
        );
        _ = Interlocked.Exchange(ref _data, newInstance._data);
    }

    /// <inheritdoc/>
    public bool IsProperSubsetOf(IEnumerable<T> other)
    {
        return IsProperSubsetOf(other, Token.None, FixedValues.ProcessorCountWithMinBound);
    }

    /// <inheritdoc/>
    public bool IsProperSubsetOf(IEnumerable<T> other, Token token, int maxConcurrency)
    {
        if (ReferenceEquals(this, other))
        {
            return false;
        }
        if (other is ICollection<T> coll)
        {
            if (Count >= coll.Count)
            {
                return false;
            }
            if (Count == 0)
            {
                return coll.Count > 0;
            }
        }
        if (other is IReadOnlyCollection<T> ro)
        {
            if (Count >= ro.Count)
            {
                return false;
            }
            if (Count == 0)
            {
                return ro.Count > 0;
            }
        }
        if (other is ISet<T>)
        {
            int totalUnMatch = Count;
            _ = Parallel.ForEach(
                other,
                new ParallelOptions
                {
                    CancellationToken = token,
                    MaxDegreeOfParallelism = Math.Max(FixedValues.MinConcurrencyLevel, maxConcurrency)
                },
                () => 0,
                (x, s, l) =>
                {
                    if (s.IsStopped)
                    {
                        return l;
                    }
                    if (Contains(x) &&
                        totalUnMatch <= ++l)
                    {
                        s.Stop();
                    }
                    return l;
                },
                l => Interlocked.Add(ref totalUnMatch, -l)
            );
            //it may go less than 0 if collection is mutated concurrently
            //but the comment on the method warns about it,
            //so we do NOT throw exception NOR we check for STRICT 0 equality.
            return totalUnMatch <= 0;
        }
        else
        {
            int mdop = Math.Max(FixedValues.MinConcurrencyLevel, maxConcurrency);
            FastSet<T> dataClone = new(Count, mdop + 1, _comparer, this);
            if (dataClone.Count == 0)
            {
                using IEnumerator<T> oe = other.GetEnumerator();
                return oe.MoveNext();
            }
            int set1ForUnmatch = 0;
            int set1ForAllMatch = 0;
            _ = Parallel.ForEach(
                other,
                new ParallelOptions
                {
                    CancellationToken = token,
                    MaxDegreeOfParallelism = mdop
                },
                () => 0,
                (x, s, l) =>
                {
                    if (s.IsStopped)
                    {
                        return l;
                    }
                    if (dataClone.Remove(x, out int pCount))
                    {
                        if (pCount == 0 && dataClone.Count == 0)
                        {
                            _ = Interlocked.CompareExchange(ref set1ForAllMatch, 1, 0);
                            if (l > 0 ||
                                set1ForUnmatch > 0)
                            {
                                //all conditions are met no need to continue enumerating
                                s.Stop();
                            }
                        }
                    }
                    else
                    {
                        if (set1ForAllMatch > 0)
                        {
                            //all conditions are met no need to continue enumerating
                            s.Stop();
                        }
                        return 1;
                    }
                    return l;
                },
                l => Interlocked.CompareExchange(ref set1ForUnmatch, l, 0)
            );
            return set1ForAllMatch > 0 && set1ForUnmatch > 0;
        }
    }

    /// <inheritdoc/>
    public bool IsProperSupersetOf(IEnumerable<T> other)
    {
        return IsProperSupersetOf(other, Token.None, FixedValues.ProcessorCountWithMinBound);
    }

    /// <inheritdoc/>
    public bool IsProperSupersetOf(IEnumerable<T> other, Token token, int maxConcurrency)
    {
        if (ReferenceEquals(this, other) ||
            Count == 0)
        {
            return false;
        }
        if (other is ICollection<T> coll && coll.Count == 0)
        {
            return true;
        }
        if (other is IReadOnlyCollection<T> ro && ro.Count == 0)
        {
            return true;
        }

        if (other is ISet<T> os)
        {
            if (Count <= os.Count)
            {
                return false;
            }
            int totalUnMatch = Count;
            _ = Parallel.ForEach(
                other,
                new ParallelOptions
                {
                    CancellationToken = token,
                    MaxDegreeOfParallelism = Math.Max(FixedValues.MinConcurrencyLevel, maxConcurrency)
                },
                () => 0,
                (x, s, l) =>
                {
                    if (s.IsStopped)
                    {
                        return l;
                    }
                    if (Contains(x) &&
                        totalUnMatch <= ++l)
                    {
                        s.Stop();
                    }
                    return l;
                },
                l => Interlocked.Add(ref totalUnMatch, -l)
            );
            //it may go less than 0 if collection is mutated concurrently
            //but the comment on the method warns about it,
            //so we do NOT throw exception NOR we check for STRICT 0 equality.
            return totalUnMatch <= 0;
        }

        return false;
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
        HashSet<T> h = GetPartition(item);
        Monitor.Enter(h);
        try
        {
            return h.Remove(item);
        }
        finally
        {
            Monitor.Exit(h);
        }
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
        _ = Add(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private bool Remove(T item, out int countInPartition)
    {
        HashSet<T> h = GetPartition(item);
        Monitor.Enter(h);
        try
        {
            bool result = h.Remove(item);
            countInPartition = h.Count;
            return result;
        }
        finally
        {
            Monitor.Exit(h);
        }
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

    private bool TryGetPartition(int position, [NotNullWhen(true)] out HashSet<T>? partition)
    {
        if (position >= 0 && position < PartitionCount)
        {
            partition = _data[position];
            return true;
        }
        partition = default;
        return false;
    }

    private static HashSet<T>[] CreateDataSet(
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S1172 // Unused method parameters should be removed
        int initialCapacity,
#pragma warning restore S1172 // Unused method parameters should be removed
#pragma warning restore IDE0079 // Remove unnecessary suppression
        int totalPartition,
        IEqualityComparer<T>? comparer)
    {
        HashSet<T>[] data = new HashSet<T>[totalPartition];
#if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        initialCapacity = Math.Max(FixedValues.MinInitialCapacity, initialCapacity / totalPartition);
#endif
        for (int i = 0; i < totalPartition; i++)
        {
#if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            data[i] = new HashSet<T>(initialCapacity, comparer);
#else
            data[i] = new HashSet<T>(comparer);
#endif
        }
        return data;
    }

    private static void InitializeEntries(Action<T> lambda,
        IEnumerable<T> initialData)
    {
        _ = Parallel.ForEach(
                initialData,
                new ParallelOptions { MaxDegreeOfParallelism = FixedValues.ProcessorCountWithMinBound },
                lambda
            );
    }

    private static void InitializeEntries(Action<T> lambda,
        IFastSet<T> src)
    {
        _ = Parallel.For(
                0,
                src.PartitionCount,
                new ParallelOptions { MaxDegreeOfParallelism = FixedValues.ProcessorCountWithMinBound },
                i =>
                {
                    foreach (T val in src.EnumerableOnPartition(i))
                    {
                        lambda(val);
                    }
                }
            );
    }
    /// <inheritdoc/>

    public IEnumerable<T> EnumerableOnPartition(int partitionIndex)
    {
        throw new NotImplementedException();
    }
}
