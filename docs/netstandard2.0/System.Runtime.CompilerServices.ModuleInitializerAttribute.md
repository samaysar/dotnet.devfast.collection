#### [DevFast.Net.Collection](index.md 'index')
### [System.Runtime.CompilerServices](System.Runtime.CompilerServices.md 'System.Runtime.CompilerServices')

## ModuleInitializerAttribute Class

Used to indicate to the compiler that a method should be called
in its containing module's initializer.

```csharp
internal sealed class ModuleInitializerAttribute : System.Attribute
```

## ModuleInitializerAttribute Class

Used to indicate to the compiler that a method should be called
in its containing module's initializer.

```csharp
internal sealed class ModuleInitializerAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; ModuleInitializerAttribute

### Remarks
When one or more valid methods
with this attribute are found in a compilation, the compiler will
emit a module initializer which calls each of the attributed methods.

Certain requirements are imposed on any method targeted with this attribute:
- The method must be `static`.
- The method must be an ordinary member method, as opposed to a property accessor, constructor, local function, etc.
- The method must be parameterless.
- The method must return `void`.
- The method must not be generic or be contained in a generic type.
- The method's effective accessibility must be `internal` or `public`.

The specification for module initializers in the .NET runtime can be found here:
https://github.com/dotnet/runtime/blob/main/docs/design/specs/Ecma-335-Augments.md#module-initializer