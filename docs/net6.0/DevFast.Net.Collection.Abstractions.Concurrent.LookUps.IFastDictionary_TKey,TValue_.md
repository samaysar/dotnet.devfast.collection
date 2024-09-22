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

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.PartitionCount'></a>

## IFastDictionary<TKey,TValue>.PartitionCount Property

Gets the number of Partitions contained in the [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>').

```csharp
int PartitionCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
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

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.EnumerableOfKeys()'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfKeys() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeys();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.EnumerableOfValues()'></a>

## IFastDictionary<TKey,TValue>.EnumerableOfValues() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
System.Collections.Generic.IEnumerable<TValue> EnumerableOfValues();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Abstractions.Concurrent.LookUps.IFastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')