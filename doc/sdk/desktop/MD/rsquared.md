**Path**: [TradesPerformance](./tradesperformance.md) > [RSquared](./rsquared.md)

# RSquared

# RSquared

## [Definition](./rsquared.md)

Returns the trade performance R\-Squared value.

## [Property Value](./rsquared.md)

A **double** value that represents the R\-Squared (R2)

## [Syntax](./rsquared.md)

`<tradecollection>.TradesPerformance.RSquared`

## [Examples](./rsquared.md)

```csharp
protected override void OnBarUpdate()
// Print out the R2 value of all trades
Print("R-Squared is: " + SystemPerformance.AllTrades.TradesPerformance.RSquared);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./rsquared.md)
*   [Property Value](./rsquared.md)
*   [Syntax](./rsquared.md)
*   [Examples](./rsquared.md)