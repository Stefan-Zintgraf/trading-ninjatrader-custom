**Path**: [TradesPerformance](./tradesperformance.md) > [AverageBarsInTrade](./averagebarsintrade.md)

# AverageBarsInTrade

# AverageBarsInTrade

## [Definition](./averagebarsintrade.md)

Returns the average number of bars per trade.

## [Property Value](./averagebarsintrade.md)

A **double** value that represents the average number of bars per trade.

## [Syntax](./averagebarsintrade.md)

`TradesPerformance.AverageBarsInTrade`

## [Examples](./averagebarsintrade.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the average number of bars per trade of all trades
    Print("Average # bars per trade is: " + SystemPerformance.AllTrades.TradesPerformance.AverageBarsInTrade);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averagebarsintrade.md)
*   [Property Value](./averagebarsintrade.md)
*   [Syntax](./averagebarsintrade.md)
*   [Examples](./averagebarsintrade.md)