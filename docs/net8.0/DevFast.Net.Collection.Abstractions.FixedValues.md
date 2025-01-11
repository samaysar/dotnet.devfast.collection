#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions](DevFast.Net.Collection.Abstractions.md 'DevFast.Net.Collection.Abstractions')

## FixedValues Class

A wrapper class holding constant values.

```csharp
public static class FixedValues
```
- *Fields*
  - **[HashedCollectionMaxConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel')**
  - **[MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel')**
  - **[MinInitialCapacity](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity 'DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity')**
- *Properties*
  - **[ProcessorCountWithMinBound](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.ProcessorCountWithMinBound 'DevFast.Net.Collection.Abstractions.FixedValues.ProcessorCountWithMinBound')**

## FixedValues Class

A wrapper class holding constant values.

```csharp
public static class FixedValues
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FixedValues
### Fields

<a name='DevFast.Net.Collection.Abstractions.FixedValues.HashedCollectionMaxConcurrencyLevel'></a>

## FixedValues.HashedCollectionMaxConcurrencyLevel Field

Maximum bound on concurrency level.

```csharp
public const int HashedCollectionMaxConcurrencyLevel = 256;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel'></a>

## FixedValues.MinConcurrencyLevel Field

Minimum bound on concurrency level.

```csharp
public const int MinConcurrencyLevel = 2;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='DevFast.Net.Collection.Abstractions.FixedValues.MinInitialCapacity'></a>

## FixedValues.MinInitialCapacity Field

Minimum bound on initial capacity.

```csharp
public const int MinInitialCapacity = 0;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Properties

<a name='DevFast.Net.Collection.Abstractions.FixedValues.ProcessorCountWithMinBound'></a>

## FixedValues.ProcessorCountWithMinBound Property

Runtime environment processor count with minimum bound set to [MinConcurrencyLevel](DevFast.Net.Collection.Abstractions.FixedValues.md#DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel 'DevFast.Net.Collection.Abstractions.FixedValues.MinConcurrencyLevel').

```csharp
public static int ProcessorCountWithMinBound { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')