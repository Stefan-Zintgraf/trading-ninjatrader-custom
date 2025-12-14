**Path**: [ChartControl](./chartcontrol.md) > [SlotsPainted](./slotspainted.md)

# SlotsPainted

# SlotsPainted

## [Definition](./slotspainted.md)

Indicates the number of index slots in which bars are painted within the chart canvas area. This covers the visible portion of the chart only, and does not include historical painted bars outside of the visible area.

## [Property Value](./slotspainted.md)

An int representing the number of index slots in which bars are painted.

## [Syntax](./slotspainted.md)

`<chartcontrol>.SlotsPainted`

## [Examples](./slotspainted.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   int painted = chartControl.SlotsPainted;
 
   // Print the number of bars painted on the visible chart canvas
   Print(painted);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, **SlotsPainted** reveals that there are 17 bars painted on the chart canvas.

![ChartControl_SlotsPainted](https://cdn.sanity.io/images/1hlwceal/production/a6e80e77cacce15553e0a1a5ee4abbeb9bd7f3f4-531x431.png)

#### ON THIS PAGE

*   [Definition](./slotspainted.md)
*   [Property Value](./slotspainted.md)
*   [Syntax](./slotspainted.md)
*   [Examples](./slotspainted.md)