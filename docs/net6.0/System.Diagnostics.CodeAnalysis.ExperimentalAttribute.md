#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## ExperimentalAttribute Class

Indicates that an API is experimental and it may change in the future.

```csharp
internal sealed class ExperimentalAttribute : System.Attribute
```
- *Constructors*
  - **[ExperimentalAttribute(string)](System.Diagnostics.CodeAnalysis.ExperimentalAttribute.md#System.Diagnostics.CodeAnalysis.ExperimentalAttribute.ExperimentalAttribute(string) 'System.Diagnostics.CodeAnalysis.ExperimentalAttribute.ExperimentalAttribute(string)')**
- *Properties*
  - **[DiagnosticId](System.Diagnostics.CodeAnalysis.ExperimentalAttribute.md#System.Diagnostics.CodeAnalysis.ExperimentalAttribute.DiagnosticId 'System.Diagnostics.CodeAnalysis.ExperimentalAttribute.DiagnosticId')**
  - **[UrlFormat](System.Diagnostics.CodeAnalysis.ExperimentalAttribute.md#System.Diagnostics.CodeAnalysis.ExperimentalAttribute.UrlFormat 'System.Diagnostics.CodeAnalysis.ExperimentalAttribute.UrlFormat')**

## ExperimentalAttribute Class

Indicates that an API is experimental and it may change in the future.

```csharp
internal sealed class ExperimentalAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; ExperimentalAttribute

### Remarks
This attribute allows call sites to be flagged with a diagnostic that indicates that an experimental
feature is used. Authors can use this attribute to ship preview features in their assemblies.
### Constructors

<a name='System.Diagnostics.CodeAnalysis.ExperimentalAttribute.ExperimentalAttribute(string)'></a>

## ExperimentalAttribute(string) Constructor

Initializes a new instance of the [ExperimentalAttribute](System.Diagnostics.CodeAnalysis.ExperimentalAttribute.md 'System.Diagnostics.CodeAnalysis.ExperimentalAttribute') class,
specifying the ID that the compiler will use when reporting a use of the API the attribute applies to.

```csharp
public ExperimentalAttribute(string diagnosticId);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.ExperimentalAttribute.ExperimentalAttribute(string).diagnosticId'></a>

`diagnosticId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The ID that the compiler will use when reporting a use of the API the attribute applies to.
### Properties

<a name='System.Diagnostics.CodeAnalysis.ExperimentalAttribute.DiagnosticId'></a>

## ExperimentalAttribute.DiagnosticId Property

Gets the ID that the compiler will use when reporting a use of the API the attribute applies to.

```csharp
public string DiagnosticId { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The unique diagnostic ID.

### Remarks
The diagnostic ID is shown in build output for warnings and errors.

This property represents the unique ID that can be used to suppress the warnings or errors, if needed.

<a name='System.Diagnostics.CodeAnalysis.ExperimentalAttribute.UrlFormat'></a>

## ExperimentalAttribute.UrlFormat Property

Gets or sets the URL for corresponding documentation.
The API accepts a format string instead of an actual URL, creating a generic URL that includes the diagnostic ID.

```csharp
public string? UrlFormat { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The format string that represents a URL to corresponding documentation.

### Remarks
An example format string is `https://contoso.com/obsoletion-warnings/{0}`.