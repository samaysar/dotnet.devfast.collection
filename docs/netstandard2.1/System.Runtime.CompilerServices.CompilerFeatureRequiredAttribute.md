#### [DevFast.Net.Collection](index.md 'index')
### [System.Runtime.CompilerServices](System.Runtime.CompilerServices.md 'System.Runtime.CompilerServices')

## CompilerFeatureRequiredAttribute Class

Indicates that compiler support for a particular feature is required for the location where this attribute is applied.

```csharp
internal sealed class CompilerFeatureRequiredAttribute : System.Attribute
```
- *Constructors*
  - **[CompilerFeatureRequiredAttribute(string)](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.CompilerFeatureRequiredAttribute(string) 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.CompilerFeatureRequiredAttribute(string)')**
- *Fields*
  - **[RefStructs](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.RefStructs 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.RefStructs')**
  - **[RequiredMembers](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.RequiredMembers 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.RequiredMembers')**
- *Properties*
  - **[FeatureName](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName')**
  - **[IsOptional](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.IsOptional 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.IsOptional')**

## CompilerFeatureRequiredAttribute Class

Indicates that compiler support for a particular feature is required for the location where this attribute is applied.

```csharp
internal sealed class CompilerFeatureRequiredAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; CompilerFeatureRequiredAttribute
### Constructors

<a name='System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.CompilerFeatureRequiredAttribute(string)'></a>

## CompilerFeatureRequiredAttribute(string) Constructor

Creates a new instance of the [CompilerFeatureRequiredAttribute](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute') type.

```csharp
public CompilerFeatureRequiredAttribute(string featureName);
```
#### Parameters

<a name='System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.CompilerFeatureRequiredAttribute(string).featureName'></a>

`featureName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the feature to indicate.
### Fields

<a name='System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.RefStructs'></a>

## CompilerFeatureRequiredAttribute.RefStructs Field

The [FeatureName](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName') used for the ref structs C# feature.

```csharp
public const string RefStructs = RefStructs;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.RequiredMembers'></a>

## CompilerFeatureRequiredAttribute.RequiredMembers Field

The [FeatureName](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName') used for the required members C# feature.

```csharp
public const string RequiredMembers = RequiredMembers;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Properties

<a name='System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName'></a>

## CompilerFeatureRequiredAttribute.FeatureName Property

The name of the compiler feature.

```csharp
public string FeatureName { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.IsOptional'></a>

## CompilerFeatureRequiredAttribute.IsOptional Property

If true, the compiler can choose to allow access to the location where this attribute is applied if it does not understand [FeatureName](System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.md#System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute.FeatureName').

```csharp
public bool IsOptional { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')