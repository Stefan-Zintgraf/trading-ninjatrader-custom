**Path**: [Chart Style](./chart_style.md) > [BarWidthUI](./barwidthui.md)

# BarWidthUI

# BarWidthUI

## [Definition](./barwidthui.md)

The Bar width value which displays on the UI. This value will be rounded from the internal **BarWidth** property which is updated as the ChartControl is resized.

## [Property Value](./barwidthui.md)

An **int** value representing the width of the chart bars which can be set by a user.

## [Syntax](./barwidthui.md)

`BarWidthUI`

## [Examples](./barwidthui.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)
{
     int barWidth = GetBarPaintWidth(BarWidthUI);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barwidthui.md)
*   [Property Value](./barwidthui.md)
*   [Syntax](./barwidthui.md)
*   [Examples](./barwidthui.md)