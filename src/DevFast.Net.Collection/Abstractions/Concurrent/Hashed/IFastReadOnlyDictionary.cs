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
    /// Returns the count of elements in the partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    int CountInPartition(int partitionIndex);

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the keys of the <see cref="Dictionary{TKey, TValue}"/>.
    /// <para>
    /// IMPLEMENTATION NOTES: Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition
    /// at a time. That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
    /// You may consider using <see cref="EnumerableOfKeysOnPartition"/> if the dictionary is NOT
    /// being modified concurrently.
    /// </summary>
    IEnumerable<TKey> EnumerableOfKeys();

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the keys of
    /// a partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// <para>
    /// IMPLEMENTATION NOTES: This implementation is preferable over other <see cref="IEnumerable{T}"/> implementations
    /// as it creates a snapshot on the partition without consuming space. This implementation is very
    /// interesting to traverse keys concurrently on different partitions from separate thread; for an example:
    /// <code>
    /// Parallel.For(
    ///     0,
    ///     instance.PartitionCount,
    ///     i =>
    ///     {
    ///         foreach(var key in instance.KeysEnumerableOnPartition(i))
    ///         {
    ///             ...YOUR CODE...
    ///         }
    ///     }
    /// );
    /// </code>
    /// </para>
    /// NOTE: During the enumeration the partition is locked, i.e. concurrent operations done from
    /// different threads (e.g. add/remove) will be blocked. Modifying the collection while enumerating
    /// (e.g. removing entries) from the same thread is an anti-pattern and should be avoided
    /// (e.g. case of re-entrancy); this MAY lead to unexpected outcome.
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    IEnumerable<TKey> EnumerableOfKeysOnPartition(int partitionIndex);

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the values of the <see cref="Dictionary{TKey, TValue}"/>.
    /// <para>
    /// IMPLEMENTATION NOTES: Current implementation returns
    /// enumerator that creates a snapshot (thus, consuming space) on a partition
    /// at a time. That said, if one is adding/removing elements concurrently, while
    /// enumerating on the collection, it is well possible that lookup may yield
    /// <see langword="false"/> or the element is NOT part of the enumerable.
    /// </para>
    /// In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
    /// You may consider using <see cref="EnumerableOfValuesOnPartition"/> if the dictionary is NOT
    /// being modified concurrently.
    /// </summary>
    IEnumerable<TValue> EnumerableOfValues();

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the values
    /// of a partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// <para>
    /// IMPLEMENTATION NOTES: This implementation is preferable over other <see cref="IEnumerable{T}"/> implementations
    /// as it creates a snapshot on the partition without consuming space. This implementation is very
    /// interesting to traverse values concurrently on different partitions from separate thread; for an example:
    /// <code>
    /// Parallel.For(
    ///     0,
    ///     instance.PartitionCount,
    ///     i =>
    ///     {
    ///         foreach(var value in instance.EnumerableOfValuesOnPartition(i))
    ///         {
    ///             ...YOUR CODE...
    ///         }
    ///     }
    /// );
    /// </code>
    /// </para>
    /// NOTE: During the enumeration the partition is locked, i.e. concurrent operations done from
    /// different threads (e.g. add/remove) will be blocked. Modifying the collection while enumerating
    /// (e.g. removing entries) from the same thread is an anti-pattern and should be avoided
    /// (e.g. case of re-entrancy); this MAY lead to unexpected outcome.
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    IEnumerable<TValue> EnumerableOfValuesOnPartition(int partitionIndex);

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the key-values pairs
    /// of a partition identified with <paramref name="partitionIndex"/>; where Partition index is 0-based
    /// (i.e. 0 to <see cref="PartitionCount"/> - 1).
    /// <para>
    /// IMPLEMENTATION NOTES: This implementation is preferable over other <see cref="IEnumerable{T}"/> implementations
    /// as it creates a snapshot on the partition without consuming space. This implementation is very
    /// interesting to traverse key-value pairs concurrently on different partitions from separate thread; for an example:
    /// <code>
    /// Parallel.For(
    ///     0,
    ///     instance.PartitionCount,
    ///     i =>
    ///     {
    ///         foreach(var pair in instance.EnumerableOnPartition(i))
    ///         {
    ///             ...YOUR CODE...
    ///         }
    ///     }
    /// );
    /// </code>
    /// </para>
    /// NOTE: During the enumeration the partition is locked, i.e. concurrent operations done from
    /// different threads (e.g. add/remove) will be blocked. Modifying the collection while enumerating
    /// (e.g. removing entries) from the same thread is an anti-pattern and should be avoided
    /// (e.g. case of re-entrancy); this MAY lead to unexpected outcome.
    /// </summary>
    /// <param name="partitionIndex">Index of the parition on which to create enumeration</param>
    IEnumerable<KeyValuePair<TKey, TValue>> EnumerableOnPartition(int partitionIndex);
}
