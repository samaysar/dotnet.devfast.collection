#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## NotNullWhenAttribute Class

Specifies that when a method returns [ReturnValue](System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue'), the parameter will not be null even if the corresponding type allows it.

```csharp
internal sealed class NotNullWhenAttribute : System.Attribute
```
- *Constructors*
  - **[NotNullWhenAttribute(bool)](System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.NotNullWhenAttribute(bool) 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.NotNullWhenAttribute(bool)')**
- *Properties*
  - **[ReturnValue](System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue')**

## NotNullWhenAttribute Class

Specifies that when a method returns [ReturnValue](System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue'), the parameter will not be null even if the corresponding type allows it.

```csharp
internal sealed class NotNullWhenAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; NotNullWhenAttribute
### Constructors

<a name='System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.NotNullWhenAttribute(bool)'></a>

## NotNullWhenAttribute(bool) Constructor

Initializes the attribute with the specified return value condition.

```csharp
public NotNullWhenAttribute(bool returnValue);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.NotNullWhenAttribute(bool).returnValue'></a>

`returnValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The return value condition. If the method returns this value, the associated parameter will not be null.
### Properties

<a name='System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue'></a>

## NotNullWhenAttribute.ReturnValue Property

Gets the return value condition.

```csharp
public bool ReturnValue { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')