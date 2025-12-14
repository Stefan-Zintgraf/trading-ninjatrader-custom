**Path**: [TradesPerformance](./tradesperformance.md) > [ProfitFactor](./profitfactor.md)

# ProfitFactor

# ProfitFactor

## [Definition](./profitfactor.md)

Returns the profit factor.

## [Property Value](./profitfactor.md)

A **double** value that represents the profit factor.

## [Syntax](./profitfactor.md)

`<tradecollection>.TradesPerformance.ProfitFactor`

## [Examples](./profitfactor.md)

```csharp
protected override void OnBarUpdate()
{
    // Print out the profit factor of all trades
    Print("Profit factor is: " + SystemPerformance.AllTrades.TradesPerformance.ProfitFactor);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./profitfactor.md)
*   [Property Value](./profitfactor.md)
*   [Syntax](./profitfactor.md)
*   [Examples](./profitfactor.md)