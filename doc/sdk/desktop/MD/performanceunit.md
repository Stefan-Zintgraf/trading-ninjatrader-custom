**Path**: [Performance Metrics](./performance_metrics.md) > [PerformanceUnit](./performanceunit.md)

# PerformanceUnit

# PerformanceUnit

## [Definition](./performanceunit.md)

Enumeration defining each type of **PerformanceUnit** calculated by **NinjaTrader**. Used to store a value for this performance type in **PerformanceMetrics**.

## [Syntax](./performanceunit.md)

`PerformanceUnit.Currency`

`PerformanceUnit.Percent`

`PerformanceUnit.Pips`

`PerformanceUnit.Points`

`PerformanceUnit.Ticks`

## [Examples](./performanceunit.md)

```csharp
//Prints unrealized PnL in ticks at the close of each bar
Print(Position.GetUnrealizedProfitLoss(PerformanceUnit.Ticks, Close[0]));

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./performanceunit.md)
*   [Syntax](./performanceunit.md)
*   [Examples](./performanceunit.md)