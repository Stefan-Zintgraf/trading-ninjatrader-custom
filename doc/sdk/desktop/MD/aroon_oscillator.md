**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Aroon Oscillator](./aroon_oscillator.md)

# Aroon Oscillator

# Aroon Oscillator

## [Description](./aroon_oscillator.md)

A trend\-following indicator that uses aspects of the Aroon indicator ("Aroon up" and "Aroon down") to gauge the strength of a current trend and the likelihood that it will continue. The Aroon oscillator is calculated by subtracting Aroon down from Aroon up. Readings above zero indicate that an uptrend is present, while readings below zero indicate that a downtrend is present.

Courtesy of [Investopedia](http://investopedia.com/terms/a/aroonoscillator.asp)

## [Syntax](./aroon_oscillator.md)

`AroonOscillator(int period)`

`AroonOscillator(ISeries<double> input, int period)`

**Returns default value**

`AroonOscillator(int period)[int barsAgo]`

`AroonOscillator(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./aroon_oscillator.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./aroon_oscillator.md)

Parameter

Description

input

Indicator source data

period

Number of bars used in the calculation

## [Examples](./aroon_oscillator.md)

```csharp
// Prints the current values of a 20 period AroonOscillator using default price type
double upValue = AroonOscillator(20)[0];
Print("The current AroonOscillator value is " + upValue.ToString());

// Prints the current values of a 20 period AroonOscillator using high price type
double upValue = AroonOscillator(High, 20)[0];
Print("The current AroonOscillator value is " + upValue.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./aroon_oscillator.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./aroon_oscillator.md)
*   [Syntax](./aroon_oscillator.md)
*   [Return Value](./aroon_oscillator.md)
*   [Parameters](./aroon_oscillator.md)
*   [Examples](./aroon_oscillator.md)
*   [Source Code](./aroon_oscillator.md)