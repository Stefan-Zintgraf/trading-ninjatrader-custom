**Path**: [Chart Style](./chart_style.md) > [UpBrushDX](./upbrushdx.md)

# UpBrushDX

# UpBrushDX

## [Definition](./upbrushdx.md)

A SharpDX [Brush](./sharpdx_direct2d1_brush.md) object used to paint the up bars for the ChartStyle.

## [Property  Value](./upbrushdx.md)

A [SharpDX](./sharpdx_direct2d1.md) Brush object used to paint the up bars

## [Syntax](./upbrushdx.md)

`UpBrushDX`

## [Examples](./upbrushdx.md)

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

*   [Definition](./upbrushdx.md)
*   [Property  Value](./upbrushdx.md)
*   [Syntax](./upbrushdx.md)
*   [Examples](./upbrushdx.md)