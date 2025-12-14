**Path**: [Performance Metrics](./performance_metrics.md) > [OnMergePerformanceMetric()](./onmergeperformancemetric.md)

# OnMergePerformanceMetric()

# OnMergePerformanceMetric()

## [Definition](./onmergeperformancemetric.md)

This method is called when the Performance Metric would be aggregated and merged together (E.g. on the Strategy Analyzer's total row).

## [Syntax](./onmergeperformancemetric.md)

`protected override void OnMergePerformanceMetric(PerformanceMetricBase merge)`

## [Examples](./onmergeperformancemetric.md)

```csharp
protected override void OnMergePerformanceMetric(PerformanceMetricBase target)
{
   // You need to cast, in order to access the right type
   SampleCumProfit targetMetrics = (target as SampleCumProfit);

   // This is just a simple weighted average sample
   if (targetMetrics != null && TradesPerformance.TradesCount + targetMetrics.TradesPerformance.TradesCount > 0)
     for (int i = 0; i < Values.Length; i++)
         targetMetrics.Values[i] = (targetMetrics.Values[i] *targetMetrics.TradesPerformance.TradesCount + Values[i]* TradesPerformance.TradesCount) / (TradesPerformance.TradesCount + targetMetrics.TradesPerformance.TradesCount);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onmergeperformancemetric.md)
*   [Syntax](./onmergeperformancemetric.md)
*   [Examples](./onmergeperformancemetric.md)