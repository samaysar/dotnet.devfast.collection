#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Concurrent.Hashed](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed')

## IFastReadOnlyDictionary<TKey,TValue> Interface

Interface for a thread-safe collection of key-value pairs, for read-only purpose, that can be accessed by multiple threads concurrently.

```csharp
public interface IFastReadOnlyDictionary<TKey,TValue> :
System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    where TKey : notnull
```
#### Type parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey'></a>

`TKey`

The type of the keys in the dictionary.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue'></a>

`TValue`

The type of the values in the dictionary.

Derived  
&#8627; [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>')  
&#8627; [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastDictionary<TKey,TValue>')  
&#8627; [FastReadOnlyDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>')

Implements [System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Properties

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount'></a>

## IFastReadOnlyDictionary<TKey,TValue>.PartitionCount Property

Gets the number of Partitions contained in the [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>').

```csharp
int PartitionCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## IFastReadOnlyDictionary<TKey,TValue>.Contains(KeyValuePair<TKey,TValue>, IEqualityComparer<TValue>) Method

Checks whether given key/value pair is part of current collection using provided [valueComparer](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer').
If [valueComparer](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), then [System.Collections.Generic.EqualityComparer&lt;&gt;.Default](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.EqualityComparer-1.Default 'System.Collections.Generic.EqualityComparer`1.Default')
will be used.

```csharp
bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item, System.Collections.Generic.IEqualityComparer<TValue>? valueComparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).item'></a>

`item` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

Key value pair to check

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer'></a>

`valueComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__)'></a>

## IFastReadOnlyDictionary<TKey,TValue>.CopyTo(Span<KeyValuePair<TKey,TValue>>) Method

Copies the elements of the dictionary to the provided [target](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__).target 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.CopyTo(System.Span<System.Collections.Generic.KeyValuePair<TKey,TValue>>).target') span.

```csharp
void CopyTo(System.Span<System.Collections.Generic.KeyValuePair<TKey,TValue>> target);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__).target'></a>

`target` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

Span on which to copy dictionary elements

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CountInPartition(int)'></a>

## IFastReadOnlyDictionary<TKey,TValue>.CountInPartition(int) Method

Returns the count of elements in the partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CountInPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.CountInPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
int CountInPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CountInPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeys()'></a>

## IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeys() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeys();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int)'></a>

## IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of
a partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeysOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfValues()'></a>

## IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfValues() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
System.Collections.Generic.IEnumerable<TValue> EnumerableOfValues();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int)'></a>

## IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values
of a partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
System.Collections.Generic.IEnumerable<TValue> EnumerableOfValuesOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int)'></a>

## IFastReadOnlyDictionary<TKey,TValue>.EnumerableOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the key-values pairs
of a partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> EnumerableOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')