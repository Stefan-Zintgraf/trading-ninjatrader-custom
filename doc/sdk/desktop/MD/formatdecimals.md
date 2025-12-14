**Path**: [Market Analyzer Column](./market_analyzer_column.md) > [FormatDecimals](./formatdecimals.md)

# FormatDecimals

# FormatDecimals

## [Definition](./formatdecimals.md)

Rounds the value contained in **CurrentValue** to a specified number of decimal places before displaying it in the Market Analyzer column.

## [Property Value](./formatdecimals.md)

An int representing a number of decimal places to which to round **CurrentValue**.

## [Syntax](./formatdecimals.md)

`FormatDecimals`

## [Examples](./formatdecimals.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Round CurrentValue to one decimal place
        FormatDecimals = 1;
    }
}

protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)
{
    CurrentValue = marketDataUpdate.Price;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./formatdecimals.md)
*   [Property Value](./formatdecimals.md)
*   [Syntax](./formatdecimals.md)
*   [Examples](./formatdecimals.md)