#### [DevFast.Net.Collection](index.md 'index')
### [System](System.md 'System')

## Range Struct

Represent a range has start and end indexes.

```csharp
internal readonly struct Range :
System.IEquatable<System.Range>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Range](System.Range.md 'System.Range')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
Range is used by the C# compiler to support the range syntax.

```csharp
int[] someArray = new int[5] { 1, 2, 3, 4, 5 };
int[] subArray1 = someArray[0..2]; // { 1, 2 }
int[] subArray2 = someArray[1..^0]; // { 2, 3, 4, 5 }
```
### Constructors

<a name='System.Range.Range(System.Index,System.Index)'></a>

## Range(Index, Index) Constructor

Construct a Range object using the start and end indexes.

```csharp
public Range(System.Index start, System.Index end);
```
#### Parameters

<a name='System.Range.Range(System.Index,System.Index).start'></a>

`start` [Index](System.Index.md 'System.Index')

Represent the inclusive start index of the range.

<a name='System.Range.Range(System.Index,System.Index).end'></a>

`end` [Index](System.Index.md 'System.Index')

Represent the exclusive end index of the range.
### Properties

<a name='System.Range.All'></a>

## Range.All Property

Create a Range object starting from first element to the end.

```csharp
public static System.Range All { get; }
```

#### Property Value
[Range](System.Range.md 'System.Range')

<a name='System.Range.End'></a>

## Range.End Property

Represent the exclusive end index of the Range.

```csharp
public System.Index End { get; }
```

#### Property Value
[Index](System.Index.md 'System.Index')

<a name='System.Range.Start'></a>

## Range.Start Property

Represent the inclusive start index of the Range.

```csharp
public System.Index Start { get; }
```

#### Property Value
[Index](System.Index.md 'System.Index')
### Methods

<a name='System.Range.EndAt(System.Index)'></a>

## Range.EndAt(Index) Method

Create a Range object starting from first element in the collection to the end Index.

```csharp
public static System.Range EndAt(System.Index end);
```
#### Parameters

<a name='System.Range.EndAt(System.Index).end'></a>

`end` [Index](System.Index.md 'System.Index')

#### Returns
[Range](System.Range.md 'System.Range')

<a name='System.Range.Equals(object)'></a>

## Range.Equals(object) Method

Indicates whether the current Range object is equal to another object of the same type.

```csharp
public override bool Equals(object? value);
```
#### Parameters

<a name='System.Range.Equals(object).value'></a>

`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

An object to compare with this object

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='System.Range.Equals(System.Range)'></a>

## Range.Equals(Range) Method

Indicates whether the current Range object is equal to another Range object.

```csharp
public bool Equals(System.Range other);
```
#### Parameters

<a name='System.Range.Equals(System.Range).other'></a>

`other` [Range](System.Range.md 'System.Range')

An object to compare with this object

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='System.Range.GetHashCode()'></a>

## Range.GetHashCode() Method

Returns the hash code for this instance.

```csharp
public override int GetHashCode();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='System.Range.GetOffsetAndLength(int)'></a>

## Range.GetOffsetAndLength(int) Method

Calculate the start offset and length of range object using a collection length.

```csharp
public (int Offset,int Length) GetOffsetAndLength(int length);
```
#### Parameters

<a name='System.Range.GetOffsetAndLength(int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The length of the collection that the range will be used with. length has to be a positive value.

#### Returns
[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')

### Remarks
For performance reason, we don't validate the input length parameter against negative values.
It is expected Range will be used with collections which always have non negative length/count.
We validate the range is inside the length scope though.

<a name='System.Range.StartAt(System.Index)'></a>

## Range.StartAt(Index) Method

Create a Range object starting from start index to the end of the collection.

```csharp
public static System.Range StartAt(System.Index start);
```
#### Parameters

<a name='System.Range.StartAt(System.Index).start'></a>

`start` [Index](System.Index.md 'System.Index')

#### Returns
[Range](System.Range.md 'System.Range')

<a name='System.Range.ToString()'></a>

## Range.ToString() Method

Converts the value of the current Range object to its equivalent string representation.

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')