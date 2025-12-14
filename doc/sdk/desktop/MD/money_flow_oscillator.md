**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Money Flow Oscillator](./money_flow_oscillator.md)

# Money Flow Oscillator

# Money Flow Oscillator

## [Description](./money_flow_oscillator.md)

The Money Flow Oscillator measures the amount of money flow volume over a specific period. A move into positive territory indicates buying pressure while a move into negative territory indicates selling pressure.

## [Syntax](./money_flow_oscillator.md)

`MoneyFlowOscillator(int period)`

`MoneyFlowOscillator(ISeries<double> input, int period)`

## [Return Value](./money_flow_oscillator.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./money_flow_oscillator.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./money_flow_oscillator.md)

```csharp
// Prints the current value of a 10 period Money Flow Oscillator
double value = MoneyFlowOscillator(10)[0];
Print("The current Money Flow Oscillator value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./money_flow_oscillator.md)
*   [Syntax](./money_flow_oscillator.md)
*   [Return Value](./money_flow_oscillator.md)
*   [Parameters](./money_flow_oscillator.md)
*   [Examples](./money_flow_oscillator.md)