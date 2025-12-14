**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Keltner Channel](./keltner_channel.md)

# Keltner Channel

# Keltner Channel

## [Description](./keltner_channel.md)

Keltner Channel indicator is based on volatility using a pair of values placed as an "envelope" around the data field.

## [Syntax](./keltner_channel.md)

`KeltnerChannel(double offsetMultiplier, int period)`

`KeltnerChannel(ISeries<double> input, double offsetMultiplier, int period)`

**Returns midline value**

`KeltnerChannel(double offsetMultiplier, int period)[int barsAgo]`

`KeltnerChannel(ISeries<double> input, double offsetMultiplier, int period)[int barsAgo]`

**Returns upper band value**

`KeltnerChannel(double offsetMultiplier, int period).Upper[int barsAgo]`

`KeltnerChannel(ISeries<double> input, double offsetMultiplier, int period).Upper[int barsAgo]`

**Returns lower band value**

`KeltnerChannel(double offsetMultiplier, int period).Lower[int barsAgo]`

`KeltnerChannel(ISeries<double> input, double offsetMultiplier, int period).Lower[int barsAgo]`

## [Return Value](./keltner_channel.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./keltner_channel.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./keltner_channel.md)

```csharp
// Prints the current upper value of a 20 period KeltnerChannel using default price type
double value = KeltnerChannel(1.5, 20).Upper[0];
Print("The current KeltnerChannel upper value is " + value.ToString());

// Prints the current lower value of a 20 period KeltnerChannel using high price type
double value = KeltnerChannel(High, 1.5, 20).Lower[0];
Print("The current KeltnerChannel lower value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./keltner_channel.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./keltner_channel.md)
*   [Syntax](./keltner_channel.md)
*   [Return Value](./keltner_channel.md)
*   [Parameters](./keltner_channel.md)
*   [Examples](./keltner_channel.md)
*   [Source Code](./keltner_channel.md)