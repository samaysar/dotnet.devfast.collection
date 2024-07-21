#### [DevFast.Net.Collection](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System.Diagnostics.CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')

## UnscopedRefAttribute Class

Used to indicate a byref escapes and is not scoped.

```csharp
internal sealed class UnscopedRefAttribute : System.Attribute
```

## UnscopedRefAttribute Class

Used to indicate a byref escapes and is not scoped.

```csharp
internal sealed class UnscopedRefAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; UnscopedRefAttribute

### Remarks

There are several cases where the C# compiler treats a [ref](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref') as implicitly
[scoped](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/scoped 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/scoped') - where the compiler does not allow the [ref](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref') to escape the method.

For example:
1. [this](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this') for [struct](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct') instance methods.
2. [ref](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref') parameters that refer to [ref](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref')[struct](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct') types.
3. [out](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out') parameters.

This attribute is used in those instances where the [ref](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref') should be allowed to escape.

Applying this attribute, in any form, has impact on consumers of the applicable API. It is necessary for
API authors to understand the lifetime implications of applying this attribute and how it may impact their users.