**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Wiseman Awesome Oscillator](./wiseman_awesome_oscillator.md)

# Wiseman Awesome Oscillator

# Wiseman Awesome Oscillator

## [Description](./wiseman_awesome_oscillator.md)

The Wiseman Awesome Oscillator is a momentum indicator to identify trends and reversals. This indicator was provided by Profitunity: [http://www.profitunity.com](http://www.profitunity.com)

## [Syntax](./wiseman_awesome_oscillator.md)

`WisemanAwesomeOscillator()`

`WisemanAwesomeOscillator(ISeries<double> input)`

## [Return Value](./wiseman_awesome_oscillator.md)

*   **double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./wiseman_awesome_oscillator.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

## [Examples](./wiseman_awesome_oscillator.md)

```csharp
// Prints the current value of the Wiseman Awesome Oscillator
double value = WisemanAwesomeOscillator()[0];
Print("The current Wiseman Awesome Oscillator value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./wiseman_awesome_oscillator.md)
*   [Syntax](./wiseman_awesome_oscillator.md)
*   [Return Value](./wiseman_awesome_oscillator.md)
*   [Parameters](./wiseman_awesome_oscillator.md)
*   [Examples](./wiseman_awesome_oscillator.md)