#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Implementations.ReSizing](DevFast.Net.Collection.Implementations.ReSizing.md 'DevFast.Net.Collection.Implementations.ReSizing')

## NoResizing Class

ReSizing Strategy dictating that the collection created with fixed capacity must NOT be resized.

```csharp
public sealed class NoResizing :
DevFast.Net.Collection.Abstractions.IResizeStrategy
```
- *Fields*
  - **[Default](DevFast.Net.Collection.Implementations.ReSizing.NoResizing.md#DevFast.Net.Collection.Implementations.ReSizing.NoResizing.Default 'DevFast.Net.Collection.Implementations.ReSizing.NoResizing.Default')**
- *Properties*
  - **[CanResize](DevFast.Net.Collection.Implementations.ReSizing.NoResizing.md#DevFast.Net.Collection.Implementations.ReSizing.NoResizing.CanResize 'DevFast.Net.Collection.Implementations.ReSizing.NoResizing.CanResize')**
- *Methods*
  - **[TryComputeNewSize(long, int)](DevFast.Net.Collection.Implementations.ReSizing.NoResizing.md#DevFast.Net.Collection.Implementations.ReSizing.NoResizing.TryComputeNewSize(long,int) 'DevFast.Net.Collection.Implementations.ReSizing.NoResizing.TryComputeNewSize(long, int)')**

## NoResizing Class

ReSizing Strategy dictating that the collection created with fixed capacity must NOT be resized.

```csharp
public sealed class NoResizing :
DevFast.Net.Collection.Abstractions.IResizeStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; NoResizing

Implements [IResizeStrategy](DevFast.Net.Collection.Abstractions.IResizeStrategy.md 'DevFast.Net.Collection.Abstractions.IResizeStrategy')
### Fields

<a name='DevFast.Net.Collection.Implementations.ReSizing.NoResizing.Default'></a>

## NoResizing.Default Field

Unique instance of the class.

```csharp
public static readonly NoResizing Default;
```

#### Field Value
[NoResizing](DevFast.Net.Collection.Implementations.ReSizing.NoResizing.md 'DevFast.Net.Collection.Implementations.ReSizing.NoResizing')
### Properties

<a name='DevFast.Net.Collection.Implementations.ReSizing.NoResizing.CanResize'></a>

## NoResizing.CanResize Property

Gets the truth value whether new size can be computed.

```csharp
public bool CanResize { get; }
```

Implements [CanResize](DevFast.Net.Collection.Abstractions.IResizeStrategy.md#DevFast.Net.Collection.Abstractions.IResizeStrategy.CanResize 'DevFast.Net.Collection.Abstractions.IResizeStrategy.CanResize')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Implementations.ReSizing.NoResizing.TryComputeNewSize(long,int)'></a>

## NoResizing.TryComputeNewSize(long, int) Method

Calling this method will always returns false.

```csharp
public bool TryComputeNewSize(in long currentSize, out int newSize);
```
#### Parameters

<a name='DevFast.Net.Collection.Implementations.ReSizing.NoResizing.TryComputeNewSize(long,int).currentSize'></a>

`currentSize` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Current size of the heap

<a name='DevFast.Net.Collection.Implementations.ReSizing.NoResizing.TryComputeNewSize(long,int).newSize'></a>

`newSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Always outs Default int value

Implements [TryComputeNewSize(long, int)](DevFast.Net.Collection.Abstractions.IResizeStrategy.md#DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long,int) 'DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long, int)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')