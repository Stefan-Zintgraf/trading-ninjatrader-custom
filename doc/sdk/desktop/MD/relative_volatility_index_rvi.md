**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Relative Volatility Index (RVI)](./relative_volatility_index_rvi.md)

# Relative Volatility Index (RVI)

# Relative Volatility Index (RVI)

## [Description](./relative_volatility_index_rvi.md)

Developed by Donald Dorsey, the Relative Volatility Index is the **RSI** using the standard deviation over the indicator period in place of the daily price change. The RVI measures the direction of volatility on a scale from 0 to 100. Readings below 50 indicate that the direction of volatility is to the downside and that you should be looking to sell, readings above 50 indicate that the direction of volatility is to the upside and that you should be looking to buy.

## [Syntax](./relative_volatility_index_rvi.md)

`RVI(int period)`

`RVI(ISeries<double> input, int period)`

**Returns default value**

`RVI(int period)[int barsAgo]`

`RVI[ISeries<double> input, int period)[int barsAgo]`

## [Return Value](./relative_volatility_index_rvi.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./relative_volatility_index_rvi.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Examples](./relative_volatility_index_rvi.md)

```csharp
// OnBarUpdate method
protected override void OnBarUpdate()
{
    // Check for buy condition
    if (RVI(14)[0] > 50 && CrossAbove(SMA(9), SMA(14), 1))
    {
        EnterLong();
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./relative_volatility_index_rvi.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./relative_volatility_index_rvi.md)
*   [Syntax](./relative_volatility_index_rvi.md)
*   [Return Value](./relative_volatility_index_rvi.md)
*   [Parameters](./relative_volatility_index_rvi.md)
*   [Examples](./relative_volatility_index_rvi.md)
*   [Source Code](./relative_volatility_index_rvi.md)