**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [StdDev](./stddev.md)

# StdDev

# StdDev

## [Definition](./stddev.md)

Returns the standard deviation of the collection on a per unit basis.

## [Property Value](./stddev.md)

A **double** value that represents the standard deviation of the collection on a per unit basis.

## [Syntax](./stddev.md)

`<tradecollection>.TradesPerformance.<tradesperformancevalues>.StdDev`

## [Examples](./stddev.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the standard deviation of all trades
     Print("Standard deviation of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.StdDev);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./stddev.md)
*   [Property Value](./stddev.md)
*   [Syntax](./stddev.md)
*   [Examples](./stddev.md)