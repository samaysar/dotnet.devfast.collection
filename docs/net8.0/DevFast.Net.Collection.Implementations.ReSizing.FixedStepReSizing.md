#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.ReSizing](DevFast.Net.Collection.Implementations.ReSizing.md 'DevFast.Net.Collection.Implementations.ReSizing')

## FixedStepReSizing Class

ReSizing Strategy dictating that the collection should increase its capacity by fixed size step.

```csharp
public sealed class FixedStepReSizing :
DevFast.Net.Collection.Abstractions.IResizeStrategy
```
- *Constructors*
  - **[FixedStepReSizing(int)](DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.md#DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.FixedStepReSizing(int) 'DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.FixedStepReSizing(int)')**
- *Properties*
  - **[CanResize](DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.md#DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.CanResize 'DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.CanResize')**
- *Methods*
  - **[TryComputeNewSize(long, int)](DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.md#DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.TryComputeNewSize(long,int) 'DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.TryComputeNewSize(long, int)')**

## FixedStepReSizing Class

ReSizing Strategy dictating that the collection should increase its capacity by fixed size step.

```csharp
public sealed class FixedStepReSizing :
DevFast.Net.Collection.Abstractions.IResizeStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FixedStepReSizing

Implements [IResizeStrategy](DevFast.Net.Collection.Abstractions.IResizeStrategy.md 'DevFast.Net.Collection.Abstractions.IResizeStrategy')

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When step size is zero (0) or negative.

### Remarks
Ctor with step size.
### Constructors

<a name='DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.FixedStepReSizing(int)'></a>

## FixedStepReSizing(int) Constructor

ReSizing Strategy dictating that the collection should increase its capacity by fixed size step.

```csharp
public FixedStepReSizing(int stepSize);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.FixedStepReSizing(int).stepSize'></a>

`stepSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Step size for the increments.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When step size is zero (0) or negative.

### Remarks
Ctor with step size.
### Properties

<a name='DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.CanResize'></a>

## FixedStepReSizing.CanResize Property

Gets the truth value whether new size can be computed.

```csharp
public bool CanResize { get; }
```

Implements [CanResize](DevFast.Net.Collection.Abstractions.IResizeStrategy.md#DevFast.Net.Collection.Abstractions.IResizeStrategy.CanResize 'DevFast.Net.Collection.Abstractions.IResizeStrategy.CanResize')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.TryComputeNewSize(long,int)'></a>

## FixedStepReSizing.TryComputeNewSize(long, int) Method

New size is simply the sum of the initial fixed step size and current capacity.
Returns false in case of overflow.

```csharp
public bool TryComputeNewSize(in long currentSize, out int newSize);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.TryComputeNewSize(long,int).currentSize'></a>

`currentSize` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Current size of the heap

<a name='DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.TryComputeNewSize(long,int).newSize'></a>

`newSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

outs new size

Implements [TryComputeNewSize(long, int)](DevFast.Net.Collection.Abstractions.IResizeStrategy.md#DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long,int) 'DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long, int)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')