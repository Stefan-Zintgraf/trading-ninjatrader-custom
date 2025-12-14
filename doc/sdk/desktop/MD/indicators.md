**Path**: [ChartControl](./chartcontrol.md) > [Indicators](./indicators.md)

# Indicators

# Indicators

## [Definition](./indicators.md)

Contains a collection of indicators currently configured on the chart.

## [Property Value](./indicators.md)

A ChartObjectCollection of **NinjaTrader.Gui.NinjaScript.IndicatorRenderBase** objects representing the indicators on the chart.

## [Syntax](./indicators.md)

`<chartcontro`\>.Indicators\`

## [Examples](./indicators.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Instantiate a ChartObjectCollection to hold chartControl.Indicators
    ChartObjectCollection<NinjaTrader.Gui.NinjaScript.IndicatorRenderBase> indicatorCollection = chartControl.Indicators;

    // Print the Calculate setting for any configured indicators not using Calculate.OnBarClose
    foreach (NinjaTrader.Gui.NinjaScript.IndicatorRenderBase indicator in indicatorCollection)
    {
        if (indicator.Calculate != Calculate.OnBarClose)
            Print(String.Format("{0} is using Calculate.{1}", indicator.Name, indicator.Calculate.ToString()));
    }
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./indicators.md)
*   [Property Value](./indicators.md)
*   [Syntax](./indicators.md)
*   [Examples](./indicators.md)