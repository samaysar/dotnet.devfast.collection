namespace DevFast.Net.Collection.Abstractions.Heaps;

/// <summary>
/// Heap data structure interface.
/// </summary>
/// <typeparam name="T">Heap element type</typeparam>
public interface IHeapCollection<T> : ICollection<T>, IReadOnlyCollection<T>
{
    /// <summary>
    /// Gets the truth value whether the heap is empty or not.
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Gets the truth value whether the heap is full or not.
    /// </summary>
    bool IsFull { get; }

    /// <summary>
    /// Current capacity of the heap.
    /// </summary>
    int Capacity { get; }

    /// <summary>
    /// Gets the number of elements currently present in the heap.
    /// </summary>
    new int Count { get; }

    /// <summary>
    /// Returns the first element of the heap without removing it from the heap.
    /// </summary>
    /// <exception cref="InvalidOperationException">When the heap is empty.</exception>
    T Peek();

    /// <summary>
    /// Returns the truth value whether heap contains at least one (1) item and outs the first element of the heap
    /// without removing it from the heap.
    /// </summary>
    /// <param name="item">out element</param>
    bool TryPeek(out T? item);

    /// <summary>
    /// Removes and returns the first element from the heap.
    /// </summary>
    /// <exception cref="InvalidOperationException">When the heap is empty.</exception>
    T Pop();

    /// <summary>
    /// Returns the truth value whether the first heap element was successfully removed
    /// and outs that element.
    /// </summary>
    /// <param name="item">out element</param>
    bool TryPop(out T? item);

    /// <summary>
    /// Adds given element to the heap.
    /// </summary>
    /// <param name="item">Element to add</param>
    /// <exception cref="ArgumentException">When element is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException">When element cannot be added.</exception>
    new void Add(T item);

    /// <summary>
    /// Tries adding given element in the heap.
    /// Returns the truth value whether it was successfully added or not.
    /// </summary>
    /// <param name="item">Element to add.</param>
    /// <exception cref="ArgumentException">When element is <see langword="null"/>.</exception>
    bool TryAdd(T item);

    /// <summary>
    /// Removes all the elements (in order) from the heap.
    /// </summary>
    IEnumerable<T> PopAll();

    /// <summary>
    /// Adds all elements of the given enumeration to the heap.
    /// Returns the count of the elements that were successfully added.
    /// </summary>
    /// <param name="items">Enumeration of the Elements to add.</param>
    /// <exception cref="ArgumentException">When any of the element in the <paramref name="items"/> is <see langword="null"/>.</exception>
    int AddAll(IEnumerable<T> items);

    /// <summary>
    /// Returns a copy of the internal collection without removing elements from it.
    /// <para>
    /// Enumerating on such a copy does NOT guarantee order.
    /// </para>
    /// </summary>
    T[] All();

    /// <summary>
    /// Creates and return the current internal state as <see cref="ReadOnlySpan{T}"/>.
    /// </summary>
    ReadOnlySpan<T> AsSpan();

    /// <summary>
    /// Internally allocated storage will be compacted to match the current usage.
    /// <para>
    /// The operation may take time to re-allocate required memory in order to maintain
    /// internal state.
    /// </para>
    /// </summary>
    void Compact();
}
