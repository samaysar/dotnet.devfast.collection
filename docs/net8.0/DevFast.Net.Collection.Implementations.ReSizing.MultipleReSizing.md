#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.ReSizing](DevFast.Net.Collection.Implementations.ReSizing.md 'DevFast.Net.Collection.Implementations.ReSizing')

## MultipleReSizing Class

ReSizing Strategy dictating that the collection should increase its capacity in multiple.

```csharp
public sealed class MultipleReSizing :
DevFast.Net.Collection.Abstractions.IResizeStrategy
```
- *Constructors*
  - **[MultipleReSizing(double)](DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.md#DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.MultipleReSizing(double) 'DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.MultipleReSizing(double)')**
- *Properties*
  - **[CanResize](DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.md#DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.CanResize 'DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.CanResize')**
- *Methods*
  - **[TryComputeNewSize(long, int)](DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.md#DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.TryComputeNewSize(long,int) 'DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.TryComputeNewSize(long, int)')**

## MultipleReSizing Class

ReSizing Strategy dictating that the collection should increase its capacity in multiple.

```csharp
public sealed class MultipleReSizing :
DevFast.Net.Collection.Abstractions.IResizeStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MultipleReSizing

Implements [IResizeStrategy](DevFast.Net.Collection.Abstractions.IResizeStrategy.md 'DevFast.Net.Collection.Abstractions.IResizeStrategy')

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When step size is zero (0) or negative.

### Remarks
Ctor with multiplier.
### Constructors

<a name='DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.MultipleReSizing(double)'></a>

## MultipleReSizing(double) Constructor

ReSizing Strategy dictating that the collection should increase its capacity in multiple.

```csharp
public MultipleReSizing(double multiple);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.MultipleReSizing(double).multiple'></a>

`multiple` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Size multiple.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When step size is zero (0) or negative.

### Remarks
Ctor with multiplier.
### Properties

<a name='DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.CanResize'></a>

## MultipleReSizing.CanResize Property

Gets the truth value whether new size can be computed.

```csharp
public bool CanResize { get; }
```

Implements [CanResize](DevFast.Net.Collection.Abstractions.IResizeStrategy.md#DevFast.Net.Collection.Abstractions.IResizeStrategy.CanResize 'DevFast.Net.Collection.Abstractions.IResizeStrategy.CanResize')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.TryComputeNewSize(long,int)'></a>

## MultipleReSizing.TryComputeNewSize(long, int) Method

New size is increased by multiple, with lower bound to [currentSize](DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.md#DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.TryComputeNewSize(long,int).currentSize 'DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.TryComputeNewSize(long, int).currentSize')+1.

```csharp
public bool TryComputeNewSize(in long currentSize, out int newSize);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.TryComputeNewSize(long,int).currentSize'></a>

`currentSize` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Current size of the heap

<a name='DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.TryComputeNewSize(long,int).newSize'></a>

`newSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

outs new size

Implements [TryComputeNewSize(long, int)](DevFast.Net.Collection.Abstractions.IResizeStrategy.md#DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long,int) 'DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long, int)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')