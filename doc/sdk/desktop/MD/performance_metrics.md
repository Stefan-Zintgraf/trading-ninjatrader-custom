**Path**: [Performance Metrics](./performance_metrics.md)

# Performance Metrics

# Performance Metrics

Custom Performance Metrics can be used when generating Trade Performance statistics.

Once custom performance metrics are created be sure to enable their usage in [Tools > Options > General](https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English.html?general_section.htm) or else they will not be available in the [Strategy Analyzer](https://ninjatrader.com/support/helpGuides/nt8/?strategy_analyzer.htm) or [Trade Performance](https://ninjatrader.com/support/helpguides/nt8/?trade_performance.htm) windows.

## [In this section](./performance_metrics.md)

Method

Description

[Format()](./format.md)

This method allows you to customize the rendering of the performance value on the Summary grid.

[OnAddTrade()](./onaddtrade.md)

This method is called as each trade is added.

[OnCopyTo()](./oncopyto.md)

Called as the values of a trade metric are saved.

[OnMergePerformanceMetric()](./onmergeperformancemetric.md)

This method is called when the Performance Metric would be aggregated and merged together.

[PerformanceUnit](./performanceunit.md)

Enumeration defining each type of PerformanceUnit calculated by NinjaTrader. Used to store a value for this performance type in PerformanceMetrics.

[Values](./values.md)

The Values array holds an 5 values corresponding to each Cbi.PerformanceUnit.

#### ON THIS PAGE

*   [In this section](./performance_metrics.md)