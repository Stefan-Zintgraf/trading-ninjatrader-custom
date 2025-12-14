**Path**: [ChartControl](./chartcontrol.md) > [BarWidth](./chartcontrol_barwidth.md)

# BarWidth

# BarWidth

## [Definition](./chartcontrol_barwidth.md)

Measures the value of the **bar width** set for the primary Bars object on the chart.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property value is not stated in pixels. To obtain the pixel\-width of bars on the chart, use **GetBarPaintWidth()** instead.

## [Property Value](./chartcontrol_barwidth.md)

A **double** representing the value of the bar width.

## [Syntax](./chartcontrol_barwidth.md)

`<chartcontrol>.BarWidth`

## [Examples](./chartcontrol_barwidth.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    double barWidth = chartControl.BarWidth;

    // Prints the width of bars on the chart
    Print(barWidth);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, BarWidth reveals that the bars on the chart are 4.02 pixels wide.

![ChartControl_BarWidth](https://cdn.sanity.io/images/1hlwceal/production/17998ce21ef3c4c2ec151b9e6d700c2023bfd841-534x429.png)

#### ON THIS PAGE

*   [Definition](./chartcontrol_barwidth.md)
*   [Property Value](./chartcontrol_barwidth.md)
*   [Syntax](./chartcontrol_barwidth.md)
*   [Examples](./chartcontrol_barwidth.md)