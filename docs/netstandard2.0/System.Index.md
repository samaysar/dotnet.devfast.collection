#### [DevFast.Net.Collection](index.md 'index')
### [System](System.md 'System')

## Index Struct

Represent a type can be used to index a collection either from the start or the end.

```csharp
internal readonly struct Index :
System.IEquatable<System.Index>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Index](System.Index.md 'System.Index')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
Index is used by the C# compiler to support the new index syntax

```csharp
int[] someArray = new int[5] { 1, 2, 3, 4, 5 } ;
int lastElement = someArray[^1]; // lastElement = 5
```
### Constructors

<a name='System.Index.Index(int,bool)'></a>

## Index(int, bool) Constructor

Construct an Index using a value and indicating if the index is from the start or from the end.

```csharp
public Index(int value, bool fromEnd=false);
```
#### Parameters

<a name='System.Index.Index(int,bool).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index value. it has to be zero or positive number.

<a name='System.Index.Index(int,bool).fromEnd'></a>

`fromEnd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicating if the index is from the start or from the end.

### Remarks
If the Index constructed from the end, index value 1 means pointing at the last element and index value 0 means pointing at beyond last element.
### Properties

<a name='System.Index.End'></a>

## Index.End Property

Create an Index pointing at beyond last element.

```csharp
public static System.Index End { get; }
```

#### Property Value
[Index](System.Index.md 'System.Index')

<a name='System.Index.IsFromEnd'></a>

## Index.IsFromEnd Property

Indicates whether the index is from the start or the end.

```csharp
public bool IsFromEnd { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='System.Index.Start'></a>

## Index.Start Property

Create an Index pointing at first element.

```csharp
public static System.Index Start { get; }
```

#### Property Value
[Index](System.Index.md 'System.Index')

<a name='System.Index.Value'></a>

## Index.Value Property

Returns the index value.

```csharp
public int Value { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Methods

<a name='System.Index.Equals(object)'></a>

## Index.Equals(object) Method

Indicates whether the current Index object is equal to another object of the same type.

```csharp
public override bool Equals(object? value);
```
#### Parameters

<a name='System.Index.Equals(object).value'></a>

`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

An object to compare with this object

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='System.Index.Equals(System.Index)'></a>

## Index.Equals(Index) Method

Indicates whether the current Index object is equal to another Index object.

```csharp
public bool Equals(System.Index other);
```
#### Parameters

<a name='System.Index.Equals(System.Index).other'></a>

`other` [Index](System.Index.md 'System.Index')

An object to compare with this object

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='System.Index.FromEnd(int)'></a>

## Index.FromEnd(int) Method

Create an Index from the end at the position indicated by the value.

```csharp
public static System.Index FromEnd(int value);
```
#### Parameters

<a name='System.Index.FromEnd(int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index value from the end.

#### Returns
[Index](System.Index.md 'System.Index')

<a name='System.Index.FromStart(int)'></a>

## Index.FromStart(int) Method

Create an Index from the start at the position indicated by the value.

```csharp
public static System.Index FromStart(int value);
```
#### Parameters

<a name='System.Index.FromStart(int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index value from the start.

#### Returns
[Index](System.Index.md 'System.Index')

<a name='System.Index.GetHashCode()'></a>

## Index.GetHashCode() Method

Returns the hash code for this instance.

```csharp
public override int GetHashCode();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='System.Index.GetOffset(int)'></a>

## Index.GetOffset(int) Method

Calculate the offset from the start using the giving collection length.

```csharp
public int GetOffset(int length);
```
#### Parameters

<a name='System.Index.GetOffset(int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The length of the collection that the Index will be used with. length has to be a positive value

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

### Remarks
For performance reason, we don't validate the input length parameter and the returned offset value against negative values.
we don't validate either the returned offset is greater than the input length.
It is expected Index will be used with collections which always have non negative length/count. If the returned offset is negative and
then used to index a collection will get out of range exception which will be same affect as the validation.

<a name='System.Index.ToString()'></a>

## Index.ToString() Method

Converts the value of the current Index object to its equivalent string representation.

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Operators

<a name='System.Index.op_ImplicitSystem.Index(int)'></a>

## Index.implicit operator Index(int) Operator

Converts integer number to an Index.

```csharp
public static System.Index implicit operator Index(int value);
```
#### Parameters

<a name='System.Index.op_ImplicitSystem.Index(int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

#### Returns
[Index](System.Index.md 'System.Index')