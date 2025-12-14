**Path**: [Market Analyzer Column](./market_analyzer_column.md) > [CurrentValue](./currentvalue.md)

# CurrentValue

# CurrentValue

## [Definition](./currentvalue.md)

The value to be displayed in the Market Analyzer Column

## [Property Value](./currentvalue.md)

A double representing the value to be displayed in the column

## [Syntax](./currentvalue.md)

`CurrentValue`

## [Examples](./currentvalue.md)

```csharp
protected override void OnMarketData(Data.MarketDataEventArgs marketDataUpdate)
{
     CurrentValue = marketDataUpdate.Price;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./currentvalue.md)
*   [Property Value](./currentvalue.md)
*   [Syntax](./currentvalue.md)
*   [Examples](./currentvalue.md)