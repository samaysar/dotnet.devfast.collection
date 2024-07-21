#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## MemberNotNullAttribute Class

Specifies that the method or property will ensure that the listed field and property members have not-null values.

```csharp
internal sealed class MemberNotNullAttribute : System.Attribute
```
- *Constructors*
  - **[MemberNotNullAttribute(string)](System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.md#System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string) 'System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string)')**
  - **[MemberNotNullAttribute(string[])](System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.md#System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string[]) 'System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string[])')**
- *Properties*
  - **[Members](System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.md#System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.Members 'System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.Members')**

## MemberNotNullAttribute Class

Specifies that the method or property will ensure that the listed field and property members have not-null values.

```csharp
internal sealed class MemberNotNullAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; MemberNotNullAttribute
### Constructors

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string)'></a>

## MemberNotNullAttribute(string) Constructor

Initializes the attribute with a field or property member.

```csharp
public MemberNotNullAttribute(string member);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string).member'></a>

`member` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The field or property member that is promised to be not-null.

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string[])'></a>

## MemberNotNullAttribute(string[]) Constructor

Initializes the attribute with the list of field and property members.

```csharp
public MemberNotNullAttribute(params string[] members);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.MemberNotNullAttribute(string[]).members'></a>

`members` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The list of field and property members that are promised to be not-null.
### Properties

<a name='System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.Members'></a>

## MemberNotNullAttribute.Members Property

Gets field or property member names.

```csharp
public string[] Members { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')