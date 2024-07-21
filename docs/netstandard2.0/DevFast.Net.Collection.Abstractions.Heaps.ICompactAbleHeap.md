#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Heaps](DevFast.Net.Collection.Abstractions.Heaps.md 'DevFast.Net.Collection.Abstractions.Heaps')

## ICompactAbleHeap Interface

Interface to declare compaction contract.

```csharp
public interface ICompactAbleHeap
```

Derived  
&#8627; [IResizableHeap&lt;T&gt;](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>')  
&#8627; [AbstractBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap.Compact()'></a>

## ICompactAbleHeap.Compact() Method

Internally allocated storage will be compacted to match the current usage.

```csharp
void Compact();
```