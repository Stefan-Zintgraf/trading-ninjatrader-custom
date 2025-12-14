**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Chande Momentum Oscillator (CMO)](./chande_momentum_oscillator_cmo.md)

# Chande Momentum Oscillator (CMO)

# Chande Momentum Oscillator (CMO)

## [Description](./chande_momentum_oscillator_cmo.md)

The Chande Momentum Oscillator was developed by Tushar S. Chande and is described in the 1994 book The New Technical Trader by Tushar S. Chande and Stanley Kroll. This indicator is a modified **RSI**. Where the **RSI** divides the upward movement by the net movement (up / (up + down)), the **CMO** divides the total movement by the net movement ((up \- down) / (up + down)). Values under \-50 indicate oversold conditions while values over 50 indicate overbought conditions.

## [Syntax](./chande_momentum_oscillator_cmo.md)

`CMO(int period)`

`CMO(ISeries<double> input, int period)`

**Returns default value**

`CMO(int period)[int barsAgo]`

`CMO(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./chande_momentum_oscillator_cmo.md)

**double;** Accessing this method via an index value \[int barsAgo\] returns the indicator value of the referenced bar.

## [Parameters](./chande_momentum_oscillator_cmo.md)

input

Indicator source data ([**Series<`T`\>**](./seriest.md))

period

The number of bars to include in the calculation

## [Examples](./chande_momentum_oscillator_cmo.md)

```csharp
// Prints the current value of a 20 period CMO using default price type
double value = CMO(20)[0];
Print("The current CMO value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// Prints the current value of a 20 period CMO using high price type
double value = CMO(High, 20)[0];
Print("The current CMO value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./chande_momentum_oscillator_cmo.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./chande_momentum_oscillator_cmo.md)
*   [Syntax](./chande_momentum_oscillator_cmo.md)
*   [Return Value](./chande_momentum_oscillator_cmo.md)
*   [Parameters](./chande_momentum_oscillator_cmo.md)
*   [Examples](./chande_momentum_oscillator_cmo.md)
*   [Source Code](./chande_momentum_oscillator_cmo.md)