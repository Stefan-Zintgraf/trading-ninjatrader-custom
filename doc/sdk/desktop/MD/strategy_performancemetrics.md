**Path**: [Unmanaged Approach](./unmanaged_approach.md) > [PerformanceMetrics](./strategy_performancemetrics.md)

# PerformanceMetrics

# PerformanceMetrics

## [Definition](./strategy_performancemetrics.md)

Holds an array of **PerformanceMetrics** objects that represent custom metrics that can be used for strategy calculations.

Index value is based on the array of Bars objects added via the **AddPerformanceMetric** method.

## [Property Value](./strategy_performancemetrics.md)

An array of **PerformanceMetrics** objects.

## [Syntax](./strategy_performancemetrics.md)

`PerformanceMetrics[int index]`

## [Examples](./strategy_performancemetrics.md)

```csharp
// Define a new SampleCumProfit object
NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit myProfit;
protected override void OnStateChange()
{
   if (State == State.Configure)
   {
     // Instantiate myProfit to a new instance of SampleCumProfit
     myProfit = new NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit();
      
     // Use AddPerformanceMetric to add myProfit to the strategy
     AddPerformanceMetric(myProfit);
   }
}
protected override void OnBarUpdate()
{
   // Print a string representing the Type of the performance metric at Index 0 of the PerformanceMetrics collection
   Print(PerformanceMetrics[0]);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./strategy_performancemetrics.md)
*   [Property Value](./strategy_performancemetrics.md)
*   [Syntax](./strategy_performancemetrics.md)
*   [Examples](./strategy_performancemetrics.md)