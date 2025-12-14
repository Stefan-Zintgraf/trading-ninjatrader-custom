**Path**: [System Indicator Methods](./system_indicator_methods.md) > [n Bars Up](./n_bars_up.md)

# n Bars Up

# n Bars Up

## [Description](./n_bars_up.md)

Evaluates for n number of consecutive higher closes. Returns a value of 1 when the condition is true or 0 when false.

## [Syntax](./n_bars_up.md)

`NBarsUp(int barCount, bool barUp, bool higherHigh, bool higherLow)`

`NBarsUp(ISeries<double> input, int barCount, bool barUp, bool higherHigh, bool higherLow)`

**Returns default value**

`NBarsUp(int barCount, bool barUp, bool higherHigh, bool higherLow)[int barsAgo]`

`NBarsUp(ISeries<double> input, int barCount, bool barUp, bool higherHigh, bool higherLow)[int barsAgo]`

## [Return Value](./n_bars_up.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./n_bars_up.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**barCount**

The number of required consecutive higher closes

**barUp**

Each bar's close must be higher than the open; true or false

**higherHigh**

Consecutive higher highs required; true or false

**higherLow**

Consecutive higher lows required; true or false

## [Examples](./n_bars_up.md)

```csharp
// OnBarUpdate method
protected override void OnBarUpdate()
{
   // Evaluates if we have 3 consecutive higher closes
   double value = NBarsUp(3, true, true, true)[0];
 
   if (value == 1)
       Print("We have three consecutive higher closes");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./n_bars_up.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./n_bars_up.md)
*   [Syntax](./n_bars_up.md)
*   [Return Value](./n_bars_up.md)
*   [Parameters](./n_bars_up.md)
*   [Examples](./n_bars_up.md)
*   [Source Code](./n_bars_up.md)