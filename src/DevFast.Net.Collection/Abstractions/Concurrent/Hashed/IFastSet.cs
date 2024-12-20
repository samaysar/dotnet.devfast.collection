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
    /// Concurrently removes all elements of the <paramref name="other"/> collection from current instance.
    /// </summary>
    /// <param name="other">Collection to compare with current instance</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    void ExceptWith(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Concurrently modifies the current set so that it contains only elements that are also in a specified collection.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    void IntersectWith(IEnumerable<T> other, Token token, int maxConcurrency);

#if NET5_0_OR_GREATER
    /// <inheritdoc cref="IReadOnlySet{T}.IsProperSubsetOf(IEnumerable{T})"/>
    new bool IsProperSubsetOf(IEnumerable<T> other);

    /// <inheritdoc cref="IReadOnlySet{T}.IsProperSupersetOf(IEnumerable{T})"/>
    new bool IsProperSupersetOf(IEnumerable<T> other);

    /// <inheritdoc cref="IReadOnlySet{T}.IsSubsetOf(IEnumerable{T})"/>
    new bool IsSubsetOf(IEnumerable<T> other);

    /// <inheritdoc cref="IReadOnlySet{T}.IsSupersetOf(IEnumerable{T})"/>
    new bool IsSupersetOf(IEnumerable<T> other);

    /// <inheritdoc cref="IReadOnlySet{T}.Overlaps(IEnumerable{T})"/>
    new bool Overlaps(IEnumerable<T> other);

    /// <inheritdoc cref="IReadOnlySet{T}.SetEquals(IEnumerable{T})"/>
    new bool SetEquals(IEnumerable<T> other);
#endif
}
