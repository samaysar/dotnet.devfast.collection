#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Concurrent.Hashed](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed')

## IFastSet<T> Interface

Interface for abstraction of thread-safe set.

```csharp
public interface IFastSet<T> :
System.Collections.Generic.ISet<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlySet<T>,
System.Collections.Generic.IReadOnlyCollection<T>
    where T : notnull
```
#### Type parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T'></a>

`T`

Derived  
&#8627; [FastSet&lt;T&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet_T_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastSet<T>')

Implements [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlySet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlySet-1 'System.Collections.Generic.IReadOnlySet`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlySet-1 'System.Collections.Generic.IReadOnlySet`1'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Properties

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.PartitionCount'></a>

## IFastSet<T>.PartitionCount Property

Gets the number of Partitions contained in the [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>').

```csharp
int PartitionCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.Clear(bool)'></a>

## IFastSet<T>.Clear(bool) Method

Removes all items from all the partitions.

```csharp
void Clear(bool releaseMemory);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.Clear(bool).releaseMemory'></a>

`releaseMemory` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), partitions are recreated by releasing previously allocated memory.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.Clear(int)'></a>

## IFastSet<T>.Clear(int) Method

Removes all items from all the partitions.

NOTE: [initialCapacity](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.Clear(int).initialCapacity 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.Clear(int).initialCapacity') is IGNORED for NETSTANDARD2_0 OR LOWER.

```csharp
void Clear(int initialCapacity);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.Clear(int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial capacity of the partitions to be re-created.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.EnumerableOnPartition(int)'></a>

## IFastSet<T>.EnumerableOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of
a partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.EnumerableOnPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.EnumerableOnPartition(int).partitionIndex'); where Partition index is 0-based
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
System.Collections.Generic.IEnumerable<T> EnumerableOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.EnumerableOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## IFastSet<T>.ExceptWith(IEnumerable<T>, CancellationToken, int) Method

Removes all elements of the [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.ExceptWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection from current instance.

```csharp
void ExceptWith(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Collection to compare with current instance

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.ExceptWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## IFastSet<T>.IntersectWith(IEnumerable<T>, CancellationToken, int) Method

Modifies the current set so that it contains elements that are also in [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IntersectWith(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection.

```csharp
void IntersectWith(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IntersectWith(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_)'></a>

## IFastSet<T>.IsProperSubsetOf(IEnumerable<T>) Method

Determines whether the current set is a proper subset of [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>).other') is enumerated as it-is without cast.
In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

Implements [IsProperSubsetOf(IEnumerable&lt;T&gt;)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlySet-1.IsProperSubsetOf#System_Collections_Generic_IReadOnlySet_1_IsProperSubsetOf_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.IReadOnlySet`1.IsProperSubsetOf(System.Collections.Generic.IEnumerable{`0})'), [IsProperSubsetOf(IEnumerable&lt;T&gt;)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.IsProperSubsetOf#System_Collections_Generic_ISet_1_IsProperSubsetOf_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.IsProperSubsetOf(System.Collections.Generic.IEnumerable{`0})')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## IFastSet<T>.IsProperSubsetOf(IEnumerable<T>, CancellationToken, int) Method

Determines whether the current set is a proper subset of [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') is enumerated as it-is without cast.
In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSubsetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_)'></a>

## IFastSet<T>.IsProperSupersetOf(IEnumerable<T>) Method

Determines whether the current set is a proper superset of [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>).other') is enumerated as it-is without cast.
In all cases, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

Implements [IsProperSupersetOf(IEnumerable&lt;T&gt;)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlySet-1.IsProperSupersetOf#System_Collections_Generic_IReadOnlySet_1_IsProperSupersetOf_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.IReadOnlySet`1.IsProperSupersetOf(System.Collections.Generic.IEnumerable{`0})'), [IsProperSupersetOf(IEnumerable&lt;T&gt;)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.IsProperSupersetOf#System_Collections_Generic_ISet_1_IsProperSupersetOf_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.IsProperSupersetOf(System.Collections.Generic.IEnumerable{`0})')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int)'></a>

## IFastSet<T>.IsProperSupersetOf(IEnumerable<T>, CancellationToken, int) Method

Determines whether the current set is a proper superset of [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') collection.

IMPLEMENTATION NOTES:
1. Whenever possible comparison is done WITHOUT taking the snapshot of the current state,
thus, in order to obtain consistent results, do NOT mutate collection (e.g. add, remove etc) concurrently.

2. Snapshot is taken when [other](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>, System.Threading.CancellationToken, int).other') is enumerated as it-is without cast. But,
in any case, concurrently mutating a set and comparing with another collection does NOT make much sense.

```csharp
bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other, System.Threading.CancellationToken token, int maxConcurrency);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.T 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare with

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastSet_T_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_T_,System.Threading.CancellationToken,int).maxConcurrency'></a>

`maxConcurrency` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum parallelism to be employed (Min bound is [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'))

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')