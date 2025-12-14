**Path**: [ChartControl](./chartcontrol.md) > [GetXByBarIndex()](./getxbybarindex.md)

# GetXByBarIndex()

# GetXByBarIndex()

## [Definition](./getxbybarindex.md)

Returns the chart\-canvas x\-coordinate of the bar at a specified index of a specified **ChartBars** object on the chart.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Since the index is based upon bars that move across the chart canvas as new bars are painted, the value returned by **GetXByBarIndex()** can be expected to change as new bars are painted on the chart, or as the chart is scrolled backward or forward on the x\-axis.

## [Method Return Value](./getxbybarindex.md)

An int representing a chart\-canvas x\-coordinate.

## [Syntax](./getxbybarindex.md)

`<chartcontrol>.GetXByBarIndex(ChartBars chartBars, int barIndex)`

## [Method Parameters](./getxbybarindex.md)

**Parameter**

**Description**

**chartBars**

The **ChartBars** object to check.

**barIndex**

The slot index used to determine an x\-coordinate.

## [Examples](./getxbybarindex.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    double xCoordinate = chartControl.GetXByBarIndex(ChartBars, 100);
    
    // Print the x-coordinate value
    Print(xCoordinate);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getxbybarindex.md)
*   [Method Return Value](./getxbybarindex.md)
*   [Syntax](./getxbybarindex.md)
*   [Method Parameters](./getxbybarindex.md)
*   [Examples](./getxbybarindex.md)