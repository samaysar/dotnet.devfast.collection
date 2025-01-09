#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.Concurrent.Hashed](DevFast.Net.Collection.Implementations.Concurrent.Hashed.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed')

## FastSet<T> Class

Implementation of thread-safe set.

```csharp
public sealed class FastSet<T> :
DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>,
System.Collections.Generic.ISet<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable
    where T : notnull
```
- *Constructors*
  - **[FastSet()](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet() 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet()')**
  - **[FastSet(int, int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int)')**
  - **[FastSet(int, int, IEqualityComparer&lt;T&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>)')**
  - **[FastSet(int, int, IEqualityComparer&lt;T&gt;, IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>)')**
  - **[FastSet(int, IEqualityComparer&lt;T&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, System.Collections.Generic.IEqualityComparer<T>)')**
  - **[FastSet(IEqualityComparer&lt;T&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(System.Collections.Generic.IEqualityComparer_T_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(System.Collections.Generic.IEqualityComparer<T>)')**
- *Properties*
  - **[Count](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Count 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Count')**
  - **[IsReadOnly](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsReadOnly 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsReadOnly')**
  - **[PartitionCount](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.PartitionCount 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.PartitionCount')**
- *Methods*
  - **[Add(T)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Add(T) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Add(T)')**
  - **[Clear()](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear() 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Clear()')**
  - **[Clear(bool)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear(bool) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Clear(bool)')**
  - **[Clear(int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear(int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Clear(int)')**
  - **[Contains(T)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Contains(T) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Contains(T)')**
  - **[CopyTo(T[], int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.CopyTo(T[], int)')**
  - **[EnumerableOnPartition(int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.EnumerableOnPartition(int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.EnumerableOnPartition(int)')**
  - **[ExceptWith(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.ExceptWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')**
  - **[GetEnumerator()](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.GetEnumerator() 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.GetEnumerator()')**
  - **[IntersectWith(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IntersectWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')**
  - **[IsProperSubsetOf(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>)')**
  - **[IsProperSubsetOf(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')**
  - **[IsProperSupersetOf(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>)')**
  - **[IsProperSupersetOf(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')**
  - **[Remove(T)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Remove(T) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Remove(T)')**

## FastSet<T> Class

Implementation of thread-safe set.

```csharp
public sealed class FastSet<T> :
DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>,
System.Collections.Generic.ISet<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable
    where T : notnull
```
#### Type parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FastSet<T>

Implements [DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet&lt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>'), [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Constructors

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet()'></a>

## FastSet() Constructor

Initializes a new instance of the [FastSet&lt;T&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>') class that is empty and
has default initial capacity, has default concurrency level,
and uses default Equality comparer for the key.

NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.

```csharp
public FastSet();
```

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int)'></a>

## FastSet(int, int) Constructor

Initializes a new instance of the [FastSet&lt;T&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>') class that is empty
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).initialCapacity'), has given [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).concurrencyLevel')
and uses default Equality comparer for the key.

NOTE: Total expected memory allocation is bit more than [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).initialCapacity') * [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).concurrencyLevel').
NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).initialCapacity') has internal lower bound=[MinInitialCapacity](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity 'DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity') and [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).concurrencyLevel') has internal lower bound=[MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel').

NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).initialCapacity') is IGNORED for NETSTANDARD2_0 OR LOWER.[concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int).concurrencyLevel') has internal upper bound=[HashedCollectionMaxConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel') and always adjusted to the nearest higher power of 2.

```csharp
public FastSet(int initialCapacity, int concurrencyLevel);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int).concurrencyLevel'></a>

`concurrencyLevel` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Concurrency level

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_)'></a>

## FastSet(int, int, IEqualityComparer<T>) Constructor

Initializes a new instance of the [FastSet&lt;T&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>') class that is empty
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity'), has given [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).concurrencyLevel')
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).comparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).comparer') for the key type.

NOTE: Total expected memory allocation is bit more than [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity') * [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).concurrencyLevel').
NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity') has internal lower bound=[MinInitialCapacity](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity 'DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity') and [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).concurrencyLevel') has internal lower bound=[MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel').
[concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).concurrencyLevel') has internal upper bound=[HashedCollectionMaxConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel') and always adjusted to the nearest higher power of 2.

NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity') is IGNORED for NETSTANDARD2_0 OR LOWER.

```csharp
public FastSet(int initialCapacity, int concurrencyLevel, System.Collections.Generic.IEqualityComparer<T>? comparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).concurrencyLevel'></a>

`concurrencyLevel` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Expected maximum concurrency

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_)'></a>

## FastSet(int, int, IEqualityComparer<T>, IEnumerable<T>) Constructor

Initializes a new instance of the [FastSet&lt;T&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>') class that initially contains
items of the [initialData](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).initialData 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).initialData'),
has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).initialCapacity'), has given [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).concurrencyLevel')
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).comparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).comparer') for the key type.

NOTE: Total expected memory allocation is bit more than [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).initialCapacity') * [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).concurrencyLevel').
NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).initialCapacity') has internal lower bound=[MinInitialCapacity](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity 'DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity') and [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).concurrencyLevel') has internal lower bound=[MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel').
[concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).concurrencyLevel') has internal upper bound=[HashedCollectionMaxConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel') and always adjusted to the nearest higher power of 2.

NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, int, System.Collections.Generic.IEqualityComparer<T>, System.Collections.Generic.IEnumerable<T>).initialCapacity') is IGNORED for NETSTANDARD2_0 OR LOWER.

```csharp
public FastSet(int initialCapacity, int concurrencyLevel, System.Collections.Generic.IEqualityComparer<T>? comparer, System.Collections.Generic.IEnumerable<T> initialData);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).concurrencyLevel'></a>

`concurrencyLevel` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Expected maximum concurrency

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,int,System.Collections.Generic.IEqualityComparer_T_,System.Collections.Generic.IEnumerable_T_).initialData'></a>

`initialData` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Initial dataset of the set

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_)'></a>

## FastSet(int, IEqualityComparer<T>) Constructor

Initializes a new instance of the [FastSet&lt;T&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>') class that is empty and
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity'), has default concurrency level,
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_).comparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, System.Collections.Generic.IEqualityComparer<T>).comparer') for the key type.

NOTE: Total expected memory allocation is bit more than [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity') * default_concurrency_level.
NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity') has internal lower bound=[MinInitialCapacity](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity 'DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity').

NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(int, System.Collections.Generic.IEqualityComparer<T>).initialCapacity') is IGNORED for NETSTANDARD2_0 OR LOWER.

```csharp
public FastSet(int initialCapacity, System.Collections.Generic.IEqualityComparer<T>? comparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(int,System.Collections.Generic.IEqualityComparer_T_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(System.Collections.Generic.IEqualityComparer_T_)'></a>

## FastSet(IEqualityComparer<T>) Constructor

Initializes a new instance of the [FastSet&lt;T&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>') class that is empty and
has the default initial capacity, has default concurrency level,
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(System.Collections.Generic.IEqualityComparer_T_).comparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.FastSet(System.Collections.Generic.IEqualityComparer<T>).comparer') for the key type.

NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.

```csharp
public FastSet(System.Collections.Generic.IEqualityComparer<T> comparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.FastSet(System.Collections.Generic.IEqualityComparer_T_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key
### Properties

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Count'></a>

## FastSet<T>.Count Property

Gets the number of elements contained in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

```csharp
public int Count { get; }
```

Implements [Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Count 'System.Collections.Generic.ICollection`1.Count')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsReadOnly'></a>

## FastSet<T>.IsReadOnly Property

Gets a value indicating whether the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

```csharp
public bool IsReadOnly { get; }
```

Implements [IsReadOnly](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.IsReadOnly 'System.Collections.Generic.ICollection`1.IsReadOnly')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.PartitionCount'></a>

## FastSet<T>.PartitionCount Property

Gets the number of Partitions contained in the [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>').

```csharp
public int PartitionCount { get; }
```

Implements [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.PartitionCount')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Methods

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Add(T)'></a>

## FastSet<T>.Add(T) Method

Adds an item to the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

```csharp
public bool Add(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Add(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')

The object to add to the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

Implements [Add(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.Add#System_Collections_Generic_ISet_1_Add__0_ 'System.Collections.Generic.ISet`1.Add(`0)'), [Add(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Add#System_Collections_Generic_ICollection_1_Add__0_ 'System.Collections.Generic.ICollection`1.Add(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Exceptions

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear()'></a>

## FastSet<T>.Clear() Method

Removes all items from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

```csharp
public void Clear();
```

Implements [Clear()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Clear 'System.Collections.Generic.ICollection`1.Clear')

#### Exceptions

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear(bool)'></a>

## FastSet<T>.Clear(bool) Method

Removes all items from all the partitions.

```csharp
public void Clear(bool releaseMemory);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear(bool).releaseMemory'></a>

`releaseMemory` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), partitions are recreated by releasing previously allocated memory.

Implements [Clear(bool)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.Clear(bool) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.Clear(bool)')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear(int)'></a>

## FastSet<T>.Clear(int) Method

Removes all items from all the partitions.

NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear(int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Clear(int).initialCapacity') is IGNORED for NETSTANDARD2_0 OR LOWER.

```csharp
public void Clear(int initialCapacity);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Clear(int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial capacity of the partitions to be re-created.

Implements [Clear(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.Clear(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.Clear(int)')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Contains(T)'></a>

## FastSet<T>.Contains(T) Method

Determines whether the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') contains a specific value.

```csharp
public bool Contains(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Contains(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')

The object to locate in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

Implements [Contains(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Contains#System_Collections_Generic_ICollection_1_Contains__0_ 'System.Collections.Generic.ICollection`1.Contains(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [item](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Contains(T).item 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Contains(T).item') is found in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int)'></a>

## FastSet<T>.CopyTo(T[], int) Method

Copies the elements of the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'), starting at a particular [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') index.

```csharp
public void CopyTo(T[] array, int arrayIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int).array'></a>

`array` [T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that is the destination of the elements copied from [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'). The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') must have zero-based indexing.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int).arrayIndex'></a>

`arrayIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based index in [array](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int).array 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.CopyTo(T[], int).array') at which copying begins.

Implements [CopyTo(T[], int)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.CopyTo#System_Collections_Generic_ICollection_1_CopyTo__0[],System_Int32_ 'System.Collections.Generic.ICollection`1.CopyTo(`0[],System.Int32)')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[array](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int).array 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.CopyTo(T[], int).array') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[arrayIndex](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int).arrayIndex 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.CopyTo(T[], int).arrayIndex') is less than 0.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
The number of elements in the source [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is greater than the available space from [arrayIndex](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int).arrayIndex 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.CopyTo(T[], int).arrayIndex') to the end of the destination [array](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.CopyTo(T[],int).array 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.CopyTo(T[], int).array').

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.EnumerableOnPartition(int)'></a>

## FastSet<T>.EnumerableOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of
a partition identified with [partitionIndex](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.EnumerableOnPartition(int).partitionIndex 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.EnumerableOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.PartitionCount') - 1).

IMPLEMENTATION NOTES: This implementation is preferable over other [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') implementations
as it creates a snapshot on the partition without consuming space. This implementation is very
interesting to traverse values concurrently on different partitions from separate thread; for an example:

```csharp
Parallel.For(
    0,
    instance.PartitionCount,
    i =>
    {
        foreach(var val in instance.EnumerableOnPartition(i))
        {
            ...YOUR CODE...
        }
    }
);
```
NOTE: During the enumeration the partition is locked, i.e. concurrent operations done from
different threads (e.g. add/remove) will be blocked. Modifying the collection while enumerating
(e.g. removing entries) from the same thread is an anti-pattern and should be avoided
(e.g. case of re-entrancy); this MAY lead to unexpected outcome.

```csharp
public System.Collections.Generic.IEnumerable<T> EnumerableOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.EnumerableOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

Implements [EnumerableOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.EnumerableOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.EnumerableOnPartition(int)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## FastSet<T>.ExceptWith(IEnumerable<T>, CancellationToken, int) Method

Removes all elements of the [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.ExceptWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection from current instance.

```csharp
public void ExceptWith(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Collection to compare with current instance

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

Implements [ExceptWith(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.ExceptWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.GetEnumerator()'></a>

## FastSet<T>.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
public System.Collections.Generic.IEnumerator<T> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator that can be used to iterate through the collection.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## FastSet<T>.IntersectWith(IEnumerable<T>, CancellationToken, int) Method

Modifies the current set so that it contains elements that are also in [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IntersectWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection.

```csharp
public void IntersectWith(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

Implements [IntersectWith(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IntersectWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_)'></a>

## FastSet<T>.IsProperSubsetOf(IEnumerable<T>) Method

Determines whether the current set is a proper subset of [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>).other') is enumerated as it-is without cast.
In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
public bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

Implements [IsProperSubsetOf(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>)'), [IsProperSubsetOf(IEnumerable&lt;T&gt;)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.IsProperSubsetOf#System_Collections_Generic_ISet_1_IsProperSubsetOf_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.IsProperSubsetOf(System.Collections.Generic.IEnumerable{`0})')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## FastSet<T>.IsProperSubsetOf(IEnumerable<T>, CancellationToken, int) Method

Determines whether the current set is a proper subset of [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') is enumerated as it-is without cast.
In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
public bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

Implements [IsProperSubsetOf(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_)'></a>

## FastSet<T>.IsProperSupersetOf(IEnumerable<T>) Method

Determines whether the current set is a proper superset of [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>).other') is enumerated as it-is without cast.
In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

Implements [IsProperSupersetOf(IEnumerable&lt;T&gt;)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>)'), [IsProperSupersetOf(IEnumerable&lt;T&gt;)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.IsProperSupersetOf#System_Collections_Generic_ISet_1_IsProperSupersetOf_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.IsProperSupersetOf(System.Collections.Generic.IEnumerable{`0})')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## FastSet<T>.IsProperSupersetOf(IEnumerable<T>, CancellationToken, int) Method

Determines whether the current set is a proper superset of [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') is enumerated as it-is without cast. But,
in any case, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

Implements [IsProperSupersetOf(IEnumerable&lt;T&gt;, CancellationToken, int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Remove(T)'></a>

## FastSet<T>.Remove(T) Method

Removes the first occurrence of a specific object from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

```csharp
public bool Remove(T item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Remove(T).item'></a>

`item` [T](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.T 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.T')

The object to remove from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

Implements [Remove(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Remove#System_Collections_Generic_ICollection_1_Remove__0_ 'System.Collections.Generic.ICollection`1.Remove(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [item](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Remove(T).item 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Remove(T).item') was successfully removed from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). This method also returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [item](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.Remove(T).item 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>.Remove(T).item') is not found in the original [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

#### Exceptions

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.