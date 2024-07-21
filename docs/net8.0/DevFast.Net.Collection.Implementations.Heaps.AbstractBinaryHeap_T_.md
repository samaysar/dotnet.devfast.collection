#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.Heaps](DevFast.Net.Collection.Implementations.Heaps.md 'DevFast.Net.Collection.Implementations.Heaps')

## AbstractBinaryHeap<T> Class

Abstract binary heap implementation.

```csharp
public abstract class AbstractBinaryHeap<T> :
DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap
```
- *Constructors*
  - **[AbstractBinaryHeap(int)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AbstractBinaryHeap(int) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.AbstractBinaryHeap(int)')**
- *Properties*
  - **[Capacity](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Capacity 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Capacity')**
  - **[Count](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Count 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Count')**
  - **[IsEmpty](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsEmpty 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.IsEmpty')**
  - **[IsFull](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsFull 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.IsFull')**
- *Methods*
  - **[Add(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Add(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Add(T)')**
  - **[AddAll(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.AddAll(System.Collections.Generic.IEnumerable<T>)')**
  - **[All()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.All() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.All()')**
  - **[Compact()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Compact() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Compact()')**
  - **[EnsureCapacity()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.EnsureCapacity() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.EnsureCapacity()')**
  - **[GetEnumerator()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.GetEnumerator() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.GetEnumerator()')**
  - **[GetFirstUnsafe()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.GetFirstUnsafe() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.GetFirstUnsafe()')**
  - **[InternalReSizeData(int)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.InternalReSizeData(int) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.InternalReSizeData(int)')**
  - **[LeftPrecedes(T, T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.LeftPrecedes(T, T)')**
  - **[Peek()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Peek() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Peek()')**
  - **[Pop()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Pop() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.Pop()')**
  - **[PopAll()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.PopAll() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.PopAll()')**
  - **[TryAdd(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryAdd(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.TryAdd(T)')**
  - **[TryPeek(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPeek(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.TryPeek(T)')**
  - **[TryPop(T)](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.TryPop(T) 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.TryPop(T)')**
- *Explicit Interface Implementations*
  - **[System.Collections.IEnumerable.GetEnumerator()](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.System.Collections.IEnumerable.GetEnumerator() 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.System.Collections.IEnumerable.GetEnumerator()')**

## AbstractBinaryHeap<T> Class

Abstract binary heap implementation.

```csharp
public abstract class AbstractBinaryHeap<T> :
DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap
```
#### Type parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AbstractBinaryHeap<T>

Implements [DevFast.Net.Collection.Abstractions.Heaps.IHeap&lt;](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [ICompactAbleHeap](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap.md 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap')
### Constructors

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AbstractBinaryHeap(int)'></a>

## AbstractBinaryHeap(int) Constructor

Ctor with initial heap capacity.

```csharp
protected AbstractBinaryHeap(int initialCapacity);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.AbstractBinaryHeap(int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial capacity of the heap.
### Properties

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Capacity'></a>

## AbstractBinaryHeap<T>.Capacity Property

Current capacity of the heap.

```csharp
public int Capacity { get; }
```

Implements [Capacity](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Capacity 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.Capacity')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Count'></a>

## AbstractBinaryHeap<T>.Count Property

Current count of the elements in the heap.

```csharp
public int Count { get; set; }
```

Implements [Count](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Count 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.Count')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsEmpty'></a>

## AbstractBinaryHeap<T>.IsEmpty Property

Gets the truth value whether the heap is empty or not.

```csharp
public bool IsEmpty { get; }
```

Implements [IsEmpty](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.IsEmpty 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.IsEmpty')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.IsFull'></a>

## AbstractBinaryHeap<T>.IsFull Property

Gets the truth value whether the heap is full or not.

```csharp
public bool IsFull { get; }
```

Implements [IsFull](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.IsFull 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.IsFull')

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

Implements [Add(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Add(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.Add(T)')

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

Implements [AddAll(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.AddAll(System.Collections.Generic.IEnumerable<T>)')

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

Implements [All()](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.All() 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.All()')

#### Returns
[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Compact()'></a>

## AbstractBinaryHeap<T>.Compact() Method

Internally allocated storage will be compacted to match the current usage.

```csharp
public void Compact();
```

Implements [Compact()](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap.md#DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap.Compact() 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap.Compact()')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.EnsureCapacity()'></a>

## AbstractBinaryHeap<T>.EnsureCapacity() Method

Ensures that there is a capacity to add an element.

```csharp
protected virtual bool EnsureCapacity();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

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

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.GetFirstUnsafe()'></a>

## AbstractBinaryHeap<T>.GetFirstUnsafe() Method

Its an unsafe getter. !!! Does not check for the presence of the element
at 0th index. !!!

```csharp
internal T GetFirstUnsafe();
```

#### Returns
[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.InternalReSizeData(int)'></a>

## AbstractBinaryHeap<T>.InternalReSizeData(int) Method

Replaces the internal array with a new array of a given [size](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.InternalReSizeData(int).size 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.InternalReSizeData(int).size').

```csharp
protected void InternalReSizeData(int size);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.InternalReSizeData(int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Size of the new array.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the given size is less than current count.

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T)'></a>

## AbstractBinaryHeap<T>.LeftPrecedes(T, T) Method

Returns the truth value whether given [left](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T).left 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.LeftPrecedes(T, T).left') element precedes
compared to given [right](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T).right 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.LeftPrecedes(T, T).right') element, in assumed sorted order (i.e. if
we start popping out elements from heap, whether element provided as [left](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T).left 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.LeftPrecedes(T, T).left') must
be popped out before the element provided as [right](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T).right 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.LeftPrecedes(T, T).right')).

```csharp
protected abstract bool LeftPrecedes(T left, T right);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T).left'></a>

`left` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

Left element

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.LeftPrecedes(T,T).right'></a>

`right` [T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')

Right element

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.Peek()'></a>

## AbstractBinaryHeap<T>.Peek() Method

Returns the first element of the heap without removing it from the heap.

```csharp
public T Peek();
```

Implements [Peek()](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Peek() 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.Peek()')

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

Implements [Pop()](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Pop() 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.Pop()')

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

Implements [PopAll()](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.PopAll() 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.PopAll()')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md#DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.T 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

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

Implements [TryAdd(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryAdd(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.TryAdd(T)')

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

Implements [TryPeek(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryPeek(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.TryPeek(T)')

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

Implements [TryPop(T)](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryPop(T) 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.TryPop(T)')

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