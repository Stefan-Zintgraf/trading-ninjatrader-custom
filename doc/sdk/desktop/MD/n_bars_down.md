**Path**: [System Indicator Methods](./system_indicator_methods.md) > [n Bars Down](./n_bars_down.md)

# n Bars Down

# n Bars Down

## [Description](./n_bars_down.md)

Evaluates for n number of consecutive lower closes. Returns a value of 1 when the condition is true or 0 when false.

## [Syntax](./n_bars_down.md)

`NBarsDown(int barCount, bool barDown, bool lowerHigh, bool lowerLow)`

`NBarsDown(ISeries<double> input, int barCount, bool barDown, bool lowerHigh, bool lowerLow)`

**Returns default value**

`NBarsDown(int barCount, bool barDown, bool lowerHigh, bool lowerLow)[int barsAgo]`

`NBarsDown(ISeries<double> input, bool barCount, int barDown, bool lowerHigh, bool lowerLow)[int barsAgo]`

## [Return Value](./n_bars_down.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./n_bars_down.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

barCount

The number of required consecutive lower closes

barDown

Each bar's open must be less than the close; true or false

lowerHigh

Consecutive lower highs required; true or false

lowerLow

Consecutive lower lows required; true or false

## [Examples](./n_bars_down.md)

```csharp
// OnBarUpdate method
protected override void OnBarUpdate()
{
   // Evaluates if we have 3 consecutive lower closes
   double value = NBarsDown(3, true, true, true)[0];
 
   if (value == 1)
       Print("We have three consecutive lower closes");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./n_bars_down.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./n_bars_down.md)
*   [Syntax](./n_bars_down.md)
*   [Return Value](./n_bars_down.md)
*   [Parameters](./n_bars_down.md)
*   [Examples](./n_bars_down.md)
*   [Source Code](./n_bars_down.md)