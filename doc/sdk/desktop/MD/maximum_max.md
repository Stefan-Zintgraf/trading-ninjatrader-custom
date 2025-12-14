**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Maximum (MAX)](./maximum_max.md)

# Maximum (MAX)

# Maximum (MAX)

## [Description](./maximum_max.md)

Returns the highest value over the specified period.

## [Syntax](./maximum_max.md)

`MAX(int period)`

`MAX(ISeries<double> input, int period)`

**Returns default value**

`MAX(int period)[int barsAgo]`

`MAX(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./maximum_max.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./maximum_max.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./maximum_max.md)

```csharp
// Prints the highest high value over the last 20 periods
double value = MAX(High, 20)[0];
Print("The current MAX value is " + value.ToString());

// Note the above call with a barsAgo of 0 includes the current MAX of the input high series in the value. If we want to check for example for a break of this value, storing the last bar's MAX would be needed.
double value = MAX(High, 20)[1];

if (High[0] > value)
    Draw.ArrowUp(this, CurrentBar.ToString(), true, 0, Low[0] - TickSize, Brushes.Blue);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./maximum_max.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./maximum_max.md)
*   [Syntax](./maximum_max.md)
*   [Return Value](./maximum_max.md)
*   [Parameters](./maximum_max.md)
*   [Examples](./maximum_max.md)
*   [Source Code](./maximum_max.md)