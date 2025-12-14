**Path**: [TradesPerformance](./tradesperformance.md) > [TotalSlippage](./totalslippage.md)

# TotalSlippage

# TotalSlippage

## [Definition](./totalslippage.md)

Returns the total slippage.

## [Property Value](./totalslippage.md)

A **double** value that represents the total slippage. This is presented in points, I.E. 0.25 for 1 execution on E\-mini S&P 500 Futures.

## [Syntax](./totalslippage.md)

`<tradecollection>.TradesPerformance.TotalSlippage`

## [Examples](./totalslippage.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the total slippage of all trades
     Print("Total slippage is: " + SystemPerformance.AllTrades.TradesPerformance.TotalSlippage);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./totalslippage.md)
*   [Property Value](./totalslippage.md)
*   [Syntax](./totalslippage.md)
*   [Examples](./totalslippage.md)