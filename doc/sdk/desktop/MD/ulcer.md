**Path**: [TradesPerformanceValues](./tradesperformancevalues.md) > [Ulcer](./ulcer.md)

# Ulcer

# Ulcer

## [Definition](./ulcer.md)

Returns the Ulcer.

## [Property Value](./ulcer.md)

A **double** value that represents the Ulcer.

## [Syntax](./ulcer.md)

`<TradeCollection>.TradesPerformance.<`TradesPerformanceValues>.Ulcer\`

## [Examples](./ulcer.md)

```csharp
protected override void OnBarUpdate()  
{  
    // Print out the Ulcer index of all trades  
    Print("Turnaround of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Ulcer);  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ulcer.md)
*   [Property Value](./ulcer.md)
*   [Syntax](./ulcer.md)
*   [Examples](./ulcer.md)