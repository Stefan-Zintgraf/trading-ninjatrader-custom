**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [CumProfit](./cumprofit.md)

# CumProfit

# CumProfit

## [Definition](./cumprofit.md)

Returns the cumulative profit of the collection.

## [Property Value](./cumprofit.md)

A **double** value that represents the cumulative profit of the collection.

## [Syntax](./cumprofit.md)

`<tradecollection>.TradesPerformance.<`tradesperformancevalues>.CumProfit\`

## [Examples](./cumprofit.md)

```csharp
// Print out the cumulative profit of all trades in currency
protected override void OnBarUpdate()
{
    // Print out the cumulative profit of all trades in currency
    Print("Average cumulative profit of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.CumProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./cumprofit.md)
*   [Property Value](./cumprofit.md)
*   [Syntax](./cumprofit.md)
*   [Examples](./cumprofit.md)