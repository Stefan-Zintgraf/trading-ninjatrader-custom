**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Polarized Fractal Efficiency (PFE)](./polarized_fractal_efficiency_pfe.md)

# Polarized Fractal Efficiency (PFE)

# Polarized Fractal Efficiency (PFE)

## [Description](./polarized_fractal_efficiency_pfe.md)

The Polarized Fractal Efficiency indicator uses fractal geometry to determine how efficiently the price is moving. When the **PFE** is zigzagging around zero, then the price is congested and not trending. When the **PFE** is smooth and above/below zero, then the price is in an up/down trend. The higher/lower the **PFE** value, the stronger the trend is.

... Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=PFE.htm)

## [Syntax](./polarized_fractal_efficiency_pfe.md)

`PFE(int period, int smooth)`

`PFE(ISeries<double> input, int period, int smooth)`

**Returns default value**

`PFE(int period, int smooth)[int barsAgo]`

`PFE(ISeries<double> input, int period, int smooth)[int barsAgo]`

## [Return Value](./polarized_fractal_efficiency_pfe.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./polarized_fractal_efficiency_pfe.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

smooth

The smoothing factor to be applied

## [Examples](./polarized_fractal_efficiency_pfe.md)

```csharp
// Prints the current value of a 20 period PFE using default price type
double value = PFE(20, 2)[0];
Print("The current PFE value is " + value.ToString());

// Prints the current value of a 20 period PFE using high price type
double value = PFE(High, 20, 2)[0];
Print("The current PFE value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./polarized_fractal_efficiency_pfe.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./polarized_fractal_efficiency_pfe.md)
*   [Syntax](./polarized_fractal_efficiency_pfe.md)
*   [Return Value](./polarized_fractal_efficiency_pfe.md)
*   [Parameters](./polarized_fractal_efficiency_pfe.md)
*   [Examples](./polarized_fractal_efficiency_pfe.md)
*   [Source Code](./polarized_fractal_efficiency_pfe.md)