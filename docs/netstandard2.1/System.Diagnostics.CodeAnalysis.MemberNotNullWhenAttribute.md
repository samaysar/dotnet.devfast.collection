#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## MemberNotNullWhenAttribute Class

Specifies that the method or property will ensure that the listed field and property
members have not-null values when returning with the specified return value condition.

```csharp
internal sealed class MemberNotNullWhenAttribute : System.Attribute
```
- *Constructors*
  - **[MemberNotNullWhenAttribute(bool, string)](System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string) 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool, string)')**
  - **[MemberNotNullWhenAttribute(bool, string[])](System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string[]) 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool, string[])')**
- *Properties*
  - **[Members](System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.Members 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.Members')**
  - **[ReturnValue](System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.ReturnValue')**

## MemberNotNullWhenAttribute Class

Specifies that the method or property will ensure that the listed field and property
members have not-null values when returning with the specified return value condition.

```csharp
internal sealed class MemberNotNullWhenAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; MemberNotNullWhenAttribute
### Constructors

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string)'></a>

## MemberNotNullWhenAttribute(bool, string) Constructor

Initializes the attribute with the specified return value condition and a field or property member.

```csharp
public MemberNotNullWhenAttribute(bool returnValue, string member);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string).returnValue'></a>

`returnValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The return value condition. If the method returns this value, the associated parameter will not be null.

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string).member'></a>

`member` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The field or property member that is promised to be not-null.

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string[])'></a>

## MemberNotNullWhenAttribute(bool, string[]) Constructor

Initializes the attribute with the specified return value condition and list of field and property members.

```csharp
public MemberNotNullWhenAttribute(bool returnValue, params string[] members);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string[]).returnValue'></a>

`returnValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The return value condition. If the method returns this value, the associated parameter will not be null.

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool,string[]).members'></a>

`members` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The list of field and property members that are promised to be not-null.
### Properties

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.Members'></a>

## MemberNotNullWhenAttribute.Members Property

Gets field or property member names.

```csharp
public string[] Members { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.ReturnValue'></a>

## MemberNotNullWhenAttribute.ReturnValue Property

Gets the return value condition.

```csharp
public bool ReturnValue { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')