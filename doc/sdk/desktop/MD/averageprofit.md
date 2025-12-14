**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [AverageProfit](./averageprofit.md)

# AverageProfit

# AverageProfit

## [Definition](./averageprofit.md)

Returns the average profit of the collection.

## [Property Value](./averageprofit.md)

A **double** value that represents the average profit of the collection.

## [Syntax](./averageprofit.md)

`TradesPerformance.TradesPerformanceValues.AverageProfit`

## [Examples](./averageprofit.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the average profit of all trades in currency
     Print("Average profit of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./averageprofit.md)
*   [Property Value](./averageprofit.md)
*   [Syntax](./averageprofit.md)
*   [Examples](./averageprofit.md)