**Path**: [Chart Style](./chart_style.md) > [DownBrushDX](./downbrushdx.md)

# DownBrushDX

# DownBrushDX

## [Definition](./downbrushdx.md)

A **SharpDX** [Brush](./sharpdx_direct2d1_brush.md) object used to paint the down bars for the ChartStyle.

## [Property  Value](./downbrushdx.md)

A **SharpDX** [Brush](./sharpdx_direct2d1.md) object used to paint the down bars.

## [Syntax](./downbrushdx.md)

`DownBrushDX`

## [Examples](./downbrushdx.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)
{
   for (int idx = chartBars.FromIndex; idx <= chartBars.ToIndex; idx++)
       {
           double     closeValue             = bars.GetClose(idx); 
           double     openValue               = bars.GetOpen(idx);
 
           // Set the brush of the current candle to UpBrushDX or DownBrushDX, depending on the 
           // bar direction
           Brush brush = closeValue >= openValue ? UpBrushDX : DownBrushDX;
       }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./downbrushdx.md)
*   [Property  Value](./downbrushdx.md)
*   [Syntax](./downbrushdx.md)
*   [Examples](./downbrushdx.md)