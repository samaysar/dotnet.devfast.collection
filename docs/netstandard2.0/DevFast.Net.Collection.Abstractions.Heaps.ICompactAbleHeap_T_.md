#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Heaps](DevFast.Net.Collection.Abstractions.Heaps.md 'DevFast.Net.Collection.Abstractions.Heaps')

## ICompactAbleHeap<T> Interface

Interface to declare compaction contract.

```csharp
public interface ICompactAbleHeap<T> :
DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable
```
#### Type parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.T'></a>

`T`

Derived  
&#8627; [IResizableHeap&lt;T&gt;](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>')  
&#8627; [AbstractBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>')

Implements [DevFast.Net.Collection.Abstractions.Heaps.IHeap&lt;](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>')[T](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.Compact()'></a>

## ICompactAbleHeap<T>.Compact() Method

Internally allocated storage will be compacted to match the current usage.

```csharp
void Compact();
```