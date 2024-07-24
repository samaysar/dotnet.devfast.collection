#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.Heaps](DevFast.Net.Collection.Implementations.Heaps.md 'DevFast.Net.Collection.Implementations.Heaps')

## AbstractBinaryHeap<T> Class

Abstract binary heap implementation.

```csharp
public abstract class AbstractBinaryHeap<T> :
DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<T>
```
- *Properties*
  - **[Capacity](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Capacity 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Capacity')**
  - **[Count](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Count 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Count')**
  - **[IsEmpty](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsEmpty 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.IsEmpty')**
  - **[IsFull](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsFull 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.IsFull')**
  - **[IsReadOnly](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsReadOnly 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.IsReadOnly')**
- *Methods*
  - **[Add(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Add(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Add(T)')**
  - **[AddAll(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.AddAll(System.Collections.Generic.IEnumerable<T>)')**
  - **[All()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.All() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.All()')**
  - **[AsSpan()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AsSpan() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.AsSpan()')**
  - **[Clear()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Clear() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Clear()')**
  - **[Compact()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Compact() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Compact()')**
  - **[Contains(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Contains(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Contains(T)')**
  - **[CopyTo(T[], int)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.CopyTo(T[], int)')**
  - **[GetEnumerator()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.GetEnumerator() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.GetEnumerator()')**
  - **[Peek()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Peek() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Peek()')**
  - **[Pop()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Pop() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Pop()')**
  - **[PopAll()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.PopAll() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.PopAll()')**
  - **[Remove(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Remove(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Remove(T)')**
  - **[TryAdd(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryAdd(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.TryAdd(T)')**
  - **[TryPeek(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPeek(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.TryPeek(T)')**
  - **[TryPop(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPop(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.TryPop(T)')**
- *Explicit Interface Implementations*
  - **[System.Collections.IEnumerable.GetEnumerator()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.System.Collections.IEnumerable.GetEnumerator() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.System.Collections.IEnumerable.GetEnumerator()')**

## AbstractBinaryHeap<T> Class

Abstract binary heap implementation.

```csharp
public abstract class AbstractBinaryHeap<T> :
DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>,
DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<T>
```
#### Type parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AbstractBinaryHeap<T>

Derived  
&#8627; [AbstractSizableBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractSizableBinaryHeap<T>')

Implements [DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap&lt;](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>'), [DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection&lt;](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Properties

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Capacity'></a>

## AbstractBinaryHeap<T>.Capacity Property

Current capacity of the heap.

```csharp
public int Capacity { get; }
```

Implements [Capacity](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.Capacity 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.Capacity')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Count'></a>

## AbstractBinaryHeap<T>.Count Property

Gets the number of elements currently present in the heap.

```csharp
public int Count { get; set; }
```

Implements [Count](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.Count 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.Count'), [Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1.Count 'System.Collections.Generic.IReadOnlyCollection`1.Count'), [Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Count 'System.Collections.Generic.ICollection`1.Count')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsEmpty'></a>

## AbstractBinaryHeap<T>.IsEmpty Property

Gets the truth value whether the heap is empty or not.

```csharp
public bool IsEmpty { get; }
```

Implements [IsEmpty](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.IsEmpty 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.IsEmpty')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsFull'></a>

## AbstractBinaryHeap<T>.IsFull Property

Gets the truth value whether the heap is full or not.

```csharp
public bool IsFull { get; }
```

Implements [IsFull](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.IsFull 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.IsFull')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsReadOnly'></a>

## AbstractBinaryHeap<T>.IsReadOnly Property

Gets a value indicating whether the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

```csharp
public bool IsReadOnly { get; }
```

Implements [IsReadOnly](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.IsReadOnly 'System.Collections.Generic.ICollection`1.IsReadOnly')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Add(T)'></a>

## AbstractBinaryHeap<T>.Add(T) Method

Adds given element to the heap.

```csharp
public void Add(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Add(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

Element to add

Implements [Add(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.Add(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.Add(T)'), [Add(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Add#System_Collections_Generic_ICollection_1_Add__0_ 'System.Collections.Generic.ICollection`1.Add(`0)')

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When element is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
When element cannot be added.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_)'></a>

## AbstractBinaryHeap<T>.AddAll(IEnumerable<T>) Method

Adds all elements of the given enumeration to the heap.
Returns the count of the elements that were successfully added.

```csharp
public int AddAll(System.Collections.Generic.IEnumerable<T> items);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumeration of the Elements to add.

Implements [AddAll(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.AddAll(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.AddAll(System.Collections.Generic.IEnumerable<T>)')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When any of the element in the [items](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_).items 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.AddAll(System.Collections.Generic.IEnumerable<T>).items') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.All()'></a>

## AbstractBinaryHeap<T>.All() Method

Returns a copy of the internal collection without removing elements from it.

Enumerating on such a copy does NOT guarantee order.

```csharp
public T[] All();
```

Implements [All()](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.All() 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.All()')

#### Returns
[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AsSpan()'></a>

## AbstractBinaryHeap<T>.AsSpan() Method

Creates and return the current internal state as [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1').

```csharp
public System.ReadOnlySpan<T> AsSpan();
```

Implements [AsSpan()](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.AsSpan() 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.AsSpan()')

#### Returns
[System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Clear()'></a>

## AbstractBinaryHeap<T>.Clear() Method

Removes all items from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

```csharp
public virtual void Clear();
```

Implements [Clear()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Clear 'System.Collections.Generic.ICollection`1.Clear')

#### Exceptions

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Compact()'></a>

## AbstractBinaryHeap<T>.Compact() Method

Internally allocated storage will be compacted to match the current usage.

```csharp
public void Compact();
```

Implements [Compact()](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.Compact() 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>.Compact()')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Contains(T)'></a>

## AbstractBinaryHeap<T>.Contains(T) Method

Determines whether the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') contains a specific value.

```csharp
public bool Contains(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Contains(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

The object to locate in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

Implements [Contains(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Contains#System_Collections_Generic_ICollection_1_Contains__0_ 'System.Collections.Generic.ICollection`1.Contains(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [item](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Contains(T).item 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Contains(T).item') is found in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int)'></a>

## AbstractBinaryHeap<T>.CopyTo(T[], int) Method

Copies the elements of the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'), starting at a particular [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') index.

```csharp
public void CopyTo(T[] array, int arrayIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int).array'></a>

`array` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that is the destination of the elements copied from [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'). The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') must have zero-based indexing.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int).arrayIndex'></a>

`arrayIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based index in [array](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int).array 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.CopyTo(T[], int).array') at which copying begins.

Implements [CopyTo(T[], int)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.CopyTo#System_Collections_Generic_ICollection_1_CopyTo__0[],System_Int32_ 'System.Collections.Generic.ICollection`1.CopyTo(`0[],System.Int32)')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[array](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int).array 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.CopyTo(T[], int).array') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[arrayIndex](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int).arrayIndex 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.CopyTo(T[], int).arrayIndex') is less than 0.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
The number of elements in the source [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is greater than the available space from [arrayIndex](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int).arrayIndex 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.CopyTo(T[], int).arrayIndex') to the end of the destination [array](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.CopyTo(T[],int).array 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.CopyTo(T[], int).array').

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.GetEnumerator()'></a>

## AbstractBinaryHeap<T>.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
public System.Collections.Generic.IEnumerator<T> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator that can be used to iterate through the collection.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Peek()'></a>

## AbstractBinaryHeap<T>.Peek() Method

Returns the first element of the heap without removing it from the heap.

```csharp
public T Peek();
```

Implements [Peek()](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.Peek() 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.Peek()')

#### Returns
[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
When the heap is empty.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Pop()'></a>

## AbstractBinaryHeap<T>.Pop() Method

Removes and returns the first element from the heap.

```csharp
public T Pop();
```

Implements [Pop()](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.Pop() 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.Pop()')

#### Returns
[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
When the heap is empty.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.PopAll()'></a>

## AbstractBinaryHeap<T>.PopAll() Method

Removes all the elements (in order) from the heap.

```csharp
public System.Collections.Generic.IEnumerable<T> PopAll();
```

Implements [PopAll()](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.PopAll() 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.PopAll()')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Remove(T)'></a>

## AbstractBinaryHeap<T>.Remove(T) Method

Removes the first occurrence of a specific object from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

```csharp
public bool Remove(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Remove(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

The object to remove from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

Implements [Remove(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Remove#System_Collections_Generic_ICollection_1_Remove__0_ 'System.Collections.Generic.ICollection`1.Remove(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [item](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Remove(T).item 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Remove(T).item') was successfully removed from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). This method also returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [item](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Remove(T).item 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Remove(T).item') is not found in the original [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

#### Exceptions

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryAdd(T)'></a>

## AbstractBinaryHeap<T>.TryAdd(T) Method

Tries adding given element in the heap.
Returns the truth value whether it was successfully added or not.

```csharp
public virtual bool TryAdd(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryAdd(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

Element to add.

Implements [TryAdd(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.TryAdd(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.TryAdd(T)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When element is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPeek(T)'></a>

## AbstractBinaryHeap<T>.TryPeek(T) Method

Returns the truth value whether heap contains at least one (1) item and outs the first element of the heap
without removing it from the heap.

```csharp
public virtual bool TryPeek(out T? item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPeek(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

out element

Implements [TryPeek(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.TryPeek(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.TryPeek(T)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPop(T)'></a>

## AbstractBinaryHeap<T>.TryPop(T) Method

Returns the truth value whether the first heap element was successfully removed
and outs that element.

```csharp
public virtual bool TryPop(out T? item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPop(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

out element

Implements [TryPop(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection_T_.TryPop(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeapCollection<T>.TryPop(T)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Explicit Interface Implementations

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.System.Collections.IEnumerable.GetEnumerator()'></a>

## AbstractBinaryHeap<T>.System.Collections.IEnumerable.GetEnumerator() Method

Returns an enumerator that iterates through a collection.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')