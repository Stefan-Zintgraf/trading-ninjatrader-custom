**Path**: [ChartControl](./chartcontrol.md) > [GetTimeBySlotIndex()](./gettimebyslotindex.md)

# GetTimeBySlotIndex()

# GetTimeBySlotIndex()

## [Definition](./gettimebyslotindex.md)

Returns a time value relative to the chart control corresponding to a specified slot index.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Notes:

*   A "Slot" is used in Equidistant **bar spacing** and represents a position on the chart canvas background which may or may not contain a bar. The concept of "Slots" does NOT exist on a TimeBased bar spacing type.
*   If you are looking for information on a bar series, please see [ChartBars.GetTimeByBarIdx()](./gettimebybaridx.md).
*   For slot index values in the future, an estimation of time will be returned. It is not possible to predict the future time of a bar for all bar series (i.e., tick/volume based bars).

## [Method Return Value](./gettimebyslotindex.md)

A **DateTime** object corresponding to a specified slot index; returns **DateTime** value for 'now' on a time based bar spacing type.

## [Syntax](./gettimebyslotindex.md)

`<chartcontrol>.GetTimeBySlotIndex(double slotIndex)`

## [Method Parameters](./gettimebyslotindex.md)

slotIndex

The slot index used to determine a time value

## [Examples](./gettimebyslotindex.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Find the timestamp of the bar at index 150
    DateTime slotTime = chartControl.GetTimeBySlotIndex(150);
    
    // Print the date of slotTime
    Print(slotTime.Date);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettimebyslotindex.md)
*   [Method Return Value](./gettimebyslotindex.md)
*   [Syntax](./gettimebyslotindex.md)
*   [Method Parameters](./gettimebyslotindex.md)
*   [Examples](./gettimebyslotindex.md)