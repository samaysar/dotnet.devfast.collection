#### [DevFast.Net.Collection](index.md 'index')

## DevFast.Net.Collection.Implementations.Heaps Namespace

Under this [namespace](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace') we have implemented various Heap data-structures.

| Classes | |
| :--- | :--- |
| [AbstractBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>') | Abstract binary heap implementation. |
| [AbstractSizableBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>') | Sizable binary heap abstract implementation. Think of it as HeapBuilder (similar to StringBuilder) when final size of the heap is not known in advance (e.g. data coming from db, network etc). Once construction is done, capacity can be frozen, with ot without compaction ([FreezeCapacity(bool)](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.FreezeCapacity(bool) 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>.FreezeCapacity(bool)')). |
| [MinHeap](DevFast.Net.Collection.Implementations.Heaps.MinHeap.md 'DevFast.Net.Collection.Implementations.Heaps.MinHeap') | Implementation of Binary Min Heap. |
