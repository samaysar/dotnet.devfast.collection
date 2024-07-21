#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## StringSyntaxAttribute Class

Specifies the syntax used in a string.

```csharp
internal sealed class StringSyntaxAttribute : System.Attribute
```
- *Constructors*
  - **[StringSyntaxAttribute(string)](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string) 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string)')**
  - **[StringSyntaxAttribute(string, object[])](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string,object[]) 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string, object[])')**
- *Fields*
  - **[CompositeFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.CompositeFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.CompositeFormat')**
  - **[DateOnlyFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.DateOnlyFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.DateOnlyFormat')**
  - **[DateTimeFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.DateTimeFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.DateTimeFormat')**
  - **[EnumFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.EnumFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.EnumFormat')**
  - **[GuidFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.GuidFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.GuidFormat')**
  - **[Json](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Json 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Json')**
  - **[NumericFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.NumericFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.NumericFormat')**
  - **[Regex](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Regex 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Regex')**
  - **[TimeOnlyFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.TimeOnlyFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.TimeOnlyFormat')**
  - **[TimeSpanFormat](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.TimeSpanFormat 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.TimeSpanFormat')**
  - **[Uri](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Uri 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Uri')**
  - **[Xml](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Xml 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Xml')**
- *Properties*
  - **[Arguments](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Arguments 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Arguments')**
  - **[Syntax](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md#System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Syntax 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Syntax')**

## StringSyntaxAttribute Class

Specifies the syntax used in a string.

```csharp
internal sealed class StringSyntaxAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; StringSyntaxAttribute
### Constructors

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string)'></a>

## StringSyntaxAttribute(string) Constructor

Initializes the [StringSyntaxAttribute](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute') with the identifier of the syntax used.

```csharp
public StringSyntaxAttribute(string syntax);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string).syntax'></a>

`syntax` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The syntax identifier.

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string,object[])'></a>

## StringSyntaxAttribute(string, object[]) Constructor

Initializes the [StringSyntaxAttribute](System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.md 'System.Diagnostics.CodeAnalysis.StringSyntaxAttribute') with the identifier of the syntax used.

```csharp
public StringSyntaxAttribute(string syntax, params object?[] arguments);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string,object[]).syntax'></a>

`syntax` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The syntax identifier.

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.StringSyntaxAttribute(string,object[]).arguments'></a>

`arguments` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Optional arguments associated with the specific syntax employed.
### Fields

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.CompositeFormat'></a>

## StringSyntaxAttribute.CompositeFormat Field

The syntax identifier for strings containing composite formats for string formatting.

```csharp
public const string CompositeFormat = CompositeFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.DateOnlyFormat'></a>

## StringSyntaxAttribute.DateOnlyFormat Field

The syntax identifier for strings containing date format specifiers.

```csharp
public const string DateOnlyFormat = DateOnlyFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.DateTimeFormat'></a>

## StringSyntaxAttribute.DateTimeFormat Field

The syntax identifier for strings containing date and time format specifiers.

```csharp
public const string DateTimeFormat = DateTimeFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.EnumFormat'></a>

## StringSyntaxAttribute.EnumFormat Field

The syntax identifier for strings containing [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum') format specifiers.

```csharp
public const string EnumFormat = EnumFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.GuidFormat'></a>

## StringSyntaxAttribute.GuidFormat Field

The syntax identifier for strings containing [System.Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid 'System.Guid') format specifiers.

```csharp
public const string GuidFormat = GuidFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Json'></a>

## StringSyntaxAttribute.Json Field

The syntax identifier for strings containing JavaScript Object Notation (JSON).

```csharp
public const string Json = Json;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.NumericFormat'></a>

## StringSyntaxAttribute.NumericFormat Field

The syntax identifier for strings containing numeric format specifiers.

```csharp
public const string NumericFormat = NumericFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Regex'></a>

## StringSyntaxAttribute.Regex Field

The syntax identifier for strings containing regular expressions.

```csharp
public const string Regex = Regex;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.TimeOnlyFormat'></a>

## StringSyntaxAttribute.TimeOnlyFormat Field

The syntax identifier for strings containing time format specifiers.

```csharp
public const string TimeOnlyFormat = TimeOnlyFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.TimeSpanFormat'></a>

## StringSyntaxAttribute.TimeSpanFormat Field

The syntax identifier for strings containing [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') format specifiers.

```csharp
public const string TimeSpanFormat = TimeSpanFormat;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Uri'></a>

## StringSyntaxAttribute.Uri Field

The syntax identifier for strings containing URIs.

```csharp
public const string Uri = Uri;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Xml'></a>

## StringSyntaxAttribute.Xml Field

The syntax identifier for strings containing XML.

```csharp
public const string Xml = Xml;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Properties

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Arguments'></a>

## StringSyntaxAttribute.Arguments Property

Optional arguments associated with the specific syntax employed.

```csharp
public object?[] Arguments { get; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='System.Diagnostics.CodeAnalysis.StringSyntaxAttribute.Syntax'></a>

## StringSyntaxAttribute.Syntax Property

Gets the identifier of the syntax used.

```csharp
public string Syntax { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')