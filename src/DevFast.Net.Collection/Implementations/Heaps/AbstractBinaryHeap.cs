using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DevFast.Net.Collection.Abstractions.Heaps;
using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Collection.Implementations.Heaps;

/// <summary>
/// Abstract binary heap implementation.
/// </summary>
public abstract class AbstractBinaryHeap<T> : ICompactAbleHeap<T>
{
    private T[] _heapData;
    private readonly IEqualityComparer<T>? _comparer;

    /// <summary>
    /// Ctor with initial heap capacity.
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the heap.</param>
    protected AbstractBinaryHeap(int initialCapacity) : this(initialCapacity, null)
    {
    }

    /// <summary>
    /// Ctor with initial heap capacity and equality comparer.
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the heap.</param>
    /// <param name="equalityComparer">Equality comparer for items.</param>
    protected AbstractBinaryHeap(int initialCapacity, IEqualityComparer<T>? equalityComparer)
    {
        _comparer = equalityComparer;
        _heapData = new T[initialCapacity
            .ThrowArgumentExceptionOnPredicateFail(static x => x >= 0,
            $"Inside {nameof(AbstractBinaryHeap<T>)}, {nameof(initialCapacity)}", ": 'value > 0'")];
        Count = 0;
    }

    /// <inheritdoc />
    public bool IsEmpty => Count.Equals(0);

    /// <inheritdoc />
    public bool IsFull => Count.Equals(Capacity);

    /// <inheritdoc />
    public int Count { get; private set; }

    /// <inheritdoc />
    public int Capacity => _heapData.Length;

    /// <inheritdoc />
    public bool IsReadOnly => false;

    /// <inheritdoc />
    public T Peek()
    {
        return TryPeek(out T? item) ? item : throw new InvalidOperationException($"{nameof(Peek)} not permitted on empty heap.");
    }

    /// <inheritdoc />
    public virtual bool TryPeek([NotNullWhen(true)] out T? item)
    {
        if (IsEmpty)
        {
            item = default;
            return false;
        }
        item = _heapData[0]!;
        return true;
    }

    /// <inheritdoc />
    public T Pop()
    {
        return TryPop(out T? item) ? item : throw new InvalidOperationException($"{nameof(Pop)} not permitted on empty heap.");
    }

    /// <inheritdoc />
#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public virtual bool TryPop([NotNullWhen(true)] out T? item)
    {
        if (IsEmpty)
        {
            item = default;
            return false;
        }
        item = _heapData[0]!;
        _heapData[0] = _heapData[--Count];
        PushDown();
        return true;
    }

    /// <inheritdoc />
    public void Add(T item)
    {
        _ = TryAdd(item).ThrowInvalidOperationExceptionIfFalse("Unable to add element in the heap.");
    }

    /// <inheritdoc />
#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public virtual bool TryAdd(T item)
    {
        return AddCore(item.ThrowArgumentExceptionForNull(nameof(item)));
    }

    /// <inheritdoc />
    public IEnumerable<T> PopAll()
    {
        while (TryPop(out T? item))
        {
            yield return item;
        }
    }

    /// <inheritdoc />
    public int AddAll(IEnumerable<T> items)
    {
        int count = 0;
        using IEnumerator<T> enu = items.GetEnumerator();
        while (enu.MoveNext() && TryAdd(enu.Current))
        {
            count++;
        }

        return count;
    }

    /// <inheritdoc />
    public void Compact()
    {
        ReSizeCapacity(Count);
    }

    /// <inheritdoc/>
    public T[] All()
    {
        if (Count != 0)
        {
            T[] newCollection = new T[Count];
            CopyTo(newCollection, 0);
            return newCollection;
        }
        return [];
    }

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator()
    {
#if NETSTANDARD2_1_OR_GREATER || NET6_0_OR_GREATER
        return new ArraySegment<T>(_heapData, 0, Count).GetEnumerator();
#else
        for (int i = 0; i < Count; i++)
        {
            yield return _heapData[i];
        }
#endif
    }

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc/>
    public virtual void Clear()
    {
        Count = 0;
    }

    /// <inheritdoc/>
    public bool Contains(T item)
    {
        if (_comparer == null)
        {
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, _heapData[i]))
                {
                    return true;
                }
            }
        }
        else
        {
            for (int i = 0; i < Count; i++)
            {
                if (_comparer.Equals(item, _heapData[i]))
                {
                    return true;
                }
            }
        }
        return false;
    }

    /// <inheritdoc/>
    public void CopyTo(T[] array, int arrayIndex)
    {
        AsSpan().CopyTo(array.AsSpan(arrayIndex));
    }

    /// <inheritdoc/>
    public bool Remove(T item)
    {
        throw new NotSupportedException();
    }

    /// <inheritdoc/>
    public ReadOnlySpan<T> AsSpan()
    {
        return new ReadOnlySpan<T>(_heapData, 0, Count);
    }

    /// <summary>
    /// Returns the truth value whether given <paramref name="left"/> element precedes
    /// compared to given <paramref name="right"/> element, in assumed sorted order (i.e. if
    /// we start popping out elements from heap, whether element provided as <paramref name="left"/> must
    /// be popped out before the element provided as <paramref name="right"/>).
    /// </summary>
    /// <param name="left">Left element</param>
    /// <param name="right">Right element</param>
#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    protected abstract bool LeftPrecedes(T left, T right);

    /// <summary>
    /// Ensures that there is a capacity to add an element.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    protected virtual bool EnsureCapacity()
    {
        return !IsFull;
    }

    /// <summary>
    /// Replaces the internal array with a new array of a given <paramref name="size"/>.
    /// </summary>
    /// <param name="size">Size of the new array.</param>
    /// <exception cref="ArgumentException">When the given size is less than current count.</exception>
    protected void ReSizeCapacity(int size)
    {
        T[] newCollection = new T[size.ThrowArgumentExceptionOnPredicateFail(x => x < Count, $"Cannot resize; {nameof(size)}", $"size >= {nameof(Count)}.")];
        CopyTo(newCollection, 0);
        _heapData = newCollection;
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private bool AddCore(T item)
    {
        if (!EnsureCapacity())
        {
            return false;
        }

        _heapData[Count] = item;
        BubbleUp(Count++);
        return true;
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private static int LeftChildIndex(int elementIndex)
    {
        return (elementIndex << 1) + 1;
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private static int ParentIndex(int elementIndex)
    {
        return (elementIndex - 1) >> 1;
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private void BubbleUp(int current)
    {
        while (!current.Equals(0))
        {
            int parentIndex = ParentIndex(current);
            if (!LeftPrecedes(_heapData[current], _heapData[parentIndex]))
            {
                return;
            }

            current = SwapNReturnLastParam(current, parentIndex);
        }
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private void PushDown()
    {
        int current = 0;
        int leftIndex = 1;
        while (leftIndex < Count)
        {
            int swapWith = leftIndex;
            int rightIndex = leftIndex + 1;
            if (rightIndex < Count &&
                LeftPrecedes(_heapData[rightIndex], _heapData[leftIndex]))
            {
                swapWith = rightIndex;
            }
            if (!LeftPrecedes(_heapData[swapWith], _heapData[current]))
            {
                return;
            }
            current = SwapNReturnLastParam(current, swapWith);
            leftIndex = LeftChildIndex(current);
        }
    }

#if NETCOREAPP3_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    private int SwapNReturnLastParam(int firstIndex, int secondIndex)
    {
        (_heapData[secondIndex], _heapData[firstIndex]) = (_heapData[firstIndex], _heapData[secondIndex]);
        return secondIndex;
    }
}