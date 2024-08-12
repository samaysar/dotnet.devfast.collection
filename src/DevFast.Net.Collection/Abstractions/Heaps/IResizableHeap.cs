namespace DevFast.Net.Collection.Abstractions.Heaps;

/// <summary>
/// Interface to declare resizing operations contract on a Heap collection.
/// </summary>
public interface IResizableHeap<T> : IHeapCollection<T>
{
    /// <summary>
    /// Gets the current truth value whether resizing is possible or not.
    /// <para>
    /// NOTE: After calling <see cref="FreezeCapacity"/>, it shall always return false.
    /// </para>
    /// </summary>
    bool CanResize { get; }

    /// <summary>
    /// Calling this method will freeze the capacity (i.e. heap will not resize upon add).
    /// Also, runs compaction on the internally allocated storage based on <paramref name="compact"/> flag.
    /// <para>
    /// Use <paramref name="compact"/>, if gain from releasing memory outweighs the cost of compaction.
    /// </para>
    /// </summary>
    /// <param name="compact">If true, internally allocated storage will be compacted.</param>
    void FreezeCapacity(bool compact);
}