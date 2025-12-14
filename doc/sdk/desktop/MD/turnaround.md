**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [Turnaround](./turnaround.md)

# Turnaround

# Turnaround

## [Definition](./turnaround.md)

Returns the amount of turnaround.

## [Property Value](./turnaround.md)

A **double** value that represents the amount of turnaround.

## [Syntax](./turnaround.md)

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.Turnaround`

## [Examples](./turnaround.md)

```csharp
protected override void OnBarUpdate()  
{  
    // Print out the turnaround of all trades  
    Print("Turnaround of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Turnaround);  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./turnaround.md)
*   [Property Value](./turnaround.md)
*   [Syntax](./turnaround.md)
*   [Examples](./turnaround.md)