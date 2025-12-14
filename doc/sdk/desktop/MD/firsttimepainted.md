**Path**: [ChartControl](./chartcontrol.md) > [FirstTimePainted](./firsttimepainted.md)

# FirstTimePainted

# FirstTimePainted

## [Definition](./firsttimepainted.md)

Indicates a **DateTime** value of the first bar painted on the chart.

**FirstTimePainted** provides the timestamp of the first bar, NOT the time at which the bar was painted. For example, if a chart was opened and historical bars drawn on August 2nd at 5:00 pm, but the first bar on the chart is painted at a time\-axis value of July 31st at 1:00 am, then **FirstTimePainted** will return the July 31st date and time.

## [Property Value](./firsttimepainted.md)

A **DateTime** object containing information on the timestamp of the first bar of the chart.

## [Syntax](./firsttimepainted.md)

`<chartcontrol>.FirstTimePainted`

## [Examples](./firsttimepainted.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Draw text to display the first timestamp of a bar on the chart
    Draw.Text(this, "firstTimeText", String.Format("The first bar of {0} is drawn at {1}", Instrument.MasterInstrument.Name, chartControl.FirstTimePainted), 1, High[0],Brushes.Black);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

In the image below, **FirstTimePainted** reveals that the first painted slot corresponds to 8/12/17 at 10:40:00 AM.

![ChartControl_FirstTimePainted](https://cdn.sanity.io/images/1hlwceal/production/c18c7653f0e2789de04b4c7875ca2e294ec490f4-531x431.png)

#### ON THIS PAGE

*   [Definition](./firsttimepainted.md)
*   [Property Value](./firsttimepainted.md)
*   [Syntax](./firsttimepainted.md)
*   [Examples](./firsttimepainted.md)