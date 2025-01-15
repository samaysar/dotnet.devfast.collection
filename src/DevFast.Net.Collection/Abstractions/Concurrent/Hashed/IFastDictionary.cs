namespace DevFast.Net.Collection.Abstractions.Concurrent.Hashed;

/// <summary>
/// Interface for a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently.
/// </summary>
/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
public interface IFastDictionary<TKey, TValue> : IFastReadOnlyDictionary<TKey, TValue>, IDictionary<TKey, TValue>
    where TKey : notnull
{
    /// <inheritdoc cref="IDictionary{TKey,TValue}.this[TKey]" />
    new TValue this[TKey key] { get; set; }

    /// <inheritdoc cref="IReadOnlyDictionary{TKey,TValue}.Keys" />
    new IEnumerable<TKey> Keys { get; }

    /// <inheritdoc cref="IReadOnlyDictionary{TKey,TValue}.Values" />
    new IEnumerable<TValue> Values { get; }

    /// <summary>
    /// Adds <paramref name="key"/>/<paramref name="addValue"/> pair to the collection
    /// if the <paramref name="key"/> does not already exist,
    /// or updates <paramref name="key"/>/value pair by using <paramref name="updateValueFactory"/> lambda
    /// if the <paramref name="key"/> already exists.
    /// </summary>
    /// <param name="key">The key to be added or updated</param>
    /// <param name="addValue">The value to be added</param>
    /// <param name="updateValueFactory">Value generating lambda for an existing key and value</param>
    /// <param name="comparer">Value comparer. If not provided then default implementation will be used.</param>
    /// <returns>The new value for the key. This will be either be <paramref name="addValue" /> (if the key was absent) or the result of <paramref name="updateValueFactory" /> (if the key was present).</returns>
    TValue AddOrUpdate(TKey key,
        TValue addValue,
        Func<TKey, TValue, TValue> updateValueFactory,
        IEqualityComparer<TValue>? comparer = null);

    /// <inheritdoc cref="IReadOnlyDictionary{TKey,TValue}.ContainsKey" />
    new bool ContainsKey(TKey key);

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

    /// <summary>
    /// Creates and returns a new instance of a Read-Only dictionary version
    /// which contains all the elements of the current instance.
    /// Based on actual implementation, such read-only dictionary version can be optimized for
    /// lookup and enumeration.
    /// <para>
    /// Actual implementation may requires re-allocating memory and may requires memory
    /// intensive operations. Depending on the size of current collection, calling this
    /// method may take some time before returning.
    /// </para>
    /// The purpose of this method to be able to created multiple
    /// instances of read-only dictionary based on the snapshot state
    /// of the dictionary contents.
    /// Also, <see cref="ToReadOnlyAndClear()"/>.
    /// </summary>
    IFastReadOnlyDictionary<TKey, TValue> ToReadOnly();

    /// <summary>
    /// Creates and returns a new instance of a Read-Only dictionary version
    /// which contains all the elements of the current instance.
    /// Based on actual implementation, such read-only dictionary version can be optimized for
    /// lookup and enumeration.
    /// Before returning the instance of read-only dictionary, it clears internal collections.
    /// <para>
    /// The purpose of this method is to create 1 last instance of read-only
    /// dictionary before clearing the contents.
    /// </para>
    /// As the internal state will be cleared, some implementation may
    /// take the advantage of such fact and provide some optimization in order to
    /// make this method call cheaper compared to <see cref="ToReadOnly"/>.
    /// </summary>
    IFastReadOnlyDictionary<TKey, TValue> ToReadOnlyAndClear();

    /// <summary>
    /// Adds a key/value pair to the collection by using the specified function
    /// if the key does not already exist.
    /// Returns the new value, or the existing value if the key exists.</summary>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="valueFactory">The function used to generate a value for the key.</param>
    /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
    TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory);

    /// <summary>
    /// Adds a key/value pair to the collection if the key does not already exist.
    /// Returns the new value, or the existing value if the key exists.
    /// </summary>
    /// <param name="key">Key value.</param>
    /// <param name="value">Value.</param>
    /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
    TValue GetOrAdd(TKey key, TValue value);

    /// <summary>
    /// Removes the given key/value pair from the collection using provided <paramref name="valueComparer"/>.
    /// If <paramref name="valueComparer"/> is <see langword="null" />, then <see cref="EqualityComparer{TValue}.Default"/>
    /// will be used.
    /// </summary>
    /// <param name="item">Key value pair to be removed.</param>
    /// <param name="valueComparer">Equality comparer for the value.</param>
    bool Remove(KeyValuePair<TKey, TValue> item, IEqualityComparer<TValue>? valueComparer);

    /// <summary>
    /// Attempts to add the specified key and value to the collection.
    /// </summary>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="value">The value of the element to add.</param>
    /// <returns> <see langword="true" /> if the key/value pair was added successfully; <see langword="false" /> if the key already exists.</returns>
    bool TryAdd(TKey key, TValue value);

    /// <inheritdoc cref="IReadOnlyDictionary{TKey,TValue}.TryGetValue" />
    new bool TryGetValue(TKey key, out TValue value);

    /// <summary>
    /// Attempts to remove and return the value that has the specified key.
    /// </summary>
    /// <param name="key">The key of the element to remove and return.</param>
    /// <param name="value">When this method returns, contains the object removed from the collection, or the default value of the <see langword="TValue" /> type if <paramref name="key" /> does not exist.</param>
    /// <returns><see langword="true" /> if the object was removed successfully; otherwise, <see langword="false" />.</returns>
    bool TryRemove(TKey key, out TValue value);

    /// <summary>
    /// Updates the value associated with <paramref name="key" /> to <paramref name="newValue" />
    /// if the existing value with <paramref name="key" /> is equal to <paramref name="comparisonValue" />.
    /// </summary>
    /// <param name="key">key.</param>
    /// <param name="newValue">Replacement value.</param>
    /// <param name="comparisonValue">Value to compare with the existing key value.</param>
    /// <param name="comparer">Value comparer. If not provided then default implementation will be used.</param>
    /// <returns><see langword="true" /> if the value with <paramref name="key" /> was equal to <paramref name="comparisonValue" /> and was replaced with <paramref name="newValue" />; otherwise, <see langword="false" />.</returns>
    bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue, IEqualityComparer<TValue>? comparer = null);
}