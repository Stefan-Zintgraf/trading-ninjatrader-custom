**Path**: [ChartAnchor](./chartanchor.md) > [IsYPropertyVisibile](./isypropertyvisibile.md)

# IsYPropertyVisibile

# IsYPropertyVisibile

## [Definition](./isypropertyvisibile.md)

Indicates the anchor's Y properties are visible on the UI. When set to true, the Y values can be viewed from the Drawing Objects properties.

## [Property Value](./isypropertyvisibile.md)

A bool value which when true will display the anchor's Y (price) data values from the drawing object properties; otherwise false. Default value is true.

## [Syntax](./isypropertyvisibile.md)

`<chartanchor>.IsYPropertyVisibile`

## [Examples](./isypropertyvisibile.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
          MyAnchor = new ChartAnchor();
          MyAnchor.IsYPropertyVisibile = true;
     }
     else if (State == State.Configure)
     {

     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isypropertyvisibile.md)
*   [Property Value](./isypropertyvisibile.md)
*   [Syntax](./isypropertyvisibile.md)
*   [Examples](./isypropertyvisibile.md)