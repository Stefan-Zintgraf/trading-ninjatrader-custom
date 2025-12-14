**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Correlation](./correlation.md)

# Correlation

# Correlation

## [Description](./correlation.md)

The correlation indicator will plot the correlation of the data series to a desired instrument. Values close to 1 indicate movement in the same direction. Values close to \-1 indicate movement in opposite directions. Values near 0 indicate no correlation.

## [Syntax](./correlation.md)

`Correlation(int period, string correlationSeries)`

`Correlation(ISeries<double> input, int period, string correlationSeries)`

## [Return Value](./correlation.md)

**double**; Accessing this method via an index value **int barsAgo** returns the indicator value of the referenced bar.

## [Parameters](./correlation.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

correlationSeries

The data series to compare to

## [Examples](./correlation.md)

```csharp
// The correlation data series must be added to OnStateChange() as this indicator runs off the correlation data series data
else if (State == State.Configure)
{
   AddDataSeries("SPY");
}

// Checks the bars in progress and prints the current correlation to the SPY
if (BarsInProgress == 0)
{
   double value = Correlation(20, "SPY")[0];
   Print("The current correlation to the SPY is " + value.ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If the correlation series does not plot during a time the input series plots, a value of zero would plot in the above example. You may consider ignoring zero values.

## [Source Code](./correlation.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./correlation.md)
*   [Syntax](./correlation.md)
*   [Return Value](./correlation.md)
*   [Parameters](./correlation.md)
*   [Examples](./correlation.md)
*   [Source Code](./correlation.md)