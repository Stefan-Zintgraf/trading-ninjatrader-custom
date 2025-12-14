**Path**: [ChartControl](./chartcontrol.md) > [BarsPeriod](./chartcontrol_barsperiod.md)

# BarsPeriod

# BarsPeriod

## [Definition](./chartcontrol_barsperiod.md)

Provides the period (interval) used for the primary **Bars** object on the chart.

## [Property Value](./chartcontrol_barsperiod.md)

A **NinjaTrader.Data.BarsPeriod** object containing information on the period used by the **Bars** object on the chart.

## [Syntax](./chartcontrol_barsperiod.md)

`<chartcontrol>.BarsPeriod`

## [Examples](./chartcontrol_barsperiod.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale) 
{
   BarsPeriod period = chartControl.BarsPeriod;
 
   // Print the period (interval) of the Bars object on the chart
   Print(period);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Based on the image below, **BarsPeriod** confirms that the primary **Bars** object on the chart is configured to a 5\-minute interval.

![ChartControl_BarsPeriod](https://cdn.sanity.io/images/1hlwceal/production/676ace86d5b9ad2338dfbc22509291da8f9d517a-531x431.png)

#### ON THIS PAGE

*   [Definition](./chartcontrol_barsperiod.md)
*   [Property Value](./chartcontrol_barsperiod.md)
*   [Syntax](./chartcontrol_barsperiod.md)
*   [Examples](./chartcontrol_barsperiod.md)