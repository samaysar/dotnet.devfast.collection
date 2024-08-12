using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Heaps;
using DevFast.Net.Collection.Implementations.ReSizing;
using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Collection.Implementations.Heaps.AbstractBase;

/// <summary>
/// Sizable binary heap abstract implementation.
/// Think of it as HeapBuilder (similar to StringBuilder) when
/// final size of the heap is not known in advance (e.g. data coming from db, network etc).
/// Once construction is done, capacity can be frozen, with or without compaction (<see cref="FreezeCapacity(bool)"/>).
/// </summary>
/// <typeparam name="T">Heap type</typeparam>
public abstract class SizableBinaryHeap<T> : BinaryHeap<T>, IResizableHeap<T>
{
    private IResizeStrategy _resizing;

    /// <summary>
    /// Ctor with initial capacity. <seealso cref="NoResizing"/> is used as sizing strategy.
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the heap</param>
    /// <exception cref="ArgumentException">When capacity is less than 0.</exception>
    protected SizableBinaryHeap(int initialCapacity) : this(initialCapacity, NoResizing.Default)
    {
    }

    /// <summary>
    /// Ctor with initial capacity and resizing strategy.
    /// Different in-built resizing strategy are available (<seealso cref="NoResizing"/>, <seealso cref="FixedStepReSizing"/>
    /// and <seealso cref="MultipleReSizing"/>).
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the heap</param>
    /// <param name="resizeStrategy">Heap resizing strategy.</param>
    /// <exception cref="ArgumentException">When capacity is less than 0 or resize-strategy is null.</exception>
    protected SizableBinaryHeap(int initialCapacity, IResizeStrategy resizeStrategy) : base(initialCapacity)
    {
        _resizing = resizeStrategy.ThrowArgumentExceptionForNull(nameof(resizeStrategy));
    }

    /// <inheritdoc />
    public bool CanResize => _resizing.CanResize;

    /// <inheritdoc />
    public void FreezeCapacity(bool compact)
    {
        _resizing = NoResizing.Default;
        if (compact)
        {
            Compact();
        }
    }

    /// <inheritdoc/>
    protected sealed override bool EnsureCapacity()
    {
        if (!IsFull)
        {
            return true;
        }

        if (!_resizing.TryComputeNewSize(Count, out int newSize))
        {
            return false;
        }

        ReSizeCapacity(newSize);
        return true;
    }
}