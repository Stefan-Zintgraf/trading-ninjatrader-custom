**Path**: [ChartControl](./chartcontrol.md) > [AxisYRightWidth](./axisyrightwidth.md)

# AxisYRightWidth

# AxisYRightWidth

## [Definition](./axisyrightwidth.md)

Measures the distance (in pixels) between the y\-axis and the right edge of a chart.

## [Property Value](./axisyrightwidth.md)

A double representing the number of pixels separating the y\-axis and the right edge of the chart.

## [Syntax](./axisyrightwidth.md)

`<chartcontrol>.AxisYRightWidth`

## [Example](./axisyrightwidth.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
     // Print the number of pixels between the y-axis and the right edge of the chart
     double rightWidth = chartControl.AxisYRightWidth;
     Print(rightWidth);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, AxisYRightWidth reveals that the space between the y\-axis and the right edge of the chart is 53 pixels on this chart.

![ChartControl_AxisYRightWidth](https://cdn.sanity.io/images/1hlwceal/production/0f4affdc130fe1543d4a04caf22fa818ece905a1-534x429.png)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When there are no right\-justified data series on a chart, AxisYRightWidth will return 0, as there will be no space between the y\-axis and the right edge.

#### ON THIS PAGE

*   [Definition](./axisyrightwidth.md)
*   [Property Value](./axisyrightwidth.md)
*   [Syntax](./axisyrightwidth.md)
*   [Example](./axisyrightwidth.md)