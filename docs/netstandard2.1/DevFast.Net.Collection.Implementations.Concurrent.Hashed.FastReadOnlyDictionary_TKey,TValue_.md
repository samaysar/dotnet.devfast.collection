#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.Concurrent.Hashed](DevFast.Net.Collection.Implementations.Concurrent.Hashed.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed')

## FastReadOnlyDictionary<TKey,TValue> Class

Implementation of dictionary which is fully-constructed during instantiation and
cannot be further modified.

```csharp
public sealed class FastReadOnlyDictionary<TKey,TValue> :
DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    where TKey : notnull
```
- *Constructors*
  - **[FastReadOnlyDictionary(int, int, IEnumerable&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;, bool)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool)')**
  - **[FastReadOnlyDictionary(int, int, IEqualityComparer&lt;TKey&gt;, IEnumerable&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;, bool)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool)')**
  - **[FastReadOnlyDictionary(int, IEqualityComparer&lt;TKey&gt;, IEnumerable&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;, bool)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool)')**
  - **[FastReadOnlyDictionary(IEnumerable&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;, bool)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool)')**
  - **[FastReadOnlyDictionary(IEqualityComparer&lt;TKey&gt;, IEnumerable&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;, bool)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool)')**
- *Properties*
  - **[Count](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Count 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.Count')**
  - **[Keys](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Keys 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.Keys')**
  - **[PartitionCount](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.PartitionCount')**
  - **[this[TKey]](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.this[TKey] 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.this[TKey]')**
  - **[Values](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Values 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.Values')**
- *Methods*
  - **[Contains(KeyValuePair&lt;TKey,TValue&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>)')**
  - **[Contains(KeyValuePair&lt;TKey,TValue&gt;, IEqualityComparer&lt;TValue&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>)')**
  - **[ContainsKey(TKey)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.ContainsKey(TKey) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.ContainsKey(TKey)')**
  - **[CopyTo(Span&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.CopyTo(System.Span<System.Collections.Generic.KeyValuePair<TKey,TValue>>)')**
  - **[CountInPartition(int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CountInPartition(int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.CountInPartition(int)')**
  - **[EnumerableOfKeys()](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeys() 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeys()')**
  - **[EnumerableOfKeysOnPartition(int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int)')**
  - **[EnumerableOfValues()](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfValues() 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOfValues()')**
  - **[EnumerableOfValuesOnPartition(int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int)')**
  - **[EnumerableOnPartition(int)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOnPartition(int)')**
  - **[GetEnumerator()](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.GetEnumerator() 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.GetEnumerator()')**
  - **[TryGetValue(TKey, TValue)](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TryGetValue(TKey,TValue) 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TryGetValue(TKey, TValue)')**
- *Explicit Interface Implementations*
  - **[System.Collections.IEnumerable.GetEnumerator()](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.System.Collections.IEnumerable.GetEnumerator() 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.System.Collections.IEnumerable.GetEnumerator()')**

## FastReadOnlyDictionary<TKey,TValue> Class

Implementation of dictionary which is fully-constructed during instantiation and
cannot be further modified.

```csharp
public sealed class FastReadOnlyDictionary<TKey,TValue> :
DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    where TKey : notnull
```
#### Type parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey'></a>

`TKey`

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue'></a>

`TValue`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FastReadOnlyDictionary<TKey,TValue>

Implements [DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary&lt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>'), [System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Constructors

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool)'></a>

## FastReadOnlyDictionary(int, int, IEnumerable<KeyValuePair<TKey,TValue>>, bool) Constructor

Initializes a new instance of the [FastReadOnlyDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>') class that
contains given [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items'), 
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).initialCapacity'), has given [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).concurrencyLevel')
and uses default Equality comparer for the key.

```csharp
public FastReadOnlyDictionary(int initialCapacity, int concurrencyLevel, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> items, bool ignoreDuplicates);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).concurrencyLevel'></a>

`concurrencyLevel` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Concurrency level

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Items that the dictionary will contain

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).ignoreDuplicates'></a>

`ignoreDuplicates` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') all duplicate keys in the [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items') are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool)'></a>

## FastReadOnlyDictionary(int, int, IEqualityComparer<TKey>, IEnumerable<KeyValuePair<TKey,TValue>>, bool) Constructor

Initializes a new instance of the [FastReadOnlyDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>') class that
contains given [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items'), has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).initialCapacity'), 
has given [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).concurrencyLevel')
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).comparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).comparer') for the key type.

NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).initialCapacity') has internal lower bound=[MinInitialCapacity](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity 'DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity') and [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).concurrencyLevel') has internal lower bound=[MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel').
[concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).concurrencyLevel') has internal upper bound=[HashedCollectionMaxConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel') and always adjusted to the nearest higher power of 2.

```csharp
public FastReadOnlyDictionary(int initialCapacity, int concurrencyLevel, System.Collections.Generic.IEqualityComparer<TKey>? comparer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> items, bool ignoreDuplicates);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).concurrencyLevel'></a>

`concurrencyLevel` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Expected maximum concurrency

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Data to initial the dictionary with

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).ignoreDuplicates'></a>

`ignoreDuplicates` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') all duplicate keys in the [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items') are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool)'></a>

## FastReadOnlyDictionary(int, IEqualityComparer<TKey>, IEnumerable<KeyValuePair<TKey,TValue>>, bool) Constructor

Initializes a new instance of the [FastReadOnlyDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>') class that
contains given [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items'), 
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).initialCapacity'), has default concurrency level,
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).comparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).comparer') for the key type.

```csharp
public FastReadOnlyDictionary(int initialCapacity, System.Collections.Generic.IEqualityComparer<TKey>? comparer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> items, bool ignoreDuplicates);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Items that the dictionary will contain

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).ignoreDuplicates'></a>

`ignoreDuplicates` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') all duplicate keys in the [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items') are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool)'></a>

## FastReadOnlyDictionary(IEnumerable<KeyValuePair<TKey,TValue>>, bool) Constructor

Initializes a new instance of the [FastReadOnlyDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>') class that
contains given [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items'), has the default initial capacity, has default concurrency level,
and uses default Equality comparer for the key.

```csharp
public FastReadOnlyDictionary(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> items, bool ignoreDuplicates);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Items that the dictionary will contain

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).ignoreDuplicates'></a>

`ignoreDuplicates` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') all duplicate keys in the [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items') are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool)'></a>

## FastReadOnlyDictionary(IEqualityComparer<TKey>, IEnumerable<KeyValuePair<TKey,TValue>>, bool) Constructor

Initializes a new instance of the [FastReadOnlyDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>') class that
contains given [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items'), has the default initial capacity, has default concurrency level,
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).comparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).comparer') for the key type.

```csharp
public FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer<TKey>? comparer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> items, bool ignoreDuplicates);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Items that the dictionary will contain

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).ignoreDuplicates'></a>

`ignoreDuplicates` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') all duplicate keys in the [items](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer_TKey_,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_TKey,TValue__,bool).items 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.FastReadOnlyDictionary(System.Collections.Generic.IEqualityComparer<TKey>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, bool).items') are ignored and arbitrary one of those is kept; otherwise exception is thrown when duplicate key is found.
### Properties

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Count'></a>

## FastReadOnlyDictionary<TKey,TValue>.Count Property

Gets the number of elements in the collection.

```csharp
public int Count { get; }
```

Implements [Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1.Count 'System.Collections.Generic.IReadOnlyCollection`1.Count')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Keys'></a>

## FastReadOnlyDictionary<TKey,TValue>.Keys Property

Gets an enumerable collection that contains the keys in the read-only dictionary.

```csharp
public System.Collections.Generic.IEnumerable<TKey> Keys { get; }
```

Implements [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Keys 'System.Collections.Generic.IReadOnlyDictionary`2.Keys')

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.PartitionCount'></a>

## FastReadOnlyDictionary<TKey,TValue>.PartitionCount Property

Gets the number of Partitions contained in the [IFastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastDictionary<TKey,TValue>').

```csharp
public int PartitionCount { get; }
```

Implements [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.this[TKey]'></a>

## FastReadOnlyDictionary<TKey,TValue>.this[TKey] Property

Gets the element that has the specified key in the read-only dictionary.

```csharp
public TValue this[TKey key] { get; }
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.this[TKey].key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [this[TKey]](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Item#System_Collections_Generic_IReadOnlyDictionary_2_Item__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.Item(`0)')

#### Property Value
[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.this[TKey].key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
The property is retrieved and [key](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.this[TKey].key') is not found.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Values'></a>

## FastReadOnlyDictionary<TKey,TValue>.Values Property

Gets an enumerable collection that contains the values in the read-only dictionary.

```csharp
public System.Collections.Generic.IEnumerable<TValue> Values { get; }
```

Implements [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Values 'System.Collections.Generic.IReadOnlyDictionary`2.Values')

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
### Methods

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_)'></a>

## FastReadOnlyDictionary<TKey,TValue>.Contains(KeyValuePair<TKey,TValue>) Method

Checks whether given key/value pair is part of current collection using default value comparer.

```csharp
public bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_).item'></a>

`item` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

Key value pair to check

Implements [Contains(KeyValuePair&lt;TKey,TValue&gt;)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## FastReadOnlyDictionary<TKey,TValue>.Contains(KeyValuePair<TKey,TValue>, IEqualityComparer<TValue>) Method

Checks whether given key/value pair is part of current collection using provided [valueComparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer').
If [valueComparer](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), then [System.Collections.Generic.EqualityComparer&lt;&gt;.Default](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.EqualityComparer-1.Default 'System.Collections.Generic.EqualityComparer`1.Default')
will be used.

```csharp
public bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item, System.Collections.Generic.IEqualityComparer<TValue>? valueComparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).item'></a>

`item` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

Key value pair to check

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer'></a>

`valueComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the value.

Implements [Contains(KeyValuePair&lt;TKey,TValue&gt;, IEqualityComparer&lt;TValue&gt;)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.ContainsKey(TKey)'></a>

## FastReadOnlyDictionary<TKey,TValue>.ContainsKey(TKey) Method

Determines whether the read-only dictionary contains an element that has the specified key.

```csharp
public bool ContainsKey(TKey key);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.ContainsKey(TKey).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [ContainsKey(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.ContainsKey#System_Collections_Generic_IReadOnlyDictionary_2_ContainsKey__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.ContainsKey(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the read-only dictionary contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.ContainsKey(TKey).key 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.ContainsKey(TKey).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__)'></a>

## FastReadOnlyDictionary<TKey,TValue>.CopyTo(Span<KeyValuePair<TKey,TValue>>) Method

Copies the elements of the dictionary to the provided [target](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__).target 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.CopyTo(System.Span<System.Collections.Generic.KeyValuePair<TKey,TValue>>).target') span.

```csharp
public void CopyTo(System.Span<System.Collections.Generic.KeyValuePair<TKey,TValue>> target);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__).target'></a>

`target` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

Span on which to copy dictionary elements

Implements [CopyTo(Span&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CopyTo(System.Span_System.Collections.Generic.KeyValuePair_TKey,TValue__) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.CopyTo(System.Span<System.Collections.Generic.KeyValuePair<TKey,TValue>>)')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CountInPartition(int)'></a>

## FastReadOnlyDictionary<TKey,TValue>.CountInPartition(int) Method

Returns the count of elements in the partition identified with [partitionIndex](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CountInPartition(int).partitionIndex 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.CountInPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
public int CountInPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.CountInPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

Implements [CountInPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.CountInPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.CountInPartition(int)')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeys()'></a>

## FastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeys() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
public System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeys();
```

Implements [EnumerableOfKeys()](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeys() 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeys()')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int)'></a>

## FastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of
a partition identified with [partitionIndex](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int).partitionIndex 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
public System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeysOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

Implements [EnumerableOfKeysOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfKeysOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfKeysOnPartition(int)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfValues()'></a>

## FastReadOnlyDictionary<TKey,TValue>.EnumerableOfValues() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
public System.Collections.Generic.IEnumerable<TValue> EnumerableOfValues();
```

Implements [EnumerableOfValues()](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfValues() 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfValues()')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int)'></a>

## FastReadOnlyDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values
of a partition identified with [partitionIndex](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int).partitionIndex 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
public System.Collections.Generic.IEnumerable<TValue> EnumerableOfValuesOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

Implements [EnumerableOfValuesOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOfValuesOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOfValuesOnPartition(int)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int)'></a>

## FastReadOnlyDictionary<TKey,TValue>.EnumerableOnPartition(int) Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the key-values pairs
of a partition identified with [partitionIndex](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int).partitionIndex 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.EnumerableOnPartition(int).partitionIndex'); where Partition index is 0-based
(i.e. 0 to [PartitionCount](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.PartitionCount 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.PartitionCount') - 1).

```csharp
public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> EnumerableOnPartition(int partitionIndex);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int).partitionIndex'></a>

`partitionIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Index of the parition on which to create enumeration

Implements [EnumerableOnPartition(int)](DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary_TKey,TValue_.EnumerableOnPartition(int) 'DevFast.Net.Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<TKey,TValue>.EnumerableOnPartition(int)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.GetEnumerator()'></a>

## FastReadOnlyDictionary<TKey,TValue>.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator that can be used to iterate through the collection.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TryGetValue(TKey,TValue)'></a>

## FastReadOnlyDictionary<TKey,TValue>.TryGetValue(TKey, TValue) Method

Gets the value that is associated with the specified key.

```csharp
public bool TryGetValue(TKey key, out TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TKey')

The key to locate.

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TValue')

When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the [value](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TryGetValue(TKey, TValue).value') parameter. This parameter is passed uninitialized.

Implements [TryGetValue(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.TryGetValue#System_Collections_Generic_IReadOnlyDictionary_2_TryGetValue__0,_1@_ 'System.Collections.Generic.IReadOnlyDictionary`2.TryGetValue(`0,`1@)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the object that implements the [System.Collections.Generic.IReadOnlyDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2') interface contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key 'DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary<TKey,TValue>.TryGetValue(TKey, TValue).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
### Explicit Interface Implementations

<a name='DevFast.Net.Collection.Implementations.Concurrent.Hashed.FastReadOnlyDictionary_TKey,TValue_.System.Collections.IEnumerable.GetEnumerator()'></a>

## FastReadOnlyDictionary<TKey,TValue>.System.Collections.IEnumerable.GetEnumerator() Method

Returns an enumerator that iterates through a collection.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')