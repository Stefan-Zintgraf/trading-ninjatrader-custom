**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [ChartIndicators](./chartindicators.md)

# ChartIndicators

# ChartIndicators

## [Definition](./chartindicators.md)

Contains a collection of Indicators which have been added to the strategy instance using **AddChartIndicator()**.

## [Property Value](./chartindicators.md)

An **Indicator** object

## [Syntax](./chartindicators.md)

`ChartIndicators[int index]`

## [Examples](./chartindicators.md)

```csharp
if (State == State.DataLoaded)
{
   AddChartIndicator(SMA(20));
   
   // Set the plots color for the added indicator 
   ChartIndicators[0].Plots[0].Brush = Brushes.Blue;
   
   // Set the added indicator to panel 1 (specified index needs to be >= 1)
   ChartIndicators[0].Panel = 1;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartindicators.md)
*   [Property Value](./chartindicators.md)
*   [Syntax](./chartindicators.md)
*   [Examples](./chartindicators.md)