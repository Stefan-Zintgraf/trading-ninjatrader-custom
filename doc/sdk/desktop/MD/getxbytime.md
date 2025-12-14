**Path**: [ChartControl](./chartcontrol.md) > [GetXByTime()](./getxbytime.md)

# GetXByTime()

# GetXByTime()

## [Definition](./getxbytime.md)

Returns the chart\-canvas x\-coordinate of the slot index of the primary **Bars** object corresponding to a specified time.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Since the time correlates with a specific bar index, and since bars move on the chart canvas as new bars are painted, the value returned by **GetXByTime()** can be expected to change as new bars are painted on the chart, or as the chart is scrolled backward or forward on the x\-axis.

## [Method Return Value](./getxbytime.md)

An int representing a chart\-canvas x\-coordinate.

## [Syntax](./getxbytime.md)

`<chartcontrol>.GetXByTime(DateTime time)`

## [Method Parameters](./getxbytime.md)

time

A **DateTime** object used to determine an x\-coordinate

## [Examples](./getxbytime.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   DateTime timeToCheck = new DateTime(2017, 8, 6, 11, 0, 0);

   // Find the chart-canvas x-coordinate of the bar at the specified time
    int xCoordinate = chartControl.GetXByTime(timeToCheck);

   // Print the x-coordinate value
   Print(xCoordinate);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getxbytime.md)
*   [Method Return Value](./getxbytime.md)
*   [Syntax](./getxbytime.md)
*   [Method Parameters](./getxbytime.md)
*   [Examples](./getxbytime.md)