**Path**: [TradesPerformance](./tradesperformance.md) > [MaxTimeToRecover](./maxtimetorecover.md)

# MaxTimeToRecover

# MaxTimeToRecover

## [Definition](./maxtimetorecover.md)

Returns the maximum time to recover from a draw down.

## [Property Value](./maxtimetorecover.md)

A **TimeSpan** value that represents the maximum time to recover from a draw down.

## [Syntax](./maxtimetorecover.md)

`<tradecollection>.TradesPerformance.MaxTimeToRecover`

## [Examples](./maxtimetorecover.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the maximum time to recover from a draw down
     Print("Max time to recover is: " + SystemPerformance.AllTrades.TradesPerformance.MaxTimeToRecover);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./maxtimetorecover.md)
*   [Property Value](./maxtimetorecover.md)
*   [Syntax](./maxtimetorecover.md)
*   [Examples](./maxtimetorecover.md)