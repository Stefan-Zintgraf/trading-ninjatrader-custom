**Path**: [ChartControl](./chartcontrol.md) > [TimePainted](./timepainted.md)

# TimePainted

# TimePainted

## [Definition](./timepainted.md)

Indicates the range of time in which bars are painted on the visible chart canvas.

## [Property Value](./timepainted.md)

A TimeSpan measuring the difference between the earliest and latest times at which bars are painted on the chart.

## [Syntax](./timepainted.md)

\`\`<chartcontrol>.TimePainted\`

## [Examples](./timepainted.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print a message if less than three hours' worth of data is painted on the chart canvas
   if(chartControl.TimePainted.Hours < 3)
       Print(String.Format("It is recommended to view at least three hours worth of data on your chart with this indicator. You are currently viewing {0}", chartControl.TimePainted));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

TimePainted is intended to be used when Non\-Equidistant (time\-based) bar spacing is enabled on the chart. Otherwise, it will have a value of 0.

#### ON THIS PAGE

*   [Definition](./timepainted.md)
*   [Property Value](./timepainted.md)
*   [Syntax](./timepainted.md)
*   [Examples](./timepainted.md)