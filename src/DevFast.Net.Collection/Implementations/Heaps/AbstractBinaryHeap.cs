﻿using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DevFast.Net.Collection.Abstractions.Heaps;
using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Collection.Implementations.Heaps;

/// <summary>
/// Abstract binary heap implementation.
/// </summary>
public abstract class AbstractBinaryHeap<T> : IHeap<T>, ICompactAbleHeap
{
    private T[] _heapData;

    /// <summary>
    /// Ctor with initial heap capacity.
    /// </summary>
    /// <param name="initialCapacity">Initial capacity of the heap.</param>
    protected AbstractBinaryHeap(int initialCapacity)
    {
        _heapData = new T[initialCapacity
            .ThrowArgumentExceptionOnPredicateFail(static x => x > 0,
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

    private static int LeftChildIndex(int elementIndex)
    {
        return (elementIndex << 1) + 1;
    }

    private static int ParentIndex(int elementIndex)
    {
        return (elementIndex - 1) >> 1;
    }

    /// <inheritdoc />
    public T Peek()
    {
        return TryPeek(out T? item)
#if !NETSTANDARD2_1_OR_GREATER && !NETCOREAPP3_0_OR_GREATER
            && item != null
#endif
            ? item : throw new InvalidOperationException($"{nameof(Peek)} not permitted on empty heap.");
    }

    /// <inheritdoc />
    public virtual bool TryPeek(
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
        [NotNullWhen(true)]
#endif
    out T? item)
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
        return TryPop(out T? item)
#if !NETSTANDARD2_1_OR_GREATER && !NETCOREAPP3_0_OR_GREATER
            && item != null
#endif
            ? item : throw new InvalidOperationException($"{nameof(Pop)} not permitted on empty heap.");
    }

    /// <inheritdoc />
    public virtual bool TryPop(
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
        [NotNullWhen(true)]
#endif
    out T? item)
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
    public virtual bool TryAdd(T item)
    {
        return AddCore(item.ThrowArgumentExceptionForNull(nameof(item)));
    }

    /// <inheritdoc />
    public IEnumerable<T> PopAll()
    {
        while (TryPop(out T? item)
#if !NETSTANDARD2_1_OR_GREATER && !NETCOREAPP3_0_OR_GREATER
            && item != null
#endif
        )
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
        InternalReSizeData(Count);
    }

    /// <summary>
    /// Its an unsafe getter. !!! Does not check for the presence of the element
    /// at 0th index. !!!
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal T GetFirstUnsafe()
    {
        return _heapData[0];
    }

    internal List<T> PopAllConsistent()
    {
        List<T> results = new(Count);
        results.AddRange(PopAll());
        return results;
    }

    internal IEnumerable<T> InternalStateAsEnumerable()
    {
        return new ArraySegment<T>(_heapData, 0, Count);
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

    /// <summary>
    /// Ensures that there is a capacity to add an element.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected virtual bool EnsureCapacity()
    {
        return !IsFull;
    }

    /// <summary>
    /// Replaces the internal array with a new array of a given <paramref name="size"/>.
    /// </summary>
    /// <param name="size">Size of the new array.</param>
    /// <exception cref="ArgumentException">When the given size is less than current count.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void InternalReSizeData(int size)
    {
        T[] newCollection = new T[size.ThrowArgumentExceptionOnPredicateFail(x => x < Count, $"Cannot resize; {nameof(size)}", $"size >= {nameof(Count)}.")];
        new ReadOnlySpan<T>(_heapData, 0, Count).CopyTo(newCollection);
        _heapData = newCollection;
    }

    private int SwapNReturnLastParam(int firstIndex, int secondIndex)
    {
        (_heapData[secondIndex], _heapData[firstIndex]) = (_heapData[firstIndex], _heapData[secondIndex]);
        return secondIndex;
    }

    /// <summary>
    /// Returns the truth value whether given <paramref name="left"/> element precedes
    /// compared to given <paramref name="right"/> element, in assumed sorted order (i.e. if
    /// we start popping out elements from heap, whether element provided as <paramref name="left"/> must
    /// be popped out before the element provided as <paramref name="right"/>).
    /// </summary>
    /// <param name="left">Left element</param>
    /// <param name="right">Right element</param>
    protected abstract bool LeftPrecedes(T left, T right);

    /// <inheritdoc/>
    public T[] All()
    {
        T[] newCollection = new T[Count];
        if (Count != 0)
        {
            Array.Copy(_heapData, newCollection, Count);
        }

        return newCollection;
    }

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator()
    {
        return InternalStateAsEnumerable().GetEnumerator();
    }

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}