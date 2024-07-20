#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions](DevFast.Net.Collection.Abstractions.md 'DevFast.Net.Collection.Abstractions')

## ICompactAbleHeap Interface

Interface to declare compaction contract.

```csharp
public interface ICompactAbleHeap
```

Derived  
&#8627; [IResizableHeap&lt;T&gt;](DevFast.Net.Collection.Abstractions.IResizableHeap_T_.md 'DevFast.Net.Collection.Abstractions.IResizableHeap<T>')
### Methods

<a name='DevFast.Net.Collection.Abstractions.ICompactAbleHeap.Compact()'></a>

## ICompactAbleHeap.Compact() Method

Internally allocated storage will be compacted to match the current usage.

```csharp
void Compact();
```