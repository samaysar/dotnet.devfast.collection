#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## NotNullIfNotNullAttribute Class

Specifies that the output will be non-null if the named parameter is non-null.

```csharp
internal sealed class NotNullIfNotNullAttribute : System.Attribute
```
- *Constructors*
  - **[NotNullIfNotNullAttribute(string)](System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.md#System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.NotNullIfNotNullAttribute(string) 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.NotNullIfNotNullAttribute(string)')**
- *Properties*
  - **[ParameterName](System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.md#System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.ParameterName 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.ParameterName')**

## NotNullIfNotNullAttribute Class

Specifies that the output will be non-null if the named parameter is non-null.

```csharp
internal sealed class NotNullIfNotNullAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; NotNullIfNotNullAttribute
### Constructors

<a name='System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.NotNullIfNotNullAttribute(string)'></a>

## NotNullIfNotNullAttribute(string) Constructor

Initializes the attribute with the associated parameter name.

```csharp
public NotNullIfNotNullAttribute(string parameterName);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.NotNullIfNotNullAttribute(string).parameterName'></a>

`parameterName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The associated parameter name. The output will be non-null if the argument to the parameter specified is non-null.
### Properties

<a name='System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.ParameterName'></a>

## NotNullIfNotNullAttribute.ParameterName Property

Gets the associated parameter name.

```csharp
public string ParameterName { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')