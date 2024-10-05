#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions.Concurrent.LookUps](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.md 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps')

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

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey'></a>

`TKey`

The type of the keys in the dictionary.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue'></a>

`TValue`

The type of the values in the dictionary.

Derived  
&#8627; [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>')

Implements [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Properties

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.Keys'></a>

## IFastDictionary<TKey,TValue>.Keys Property

Gets an enumerable collection that contains the keys of the dictionary.

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.

```csharp
System.Collections.Generic.IEnumerable<TKey> Keys { get; }
```

Implements [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Keys 'System.Collections.Generic.IReadOnlyDictionary`2.Keys'), [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Keys 'System.Collections.Generic.IDictionary`2.Keys')

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.PartitionCount'></a>

## IFastDictionary<TKey,TValue>.PartitionCount Property

Gets the number of Partitions contained in the [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>').

```csharp
int PartitionCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.this[TKey]'></a>

## IFastDictionary<TKey,TValue>.this[TKey] Property

Gets the element that has the specified key in the read-only dictionary.

```csharp
TValue this[TKey key] { get; set; }
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.this[TKey].key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [this[TKey]](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Item#System_Collections_Generic_IReadOnlyDictionary_2_Item__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.Item(`0)'), [this[TKey]](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Item#System_Collections_Generic_IDictionary_2_Item__0_ 'System.Collections.Generic.IDictionary`2.Item(`0)')

#### Property Value
[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.this[TKey].key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
The property is retrieved and [key](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.this[TKey].key') is not found.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.Values'></a>

## IFastDictionary<TKey,TValue>.Values Property

Gets an enumerable collection that contains the values of the dictionary.

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.

```csharp
System.Collections.Generic.IEnumerable<TValue> Values { get; }
```

Implements [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Values 'System.Collections.Generic.IReadOnlyDictionary`2.Values'), [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Values 'System.Collections.Generic.IDictionary`2.Values')

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
### Methods

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.Clear(bool)'></a>

## IFastDictionary<TKey,TValue>.Clear(bool) Method

Removes all items from all the partitions.

```csharp
void Clear(bool releaseMemory);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.Clear(bool).releaseMemory'></a>

`releaseMemory` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), partitions are recreated by releasing previously allocated memory.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.Clear(int)'></a>

## IFastDictionary<TKey,TValue>.Clear(int) Method

Removes all items from all the partitions.

```csharp
void Clear(int initialCapacity);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.Clear(int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial capacity of the partitions to be re-created.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.ContainsKey(TKey)'></a>

## IFastDictionary<TKey,TValue>.ContainsKey(TKey) Method

Determines whether the read-only dictionary contains an element that has the specified key.

```csharp
bool ContainsKey(TKey key);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.ContainsKey(TKey).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [ContainsKey(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.ContainsKey#System_Collections_Generic_IReadOnlyDictionary_2_ContainsKey__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.ContainsKey(`0)'), [ContainsKey(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.ContainsKey#System_Collections_Generic_IDictionary_2_ContainsKey__0_ 'System.Collections.Generic.IDictionary`2.ContainsKey(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the read-only dictionary contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.ContainsKey(TKey).key 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.ContainsKey(TKey).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.EnumerableOfKeys()'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfKeys() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition
at a time. That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.

```csharp
System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeys();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.EnumerableOfValues()'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfValues() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

IMPLEMENTATION NOTES: Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition
at a time. That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.

```csharp
System.Collections.Generic.IEnumerable<TValue> EnumerableOfValues();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue)'></a>

## IFastDictionary<TKey,TValue>.TryGetValue(TKey, TValue) Method

Gets the value that is associated with the specified key.

```csharp
bool TryGetValue(TKey key, out TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')

The key to locate.

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')

When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the [value](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TryGetValue(TKey, TValue).value') parameter. This parameter is passed uninitialized.

Implements [TryGetValue(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.TryGetValue#System_Collections_Generic_IReadOnlyDictionary_2_TryGetValue__0,_1@_ 'System.Collections.Generic.IReadOnlyDictionary`2.TryGetValue(`0,`1@)'), [TryGetValue(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.TryGetValue#System_Collections_Generic_IDictionary_2_TryGetValue__0,_1@_ 'System.Collections.Generic.IDictionary`2.TryGetValue(`0,`1@)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the object that implements the [System.Collections.Generic.IReadOnlyDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2') interface contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TryGetValue(TKey, TValue).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').