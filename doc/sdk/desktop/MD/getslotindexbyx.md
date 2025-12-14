**Path**: [ChartControl](./chartcontrol.md) > [GetSlotIndexByX()](./getslotindexbyx.md)

# GetSlotIndexByX()

# GetSlotIndexByX()

## [Definition](./getslotindexbyx.md)

Returns the slot index relative to the chart control corresponding to a specified x\-coordinate.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   A "Slot" is used in Equidistant **bar spacing** and represents a position on the chart canvas background which may or may not contain a bar. The concept of "Slots" does NOT exist on a **TimeBased** bar spacing type.
*   If you are looking for information on a bar series, please see [ChartBars.GetBarIdxByX()](./getbaridxbyx.md).
*   Since the slot index is based on the chart canvas, the value returned by **GetSlotIndexByX()** can be expected to change as new bars are painted, or as the chart is scrolled backward or forward on the x\-axis.

## [Method Return Value](./getslotindexbyx.md)

A double representing a slot index; returns \-1 on a time based bar spacing type.

## [Syntax](./getslotindexbyx.md)

`<chartcontrol>.GetSlotIndexByX(int x)`

## [Method Parameters](./getslotindexbyx.md)

x

An int used to determine a slot index

## [Examples](./getslotindexbyx.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Find the index of the bar painted at x-coordinate 35
    double slotIndex = chartControl.GetSlotIndexByX(35);
    
    // Print the slot index of the specified time
    Print(slotIndex);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getslotindexbyx.md)
*   [Method Return Value](./getslotindexbyx.md)
*   [Syntax](./getslotindexbyx.md)
*   [Method Parameters](./getslotindexbyx.md)
*   [Examples](./getslotindexbyx.md)