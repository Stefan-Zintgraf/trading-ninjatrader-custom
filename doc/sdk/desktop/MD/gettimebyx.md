**Path**: [ChartControl](./chartcontrol.md) > [GetTimeByX()](./gettimebyx.md)

# GetTimeByX()

# GetTimeByX()

## [Definition](./gettimebyx.md)

Returns a time value related to the primary **Bars** slot index at a specified x\-coordinate relative to the **ChartControl**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Since the time is based upon a coordinate of the chart canvas, the value returned by **GetTimeByX()** can be expected to change as new bars are painted on the chart, or as the chart is scrolled backward or forward on the x\-axis.

## [Method Return Value](./gettimebyx.md)

A **DateTime** object corresponding to a slot index at a specified x\-coordinate.

## [Syntax](./gettimebyx.md)

`<chartcontrol>.GetTimeByX(int x)`

## [Method Parameters](./gettimebyx.md)

x

The x\-coordinate used to find a time value

## [Examples](./gettimebyx.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Find the timestamp of the bar at x-coordinate 100
   DateTime slotTime = chartControl.GetTimeByX(100);
 
   // Print the date of slotTime
   Print(slotTime);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettimebyx.md)
*   [Method Return Value](./gettimebyx.md)
*   [Syntax](./gettimebyx.md)
*   [Method Parameters](./gettimebyx.md)
*   [Examples](./gettimebyx.md)