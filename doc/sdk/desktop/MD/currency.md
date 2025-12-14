**Path**: [TradesPerformance](./tradesperformance.md) > [Currency](./currency.md)

# Currency

# Currency

## [Definition](./currency.md)

Returns a **TradesPerformanceValues** object in currency.

## [Property Value](./currency.md)

A **TradesPerformanceValues** object that is represented in currency.

## [Syntax](./currency.md)

`<tradecollection>.TradesPerformance.Currency`

## [Examples](./currency.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the avg. profit of all trades in currency
    Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./currency.md)
*   [Property Value](./currency.md)
*   [Syntax](./currency.md)
*   [Examples](./currency.md)