**Path**: [TradeCollection](./tradecollection.md) > [TradesCount](./tradescount.md)

# TradesCount

# TradesCount

## [Definition](./tradescount.md)

Returns the total # of trades.

## [Property Value](./tradescount.md)

A **double** value that represents the total # of trades.

## [Syntax](./tradescount.md)

`<tradecollection>.TradesPerformance.TradesCount`

## [Examples](./tradescount.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the total # of trades
    Print("Trades count is: " + SystemPerformance.AllTrades.TradesPerformance.TradesCount);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./tradescount.md)
*   [Property Value](./tradescount.md)
*   [Syntax](./tradescount.md)
*   [Examples](./tradescount.md)