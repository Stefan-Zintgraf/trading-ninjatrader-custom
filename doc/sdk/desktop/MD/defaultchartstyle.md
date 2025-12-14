**Path**: [Bars Type](./bars_type.md) > [DefaultChartStyle](./defaultchartstyle.md)

# DefaultChartStyle

# DefaultChartStyle

## [Definition](./defaultchartstyle.md)

Allows to set a default ChartStyle for usage with a NinjaTrader bars type

## [Property Value](./defaultchartstyle.md)

A **ChartStyleType** enum value representing the [ChartStyle](./chartstyletype.md) to be set as default. System defaults include:

*   **ChartStyleType.Box**
*   **ChartStyleType.CandleStick**
*   **ChartStyleType.LineOnClose**
*   **ChartStyleType.OHLC**
*   **ChartStyleType.PointAndFigure**
*   **ChartStyleType.KagiLine**
*   **ChartStyleType.OpenClose**
*   **ChartStyleType.Mountain**

## [Syntax](./defaultchartstyle.md)

`DefaultChartStyle`

## [Examples](./defaultchartstyle.md)

```csharp

protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name                     = "SampleBarsType";
        BarsPeriod               = new BarsPeriod { BarsPeriodType = (BarsPeriodType) 15, BarsPeriodTypeName = "SampleBarsType(15)", Value = 1 };
        BuiltFrom                = BarsPeriodType.Minute;
        DaysToLoad               = 5;
        DefaultChartStyle        = Gui.Chart.ChartStyleType.CandleStick;
        IsIntraday               = true;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./defaultchartstyle.md)
*   [Property Value](./defaultchartstyle.md)
*   [Syntax](./defaultchartstyle.md)
*   [Examples](./defaultchartstyle.md)