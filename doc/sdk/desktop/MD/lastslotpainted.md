**Path**: [ChartControl](./chartcontrol.md) > [LastSlotPainted](./lastslotpainted.md)

# LastSlotPainted

# LastSlotPainted

## [Definition](./lastslotpainted.md)

Indicates the most recent (last) slot index of the Data Series on the chart, regardless if a bar is actually painted in that slot.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

LastSlotPainted differs from **ChartBars.ToIndex**, which returns the last index containing a bar painted in the visible area of the chart.

## [Property Value](./lastslotpainted.md)

A int representing the most recent (last) slot index on the chart.

## [Syntax](./lastslotpainted.md)

`<chartcontrol>.LastSlotPainted`

## [Examples](./lastslotpainted.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   int lastSlot = chartControl.LastSlotPainted;
 
   // Print the index of the last slot on the chart
   Print(lastSlot);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./lastslotpainted.md)
*   [Property Value](./lastslotpainted.md)
*   [Syntax](./lastslotpainted.md)
*   [Examples](./lastslotpainted.md)