**Path**: [ChartScale](./chartscale.md) > [IsVisible](./chartscale_isvisible.md)

# IsVisible

# IsVisible

## [Definition](./chartscale_isvisible.md)

Indicates if the chart scale is viewable on the UI. If the bar series, indicator, or strategy which uses the chart scale is not in view, the chart scale **IsVisible** property will return false.

## [Property Value](./chartscale_isvisible.md)

A **bool** value, which when true the series used to build the scale is viewable; otherwise false. This property is read\-only.

## [Syntax](./chartscale_isvisible.md)

`<chartscale>.IsVisible`

## [Examples](./chartscale_isvisible.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{         
   // do not process render info chart scale is not visible
   if(!chartScale.IsVisible)
     return;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartscale_isvisible.md)
*   [Property Value](./chartscale_isvisible.md)
*   [Syntax](./chartscale_isvisible.md)
*   [Examples](./chartscale_isvisible.md)