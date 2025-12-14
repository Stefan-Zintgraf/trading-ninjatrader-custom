**Path**: [ChartControl](./chartcontrol.md) > [GetBarPaintWidth()](./chartcontrol_getbarpaintwidth.md)

# GetBarPaintWidth()

# GetBarPaintWidth()

## [Definition](./chartcontrol_getbarpaintwidth.md)

Returns the width of the bars in the primary Bars object on the chart, in pixels.

## [Method Return Value](./chartcontrol_getbarpaintwidth.md)

A double representing the pixel width of bars on the chart.

## [Syntax](./chartcontrol_getbarpaintwidth.md)

`<chartcontrol>.GetBarPaintWidth(ChartBars chartBars)`

## [Method Parameters](./chartcontrol_getbarpaintwidth.md)

**chartBars**

A [ChartBars](./chartbars.md) object to measure

## [Examples](./chartcontrol_getbarpaintwidth.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Use BarsArray[0] to pass in a ChartBars object representing the primary Bars object on the chart
   double barPixelWidth = chartControl.GetBarPaintWidth(chartControl.BarsArray[0]);
 
   // Print the pixel width of bars painted on the chart
   Print(String.Format("Bars on the chart are {0} pixels wide", barPixelWidth));   
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, **GetBarPaintWidth()** reveals that the bars are being drawn 27 pixels wide on the chart:

![ChartControl_GetBarPaintWidth](https://cdn.sanity.io/images/1hlwceal/production/f5c388624347d7cf06b9a3a6b43d88d5d6f5df9a-531x431.png)

#### ON THIS PAGE

*   [Definition](./chartcontrol_getbarpaintwidth.md)
*   [Method Return Value](./chartcontrol_getbarpaintwidth.md)
*   [Syntax](./chartcontrol_getbarpaintwidth.md)
*   [Method Parameters](./chartcontrol_getbarpaintwidth.md)
*   [Examples](./chartcontrol_getbarpaintwidth.md)