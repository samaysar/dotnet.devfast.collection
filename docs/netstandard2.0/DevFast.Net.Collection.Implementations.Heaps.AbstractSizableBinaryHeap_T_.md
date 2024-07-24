#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.Heaps](DevFast.Net.Collection.Implementations.Heaps.md 'DevFast.Net.Collection.Implementations.Heaps')

## AbstractSizableBinaryHeap<T> Class

Sizable binary heap abstract implementation.
Think of it as HeapBuilder (similar to StringBuilder) when
final size of the heap is not known in advance (e.g. data coming from db, network etc).
Once construction is done, capacity can be frozen, with ot without compaction ([FreezeCapacity(bool)](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.FreezeCapacity(bool)')).

```csharp
public abstract class AbstractSizableBinaryHeap<T> : DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<T>
```
- *Properties*
  - **[CanResize](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.CanResize 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.CanResize')**
- *Methods*
  - **[FreezeCapacity(bool)](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.FreezeCapacity(bool)')**

## AbstractSizableBinaryHeap<T> Class

Sizable binary heap abstract implementation.
Think of it as HeapBuilder (similar to StringBuilder) when
final size of the heap is not known in advance (e.g. data coming from db, network etc).
Once construction is done, capacity can be frozen, with ot without compaction ([FreezeCapacity(bool)](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.FreezeCapacity(bool)')).

```csharp
public abstract class AbstractSizableBinaryHeap<T> : DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<T>
```
#### Type parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T'></a>

`T`

Heap type

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap&lt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.T')[&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>') &#129106; AbstractSizableBinaryHeap<T>

Implements [DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap&lt;](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>'), [DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap&lt;](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>'), [DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection&lt;](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Properties

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.CanResize'></a>

## AbstractSizableBinaryHeap<T>.CanResize Property

Gets the current truth value whether resizing is possible or not.

NOTE: After calling [FreezeCapacity(bool)](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.FreezeCapacity(bool)'), it will always return false.

```csharp
public bool CanResize { get; }
```

Implements [CanResize](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.CanResize 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.CanResize')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.FreezeCapacity(bool)'></a>

## AbstractSizableBinaryHeap<T>.FreezeCapacity(bool) Method

Calling this method will freeze the capacity (i.e. heap will not resize upon add).
Also, runs compaction on the internally allocated storage based on [compact](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.FreezeCapacity(bool).compact 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.FreezeCapacity(bool).compact') flag.

```csharp
public void FreezeCapacity(bool compact);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.FreezeCapacity(bool).compact'></a>

`compact` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, internally allocated storage will be compacted.

Implements [FreezeCapacity(bool)](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.FreezeCapacity(bool)')