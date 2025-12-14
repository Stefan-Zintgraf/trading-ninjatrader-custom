**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Average Directional Movement Rating (ADXR)](./average_directional_movement_rating_adxr.md)

# Average Directional Movement Rating (ADXR)

# Average Directional Movement Rating (ADXR)

## [Description](./average_directional_movement_rating_adxr.md)

The ADXR is equal to the current [ADX](./average_directional_index_adx.md) plus the ADX from n bars ago divided by two.

## [Syntax](./average_directional_movement_rating_adxr.md)

`ADXR(int interval, int period)`

`ADXR(ISeries<double> input, int interval, int period)`

**Returns default value**

`ADXR(int interval, int period)[int barsAgo]`

`ADXR(ISeries<double> input, int interval, int period)[int barsAgo]`

## [Return Value](./average_directional_movement_rating_adxr.md)

**double**; Accessing this method via an index value \`\[int barsAgo\] returns the indicator value of the referenced bar.

## [Parameters](./average_directional_movement_rating_adxr.md)

input

Indicator source data

interval

The interval between the first ADX value and the current ADX value

period

Number of bars used in the calculation

## [Example](./average_directional_movement_rating_adxr.md)

```csharp
// Prints the current value of a 20 period ADXR using default price type
double value = ADXR(10, 20)[0];
Print("The current ADXR value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./average_directional_movement_rating_adxr.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./average_directional_movement_rating_adxr.md)
*   [Syntax](./average_directional_movement_rating_adxr.md)
*   [Return Value](./average_directional_movement_rating_adxr.md)
*   [Parameters](./average_directional_movement_rating_adxr.md)
*   [Example](./average_directional_movement_rating_adxr.md)
*   [Source Code](./average_directional_movement_rating_adxr.md)