**Path**: [ChartControl](./chartcontrol.md) > [Strategies](./chartcontrol_strategies.md)

# Strategies

# Strategies

## [Definition](./chartcontrol_strategies.md)

A collection of strategies configured on the chart.

## [Property Value](./chartcontrol_strategies.md)

A **ChartObjectCollection** of **StrategyRenderBase** objects containing information on all configured strategies on the chart.

## [Syntax](./chartcontrol_strategies.md)

`<chartcontrol>.Strategies`

## [Examples](./chartcontrol_strategies.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Print the number of strategies configured on the chart
   if (chartControl.Strategies.Count > 0) 
           Print(chartControl.Strategies[0].Name);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartcontrol_strategies.md)
*   [Property Value](./chartcontrol_strategies.md)
*   [Syntax](./chartcontrol_strategies.md)
*   [Examples](./chartcontrol_strategies.md)