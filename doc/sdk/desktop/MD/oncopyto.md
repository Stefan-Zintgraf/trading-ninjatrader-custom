**Path**: [Performance Metrics](./performance_metrics.md) > [OnCopyTo()](./oncopyto.md)

# OnCopyTo()

# OnCopyTo()

## [Definition](./oncopyto.md)

Called as the values of a trade metric are saved.

## [Syntax](./oncopyto.md)

`protected override void OnCopyTo(PerformanceMetricBase target) { }`

## [Examples](./oncopyto.md)

```csharp
protected override void OnCopyTo(PerformanceMetricBase target)  
{  
   // You need to cast, in order to access the right type  
   SampleCumProfit targetMetrics = (target as SampleCumProfit);  
   if (targetMetrics != null)  
     Array.Copy(Values, targetMetrics.Values, Values.Length);  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./oncopyto.md)
*   [Syntax](./oncopyto.md)
*   [Examples](./oncopyto.md)