**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [ProfitPerMonth](./profitpermonth.md)

# ProfitPerMonth

# ProfitPerMonth

## [Definition](./profitpermonth.md)

Returns the profit per month of the collection. This value is always returned as a percentage.

## [Property Value](./profitpermonth.md)

A **double** value that represents the profit per month of the collection as a percentage.

## [Syntax](./profitpermonth.md)

`<tradecollection>.TradesPerformance.<tradesperformancevalues>.ProfitPerMonth`

## [Examples](./profitpermonth.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the profit per month of all trades
     Print("Profit per month of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.ProfitPerMonth);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./profitpermonth.md)
*   [Property Value](./profitpermonth.md)
*   [Syntax](./profitpermonth.md)
*   [Examples](./profitpermonth.md)