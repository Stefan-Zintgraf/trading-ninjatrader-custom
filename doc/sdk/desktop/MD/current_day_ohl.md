**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Current Day OHL](./current_day_ohl.md)

# Current Day OHL

# Current Day OHL

## [Description](./current_day_ohl.md)

The current day (session) open, high and low values.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Only use this indicator on intraday series.

## [Syntax](./current_day_ohl.md)

`CurrentDayOHL()`

`CurrentDayOHL(ISeries<double> input)`

**Returns current session open value**

`CurrentDayOHL().CurrentOpen[int barsAgo]`

`CurrentDayOHL(ISeries<double> input).CurrentOpen[int barsAgo]`

**Returns current session high value**

`CurrentDayOHL().CurrentHigh[int barsAgo]`

`CurrentDayOHL(ISeries<double> input).CurrentHigh[int barsAgo]`

**Returns current session low value**

`CurrentDayOHL().CurrentLow[int barsAgo]`

`CurrentDayOHL(ISeries<double> input).CurrentLow[int barsAgo]`

## [Return Value](./current_day_ohl.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./current_day_ohl.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

## [Examples](./current_day_ohl.md)

```csharp
// Prints the current value of the session low
double value = CurrentDayOHL().CurrentLow[0];
Print("The current session low value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./current_day_ohl.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./current_day_ohl.md)
*   [Syntax](./current_day_ohl.md)
*   [Return Value](./current_day_ohl.md)
*   [Parameters](./current_day_ohl.md)
*   [Examples](./current_day_ohl.md)
*   [Source Code](./current_day_ohl.md)