**Path**: [Optimization Fitness](./optimization_fitness.md) > [OnCalculatePerformanceValue()](./oncalculateperformancevalue.md)

# OnCalculatePerformanceValue()

# OnCalculatePerformanceValue()

## [Definition](./oncalculateperformancevalue.md)

This method calculates the value for the Optimization Fitness.

## [Syntax](./oncalculateperformancevalue.md)

`protected override void OnCalculatePerformanceValue(StrategyBase strategy)`

## [Examples](./oncalculateperformancevalue.md)

```csharp
protected override void OnCalculatePerformanceValue(StrategyBase strategy)
{

     Value = strategy.SystemPerformance.AllTrades.TradesPerformance.Percent.Drawdown;

}
```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./oncalculateperformancevalue.md)
*   [Syntax](./oncalculateperformancevalue.md)
*   [Examples](./oncalculateperformancevalue.md)