**Path**: [ChartScale](./chartscale.md) > [ScaleJustification](./chartscale_scalejustification.md)

# ScaleJustification

# ScaleJustification

## [Definition](./chartscale_scalejustification.md)

Indicates the location of the chart scale relative to the chart control.

## [Property Value](./chartscale_scalejustification.md)

A **ScaleJustification** enum. Possible values are:

*   **Right**
*   **Left**
*   **Overlay**

## [Syntax](./chartscale_scalejustification.md)

`ScaleJustification`

## [Examples](./chartscale_scalejustification.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   if (chartScale.ScaleJustification == ScaleJustification.Right)
   {
     // do something
   }

}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartscale_scalejustification.md)
*   [Property Value](./chartscale_scalejustification.md)
*   [Syntax](./chartscale_scalejustification.md)
*   [Examples](./chartscale_scalejustification.md)