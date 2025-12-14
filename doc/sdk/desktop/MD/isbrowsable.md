**Path**: [ChartAnchor](./chartanchor.md) > [IsBrowsable](./isbrowsable.md)

# IsBrowsable

# IsBrowsable

## [Definition](./isbrowsable.md)

Determines if the anchor are visible on the UI. When set to true, the anchors Y and X values can be viewed from the Drawing Objects properties.

## [Property Value](./isbrowsable.md)

A bool value which when true will display the anchor data values from the drawing object properties; otherwise false. Default value is true.

## [Syntax](./isbrowsable.md)

`<chartanchor>.IsBrowsable`

## [Examples](./isbrowsable.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
          MyAnchor = new ChartAnchor();
          MyAnchor.IsBrowsable = true;
     }
     else if (State == State.Configure)
     {
     }
}
```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isbrowsable.md)
*   [Property Value](./isbrowsable.md)
*   [Syntax](./isbrowsable.md)
*   [Examples](./isbrowsable.md)