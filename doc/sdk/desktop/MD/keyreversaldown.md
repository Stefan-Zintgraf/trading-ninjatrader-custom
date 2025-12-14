**Path**: [System Indicator Methods](./system_indicator_methods.md) > [KeyReversalDown](./keyreversaldown.md)

# KeyReversalDown

# KeyReversalDown

## [Description](./keyreversaldown.md)

Returns a value of 1 when the current close is less than the prior close and the current high has penetrated the highest high of the last n bars.

## [Syntax](./keyreversaldown.md)

`KeyReversalDown(int period)`

`KeyReversalDown(ISeries<double> input, int period)`

**Returns default value**

`KeyReversalDown(int period)[int barsAgo]`

`KeyReversalDown(ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./keyreversaldown.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./keyreversaldown.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**period**

Number of bars used in the calculation

## [Examples](./keyreversaldown.md)

```csharp
// If we get a reversal over the past 10 bars go short
if (KeyReversalDown(10)[0] == 1)
    EnterShort();

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./keyreversaldown.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./keyreversaldown.md)
*   [Syntax](./keyreversaldown.md)
*   [Return Value](./keyreversaldown.md)
*   [Parameters](./keyreversaldown.md)
*   [Examples](./keyreversaldown.md)
*   [Source Code](./keyreversaldown.md)