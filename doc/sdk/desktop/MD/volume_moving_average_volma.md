**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Volume Moving Average (VOLMA)](./volume_moving_average_volma.md)

# Volume Moving Average (VOLMA)

# Volume Moving Average (VOLMA)

## [Description](./volume_moving_average_volma.md)

The Volume Moving Average indicator is an indicator on indicator implementation. It calculates and returns the value of an [exponential moving average](./moving_average_exponential_ema.md) of [volume](./volume.md).

## [Syntax](./volume_moving_average_volma.md)

`VOLMA(int period)`

`VOLMA(ISeries<double> input, int period)`

**Returns default value**

`VOLMA[int period] (int barsAgo)`

`VOLMA[ISeries<`double`> input, int period] (int barsAgo)`

## [Return Value](./volume_moving_average_volma.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./volume_moving_average_volma.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Example](./volume_moving_average_volma.md)

```csharp
// Evaluates if the current volume is greater than the 20 period EMA of volume  
if (Volume[0] > VOLMA(20)[0])  
  Print("Volume has risen above its 20 period average");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./volume_moving_average_volma.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./volume_moving_average_volma.md)
*   [Syntax](./volume_moving_average_volma.md)
*   [Return Value](./volume_moving_average_volma.md)
*   [Parameters](./volume_moving_average_volma.md)
*   [Example](./volume_moving_average_volma.md)
*   [Source Code](./volume_moving_average_volma.md)