**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Volume Rate of Change (VROC)](./volume_rate_of_change_vroc.md)

# Volume Rate of Change (VROC)

# Volume Rate of Change (VROC)

## [Description](./volume_rate_of_change_vroc.md)

Volume Rate of Change is identical to [Price Rate Of Change (ROC)](./rate_of_change_roc.md) indicator except that it uses volume instead of price.

## [Syntax](./volume_rate_of_change_vroc.md)

`VROC(int period, int smooth)`

`VROC(ISeries<double> input, int period, int smooth)`

**Returns default value**

`VROC(int period, int smooth)[int barsAgo]`

`VROC(ISeries<double> input, int period, int smooth] (int barsAgo)`

## [Return Value](./volume_rate_of_change_vroc.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./volume_rate_of_change_vroc.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

smooth

The number of bars for smoothing the signal

## [Example](./volume_rate_of_change_vroc.md)

```csharp
// Prints the current value of VROC  
double value = VROC(13, 3)[0];  
Print("The current VROC value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./volume_rate_of_change_vroc.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./volume_rate_of_change_vroc.md)
*   [Syntax](./volume_rate_of_change_vroc.md)
*   [Return Value](./volume_rate_of_change_vroc.md)
*   [Parameters](./volume_rate_of_change_vroc.md)
*   [Example](./volume_rate_of_change_vroc.md)
*   [Source Code](./volume_rate_of_change_vroc.md)