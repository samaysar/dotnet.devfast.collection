#### [DevFast.Net.Collection](index.md 'index')

## DevFast.Net.Collection.Implementations.Heaps.AbstractBase Namespace

[namespace](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace') contains [abstract](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract') heap implementations.

| Classes | |
| :--- | :--- |
| [BinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.BinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.BinaryHeap<T>') | Abstract binary heap implementation. |
| [SizableBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap<T>') | Sizable binary heap abstract implementation. Think of it as HeapBuilder (similar to StringBuilder) when final size of the heap is not known in advance (e.g. data coming from db, network etc). Once construction is done, capacity can be frozen, with or without compaction ([FreezeCapacity(bool)](DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBase.SizableBinaryHeap<T>.FreezeCapacity(bool)')). |
