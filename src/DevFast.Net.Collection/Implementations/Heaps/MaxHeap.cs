using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Implementations.Heaps.AbstractBase;
using DevFast.Net.Collection.Implementations.ReSizing;

namespace DevFast.Net.Collection.Implementations.Heaps;

/// <summary>
/// Implementation of Binary Max Heap.
/// </summary>
/// <remarks>
/// Ctor with initial capacity, comparer and resizing strategy.
/// Different in-built resizing strategy are available (<seealso cref="NoResizing"/>,
/// <seealso cref="FixedStepReSizing"/> and <seealso cref="MultipleReSizing"/>).
/// </remarks>
/// <param name="initialCapacity">Initial capacity of the heap</param>
/// <param name="comparer">Comparer instance. If not provided, then <seealso cref="Comparer{T}.Default"/> will be used.</param>
/// <param name="resizeStrategy">Heap resizing strategy. If not provided, then <seealso cref="NoResizing"/> will be internally used.</param>
public sealed class MaxHeap<T>(int initialCapacity,
        IComparer<T>? comparer = null,
        IResizeStrategy? resizeStrategy = null) : SizableBinaryHeap<T>(initialCapacity, resizeStrategy ?? NoResizing.Default)
{
    private readonly IComparer<T> _comparer = comparer ?? Comparer<T>.Default;

    /// <inheritdoc/>
    protected override bool LeftPrecedes(T left, T right)
    {
        return _comparer.Compare(left, right) > 0;
    }
}