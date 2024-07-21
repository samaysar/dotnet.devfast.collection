#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Heaps](DevFast.Net.Collection.Abstractions.Heaps.md 'DevFast.Net.Collection.Abstractions.Heaps')

## IHeap<T> Interface

Heap data structure interface.

```csharp
public interface IHeap<T> :
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable
```
#### Type parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T'></a>

`T`

Heap element type

Derived  
&#8627; [ICompactAbleHeap&lt;T&gt;](DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.ICompactAbleHeap<T>')  
&#8627; [IResizableHeap&lt;T&gt;](DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap_T_.md 'DevFast.Net.Collection.Abstractions.Heaps.IResizableHeap<T>')  
&#8627; [AbstractBinaryHeap&lt;T&gt;](DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap_T_.md 'DevFast.Net.Collection.Implementations.Heaps.AbstractBinaryHeap<T>')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Properties

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Capacity'></a>

## IHeap<T>.Capacity Property

Current capacity of the heap.

```csharp
int Capacity { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Count'></a>

## IHeap<T>.Count Property

Current count of the elements in the heap.

```csharp
int Count { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.IsEmpty'></a>

## IHeap<T>.IsEmpty Property

Gets the truth value whether the heap is empty or not.

```csharp
bool IsEmpty { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.IsFull'></a>

## IHeap<T>.IsFull Property

Gets the truth value whether the heap is full or not.

```csharp
bool IsFull { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Add(T)'></a>

## IHeap<T>.Add(T) Method

Adds given element to the heap.

```csharp
void Add(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Add(T).item'></a>

`item` [T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')

Element to add

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When element is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
When element cannot be added.

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_)'></a>

## IHeap<T>.AddAll(IEnumerable<T>) Method

Adds all elements of the given enumeration to the heap.
Returns the count of the elements that were successfully added.

```csharp
int AddAll(System.Collections.Generic.IEnumerable<T> items);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumeration of the Elements to add.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When any of the element in the [items](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.AddAll(System.Collections.Generic.IEnumerable_T_).items 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.AddAll(System.Collections.Generic.IEnumerable<T>).items') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.All()'></a>

## IHeap<T>.All() Method

Returns a copy of the internal collection without removing elements from it.

Enumerating on such a copy does NOT guarantee order.

```csharp
T[] All();
```

#### Returns
[T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Peek()'></a>

## IHeap<T>.Peek() Method

Returns the first element of the heap without removing it from the heap.

```csharp
T Peek();
```

#### Returns
[T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
When the heap is empty.

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.Pop()'></a>

## IHeap<T>.Pop() Method

Removes and returns the first element from the heap.

```csharp
T Pop();
```

#### Returns
[T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
When the heap is empty.

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.PopAll()'></a>

## IHeap<T>.PopAll() Method

Removes all the elements (in order) from the heap.

```csharp
System.Collections.Generic.IEnumerable<T> PopAll();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryAdd(T)'></a>

## IHeap<T>.TryAdd(T) Method

Tries adding given element in the heap.
Returns the truth value whether it was successfully added or not.

```csharp
bool TryAdd(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryAdd(T).item'></a>

`item` [T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')

Element to add.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When element is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryPeek(T)'></a>

## IHeap<T>.TryPeek(T) Method

Returns the truth value whether heap contains at least one (1) item and outs the first element of the heap
without removing it from the heap.

```csharp
bool TryPeek(out T? item);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryPeek(T).item'></a>

`item` [T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')

out element

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryPop(T)'></a>

## IHeap<T>.TryPop(T) Method

Returns the truth value whether the first heap element was successfully removed
and outs that element.

```csharp
bool TryPop(out T? item);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.TryPop(T).item'></a>

`item` [T](DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.md#DevFast.Net.Collection.Abstractions.Heaps.IHeap_T_.T 'DevFast.Net.Collection.Abstractions.Heaps.IHeap<T>.T')

out element

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')