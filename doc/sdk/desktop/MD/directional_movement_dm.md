**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Directional Movement (DM)](./directional_movement_dm.md)

# Directional Movement (DM)

# Directional Movement (DM)

## [Description](./directional_movement_dm.md)

Same as the **ADX** indicator with the addition of the +DI and \-DI values.

... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/dmi.asp)

## [Syntax](./directional_movement_dm.md)

`DM(int period)`

`DM(ISeries<double> input, int period)`

**Returns default ADX value**

`DM(int period)[int barsAgo]`

`DM(ISeries<double> input, int period)[int barsAgo]`

**Returns +DI value**

`DM(int period).DiPlus[int barsAgo]`

`DM(ISeries<double> input, int period).DiPlus[int barsAgo]`

**Returns \-DI value**

`DM(int period).DiMinus[int barsAgo]`

`DM(ISeries<double> input, int period).DiMinus[int barsAgo]`

## [Return Value](./directional_movement_dm.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./directional_movement_dm.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./directional_movement_dm.md)

```csharp
// Prints the current value of a 20 period +DI using default price type
double value = DM(20).DiPlus[0];
Print("The current +DI value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./directional_movement_dm.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./directional_movement_dm.md)
*   [Syntax](./directional_movement_dm.md)
*   [Return Value](./directional_movement_dm.md)
*   [Parameters](./directional_movement_dm.md)
*   [Examples](./directional_movement_dm.md)
*   [Source Code](./directional_movement_dm.md)