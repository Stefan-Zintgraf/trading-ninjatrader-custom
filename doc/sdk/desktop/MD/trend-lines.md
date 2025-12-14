**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Trend Lines](./trend-lines.md)

# Trend Lines

# Trend Lines

## [Description](./trend-lines.md)

When a high swing is followed by a lower high swing, a trend line high is automatically plotted. When a low swing is followed by a higher low swing, a trend line low is automatically plotted.

## [Syntax](./trend-lines.md)

`TrendLines(int strength, int numberOfTrendLines, int oldTrendsOpacity, bool alertOnBreak)`

`TrendLines(ISeries<double> input, int strength, int numberOfTrendLines, int oldTrendsOpacity, bool alertOnBreak)`

## [Return Value](./trend-lines.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar

## [Parameters](./trend-lines.md)

Property

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

strength

The number of required bars to the left and right of the swing point

numberOfTrendLines

The number of recent trend lines to plot

oldTrendOpacity

The opacity to apply to old trend lines

alertOnBreak

Sets if there should be an alert when the price breaks the current trend line

## [Examples](./trend-lines.md)

```csharp
// Prints the current value of a 5 strength Trend Lines
double value = TrendLines(5, 4, 25, true)[0];
Print("The current Trend Lines value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./trend-lines.md)
*   [Syntax](./trend-lines.md)
*   [Return Value](./trend-lines.md)
*   [Parameters](./trend-lines.md)
*   [Examples](./trend-lines.md)