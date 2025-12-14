**Path**: [TradesPerformance](./tradesperformance.md) > [MonthlyUlcer](./monthlyulcer.md)

# MonthlyUlcer

# MonthlyUlcer

## [Definition](./monthlyulcer.md)

Returns the monthly Ulcer index.

## [Property Value](./monthlyulcer.md)

A **double** value that represents the monthly Ulcer index.

## [Syntax](./monthlyulcer.md)

`<tradecollection>.TradesPerformance.MonthlyUlcer`

## [Examples](./monthlyulcer.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the monthly Ulcer index
     Print("Monthly Ulcer index is: " + SystemPerformance.AllTrades.TradesPerformance.MonthlyUlcer);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./monthlyulcer.md)
*   [Property Value](./monthlyulcer.md)
*   [Syntax](./monthlyulcer.md)
*   [Examples](./monthlyulcer.md)