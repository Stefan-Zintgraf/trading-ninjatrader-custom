**Path**: [ChartBars](./chartbars.md) > [Bars](./chartbars_bars.md)

# Bars

# Bars

## [Definition](./chartbars_bars.md)

Represents the data returned from the historical data repository in relation to the primary **ChartBars** object configured on the chart. See also [Bars](./bars.md).

## [Property Value](./chartbars_bars.md)

A **Bars** object

## [Syntax](./chartbars_bars.md)

`ChartBars.Bars`

## [Examples](./chartbars_bars.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   if(ChartBars != null && ChartBars.Bars != null)
   {
     Print("The configured bars period type represented on the chart is" + ChartBars.Bars.BarsPeriod.BarsPeriodType);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartbars_bars.md)
*   [Property Value](./chartbars_bars.md)
*   [Syntax](./chartbars_bars.md)
*   [Examples](./chartbars_bars.md)