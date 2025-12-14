**Path**: [TradesPerformance](./tradesperformance.md) > [SharpeRatio](./sharperatio.md)

# SharpeRatio

# SharpeRatio

## [Definition](./sharperatio.md)

Returns the Sharpe ratio using a **risk free return**.

## [Property Value](./sharperatio.md)

A **double** value that represents the Sharpe ratio using a risk free return.

## [Syntax](./sharperatio.md)

`<tradecollection>.TradesPerformance.SharpeRatio`

## [Examples](./sharperatio.md)

```csharp
protected override void OnBarUpdate()
{
     // Set a 0% risk free return
     SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0;

     // Print out the Sharpe ratio of all trades based on a zero risk free return
     Print("Sharpe ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SharpeRatio);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./sharperatio.md)
*   [Property Value](./sharperatio.md)
*   [Syntax](./sharperatio.md)
*   [Examples](./sharperatio.md)