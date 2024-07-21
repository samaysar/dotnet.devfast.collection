#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## DoesNotReturnIfAttribute Class

Specifies that the method will not return if the associated Boolean parameter is passed the specified value.

```csharp
internal sealed class DoesNotReturnIfAttribute : System.Attribute
```
- *Constructors*
  - **[DoesNotReturnIfAttribute(bool)](System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.md#System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.DoesNotReturnIfAttribute(bool) 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.DoesNotReturnIfAttribute(bool)')**
- *Properties*
  - **[ParameterValue](System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.md#System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.ParameterValue 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.ParameterValue')**

## DoesNotReturnIfAttribute Class

Specifies that the method will not return if the associated Boolean parameter is passed the specified value.

```csharp
internal sealed class DoesNotReturnIfAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; DoesNotReturnIfAttribute
### Constructors

<a name='System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.DoesNotReturnIfAttribute(bool)'></a>

## DoesNotReturnIfAttribute(bool) Constructor

Initializes the attribute with the specified parameter value.

```csharp
public DoesNotReturnIfAttribute(bool parameterValue);
```
#### Parameters

<a name='System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.DoesNotReturnIfAttribute(bool).parameterValue'></a>

`parameterValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The condition parameter value. Code after the method will be considered unreachable
by diagnostics if the argument to the associated parameter matches this value.
### Properties

<a name='System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.ParameterValue'></a>

## DoesNotReturnIfAttribute.ParameterValue Property

Gets the condition parameter value.

```csharp
public bool ParameterValue { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')