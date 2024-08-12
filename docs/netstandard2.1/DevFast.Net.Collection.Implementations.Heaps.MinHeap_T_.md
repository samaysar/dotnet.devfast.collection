#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.Heaps](DevFast.Net.Collection.Implementations.Heaps.md 'DevFast.Net.Collection.Implementations.Heaps')

## MinHeap<T> Class

Implementation of Binary Min Heap.

```csharp
public sealed class MinHeap<T> : DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap<T>
```
- *Constructors*
  - **[MinHeap(int, IComparer&lt;T&gt;, IResizeStrategy)](DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.MinHeap(int,System.Collections.Generic.IComparer_T_,DevFast.Net.Collection.Abstractions.IResizeStrategy) 'DevFast.Net.Collection.Implementations.Heaps.MinHeap<T>.MinHeap(int, System.Collections.Generic.IComparer<T>, DevFast.Net.Collection.Abstractions.IResizeStrategy)')**

## MinHeap<T> Class

Implementation of Binary Min Heap.

```csharp
public sealed class MinHeap<T> : DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap<T>
```
#### Type parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [DevFast.Net.Collection.Implementations.Heaps.AbstractBase.BinaryHeap&lt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.BinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.BinaryHeap<T>')[T](DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.MinHeap<T>.T')[&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.BinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.BinaryHeap<T>') &#129106; [DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap&lt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap<T>')[T](DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.MinHeap<T>.T')[&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap<T>') &#129106; MinHeap<T>

### Remarks
Ctor with initial capacity, comparer and resizing strategy.
Different in-built resizing strategy are available (<seealso cref="T:DevFast.Net.Collection.Implementations.ReSizing.NoResizing"/>,
<seealso cref="T:DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing"/> and <seealso cref="T:DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing"/>).
### Constructors

<a name='DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.MinHeap(int,System.Collections.Generic.IComparer_T_,DevFast.Net.Collection.Abstractions.IResizeStrategy)'></a>

## MinHeap(int, IComparer<T>, IResizeStrategy) Constructor

Implementation of Binary Min Heap.

```csharp
public MinHeap(int initialCapacity, System.Collections.Generic.IComparer<T>? comparer=null, DevFast.Net.Collection.Abstractions.IResizeStrategy? resizeStrategy=null);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.MinHeap(int,System.Collections.Generic.IComparer_T_,DevFast.Net.Collection.Abstractions.IResizeStrategy).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial capacity of the heap

<a name='DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.MinHeap(int,System.Collections.Generic.IComparer_T_,DevFast.Net.Collection.Abstractions.IResizeStrategy).comparer'></a>

`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.MinHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')

Comparer instance. If not provided, then <seealso cref="P:System.Collections.Generic.Comparer`1.Default"/> will be used.

### See Also
- [System.Collections.Generic.Comparer&lt;&gt;.Default](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Comparer-1.Default 'System.Collections.Generic.Comparer`1.Default')

<a name='DevFast.Net.Collection.Implementations.Heaps.MinHeap_T_.MinHeap(int,System.Collections.Generic.IComparer_T_,DevFast.Net.Collection.Abstractions.IResizeStrategy).resizeStrategy'></a>

`resizeStrategy` [IResizeStrategy](DevFast.Net.Collection.Abstractions.IResizeStrategy.md 'DevFast.Net.Collection.Abstractions.IResizeStrategy')

Heap resizing strategy. If not provided, then <seealso cref="T:DevFast.Net.Collection.Implementations.ReSizing.NoResizing"/> will be internally used.

### See Also
- [NoResizing](DevFast.Net.Collection.Implementations.ReSizing.NoResizing.md 'DevFast.Net.Collection.Implementations.ReSizing.NoResizing')

### Remarks
Ctor with initial capacity, comparer and resizing strategy.
Different in-built resizing strategy are available (<seealso cref="T:DevFast.Net.Collection.Implementations.ReSizing.NoResizing"/>,
<seealso cref="T:DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing"/> and <seealso cref="T:DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing"/>).