#### [DevFast.Net.Collection](index.md 'index')
### [DevFast.Net.Collection.Abstractions](DevFast.Net.Collection.Abstractions.md 'DevFast.Net.Collection.Abstractions')

## IResizeStrategy Interface

Interface exposing sizing strategy for the binary heap.

```csharp
public interface IResizeStrategy
```
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

<a name='DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(int,int)'></a>

## IResizeStrategy.TryComputeNewSize(int, int) Method

Calculates the new size of the heap, based on the given value of current size.

```csharp
bool TryComputeNewSize(int currentSize, out int newSize);
```
#### Parameters

<a name='DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(int,int).currentSize'></a>

`currentSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Current size of the heap

<a name='DevFast.Net.Collection.Abstractions.IResizeStrategy.TryComputeNewSize(int,int).newSize'></a>

`newSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

New size

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')