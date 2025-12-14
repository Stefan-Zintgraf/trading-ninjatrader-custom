**Path**: [TradesPerformance](./tradesperformance.md) > [SortinoRatio](./sortinoratio.md)

# SortinoRatio

# SortinoRatio

## [Definition](./sortinoratio.md)

Returns the Sortino ratio using a **risk free return**.

## [Property Value](./sortinoratio.md)

A **double** value that represents the Sortino ratio using a risk free return.

## [Syntax](./sortinoratio.md)

`<tradecollection>.TradesPerformance.SortinoRatio`

## [Examples](./sortinoratio.md)

```csharp
protected override void OnBarUpdate()
{
     // Set a 0% risk free return
     SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0;

     // Print out the Sortino ratio of all trades based on a zero risk free return
     Print("Sortino ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SortinoRatio);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./sortinoratio.md)
*   [Property Value](./sortinoratio.md)
*   [Syntax](./sortinoratio.md)
*   [Examples](./sortinoratio.md)