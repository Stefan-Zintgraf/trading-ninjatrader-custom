**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Ease of Movement](./ease_of_movement.md)

# Ease of Movement

# Ease of Movement

## [Description](./ease_of_movement.md)

The Ease of Movement indicator was designed to illustrate the relationship between volume and price change. It shows how much volume is required to move prices.

High Ease of Movement values occur when prices are moving upward with light volume. Low values occur when prices are moving downward on light volume. If prices are not moving or if heavy volume is required to move prices then the indicator will read near zero. A buy signal is produced when it crosses above zero. A sell signal is produced when the indicator crosses below zero (prices are moving downward more easily).

## [Syntax](./ease_of_movement.md)

`EaseOfMovement(int smoothing, int volumeDivisor)`

`EaseOfMovement(ISeries<double> input, int smoothing, int volumeDivisor)`

**Returns default value**

`EaseOfMovement(int smoothing, int volumeDivisor)[int barsAgo]`

`EaseOfMovement(ISeries<double> input, int smoothing, int volumeDivisor)[int barsAgo]`

## [Return Value](./ease_of_movement.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./ease_of_movement.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

smoothing

The number of bars used to smooth the signal

volumeDivisor

The value used to calculate the box ratio

## [Examples](./ease_of_movement.md)

```csharp
// Prints the current value of Ease of Movement using default price type
double value = EaseOfMovement(14, 10000)[0];
Print("The current Ease of Movement value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./ease_of_movement.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./ease_of_movement.md)
*   [Syntax](./ease_of_movement.md)
*   [Return Value](./ease_of_movement.md)
*   [Parameters](./ease_of_movement.md)
*   [Examples](./ease_of_movement.md)
*   [Source Code](./ease_of_movement.md)