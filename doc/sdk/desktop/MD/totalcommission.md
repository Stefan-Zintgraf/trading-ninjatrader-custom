**Path**: [TradesPerformance](./tradesperformance.md) > [TotalCommission](./totalcommission.md)

# TotalCommission

# TotalCommission

## [Definition](./totalcommission.md)

Returns the total commission.

## [Property Value](./totalcommission.md)

A **double** value that represents the total commission.

## [Syntax](./totalcommission.md)

`<tradecollection>.TradesPerformance.TotalCommission`

## [Examples](./totalcommission.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the total commission of all trades
     Print("Total commission is: " + SystemPerformance.AllTrades.TradesPerformance.TotalCommission);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./totalcommission.md)
*   [Property Value](./totalcommission.md)
*   [Syntax](./totalcommission.md)
*   [Examples](./totalcommission.md)