**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Chaikin Volatility](./chaikin_volatility.md)

# Chaikin Volatility

# Chaikin Volatility

## [Description](./chaikin_volatility.md)

The Chaikin Volatility Indicator is the difference between two moving averages of a volume weighted accumulation\-distribution line. By comparing the spread between a security's high and low prices, it quantifies volatility as a widening of the range between the high and the low price.

## [Syntax](./chaikin_volatility.md)

`ChaikinVolatility(int mAPeriod, int rOCPeriod)`

`ChaikinVolatility(ISeries<double> input, int mAPeriod, int rOCPeriod)`

**Returns default value**

`ChaikinVolatility(int mAPeriod, int rOCPeriod)[int barsAgo]`

`ChaikinVolatility(ISeries<double> input, int mAPeriod, int rOCPeriod)[int barsAgo]`

## [Return Value](./chaikin_volatility.md)

**double;** Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./chaikin_volatility.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

mAPeriod

Number of bars used in the moving average calculation

rOCPeriod

Number of bars used in the rate of change calculation

## [Examples](./chaikin_volatility.md)

```csharp
// Prints the current value of the 20 period Chaikin Volatility
double value = ChaikinVolatility(20, 20)[0];
Print("The current Chaikin Volatility value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./chaikin_volatility.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./chaikin_volatility.md)
*   [Syntax](./chaikin_volatility.md)
*   [Return Value](./chaikin_volatility.md)
*   [Parameters](./chaikin_volatility.md)
*   [Examples](./chaikin_volatility.md)
*   [Source Code](./chaikin_volatility.md)