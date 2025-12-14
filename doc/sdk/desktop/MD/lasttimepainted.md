**Path**: [ChartControl](./chartcontrol.md) > [LastTimePainted](./lasttimepainted.md)

# LastTimePainted

# LastTimePainted

## [Definition](./lasttimepainted.md)

Indicates the time of the most recently painted bar on the primary **Bars** object configured on the chart.

## [Property Value](./lasttimepainted.md)

A **DateTime** object corresponding to the slot index of the most recently painted bar.

## [Syntax](./lasttimepainted.md)

`<chartcontrol`\>.LastTimePainted\`

## [Examples](./lasttimepainted.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   DateTime lastSlotTime = chartControl.LastTimePainted;

   // Print the index of the last slot painted on the chart
   Print(lastSlotTime);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, LastTimePainted reveals that the last index painted on the chart corresponds to 8/12/17 at 2:10:00 PM.

![ChartControl_LastTimePainted](https://cdn.sanity.io/images/1hlwceal/production/043ba0d3fcc0ab8a3d3f2bee29577f92b7a5cee3-531x431.png)

#### ON THIS PAGE

*   [Definition](./lasttimepainted.md)
*   [Property Value](./lasttimepainted.md)
*   [Syntax](./lasttimepainted.md)
*   [Examples](./lasttimepainted.md)