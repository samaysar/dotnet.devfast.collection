#### [DevFast.Net.Collection](index.md 'index')
### [System.Runtime.Versioning](System.Runtime.Versioning.md 'System.Runtime.Versioning')

## RequiresPreviewFeaturesAttribute Class

```csharp
internal sealed class RequiresPreviewFeaturesAttribute : System.Attribute
```
- *Constructors*
  - **[RequiresPreviewFeaturesAttribute()](System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.md#System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.RequiresPreviewFeaturesAttribute() 'System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.RequiresPreviewFeaturesAttribute()')**
  - **[RequiresPreviewFeaturesAttribute(string)](System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.md#System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.RequiresPreviewFeaturesAttribute(string) 'System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.RequiresPreviewFeaturesAttribute(string)')**
- *Properties*
  - **[Message](System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.md#System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.Message 'System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.Message')**
  - **[Url](System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.md#System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.Url 'System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.Url')**

## RequiresPreviewFeaturesAttribute Class

```csharp
internal sealed class RequiresPreviewFeaturesAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; RequiresPreviewFeaturesAttribute
### Constructors

<a name='System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.RequiresPreviewFeaturesAttribute()'></a>

## RequiresPreviewFeaturesAttribute() Constructor

Initializes a new instance of the [RequiresPreviewFeaturesAttribute](System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.md 'System.Runtime.Versioning.RequiresPreviewFeaturesAttribute') class.

```csharp
public RequiresPreviewFeaturesAttribute();
```

<a name='System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.RequiresPreviewFeaturesAttribute(string)'></a>

## RequiresPreviewFeaturesAttribute(string) Constructor

Initializes a new instance of the [RequiresPreviewFeaturesAttribute](System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.md 'System.Runtime.Versioning.RequiresPreviewFeaturesAttribute') class with the specified message.

```csharp
public RequiresPreviewFeaturesAttribute(string? message);
```
#### Parameters

<a name='System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.RequiresPreviewFeaturesAttribute(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

An optional message associated with this attribute instance.
### Properties

<a name='System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.Message'></a>

## RequiresPreviewFeaturesAttribute.Message Property

Returns the optional message associated with this attribute instance.

```csharp
public string? Message { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Runtime.Versioning.RequiresPreviewFeaturesAttribute.Url'></a>

## RequiresPreviewFeaturesAttribute.Url Property

Returns the optional URL associated with this attribute instance.

```csharp
public string? Url { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')