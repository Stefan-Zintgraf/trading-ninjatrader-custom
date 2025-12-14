**Path**: [ChartAnchor](./chartanchor.md) > [IsXPropertiesVisible](./isxpropertiesvisible.md)

# IsXPropertiesVisible

# IsXPropertiesVisible

## [Definition](./isxpropertiesvisible.md)

Indicates the anchor's X properties are visible on the UI. When set to true, the X values can be viewed from the Drawing Objects properties.

## [Property Value](./isxpropertiesvisible.md)

A bool value which when true will display the anchor's X (time) data values from the drawing object properties; otherwise false. Default value is true.

## [Syntax](./isxpropertiesvisible.md)

`<chartanchor>.IsXPropertiesVisible`

## [Examples](./isxpropertiesvisible.md)

```csharp

protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         MyAnchor = new ChartAnchor();
         MyAnchor.IsXPropertiesVisible = true;
     }
     else if (State == State.Configure)
     {

     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isxpropertiesvisible.md)
*   [Property Value](./isxpropertiesvisible.md)
*   [Syntax](./isxpropertiesvisible.md)
*   [Examples](./isxpropertiesvisible.md)