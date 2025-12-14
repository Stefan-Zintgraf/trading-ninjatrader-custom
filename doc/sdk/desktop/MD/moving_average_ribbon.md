**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Moving Average Ribbon](./moving_average_ribbon.md)

# Moving Average Ribbon

# Moving Average Ribbon

## [Description](./moving_average_ribbon.md)

The Moving Average Ribbon is a series of incrementing moving averages.

## [Syntax](./moving_average_ribbon.md)

`MovingAverageribbon(RibbonMAType movingAverage, int basePeriod, int incrementalPeriod)`

`MovingAverageribbon(ISeries<double> input, RibbonMAType movingAverage, int basePeriod, int incrementalPeriod)`

**Returns the MovingAverage1 value (Replace the 1 with the desired moving average you want the value to return)**

`MovingAverageribbon(RibbonMAType movingAverage, int basePeriod, int incrementalPeriod).MovingAverage1[int barsAgo]`

`MovingAverageribbon(ISeries<double> input, RibbonMAType movingAverage, int basePeriod, int incrementalPeriod).MovingAverage1[int barsAgo]`

## [Return Value](./moving_average_ribbon.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./moving_average_ribbon.md)

input

RibbonMAType

basePeriod

incrementalPeriod

Indicator source data ([Series<`T`\>](./seriest.md))

Moving average to use for calculations

Number of bars used in the calculation for the fastest moving average

Number of bars to increase for the calculation in each additional moving average

## [Examples](./moving_average_ribbon.md)

```csharp
// Prints the current value of the 3rd moving average
double value = MovingAverageRibbon(RibbonMAType.Exponential, 10, 10).MovingAverage3[0];
Print("The current 3rd moving average's value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./moving_average_ribbon.md)
*   [Syntax](./moving_average_ribbon.md)
*   [Return Value](./moving_average_ribbon.md)
*   [Parameters](./moving_average_ribbon.md)
*   [Examples](./moving_average_ribbon.md)