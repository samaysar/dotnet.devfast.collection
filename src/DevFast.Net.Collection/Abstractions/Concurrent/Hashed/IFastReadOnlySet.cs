namespace DevFast.Net.Collection.Abstractions.Concurrent.Hashed;

/// <summary>
/// Interface for a generic abstraction of a set.
/// </summary>
public interface IFastReadOnlySet<T>
#if NET5_0_OR_GREATER
    : IReadOnlySet<T>
#else
    : IReadOnlyCollection<T>
#endif
    where T : notnull
{
    /// <summary>
    /// Gets the number of Partitions contained in the <see cref="IFastDictionary{TKey, TValue}"/>.
    /// </summary>
    int PartitionCount { get; }

    /// <summary>
    /// Copies the elements of the set to the provided <paramref name="target"/> span.
    /// </summary>
    /// <param name="target">Span on which to copy set elements</param>
    void CopyTo(Span<T> target);

    /// <summary>
    /// Returns the count of elements in the partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    int CountInPartition(int partitionIndex);

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the values
    /// of a partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    IEnumerable<T> EnumerableOnPartition(int partitionIndex);

    /// <summary>
    /// Determines whether the current set is a proper subset of <paramref name="other"/> collection
    /// while observing <paramref name="token"/> for the cancellation and maintaining
    /// concurrency up to <paramref name="maxConcurrency"/>.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Token to observe for cancellation</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool IsProperSubsetOf(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Determines whether the current set is a proper superset of <paramref name="other"/> collection
    /// while observing <paramref name="token"/> for the cancellation and maintaining
    /// concurrency up to <paramref name="maxConcurrency"/>.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool IsProperSupersetOf(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Determines whether the current set is a subset of <paramref name="other"/> collection
    /// while observing <paramref name="token"/> for the cancellation and maintaining
    /// concurrency up to <paramref name="maxConcurrency"/>.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool IsSubsetOf(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Determines whether the current set is a superset of <paramref name="other"/> collection
    /// while observing <paramref name="token"/> for the cancellation and maintaining
    /// concurrency up to <paramref name="maxConcurrency"/>.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool IsSupersetOf(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Determines whether the current set overlaps with the <paramref name="other"/> collection
    /// while observing <paramref name="token"/> for the cancellation and maintaining
    /// concurrency up to <paramref name="maxConcurrency"/>.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool Overlaps(IEnumerable<T> other, Token token, int maxConcurrency);

    /// <summary>
    /// Determines whether the current set is equal to <paramref name="other"/> collection
    /// (i.e. both sets contains the same elements)
    /// while observing <paramref name="token"/> for the cancellation and maintaining
    /// concurrency up to <paramref name="maxConcurrency"/>.
    /// </summary>
    /// <param name="other">The collection to compare with</param>
    /// <param name="token">Cancellation token to observe</param>
    /// <param name="maxConcurrency">Maximum parallelism to be employed (Min bound is <see cref="FixedValues.MinConcurrencyLevel"/>)</param>
    bool SetEquals(IEnumerable<T> other, Token token, int maxConcurrency);
}
