**Path**: [ChartControl](./chartcontrol.md) > [GetSlotIndexByTime()](./getslotindexbytime.md)

# GetSlotIndexByTime()

# GetSlotIndexByTime()

## [Definition](./getslotindexbytime.md)

Returns the slot index relative to the chart control corresponding to a specified time value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Notes:

*   A "Slot" is used in Equidistant [bar spacing](./barspacingtype.md) and represents a position on the chart canvas background which may or may not contain a bar. The concept of "Slots" does NOT exist on a TimeBased bar spacing type.
*   If you are looking for information on a bar series, please see [ChartBars.GetBarIdxByTime()](./getbaridxbytime.md).

## [Method Return Value](./getslotindexbytime.md)

A double representing a slot index.

## [Syntax](./getslotindexbytime.md)

`<chartcontrol>.GetSlotIndexByTime(DateTime time)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This method CANNOT be called on BarSpacingType.TimeBased charts. You will need to ensure an Equidistant [bar spacing type](./barspacingtype.md) is used, otherwise errors will be thrown.

## [Method Parameters](./getslotindexbytime.md)

Parameter

Description

**time**

A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) Structure used to determine a slot index

## [Examples](./getslotindexbytime.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // ensure that GetSlotIndexByTime is called on TimeBased charts
    if(chartControl.BarSpacingType != BarSpacingType.TimeBased)
    {
        // get the slot index of the first time painted on the chart
        double slotIndex = chartControl.GetSlotIndexByTime(chartControl.FirstTimePainted);
        
        Print(slotIndex);
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getslotindexbytime.md)
*   [Method Return Value](./getslotindexbytime.md)
*   [Syntax](./getslotindexbytime.md)
*   [Method Parameters](./getslotindexbytime.md)
*   [Examples](./getslotindexbytime.md)