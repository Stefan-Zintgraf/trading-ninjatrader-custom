**Path**: [ChartControl](./chartcontrol.md) > [AxisXHeight](./axisxheight.md)

# AxisXHeight

# AxisXHeight

## [Definition](./axisxheight.md)

Measures the distance (in pixels) between the x\-axis and the top of the horizontal scroll bar near the bottom of the chart.

## [Property Value](./axisxheight.md)

A double representing the number of pixels separating the x\-axis and the top of the horizontal scroll bar on the chart.

## [Syntax](./axisxheight.md)

`ChartControl.AxisXHeight`

## [Example](./axisxheight.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
     // Print the number of pixels between the x-axis and the top of the horizontal scrollbar
     double height = chartControl.AxisXHeight;
     Print(height);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, AxisXHeight reveals that the space between the x\-axis and the top of the horizontal scrollbar is 31 pixels on this chart.

![ChartControl_AxisXHeight](https://cdn.sanity.io/images/1hlwceal/production/8be3b4d4a088a06870d4dfe1ae9ff2d8df7c7219-530x431.png)

#### ON THIS PAGE

*   [Definition](./axisxheight.md)
*   [Property Value](./axisxheight.md)
*   [Syntax](./axisxheight.md)
*   [Example](./axisxheight.md)