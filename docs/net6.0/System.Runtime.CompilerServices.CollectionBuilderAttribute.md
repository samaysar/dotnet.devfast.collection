#### [DevFast.Net.Collection](index.md 'index')
### [System.Runtime.CompilerServices](System.Runtime.CompilerServices.md 'System.Runtime.CompilerServices')

## CollectionBuilderAttribute Class

```csharp
internal sealed class CollectionBuilderAttribute : System.Attribute
```
- *Constructors*
  - **[CollectionBuilderAttribute(Type, string)](System.Runtime.CompilerServices.CollectionBuilderAttribute.md#System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type,string) 'System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type, string)')**
- *Properties*
  - **[BuilderType](System.Runtime.CompilerServices.CollectionBuilderAttribute.md#System.Runtime.CompilerServices.CollectionBuilderAttribute.BuilderType 'System.Runtime.CompilerServices.CollectionBuilderAttribute.BuilderType')**
  - **[MethodName](System.Runtime.CompilerServices.CollectionBuilderAttribute.md#System.Runtime.CompilerServices.CollectionBuilderAttribute.MethodName 'System.Runtime.CompilerServices.CollectionBuilderAttribute.MethodName')**

## CollectionBuilderAttribute Class

```csharp
internal sealed class CollectionBuilderAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; CollectionBuilderAttribute
### Constructors

<a name='System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type,string)'></a>

## CollectionBuilderAttribute(Type, string) Constructor

Initialize the attribute to refer to the [methodName](System.Runtime.CompilerServices.CollectionBuilderAttribute.md#System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type,string).methodName 'System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type, string).methodName') method on the [builderType](System.Runtime.CompilerServices.CollectionBuilderAttribute.md#System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type,string).builderType 'System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type, string).builderType') type.

```csharp
public CollectionBuilderAttribute(System.Type builderType, string methodName);
```
#### Parameters

<a name='System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type,string).builderType'></a>

`builderType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the builder to use to construct the collection.

<a name='System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type,string).methodName'></a>

`methodName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the method on the builder to use to construct the collection.

### Remarks
[methodName](System.Runtime.CompilerServices.CollectionBuilderAttribute.md#System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type,string).methodName 'System.Runtime.CompilerServices.CollectionBuilderAttribute.CollectionBuilderAttribute(System.Type, string).methodName') must refer to a static method that accepts a single parameter of
            type [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1') and returns an instance of the collection being built containing
            a copy of the data from that span.  In future releases of .NET, additional patterns may be supported.
### Properties

<a name='System.Runtime.CompilerServices.CollectionBuilderAttribute.BuilderType'></a>

## CollectionBuilderAttribute.BuilderType Property

Gets the type of the builder to use to construct the collection.

```csharp
public System.Type BuilderType { get; }
```

#### Property Value
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='System.Runtime.CompilerServices.CollectionBuilderAttribute.MethodName'></a>

## CollectionBuilderAttribute.MethodName Property

Gets the name of the method on the builder to use to construct the collection.

```csharp
public string MethodName { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
This should match the metadata name of the target method.
For example, this might be ".ctor" if targeting the type's constructor.