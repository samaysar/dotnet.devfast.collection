#### [DevFast.Net.Collection](index.md 'index')
### [System.Runtime.CompilerServices](System.Runtime.CompilerServices.md 'System.Runtime.CompilerServices')

## InterpolatedStringHandlerArgumentAttribute Class

Indicates which arguments to a method involving an interpolated string handler should be passed to that handler.

```csharp
internal sealed class InterpolatedStringHandlerArgumentAttribute : System.Attribute
```
- *Constructors*
  - **[InterpolatedStringHandlerArgumentAttribute(string)](System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.md#System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string) 'System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string)')**
  - **[InterpolatedStringHandlerArgumentAttribute(string[])](System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.md#System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string[]) 'System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string[])')**
- *Properties*
  - **[Arguments](System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.md#System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.Arguments 'System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.Arguments')**

## InterpolatedStringHandlerArgumentAttribute Class

Indicates which arguments to a method involving an interpolated string handler should be passed to that handler.

```csharp
internal sealed class InterpolatedStringHandlerArgumentAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; InterpolatedStringHandlerArgumentAttribute
### Constructors

<a name='System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string)'></a>

## InterpolatedStringHandlerArgumentAttribute(string) Constructor

Initializes a new instance of the [InterpolatedStringHandlerArgumentAttribute](System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.md 'System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute') class.

```csharp
public InterpolatedStringHandlerArgumentAttribute(string argument);
```
#### Parameters

<a name='System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string).argument'></a>

`argument` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the argument that should be passed to the handler.

### Remarks
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') may be used as the name of the receiver in an instance method.

<a name='System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string[])'></a>

## InterpolatedStringHandlerArgumentAttribute(string[]) Constructor

Initializes a new instance of the [InterpolatedStringHandlerArgumentAttribute](System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.md 'System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute') class.

```csharp
public InterpolatedStringHandlerArgumentAttribute(params string[] arguments);
```
#### Parameters

<a name='System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.InterpolatedStringHandlerArgumentAttribute(string[]).arguments'></a>

`arguments` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The names of the arguments that should be passed to the handler.

### Remarks
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') may be used as the name of the receiver in an instance method.
### Properties

<a name='System.Runtime.CompilerServices.InterpolatedStringHandlerArgumentAttribute.Arguments'></a>

## InterpolatedStringHandlerArgumentAttribute.Arguments Property

Gets the names of the arguments that should be passed to the handler.

```csharp
public string[] Arguments { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

### Remarks
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') may be used as the name of the receiver in an instance method.