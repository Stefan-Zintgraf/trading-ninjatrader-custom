**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Donchian Channel](./donchian_channel.md)

# Donchian Channel

# Donchian Channel

## [Description](./donchian_channel.md)

A moving average indicator developed by Richard Donchian. It plots the highest high and lowest low over a specific period.

## [Syntax](./donchian_channel.md)

`DonchianChannel(int period)`

`DonchianChannel(ISeries<double> input, int period)`

\*\*Returns mean value (middle band) at a specified bar index \*\*

`DonchianChannel(int period)[int barsAgo]`

`DonchianChannel(ISeries<double> input, int period)[int barsAgo]`

\*\*Returns upper band value at a specified bar index \*\*

`DonchianChannel(int period).Upper[int barsAgo]`

`DonchianChannel(ISeries<double> input, int period).Upper[int barsAgo]`

**Returns lower band value at a specified bar index**

`DonchianChannel(int period).Lower[int barsAgo]`

`DonchianChannel(ISeries<double> input, int period).Lower[int barsAgo]`

## [Return Value](./donchian_channel.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./donchian_channel.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./donchian_channel.md)

```csharp
// Prints the current upper value of a 20 period DonchianChannel using default price type
double value = DonchianChannel(20).Upper[0];
Print("The current DonchianChannel upper value is " + value.ToString());

// Note the above call with a barsAgo of 0 includes the current Upper channel in the value. If we want to check for example for a break of this value, storing the last bar's channel value would be needed.
double value = DonchianChannel(20).Upper[1];
if (High[0] > value)
 Draw.ArrowUp(this, CurrentBar.ToString(), true, 0, Low[0] - TickSize, Brushes.Blue);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./donchian_channel.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./donchian_channel.md)
*   [Syntax](./donchian_channel.md)
*   [Return Value](./donchian_channel.md)
*   [Parameters](./donchian_channel.md)
*   [Examples](./donchian_channel.md)
*   [Source Code](./donchian_channel.md)