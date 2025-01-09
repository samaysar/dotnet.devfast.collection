#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Concurrent.Hashed](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed')

## IFastDictionary<TKey,TValue> Interface

Interface for a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently.

```csharp
public interface IFastDictionary<TKey,TValue> :
System.Collections.Generic.IDictionary<TKey, TValue>,
System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    where TKey : notnull
```
#### Type parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey'></a>

`TKey`

The type of the keys in the dictionary.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue'></a>

`TValue`

The type of the values in the dictionary.

Derived  
&#8627; [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastDictionary<TKey,TValue>')

Implements [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Properties

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Keys'></a>

## IFastDictionary<TKey,TValue>.Keys Property

Gets an enumerable collection that contains the keys of the dictionary.

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
You may consider using [EnumerableOfKeysOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int)') if the dictionary is NOT
being modified concurrently.

```csharp
System.Collections.Generic.IEnumerable<TKey> Keys { get; }
```

Implements [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Keys 'System.Collections.Generic.IReadOnlyDictionary`2.Keys'), [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Keys 'System.Collections.Generic.IDictionary`2.Keys')

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.PartitionCount'></a>

## IFastDictionary<TKey,TValue>.PartitionCount Property

Gets the number of Partitions contained in the [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>').

```csharp
int PartitionCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.this[TKey]'></a>

## IFastDictionary<TKey,TValue>.this[TKey] Property

Gets the element that has the specified key in the read-only dictionary.

```csharp
TValue this[TKey key] { get; set; }
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.this[TKey].key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [this[TKey]](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Item#System_Collections_Generic_IReadOnlyDictionary_2_Item__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.Item(`0)'), [this[TKey]](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Item#System_Collections_Generic_IDictionary_2_Item__0_ 'System.Collections.Generic.IDictionary`2.Item(`0)')

#### Property Value
[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.this[TKey].key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
The property is retrieved and [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.this[TKey].key') is not found.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Values'></a>

## IFastDictionary<TKey,TValue>.Values Property

Gets an enumerable collection that contains the values of the dictionary.

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
You may consider using [EnumerableOfValuesOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int)') if the dictionary is NOT
being modified concurrently.

```csharp
System.Collections.Generic.IEnumerable<TValue> Values { get; }
```

Implements [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Values 'System.Collections.Generic.IReadOnlyDictionary`2.Values'), [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Values 'System.Collections.Generic.IDictionary`2.Values')

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, Func<TKey,TValue,TValue>, IEqualityComparer<TValue>) Method

Adds [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key')/[addValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).addValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).addValue') pair to the collection
if the [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key') does not already exist,
or updates [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key')/value pair by using [updateValueFactory](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).updateValueFactory 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).updateValueFactory') lambda
if the [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key') already exists.

```csharp
TValue AddOrUpdate(TKey key, TValue addValue, System.Func<TKey,TValue,TValue> updateValueFactory, System.Collections.Generic.IEqualityComparer<TValue>? comparer=null);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

The key to be added or updated

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).addValue'></a>

`addValue` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

The value to be added

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).updateValueFactory'></a>

`updateValueFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Value generating lambda for an existing key and value

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Value comparer. If not provided then default implementation will be used.

#### Returns
[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')  
The new value for the key. This will be either be [addValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).addValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).addValue') (if the key was absent) or the result of [updateValueFactory](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).updateValueFactory 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).updateValueFactory') (if the key was present).

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Clear(bool)'></a>

## IFastDictionary<TKey,TValue>.Clear(bool) Method

Removes all items from all the partitions.

```csharp
void Clear(bool releaseMemory);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Clear(bool).releaseMemory'></a>

`releaseMemory` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), partitions are recreated by releasing previously allocated memory.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Clear(int)'></a>

## IFastDictionary<TKey,TValue>.Clear(int) Method

Removes all items from all the partitions.

```csharp
void Clear(int initialCapacity);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Clear(int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial capacity of the partitions to be re-created.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## IFastDictionary<TKey,TValue>.Contains(KeyValuePair<TKey,TValue>, IEqualityComparer<TValue>) Method

Checks whether given key/value pair is part of current collection using provided [valueComparer](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer').
If [valueComparer](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), then [System.Collections.Generic.EqualityComparer&lt;&gt;.Default](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.EqualityComparer-1.Default 'System.Collections.Generic.EqualityComparer`1.Default')
will be used.

```csharp
bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item, System.Collections.Generic.IEqualityComparer<TValue>? valueComparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).item'></a>

`item` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

Key value pair to check

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer'></a>

`valueComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.ContainsKey(TKey)'></a>

## IFastDictionary<TKey,TValue>.ContainsKey(TKey) Method

Determines whether the read-only dictionary contains an element that has the specified key.

```csharp
bool ContainsKey(TKey key);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.ContainsKey(TKey).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [ContainsKey(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.ContainsKey#System_Collections_Generic_IReadOnlyDictionary_2_ContainsKey__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.ContainsKey(`0)'), [ContainsKey(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.ContainsKey#System_Collections_Generic_IDictionary_2_ContainsKey__0_ 'System.Collections.Generic.IDictionary`2.ContainsKey(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the read-only dictionary contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.ContainsKey(TKey).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.ContainsKey(TKey).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfKeys()'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfKeys() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition
at a time. That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
You may consider using [EnumerableOfKeysOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int)') if the dictionary is NOT
being modified concurrently.

```csharp
System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeys();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int)'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of
a partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.PartitionCount') - 1).

IMPLEMENTATION NOTES: This implementation is preferable over other [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') implementations
as it creates a snapshot on the partition without consuming space. This implementation is very
interesting to traverse keys concurrently on different partitions from separate thread; for an example:

```csharp
Parallel.For(
    0,
    instance.PartitionCount,
    i =>
    {
        foreach(var key in instance.KeysEnumerableOnPartition(i))
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
System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeysOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfValues()'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfValues() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition
at a time. That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.
You may consider using [EnumerableOfValuesOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int)') if the dictionary is NOT
being modified concurrently.

```csharp
System.Collections.Generic.IEnumerable<TValue> EnumerableOfValues();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int)'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values
of a partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.PartitionCount') - 1).

IMPLEMENTATION NOTES: This implementation is preferable over other [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') implementations
as it creates a snapshot on the partition without consuming space. This implementation is very
interesting to traverse values concurrently on different partitions from separate thread; for an example:

```csharp
Parallel.For(
    0,
    instance.PartitionCount,
    i =>
    {
        foreach(var value in instance.EnumerableOfValuesOnPartition(i))
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
System.Collections.Generic.IEnumerable<TValue> EnumerableOfValuesOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOnPartition(int)'></a>

## IFastDictionary<TKey,TValue>.EnumerableOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the key-values pairs
of a partition identified with [partitionIndex](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOnPartition(int).partitionIndex 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.EnumerableOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.PartitionCount') - 1).

IMPLEMENTATION NOTES: This implementation is preferable over other [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') implementations
as it creates a snapshot on the partition without consuming space. This implementation is very
interesting to traverse key-value pairs concurrently on different partitions from separate thread; for an example:

```csharp
Parallel.For(
    0,
    instance.PartitionCount,
    i =>
    {
        foreach(var pair in instance.EnumerableOnPartition(i))
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
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> EnumerableOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.EnumerableOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.GetOrAdd(TKey,System.Func_TKey,TValue_)'></a>

## IFastDictionary<TKey,TValue>.GetOrAdd(TKey, Func<TKey,TValue>) Method

Adds a key/value pair to the collection by using the specified function
if the key does not already exist.
Returns the new value, or the existing value if the key exists.

```csharp
TValue GetOrAdd(TKey key, System.Func<TKey,TValue> valueFactory);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.GetOrAdd(TKey,System.Func_TKey,TValue_).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

The key of the element to add.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.GetOrAdd(TKey,System.Func_TKey,TValue_).valueFactory'></a>

`valueFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The function used to generate a value for the key.

#### Returns
[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')  
The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.GetOrAdd(TKey,TValue)'></a>

## IFastDictionary<TKey,TValue>.GetOrAdd(TKey, TValue) Method

Adds a key/value pair to the collection if the key does not already exist.
Returns the new value, or the existing value if the key exists.

```csharp
TValue GetOrAdd(TKey key, TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.GetOrAdd(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

Key value.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.GetOrAdd(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

Value.

#### Returns
[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')  
The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## IFastDictionary<TKey,TValue>.Remove(KeyValuePair<TKey,TValue>, IEqualityComparer<TValue>) Method

Removes the given key/value pair from the collection using provided [valueComparer](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer').
If [valueComparer](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), then [System.Collections.Generic.EqualityComparer&lt;&gt;.Default](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.EqualityComparer-1.Default 'System.Collections.Generic.EqualityComparer`1.Default')
will be used.

```csharp
bool Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item, System.Collections.Generic.IEqualityComparer<TValue>? valueComparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).item'></a>

`item` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

Key value pair to be removed.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer'></a>

`valueComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryAdd(TKey,TValue)'></a>

## IFastDictionary<TKey,TValue>.TryAdd(TKey, TValue) Method

Attempts to add the specified key and value to the collection.

```csharp
bool TryAdd(TKey key, TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryAdd(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

The key of the element to add.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryAdd(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

The value of the element to add.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the key/value pair was added successfully; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the key already exists.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue)'></a>

## IFastDictionary<TKey,TValue>.TryGetValue(TKey, TValue) Method

Gets the value that is associated with the specified key.

```csharp
bool TryGetValue(TKey key, out TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

The key to locate.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the [value](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryGetValue(TKey, TValue).value') parameter. This parameter is passed uninitialized.

Implements [TryGetValue(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.TryGetValue#System_Collections_Generic_IReadOnlyDictionary_2_TryGetValue__0,_1@_ 'System.Collections.Generic.IReadOnlyDictionary`2.TryGetValue(`0,`1@)'), [TryGetValue(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.TryGetValue#System_Collections_Generic_IDictionary_2_TryGetValue__0,_1@_ 'System.Collections.Generic.IDictionary`2.TryGetValue(`0,`1@)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the object that implements the [System.Collections.Generic.IReadOnlyDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2') interface contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryGetValue(TKey, TValue).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryRemove(TKey,TValue)'></a>

## IFastDictionary<TKey,TValue>.TryRemove(TKey, TValue) Method

Attempts to remove and return the value that has the specified key.

```csharp
bool TryRemove(TKey key, out TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryRemove(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

The key of the element to remove and return.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryRemove(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

When this method returns, contains the object removed from the collection, or the default value of the [TValue](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/TValue 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/TValue') type if [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryRemove(TKey,TValue).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryRemove(TKey, TValue).key') does not exist.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the object was removed successfully; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, IEqualityComparer<TValue>) Method

Updates the value associated with [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).key') to [newValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).newValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).newValue')
if the existing value with [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).key') is equal to [comparisonValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparisonValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).comparisonValue').

```csharp
bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue, System.Collections.Generic.IEqualityComparer<TValue>? comparer=null);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TKey')

key.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).newValue'></a>

`newValue` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

Replacement value.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparisonValue'></a>

`comparisonValue` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')

Value to compare with the existing key value.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Value comparer. If not provided then default implementation will be used.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value with [key](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).key') was equal to [comparisonValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparisonValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).comparisonValue') and was replaced with [newValue](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).newValue 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).newValue'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').