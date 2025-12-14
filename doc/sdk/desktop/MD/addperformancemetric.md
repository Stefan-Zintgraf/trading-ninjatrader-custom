**Path**: [Strategy](./strategy.md) > [AddPerformanceMetric()](./addperformancemetric.md)

# AddPerformanceMetric()

# AddPerformanceMetric()

## [Definition](./addperformancemetric.md)

Adds an instance of custom **Performance Metric** to a strategy used in strategy calculations.

## [Method Return Value](./addperformancemetric.md)

This method does not return a value.

## [Syntax](./addperformancemetric.md)

`AddPerformanceMetric(PerformanceMetricBase performanceMetric)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This method should ONLY be called from the `OnStateChange()` method during State.Configure

## [Parameters](./addperformancemetric.md)

performanceMetric

The performance metric object to be added

## [Examples](./addperformancemetric.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.Configure)
     {
         AddPerformanceMetric(new NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit());
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./addperformancemetric.md)
*   [Method Return Value](./addperformancemetric.md)
*   [Syntax](./addperformancemetric.md)
*   [Parameters](./addperformancemetric.md)
*   [Examples](./addperformancemetric.md)