**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Minimum (MIN)](./minimum_min.md)

# Minimum (MIN)

# Minimum (MIN)

## [Description](./minimum_min.md)

Returns the lowest value over the specified period.

## [Syntax](./minimum_min.md)

`MIN(int period)`

`MIN(ISeries<double> input, int period)`

**Returns default value**

`MIN(int period)[int barsAgo]`

`MIN(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./minimum_min.md)

**double;** Accessing this method via an index value **`[int barsAgo]`** returns the indicator value of the referenced bar.

## [Parameters](./minimum_min.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./minimum_min.md)

```csharp
// Prints the lowest low value over the last 20 periods
double value = MIN(Low, 20)[0];
Print("The current MIN value is " + value.ToString());

// Note the above call with a barsAgo of 0 includes the current MIN of the input low series in the value. If we want to check for example for a break of this value, storing the last bar's MIN would be needed.
double value = MIN(Low, 20)[1];
       
if (Low[0] < value)
  Draw.ArrowDown(this, CurrentBar.ToString(), true, 0, High[0] + TickSize, Brushes.Red);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./minimum_min.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./minimum_min.md)
*   [Syntax](./minimum_min.md)
*   [Return Value](./minimum_min.md)
*   [Parameters](./minimum_min.md)
*   [Examples](./minimum_min.md)
*   [Source Code](./minimum_min.md)