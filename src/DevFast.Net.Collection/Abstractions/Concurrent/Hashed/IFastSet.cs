namespace DevFast.Net.Collection.Abstractions.Concurrent.Hashed;

/// <summary>
/// Interface for abstraction of thread-safe set.
/// </summary>
public interface IFastSet<T> : ISet<T>
#if NET5_0_OR_GREATER
    , IReadOnlySet<T>
#endif
    where T : notnull
{
    /// <summary>
    /// Gets the number of Partitions contained in the <see cref="IFastDictionary{TKey, TValue}"/>.
    /// </summary>
    int PartitionCount { get; }

    /// <summary>
    /// Removes all items from all the partitions.
    /// </summary>
    /// <param name="releaseMemory">If <see langword="true"/>, partitions are recreated by releasing previously allocated memory.</param>
    void Clear(bool releaseMemory);

    /// <summary>
    /// Removes all items from all the partitions.
    /// <para>
    /// NOTE: <paramref name="initialCapacity"/> is IGNORED for NETSTANDARD2_0 OR LOWER.
    /// </para>
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the partitions to be re-created.</param>
    void Clear(int initialCapacity);

    /// <summary>
    /// Removes all elements of the <paramref name="other"/> collection from current instance.
    /// </summary>
    /// <param name="other">Collection to compare with current instance</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    void ExceptWith(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Modifies the current set so that it contains elements that are also in <paramref name="other"/> collection.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    void IntersectWith(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Determines whether the current set is a proper subset of <paramref name="other"/> collection.
    /// <para>
    /// IMPLEMENTATION NOTES:
    /// </para>
    /// 1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
    /// thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.
    /// <para>
    /// 2. Snapshot is taken when <paramref name="other"/> is enumerated as it-is without cast.
    /// </para>
    /// In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    new bool IsProperSubsetOf(IEnumerable<T> other);

    /// <summary>
    /// Determines whether the current set is a proper subset of <paramref name="other"/> collection.
    /// <para>
    /// IMPLEMENTATION NOTES:
    /// </para>
    /// 1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
    /// thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.
    /// <para>
    /// 2. Snapshot is taken when <paramref name="other"/> is enumerated as it-is without cast.
    /// </para>
    /// In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool IsProperSubsetOf(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Determines whether the current set is a proper superset of <paramref name="other"/> collection.
    /// <para>
    /// IMPLEMENTATION NOTES:
    /// </para>
    /// 1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
    /// thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.
    /// <para>
    /// 2. Snapshot is taken when <paramref name="other"/> is enumerated as it-is without cast.
    /// </para>
    /// In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    new bool IsProperSupersetOf(IEnumerable<T> other);

    /// <summary>
    /// Determines whether the current set is a proper superset of <paramref name="other"/> collection.
    /// <para>
    /// IMPLEMENTATION NOTES:
    /// </para>
    /// 1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
    /// thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.
    /// <para>
    /// 2. Snapshot is taken when <paramref name="other"/> is enumerated as it-is without cast. But,
    /// in any case, concurrently mutating a set and comparing with another collection does NOT make much sense.
    /// </para>
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool IsProperSupersetOf(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <inheritdoc cref="ISet{T}.IsSubsetOf(IEnumerable{T})"/>
    new bool IsSubsetOf(IEnumerable<T> other);

    /// <inheritdoc cref="ISet{T}.IsSupersetOf(IEnumerable{T})"/>
    new bool IsSupersetOf(IEnumerable<T> other);

    /// <inheritdoc cref="ISet{T}.Overlaps(IEnumerable{T})"/>
    new bool Overlaps(IEnumerable<T> other);

    /// <inheritdoc cref="ISet{T}.SetEquals(IEnumerable{T})"/>
    new bool SetEquals(IEnumerable<T> other);
}
