#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.Concurrent.LookUps](DevFast.Net.Collection.Implementations.Concurrent.LookUps.md 'DevFast.Net.Collection.Implementations.Concurrent.LookUps')

## FastDictionary<TKey,TValue> Class

Represents a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently.

```csharp
public sealed class FastDictionary<TKey,TValue> :
System.Collections.Generic.IDictionary<TKey, TValue>,
System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    where TKey : notnull
```
- *Constructors*
  - **[FastDictionary()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary()')**
  - **[FastDictionary(int, int)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int)')**
  - **[FastDictionary(int, int, IEqualityComparer&lt;TKey&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>)')**
  - **[FastDictionary(int, IEqualityComparer&lt;TKey&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>)')**
  - **[FastDictionary(IEqualityComparer&lt;TKey&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(System.Collections.Generic.IEqualityComparer_TKey_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(System.Collections.Generic.IEqualityComparer<TKey>)')**
- *Properties*
  - **[Count](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Count 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Count')**
  - **[IsReadOnly](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.IsReadOnly 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.IsReadOnly')**
  - **[Keys](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Keys 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Keys')**
  - **[this[TKey]](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.this[TKey] 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.this[TKey]')**
  - **[Values](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Values 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Values')**
- *Methods*
  - **[Add(TKey, TValue)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Add(TKey,TValue) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Add(TKey, TValue)')**
  - **[AddOrUpdate(TKey, TValue, Func&lt;TKey,TValue,TValue&gt;, IEqualityComparer&lt;TValue&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>)')**
  - **[Clear()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Clear()')**
  - **[Clear(bool)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(bool) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Clear(bool)')**
  - **[Clear(int)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(int) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Clear(int)')**
  - **[Contains(KeyValuePair&lt;TKey,TValue&gt;, IEqualityComparer&lt;TValue&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>)')**
  - **[ContainsKey(TKey)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.ContainsKey(TKey) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.ContainsKey(TKey)')**
  - **[EnumerableOfKeys()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.EnumerableOfKeys() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.EnumerableOfKeys()')**
  - **[EnumerableOfValues()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.EnumerableOfValues() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.EnumerableOfValues()')**
  - **[GetEnumerator()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetEnumerator() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.GetEnumerator()')**
  - **[GetOrAdd(TKey, Func&lt;TKey,TValue&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,System.Func_TKey,TValue_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.GetOrAdd(TKey, System.Func<TKey,TValue>)')**
  - **[GetOrAdd(TKey, TValue)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,TValue) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.GetOrAdd(TKey, TValue)')**
  - **[Remove(KeyValuePair&lt;TKey,TValue&gt;, IEqualityComparer&lt;TValue&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>)')**
  - **[Remove(TKey)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(TKey) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Remove(TKey)')**
  - **[TryAdd(TKey, TValue)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryAdd(TKey,TValue) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryAdd(TKey, TValue)')**
  - **[TryGetValue(TKey, TValue)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryGetValue(TKey,TValue) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryGetValue(TKey, TValue)')**
  - **[TryRemove(TKey, TValue)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryRemove(TKey,TValue) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryRemove(TKey, TValue)')**
  - **[TryUpdate(TKey, TValue, TValue, IEqualityComparer&lt;TValue&gt;)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>)')**
- *Explicit Interface Implementations*
  - **[System.Collections.Generic.IReadOnlyDictionary&lt;TKey,TValue&gt;.Keys](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.System.Collections.Generic.IReadOnlyDictionary_TKey,TValue_.Keys 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys')**
  - **[System.Collections.Generic.IReadOnlyDictionary&lt;TKey,TValue&gt;.Values](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.System.Collections.Generic.IReadOnlyDictionary_TKey,TValue_.Values 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values')**
  - **[System.Collections.IEnumerable.GetEnumerator()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.System.Collections.IEnumerable.GetEnumerator() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.System.Collections.IEnumerable.GetEnumerator()')**

## FastDictionary<TKey,TValue> Class

Represents a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently.

```csharp
public sealed class FastDictionary<TKey,TValue> :
System.Collections.Generic.IDictionary<TKey, TValue>,
System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
System.Collections.IEnumerable,
System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    where TKey : notnull
```
#### Type parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey'></a>

`TKey`

The type of the keys in the dictionary.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue'></a>

`TValue`

The type of the values in the dictionary.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FastDictionary<TKey,TValue>

Implements [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2'), [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')
### Constructors

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary()'></a>

## FastDictionary() Constructor

Initializes a new instance of the [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>') class that is empty and
has the default initial capacity, has default concurrency level,
and uses default Equality comparer for the key.

NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.

```csharp
public FastDictionary();
```

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int)'></a>

## FastDictionary(int, int) Constructor

Initializes a new instance of the [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>') class that is empty
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int).initialCapacity'), has given [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int).concurrencyLevel')
and uses default Equality comparer for the key.

NOTE: Total expected memory allocation is bit more than [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int).initialCapacity') * [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int).concurrencyLevel').
NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int).initialCapacity') has internal lower bound=0 and [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int).concurrencyLevel') has internal lower bound=2.

```csharp
public FastDictionary(int initialCapacity, int concurrencyLevel);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int).concurrencyLevel'></a>

`concurrencyLevel` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Concurrency level

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_)'></a>

## FastDictionary(int, int, IEqualityComparer<TKey>) Constructor

Initializes a new instance of the [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>') class that is empty
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>).initialCapacity'), has given [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>).concurrencyLevel')
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).comparer 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>).comparer') for the key type.

NOTE: Total expected memory allocation is bit more than [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>).initialCapacity') * [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>).concurrencyLevel').
NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>).initialCapacity') has internal lower bound=0 and [concurrencyLevel](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).concurrencyLevel 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, int, System.Collections.Generic.IEqualityComparer<TKey>).concurrencyLevel') has internal lower bound=2.

```csharp
public FastDictionary(int initialCapacity, int concurrencyLevel, System.Collections.Generic.IEqualityComparer<TKey>? comparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).concurrencyLevel'></a>

`concurrencyLevel` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Expected maximum concurrency

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,int,System.Collections.Generic.IEqualityComparer_TKey_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_)'></a>

## FastDictionary(int, IEqualityComparer<TKey>) Constructor

Initializes a new instance of the [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>') class that is empty and
and has the given [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>).initialCapacity'), has default concurrency level,
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_).comparer 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>).comparer') for the key type.

NOTE: Total expected memory allocation is bit more than [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>).initialCapacity') * default_concurrency_level.
NOTE: [initialCapacity](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(int, System.Collections.Generic.IEqualityComparer<TKey>).initialCapacity') has internal lower bound=0.

```csharp
public FastDictionary(int initialCapacity, System.Collections.Generic.IEqualityComparer<TKey>? comparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial estimated capacity

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(int,System.Collections.Generic.IEqualityComparer_TKey_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(System.Collections.Generic.IEqualityComparer_TKey_)'></a>

## FastDictionary(IEqualityComparer<TKey>) Constructor

Initializes a new instance of the [FastDictionary&lt;TKey,TValue&gt;](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>') class that is empty and
has the default initial capacity, has default concurrency level,
and uses the [comparer](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(System.Collections.Generic.IEqualityComparer_TKey_).comparer 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.FastDictionary(System.Collections.Generic.IEqualityComparer<TKey>).comparer') for the key type.

NOTE: Total expected memory allocation is bit more than default_initial_capacity * default_concurrency_level.

```csharp
public FastDictionary(System.Collections.Generic.IEqualityComparer<TKey>? comparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.FastDictionary(System.Collections.Generic.IEqualityComparer_TKey_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the key
### Properties

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Count'></a>

## FastDictionary<TKey,TValue>.Count Property

Gets the number of elements in the collection.

```csharp
public int Count { get; }
```

Implements [Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1.Count 'System.Collections.Generic.IReadOnlyCollection`1.Count'), [Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Count 'System.Collections.Generic.ICollection`1.Count')

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.IsReadOnly'></a>

## FastDictionary<TKey,TValue>.IsReadOnly Property

Gets a value indicating whether the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

```csharp
public bool IsReadOnly { get; }
```

Implements [IsReadOnly](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.IsReadOnly 'System.Collections.Generic.ICollection`1.IsReadOnly')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Keys'></a>

## FastDictionary<TKey,TValue>.Keys Property

Gets an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') that contains the keys of the dictionary.

IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
enumeration. Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
Partition snapshots are created as enumerable visits those. However, space complexity of
this implementation is HIGH due to the fact that all the partitions are visited almost immediately
in order to create a copy of all the keys from all the partitions.

In order to reduce space complexity, use either [System.Collections.Generic.IReadOnlyDictionary&lt;&gt;.Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Keys 'System.Collections.Generic.IReadOnlyDictionary`2.Keys')
or [EnumerableOfKeys()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.EnumerableOfKeys() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.EnumerableOfKeys()').

```csharp
public System.Collections.Generic.ICollection<TKey> Keys { get; }
```

Implements [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Keys 'System.Collections.Generic.IReadOnlyDictionary`2.Keys'), [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Keys 'System.Collections.Generic.IDictionary`2.Keys')

#### Property Value
[System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.this[TKey]'></a>

## FastDictionary<TKey,TValue>.this[TKey] Property

Gets the element that has the specified key in the read-only dictionary.

```csharp
public TValue this[TKey key] { get; set; }
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.this[TKey].key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [this[TKey]](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Item#System_Collections_Generic_IReadOnlyDictionary_2_Item__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.Item(`0)'), [this[TKey]](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Item#System_Collections_Generic_IDictionary_2_Item__0_ 'System.Collections.Generic.IDictionary`2.Item(`0)')

#### Property Value
[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.this[TKey].key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
The property is retrieved and [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.this[TKey].key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.this[TKey].key') is not found.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Values'></a>

## FastDictionary<TKey,TValue>.Values Property

Gets an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') that contains the values of the dictionary.

IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
enumeration. Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
Partition snapshots are created as enumerable visits those. However, space complexity of
this implementation is HIGH due to the fact that all the partitions are visited almost immediately
in order to create a copy of all the keys from all the partitions.

In order to reduce space complexity, use either [System.Collections.Generic.IReadOnlyDictionary&lt;&gt;.Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Values 'System.Collections.Generic.IReadOnlyDictionary`2.Values')
or [EnumerableOfValues()](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.EnumerableOfValues() 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.EnumerableOfValues()').

```csharp
public System.Collections.Generic.ICollection<TValue> Values { get; }
```

Implements [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Values 'System.Collections.Generic.IReadOnlyDictionary`2.Values'), [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Values 'System.Collections.Generic.IDictionary`2.Values')

#### Property Value
[System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')
### Methods

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Add(TKey,TValue)'></a>

## FastDictionary<TKey,TValue>.Add(TKey, TValue) Method

Adds an element with the provided key and value to the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

```csharp
public void Add(TKey key, TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Add(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The object to use as the key of the element to add.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Add(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

The object to use as the value of the element to add.

Implements [Add(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Add#System_Collections_Generic_IDictionary_2_Add__0,_1_ 'System.Collections.Generic.IDictionary`2.Add(`0,`1)')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Add(TKey,TValue).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Add(TKey, TValue).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
An element with the same key already exists in the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') is read-only.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, Func<TKey,TValue,TValue>, IEqualityComparer<TValue>) Method

Adds [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key')/[addValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).addValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).addValue') pair to the collection
if the [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key') does not already exist,
or updates [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key')/value pair by using [updateValueFactory](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).updateValueFactory 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).updateValueFactory') lambda
if the [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).key') already exists.

```csharp
public TValue AddOrUpdate(TKey key, TValue addValue, System.Func<TKey,TValue,TValue> updateValueFactory, System.Collections.Generic.IEqualityComparer<TValue>? comparer=null);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key to be added or updated

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).addValue'></a>

`addValue` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

The value to be added

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).updateValueFactory'></a>

`updateValueFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Value generating lambda for an existing key and value

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Value comparer. If not provided then default implementation will be used.

#### Returns
[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')  
The new value for the key. This will be either be [addValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).addValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).addValue') (if the key was absent) or the result of [updateValueFactory](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.AddOrUpdate(TKey,TValue,System.Func_TKey,TValue,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).updateValueFactory 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.AddOrUpdate(TKey, TValue, System.Func<TKey,TValue,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).updateValueFactory') (if the key was present).

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear()'></a>

## FastDictionary<TKey,TValue>.Clear() Method

Removes all items from all the partitions; however, allocated memory is retained.
[Clear(bool)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(bool) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Clear(bool)') and [Clear(int)](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(int) 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Clear(int)').

```csharp
public void Clear();
```

Implements [Clear()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Clear 'System.Collections.Generic.ICollection`1.Clear')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(bool)'></a>

## FastDictionary<TKey,TValue>.Clear(bool) Method

Removes all items from all the partitions.

```csharp
public void Clear(bool releaseMemory);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(bool).releaseMemory'></a>

`releaseMemory` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), partitions are recreated by releasing previously allocated memory.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(int)'></a>

## FastDictionary<TKey,TValue>.Clear(int) Method

Removes all items from all the partitions.

```csharp
public void Clear(int initialCapacity);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Clear(int).initialCapacity'></a>

`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Initial capacity of the partitions to be re-created.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## FastDictionary<TKey,TValue>.Contains(KeyValuePair<TKey,TValue>, IEqualityComparer<TValue>) Method

Checks whether given key/value pair is part of current collection using provided [valueComparer](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer').
If [valueComparer](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), then [System.Collections.Generic.EqualityComparer&lt;&gt;.Default](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.EqualityComparer-1.Default 'System.Collections.Generic.EqualityComparer`1.Default')
will be used.

```csharp
public bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item, System.Collections.Generic.IEqualityComparer<TValue>? valueComparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).item'></a>

`item` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

Key value pair to check

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Contains(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer'></a>

`valueComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.ContainsKey(TKey)'></a>

## FastDictionary<TKey,TValue>.ContainsKey(TKey) Method

Determines whether the read-only dictionary contains an element that has the specified key.

```csharp
public bool ContainsKey(TKey key);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.ContainsKey(TKey).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key to locate.

Implements [ContainsKey(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.ContainsKey#System_Collections_Generic_IReadOnlyDictionary_2_ContainsKey__0_ 'System.Collections.Generic.IReadOnlyDictionary`2.ContainsKey(`0)'), [ContainsKey(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.ContainsKey#System_Collections_Generic_IDictionary_2_ContainsKey__0_ 'System.Collections.Generic.IDictionary`2.ContainsKey(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the read-only dictionary contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.ContainsKey(TKey).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.ContainsKey(TKey).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.EnumerableOfKeys()'></a>

## FastDictionary<TKey,TValue>.EnumerableOfKeys() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the keys of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
public System.Collections.Generic.IEnumerable<TKey> EnumerableOfKeys();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.EnumerableOfValues()'></a>

## FastDictionary<TKey,TValue>.EnumerableOfValues() Method

Create a new [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') on the values of the [System.Collections.Generic.Dictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2').

```csharp
public System.Collections.Generic.IEnumerable<TValue> EnumerableOfValues();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetEnumerator()'></a>

## FastDictionary<TKey,TValue>.GetEnumerator() Method

Gets an enumerable collection that contains the [System.Collections.Generic.KeyValuePair&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2') of the dictionary.

IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
enumeration. Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition
at a time. That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.

```csharp
public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,System.Func_TKey,TValue_)'></a>

## FastDictionary<TKey,TValue>.GetOrAdd(TKey, Func<TKey,TValue>) Method

Adds a key/value pair to the collection by using the specified function
if the key does not already exist.
Returns the new value, or the existing value if the key exists.

```csharp
public TValue GetOrAdd(TKey key, System.Func<TKey,TValue> valueFactory);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,System.Func_TKey,TValue_).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key of the element to add.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,System.Func_TKey,TValue_).valueFactory'></a>

`valueFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The function used to generate a value for the key.

#### Returns
[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')  
The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,TValue)'></a>

## FastDictionary<TKey,TValue>.GetOrAdd(TKey, TValue) Method

Adds a key/value pair to the collection if the key does not already exist.
Returns the new value, or the existing value if the key exists.

```csharp
public TValue GetOrAdd(TKey key, TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

Key value.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.GetOrAdd(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

Value.

#### Returns
[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')  
The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## FastDictionary<TKey,TValue>.Remove(KeyValuePair<TKey,TValue>, IEqualityComparer<TValue>) Method

Removes the given key/value pair from the collection using provided [valueComparer](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer').
If [valueComparer](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue>, System.Collections.Generic.IEqualityComparer<TValue>).valueComparer') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), then [System.Collections.Generic.EqualityComparer&lt;&gt;.Default](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.EqualityComparer-1.Default 'System.Collections.Generic.EqualityComparer`1.Default')
will be used.

```csharp
public bool Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item, System.Collections.Generic.IEqualityComparer<TValue>? valueComparer);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).item'></a>

`item` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

Key value pair to be removed.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(System.Collections.Generic.KeyValuePair_TKey,TValue_,System.Collections.Generic.IEqualityComparer_TValue_).valueComparer'></a>

`valueComparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Equality comparer for the value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(TKey)'></a>

## FastDictionary<TKey,TValue>.Remove(TKey) Method

Removes the element with the specified key from the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

```csharp
public bool Remove(TKey key);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(TKey).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key of the element to remove.

Implements [Remove(TKey)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Remove#System_Collections_Generic_IDictionary_2_Remove__0_ 'System.Collections.Generic.IDictionary`2.Remove(`0)'), [Remove(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Remove#System_Collections_Generic_ICollection_1_Remove__0_ 'System.Collections.Generic.ICollection`1.Remove(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the element is successfully removed; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  This method also returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(TKey).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Remove(TKey).key') was not found in the original [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.Remove(TKey).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.Remove(TKey).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') is read-only.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryAdd(TKey,TValue)'></a>

## FastDictionary<TKey,TValue>.TryAdd(TKey, TValue) Method

Attempts to add the specified key and value to the collection.

```csharp
public bool TryAdd(TKey key, TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryAdd(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key of the element to add.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryAdd(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

The value of the element to add.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the key/value pair was added successfully; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the key already exists.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryGetValue(TKey,TValue)'></a>

## FastDictionary<TKey,TValue>.TryGetValue(TKey, TValue) Method

Gets the value that is associated with the specified key.

```csharp
public bool TryGetValue(TKey key, out TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key to locate.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the [value](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).value 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryGetValue(TKey, TValue).value') parameter. This parameter is passed uninitialized.

Implements [TryGetValue(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.TryGetValue#System_Collections_Generic_IReadOnlyDictionary_2_TryGetValue__0,_1@_ 'System.Collections.Generic.IReadOnlyDictionary`2.TryGetValue(`0,`1@)'), [TryGetValue(TKey, TValue)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.TryGetValue#System_Collections_Generic_IDictionary_2_TryGetValue__0,_1@_ 'System.Collections.Generic.IDictionary`2.TryGetValue(`0,`1@)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the object that implements the [System.Collections.Generic.IReadOnlyDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2') interface contains an element that has the specified key; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryGetValue(TKey,TValue).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryGetValue(TKey, TValue).key') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryRemove(TKey,TValue)'></a>

## FastDictionary<TKey,TValue>.TryRemove(TKey, TValue) Method

Attempts to remove and return the value that has the specified key.

```csharp
public bool TryRemove(TKey key, out TValue value);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryRemove(TKey,TValue).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

The key of the element to remove and return.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryRemove(TKey,TValue).value'></a>

`value` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

When this method returns, contains the object removed from the collection, or the default value of the [TValue](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/TValue 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/TValue') type if [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryRemove(TKey,TValue).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryRemove(TKey, TValue).key') does not exist.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the object was removed successfully; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_)'></a>

## FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, IEqualityComparer<TValue>) Method

Updates the value associated with [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).key') to [newValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).newValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).newValue')
if the existing value with [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).key') is equal to [comparisonValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparisonValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).comparisonValue').

```csharp
public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue, System.Collections.Generic.IEqualityComparer<TValue>? comparer=null);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key'></a>

`key` [TKey](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TKey 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TKey')

key.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).newValue'></a>

`newValue` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

Replacement value.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparisonValue'></a>

`comparisonValue` [TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')

Value to compare with the existing key value.

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

Value comparer. If not provided then default implementation will be used.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value with [key](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).key 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).key') was equal to [comparisonValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).comparisonValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).comparisonValue') and was replaced with [newValue](DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.md#DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.TryUpdate(TKey,TValue,TValue,System.Collections.Generic.IEqualityComparer_TValue_).newValue 'DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary<TKey,TValue>.TryUpdate(TKey, TValue, TValue, System.Collections.Generic.IEqualityComparer<TValue>).newValue'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
### Explicit Interface Implementations

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.System.Collections.Generic.IReadOnlyDictionary_TKey,TValue_.Keys'></a>

## FastDictionary<TKey,TValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys Property

Gets an enumerable collection that contains the keys of the dictionary.

IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
enumeration. Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.

```csharp
System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
```

Implements [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Keys 'System.Collections.Generic.IReadOnlyDictionary`2.Keys')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.System.Collections.Generic.IReadOnlyDictionary_TKey,TValue_.Values'></a>

## FastDictionary<TKey,TValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values Property

Gets an enumerable collection that contains the values of the dictionary.

IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
enumeration. Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition.
That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.
In order to reduce space complexity, Partition snapshots are created as enumerable visits those.

```csharp
System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
```

Implements [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2.Values 'System.Collections.Generic.IReadOnlyDictionary`2.Values')

<a name='DevFast.Net.Collection.Implementations.Concurrent.LookUps.FastDictionary_TKey,TValue_.System.Collections.IEnumerable.GetEnumerator()'></a>

## FastDictionary<TKey,TValue>.System.Collections.IEnumerable.GetEnumerator() Method

Gets an enumerable collection that contains the boxed [System.Collections.Generic.KeyValuePair&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2') of the dictionary.

IMPLEMENTATION NOTES: Normally a dictionary is NOT a good choice for
enumeration. Current implementation returns
enumerator that creates a snapshot (thus, consuming space) on a partition
at a time. That said, if one is adding/removing elements concurrently, while
enumerating on the collection, it is well possible that lookup may yield
[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or the element is NOT part of the enumerable.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')