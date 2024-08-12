#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions](DevFast.Net.Collection.Abstractions.md 'DevFast.Net.Collection.Abstractions')

## IResizeStrategy Interface

Interface exposing sizing strategy for any collection that can be resized.

```csharp
public interface IResizeStrategy
```

Derived  
&#8627; [FixedStepReSizing](DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing.md 'DevFast.Net.Collection.Implementations.ReSizing.FixedStepReSizing')  
&#8627; [MultipleReSizing](DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing.md 'DevFast.Net.Collection.Implementations.ReSizing.MultipleReSizing')  
&#8627; [NoResizing](DevFast.Net.Collection.Implementations.ReSizing.NoResizing.md 'DevFast.Net.Collection.Implementations.ReSizing.NoResizing')
### Properties

<a name='DevFast.Net.Collection.Abstractions.IResizeStrategy.CanResize'></a>

## IResizeStrategy.CanResize Property

Gets the truth value whether new size can be computed.

```csharp
bool CanResize { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long,int)'></a>

## IResizeStrategy.TryComputeNewSize(long, int) Method

Calculates the new size, based on the given value of current size.

```csharp
bool TryComputeNewSize(in long currentSize, out int newSize);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long,int).currentSize'></a>

`currentSize` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Current size

<a name='DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(long,int).newSize'></a>

`newSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

New size

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')