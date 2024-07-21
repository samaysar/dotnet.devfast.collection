#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## MaybeNullWhenAttribute Class

Specifies that when a method returns [ReturnValue](System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue'), the parameter may be null even if the corresponding type disallows it.

```csharp
internal sealed class MaybeNullWhenAttribute : System.Attribute
```
- *Constructors*
  - **[MaybeNullWhenAttribute(bool)](System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.MaybeNullWhenAttribute(bool) 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.MaybeNullWhenAttribute(bool)')**
- *Properties*
  - **[ReturnValue](System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue')**

## MaybeNullWhenAttribute Class

Specifies that when a method returns [ReturnValue](System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.md#System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue'), the parameter may be null even if the corresponding type disallows it.

```csharp
internal sealed class MaybeNullWhenAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; MaybeNullWhenAttribute
### Constructors

<a name='System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.MaybeNullWhenAttribute(bool)'></a>

## MaybeNullWhenAttribute(bool) Constructor

Initializes the attribute with the specified return value condition.

```csharp
public MaybeNullWhenAttribute(bool returnValue);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.MaybeNullWhenAttribute(bool).returnValue'></a>

`returnValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The return value condition. If the method returns this value, the associated parameter may be null.
### Properties

<a name='System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue'></a>

## MaybeNullWhenAttribute.ReturnValue Property

Gets the return value condition.

```csharp
public bool ReturnValue { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')