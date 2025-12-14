**Path**: [System Indicator Methods](./system_indicator_methods.md) > [KeyReversalUp](./keyreversalup.md)

# KeyReversalUp

# KeyReversalUp

## [Description](./keyreversalup.md)

Returns a value of 1 when the current close is greater than the prior close and the current low has penetrated the lowest low of the last n bars.

## [Syntax](./keyreversalup.md)

`KeyReversalUp(int period)`

`KeyReversalUp(ISeries<double> input, int period)`

**Returns default value**

`KeyReversalUp(int period)[int barsAgo]`

`KeyReversalUp(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./keyreversalup.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./keyreversalup.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./keyreversalup.md)

```csharp
// If we get a reversal over the past 10 bars go long
if (KeyReversalUp(10)[0] == 1)
    EnterLong();

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./keyreversalup.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./keyreversalup.md)
*   [Syntax](./keyreversalup.md)
*   [Return Value](./keyreversalup.md)
*   [Parameters](./keyreversalup.md)
*   [Examples](./keyreversalup.md)
*   [Source Code](./keyreversalup.md)