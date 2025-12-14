**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Volume (VOL)](./volume.md)

# Volume (VOL)

# Volume (VOL)

## [Description](./volume.md)

Volume is simply the number of shares (or contracts) traded during a specified time frame (e.g., hour, day, week, month, etc). The analysis of volume is a basic yet very important element of technical analysis. Volume provides clues as to the intensity of a given price move.

... Courtesy of [Market In Out](http://www.marketinout.com/technical_analysis.php?id=114)

## [Syntax](./volume.md)

`VOL()`

`VOL(ISeries<double> input)`

**Returns default value**

`VOL()[int barsAgo]`

`VOL(ISeries<`double`> input)[int barsAgo]`

## [Return Value](./volume.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./volume.md)

Parameter

Description

input

Indicator source data ([ISeriesT](./iseriest.md)

## [Example](./volume.md)

```csharp
// Prints the current value VOL  
double value = VOL()[0];  
Print("The current VOL value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./volume.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./volume.md)
*   [Syntax](./volume.md)
*   [Return Value](./volume.md)
*   [Parameters](./volume.md)
*   [Example](./volume.md)
*   [Source Code](./volume.md)