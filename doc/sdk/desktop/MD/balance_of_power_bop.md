**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Balance of Power (BOP)](./balance_of_power_bop.md)

# Balance of Power (BOP)

# Balance of Power (BOP)

## [Description](./balance_of_power_bop.md)

The balance of power (BOP) indicator measures the strength of the bulls vs. bears by assessing the ability of each to push price to an extreme level.

## [Syntax](./balance_of_power_bop.md)

`BOP(int smooth)`

`BOP(ISeries<double> input, int smooth)`

**Returns default value**

`BOP(int smooth)[int barsAgo]`

`BOP(ISeries<double> input, int smooth)[int barsAgo]`

## [Return Value](./balance_of_power_bop.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./balance_of_power_bop.md)

input

Indicator source data

smooth

The smoothing period

## [Example](./balance_of_power_bop.md)

```csharp
// Prints the current value of BOP using default price type and 3 period smoothing
double value = BOP(3)[0];
Print("The current BOP value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./balance_of_power_bop.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./balance_of_power_bop.md)
*   [Syntax](./balance_of_power_bop.md)
*   [Return Value](./balance_of_power_bop.md)
*   [Parameters](./balance_of_power_bop.md)
*   [Example](./balance_of_power_bop.md)
*   [Source Code](./balance_of_power_bop.md)