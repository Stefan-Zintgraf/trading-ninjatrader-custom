**Path**: [TradesPerformance](./tradesperformance.md) > [GrossProfit](./grossprofit.md)

# GrossProfit

# GrossProfit

## [Definition](./grossprofit.md)

Returns the gross profit.

## [Property Value](./grossprofit.md)

A **double** value that represents the gross profit.

## [Syntax](./grossprofit.md)

`<tradecollection>.TradesPerformance.GrossProfit`

## [Examples](./grossprofit.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the gross profit of all trades
    Print("Gross profit is: " + SystemPerformance.AllTrades.TradesPerformance.GrossProfit);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./grossprofit.md)
*   [Property Value](./grossprofit.md)
*   [Syntax](./grossprofit.md)
*   [Examples](./grossprofit.md)