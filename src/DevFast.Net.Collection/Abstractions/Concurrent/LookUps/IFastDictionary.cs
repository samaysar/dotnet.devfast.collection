namespace DevFast.Net.Collection.Abstractions.Concurrent.LookUps;

/// <summary>
/// Interface for a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently.
/// </summary>
/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
#pragma warning disable S3444 // Interfaces should not simply inherit from base interfaces with colliding members
public interface IFastDictionary<TKey, TValue> : IDictionary<TKey, TValue>,
#pragma warning restore S3444 // Interfaces should not simply inherit from base interfaces with colliding members
    IReadOnlyDictionary<TKey, TValue>
    where TKey : notnull
{
    /// <summary>
    /// Gets the number of Partitions contained in the <see cref="IFastDictionary{TKey, TValue}"/>.
    /// </summary>
    int PartitionCount { get; }

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the keys of the <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    IEnumerable<TKey> EnumerableOfKeys();

    /// <summary>
    /// Create a new <see cref="IEnumerable{T}"/> on the values of the <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    IEnumerable<TValue> EnumerableOfValues();

    /// <summary>
    /// Removes all items from all the partitions.
    /// </summary>
    /// <param name="releaseMemory">If <see langword="true"/>, partitions are recreated by releasing previously allocated memory.</param>
    void Clear(bool releaseMemory);

    /// <summary>
    /// Removes all items from all the partitions.
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the partitions to be re-created.</param>
    void Clear(int initialCapacity);
}