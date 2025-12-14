**Path**: [TradesPerformance](./tradesperformance.md) > [AverageTimeInMarket](./averagetimeinmarket.md)

# AverageTimeInMarket

# AverageTimeInMarket

## [Definition](./averagetimeinmarket.md)

Returns the average duration of a trade weighted by quantity.

## [Property Value](./averagetimeinmarket.md)

A TimeSpan value that represents the quantity\-weighted average duration of a trade.

## [Syntax](./averagetimeinmarket.md)

`TradesPerformance.AverageTimeInMarket`

## [Examples](./averagetimeinmarket.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the quantity-weighted average duration of all trades
     Print("Average time in market: " + SystemPerformance.AllTrades.TradesPerformance.AverageTimeInMarket);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averagetimeinmarket.md)
*   [Property Value](./averagetimeinmarket.md)
*   [Syntax](./averagetimeinmarket.md)
*   [Examples](./averagetimeinmarket.md)