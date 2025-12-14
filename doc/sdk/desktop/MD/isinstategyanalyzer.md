**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [IsInStrategyAnalyzer](./isinstategyanalyzer.md)

# IsInStrategyAnalyzer

# IsInStrategyAnalyzer

## [Definition](./isinstategyanalyzer.md)

Determines if the current **NinjaScript** Strategy is run from a Strategy Analyzer chart.

## [Property Value](./isinstategyanalyzer.md)

A bool value when true the strategy is being run from the Strategy Analyzer chart; otherwise will return false.

## [Syntax](./isinstategyanalyzer.md)

`IsInStrategyAnalyzer`

## [Examples](./isinstategyanalyzer.md)

```csharp
protected override void OnBarUpdate()
{
    // Only draw the ArrowUp on our condition if we're not in the Strategy Analyzer chart
    if (Close[0] > SMA(High, 14)[0] && !IsInStrategyAnalyzer)
        Draw.ArrowUp(this, CurrentBar.ToString(), true, 0, High[0] + TickSize, Brushes.Blue);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isinstategyanalyzer.md)
*   [Property Value](./isinstategyanalyzer.md)
*   [Syntax](./isinstategyanalyzer.md)
*   [Examples](./isinstategyanalyzer.md)