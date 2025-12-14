**Path**: [TradesPerformance](./tradesperformance.md) > [RiskFreeReturn](./riskfreereturn.md)

# RiskFreeReturn

# RiskFreeReturn

## [Definition](./riskfreereturn.md)

The risk free return used in calculations of **Sharpe** and **Sortino** ratios.

## [Property Value](./riskfreereturn.md)

A **double** value that represents the risk free return.

## [Syntax](./riskfreereturn.md)

`<tradecollection>.TradesPerformance.RiskFreeReturn`

## [Examples](./riskfreereturn.md)

```csharp
protected override void OnBarUpdate()
{
     // Set a 3.5% risk free return
     SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0.035;

     // Print out the Sharpe ratio of all trades based on a 3.5% risk free return
     Print("Sharpe ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SharpeRatio);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./riskfreereturn.md)
*   [Property Value](./riskfreereturn.md)
*   [Syntax](./riskfreereturn.md)
*   [Examples](./riskfreereturn.md)