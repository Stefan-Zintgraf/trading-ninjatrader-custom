**Path**: [TradesPerformance](./tradesperformance.md) > [PerformanceMetrics](./performancemetrics.md)

# PerformanceMetrics

# PerformanceMetrics

## [Definition](./performancemetrics.md)

Returns a collection of custom **Performance Metrics**. These need to have been enabled in [Tools > Options > General](https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English.html?general_section.htm) to be able to use them.

## [Syntax](./performancemetrics.md)

`<tradecollection>.TradesPerformance.PerformanceMetrics`

## [Examples](./performancemetrics.md)

```csharp
protected override void OnBarUpdate()
{
     // Print out the number of enabled custom Performance Metrics
     Print("Number of Performance Metrics: "
         + SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics.Length);
 
     // Find a the value of a specific custom Performance Metric named "MyPerformanceMetric"
     for (int i = 0; i < SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics.Length; i++)
     {
         if (SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics[i] is 
               NinjaTrader.NinjaScript.PerformanceMetrics.MyPerformanceMetric)
         {
               Print((SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics[i] as 
                   NinjaTrader.NinjaScript.PerformanceMetrics.MyPerformanceMetric).Values[0]);
         }
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./performancemetrics.md)
*   [Syntax](./performancemetrics.md)
*   [Examples](./performancemetrics.md)