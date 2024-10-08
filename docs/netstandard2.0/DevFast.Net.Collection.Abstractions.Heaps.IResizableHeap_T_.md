#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Heaps](DevFast.Net.Collection.Abstractions.Heaps.md 'DevFast.Net.Collection.Abstractions.Heaps')

## IResizableHeap<T> Interface

Interface to declare resizing operations contract on a Heap collection.

```csharp
public interface IResizableHeap<T> :
DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<T>
```
#### Type parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.T'></a>

`T`

Derived  
&#8627; [SizableBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap<T>')

Implements [DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection&lt;](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>')[T](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[T](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Properties

<a name='DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.CanResize'></a>

## IResizableHeap<T>.CanResize Property

Gets the current truth value whether resizing is possible or not.

NOTE: After calling [FreezeCapacity(bool)](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.FreezeCapacity(bool)'), it shall always return false.

```csharp
bool CanResize { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.FreezeCapacity(bool)'></a>

## IResizableHeap<T>.FreezeCapacity(bool) Method

Calling this method will freeze the capacity (i.e. heap will not resize upon add).
Also, runs compaction on the internally allocated storage based on [compact](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.FreezeCapacity(bool).compact 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.FreezeCapacity(bool).compact') flag.

Use [compact](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.FreezeCapacity(bool).compact 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>.FreezeCapacity(bool).compact'), if gain from releasing memory outweighs the cost of compaction.

```csharp
void FreezeCapacity(bool compact);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.FreezeCapacity(bool).compact'></a>

`compact` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, internally allocated storage will be compacted.