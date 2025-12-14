**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Volume Oscillator](./volume_oscillator.md)

# Volume Oscillator

# Volume Oscillator

## [Description](./volume_oscillator.md)

The Volume Oscillator uses the difference between two [moving averages](./moving_average_simple_sma.md) of [volume](./volume.md) to determine if the trend is increasing or decreasing. A value above zero indicates that the shorter term volume moving average has risen above the longer term volume moving average. This indicates that the shorter term trend is higher than the longer term trend. Rising prices with with increased short term volume is bullish as is falling prices with decreased volume. Falling prices with increased volume or rising prices with decreased volume indicate market weakness.

## [Syntax](./volume_oscillator.md)

`VolumeOscillator(int fast, int slow)`

`VolumeOscillator(ISeries<double> input, int fast, int slow)`

**Returns default value**

`VolumeOscillator(int fast, int slow)[int barsAgo]`

`VolumeOscillator(ISeries<double> input, int fast, int slow) [int barsAgo]`

## [Return Value](./volume_oscillator.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./volume_oscillator.md)

Parameter

Description

fast

The number of bars to include in the short term moving average

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

slow

The number of bars to include in the long term moving average

## [Example](./volume_oscillator.md)

```csharp
// Prints the current value of a Volume Oscillator  
double value = VolumeOscillator(12, 26)[0];  
Print("The current Volume Oscillator value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./volume_oscillator.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./volume_oscillator.md)
*   [Syntax](./volume_oscillator.md)
*   [Return Value](./volume_oscillator.md)
*   [Parameters](./volume_oscillator.md)
*   [Example](./volume_oscillator.md)
*   [Source Code](./volume_oscillator.md)