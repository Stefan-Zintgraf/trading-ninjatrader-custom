**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Directional Movement Index (DMI)](./directional_movement_index_dmi.md)

# Directional Movement Index (DMI)

# Directional Movement Index (DMI)

## [Description](./directional_movement_index_dmi.md)

An indicator developed by J. Welles Wilder for identifying when a definable trend is present in an instrument. That is, the DMI tells whether an instrument is trending or not.

...Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=DX.htm)

## [Syntax](./directional_movement_index_dmi.md)

`DMI(int period)`

`DMI(ISeries<double> input, int period)`

**Returns default value**

`DMI(int period)[int barsAgo]`

`DMI(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./directional_movement_index_dmi.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./directional_movement_index_dmi.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./directional_movement_index_dmi.md)

```csharp
// Prints the current value of a 20 period DMI using default price type
double value = DMI(20)[0];
Print("The current DMI value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./directional_movement_index_dmi.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./directional_movement_index_dmi.md)
*   [Syntax](./directional_movement_index_dmi.md)
*   [Return Value](./directional_movement_index_dmi.md)
*   [Parameters](./directional_movement_index_dmi.md)
*   [Examples](./directional_movement_index_dmi.md)
*   [Source Code](./directional_movement_index_dmi.md)