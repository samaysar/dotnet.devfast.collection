#### [DevFast.Net.Collection](index.md 'index')
### [System.Runtime.CompilerServices](System.Runtime.CompilerServices.md 'System.Runtime.CompilerServices')

## CallerArgumentExpressionAttribute Class

An attribute that allows parameters to receive the expression of other parameters.

```csharp
internal sealed class CallerArgumentExpressionAttribute : System.Attribute
```
- *Constructors*
  - **[CallerArgumentExpressionAttribute(string)](System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.md#System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.CallerArgumentExpressionAttribute(string) 'System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.CallerArgumentExpressionAttribute(string)')**
- *Properties*
  - **[ParameterName](System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.md#System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.ParameterName 'System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.ParameterName')**

## CallerArgumentExpressionAttribute Class

An attribute that allows parameters to receive the expression of other parameters.

```csharp
internal sealed class CallerArgumentExpressionAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; CallerArgumentExpressionAttribute
### Constructors

<a name='System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.CallerArgumentExpressionAttribute(string)'></a>

## CallerArgumentExpressionAttribute(string) Constructor

Initializes a new instance of the [CallerArgumentExpressionAttribute](System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.md 'System.Runtime.CompilerServices.CallerArgumentExpressionAttribute') class.

```csharp
public CallerArgumentExpressionAttribute(string parameterName);
```
#### Parameters

<a name='System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.CallerArgumentExpressionAttribute(string).parameterName'></a>

`parameterName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The condition parameter value.
### Properties

<a name='System.Runtime.CompilerServices.CallerArgumentExpressionAttribute.ParameterName'></a>

## CallerArgumentExpressionAttribute.ParameterName Property

Gets the parameter name the expression is retrieved from.

```csharp
public string ParameterName { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')