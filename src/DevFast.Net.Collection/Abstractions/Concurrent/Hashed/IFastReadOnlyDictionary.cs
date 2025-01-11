namespace DevFast.Net.Collection.Abstractions.Concurrent.Hashed;

/// <summary>
/// Interface for a thread-safe collection of key-value pairs, for read-only purpose, that can be accessed by multiple threads concurrently.
/// </summary>
/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
public interface IFastReadOnlyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    where TKey : notnull
{
    /// <summary>
    /// Gets the number of Partitions contained in the <see cref="IFastDictionary{TKey, TValue}"/>.
    /// </summary>
    int PartitionCount { get; }

    /// <summary>
    /// Checks whether given key/value pair is part of current collection using provided <paramref name="valueComparer"/>.
    /// If <paramref name="valueComparer"/> is <see langword="null" />, then <see cref="EqualityComparer{TValue}.Default"/>
    /// will be used.
    /// </summary>
    /// <param name="item">Key value pair to check</param>
    /// <param name="valueComparer">Equality comparer for the value.</param>
    bool Contains(KeyValuePair<TKey, TValue> item, IEqualityComparer<TValue>? valueComparer);

    /// <summary>
    /// Copies the elements of the dictionary to the provided <paramref name="target"/> span.
    /// </summary>
    /// <param name="target">Span on which to copy dictionary elements</param>
    void CopyTo(Span<KeyValuePair<TKey, TValue>> target);

    /// <summary>
    /// Returns the count of elements in the partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    int CountInPartition(int partitionIndex);

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the keys of the <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    IEnumerable<TKey> EnumerableOfKeys();

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the keys of
    /// a partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    IEnumerable<TKey> EnumerableOfKeysOnPartition(int partitionIndex);

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the values of the <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    IEnumerable<TValue> EnumerableOfValues();

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the values
    /// of a partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    IEnumerable<TValue> EnumerableOfValuesOnPartition(int partitionIndex);

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the key-values pairs
    /// of a partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    IEnumerable<KeyValuePair<TKey, TValue>> EnumerableOnPartition(int partitionIndex);
}
