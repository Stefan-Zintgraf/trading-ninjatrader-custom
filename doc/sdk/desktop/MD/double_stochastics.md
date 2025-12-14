**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Double Stochastics](./double_stochastics.md)

# Double Stochastics

# Double Stochastics

## [Description](./double_stochastics.md)

Double Stochastics is a variation of the **Stochastics** indicator developed by William Blau.

## [Syntax](./double_stochastics.md)

`DoubleStochastics(int period)`

`DoubleStochastics(ISeries<double> input, int period)`

**Returns default value**

`DoubleStochastics(int period)[int barsAgo]`

`DoubleStochastics(ISeries<double> input, int period)[int barsAgo]`

**Returns %K value**

`DoubleStochastics(int period).K[int barsAgo]`

`DoubleStochastics(ISeries<double> input, int period).K[int barsAgo]`

## [Return Value](./double_stochastics.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./double_stochastics.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./double_stochastics.md)

```csharp
// Prints the current value
double value = DoubleStochastics(10)[0];
Print("The current Double Stochastics value is " + value.ToString());


// Prints the current %K value
double value = DoubleStochastics(10).K[0];
Print("The current Double Stochastics %K value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./double_stochastics.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./double_stochastics.md)
*   [Syntax](./double_stochastics.md)
*   [Return Value](./double_stochastics.md)
*   [Parameters](./double_stochastics.md)
*   [Examples](./double_stochastics.md)
*   [Source Code](./double_stochastics.md)