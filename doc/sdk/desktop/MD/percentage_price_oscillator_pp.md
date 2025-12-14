**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Percentage Price Oscillator (PPO)](./percentage_price_oscillator_pp.md)

# Percentage Price Oscillator (PPO)

# Percentage Price Oscillator (PPO)

## [Description](./percentage_price_oscillator_pp.md)

The Percentage Price Oscillator shows the percentage difference between two **exponential moving averages**.

## [Syntax](./percentage_price_oscillator_pp.md)

`PPO(int fast, int slow, int smooth)`

`PPO(ISeries<double> input, int fast, int slow, int smooth)`

**Returns default value**

`PPO(int fast, int slow, int smooth)[int barsAgo]`

`PPO(ISeries<double> input, int fast, int slow, int smooth)[int barsAgo]`

**Returns smoothed value**

`PPO(int fast, int slow, int smooth).Smoothed[int barsAgo]`

`PPO(ISeries<double> input, int fast, int slow, int smooth).Smoothed[int barsAgo]`

## [Return Value](./percentage_price_oscillator_pp.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./percentage_price_oscillator_pp.md)

fast

The number of bars to calculate the fast EMA

input

Indicator source data ([Series<`T`\>](./seriest.md))

slow

The number of bars to calculate the slow EMA

smooth

The number of bars to calculate the EMA signal line

## [Examples](./percentage_price_oscillator_pp.md)

```csharp
// Prints the current value of a 20 period Percentage Price Oscillator
double value = PPO(12, 26, 9)[0];
Print("The current Percentage Price Oscillator value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./percentage_price_oscillator_pp.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./percentage_price_oscillator_pp.md)
*   [Syntax](./percentage_price_oscillator_pp.md)
*   [Return Value](./percentage_price_oscillator_pp.md)
*   [Parameters](./percentage_price_oscillator_pp.md)
*   [Examples](./percentage_price_oscillator_pp.md)
*   [Source Code](./percentage_price_oscillator_pp.md)