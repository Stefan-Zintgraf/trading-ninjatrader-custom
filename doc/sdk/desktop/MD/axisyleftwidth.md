**Path**: [ChartControl](./chartcontrol.md) > [AxisYLeftWidth](./axisyleftwidth.md)

# AxisYLeftWidth

# AxisYLeftWidth

## [Definition](./axisyleftwidth.md)

Measures the distance (in pixels) between the y\-axis and the left edge of a chart.

## [Property Value](./axisyleftwidth.md)

A double representing the number of pixels separating the y\-axis and the left edge of the chart.

## [Syntax](./axisyleftwidth.md)

`ChartControl.AxisYLeftWidth`

## [Example](./axisyleftwidth.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
     // Print the number of pixels between the y-axis and the left edge of the chart
     double leftWidth = chartControl.AxisYLeftWidth;
     Print(leftWidth);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, AxisYLeftWidth reveals that the space between the y\-axis and the left edge of the chart is 53 pixels on this chart.

![ChartControl_AxisYLeftWidth](https://cdn.sanity.io/images/1hlwceal/production/1b2c5bc34f4bb28d9b7869a50976c394055032b9-534x429.png)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When there are no left\-justified data series on a chart, AxisYLeftWidth will return 0, as there will be no space between the y\-axis and the left margin.

#### ON THIS PAGE

*   [Definition](./axisyleftwidth.md)
*   [Property Value](./axisyleftwidth.md)
*   [Syntax](./axisyleftwidth.md)
*   [Example](./axisyleftwidth.md)