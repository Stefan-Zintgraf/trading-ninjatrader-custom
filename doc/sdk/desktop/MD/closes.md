**Path**: [PriceSeries<double>](./priceseries.md) > [Closes](./closes.md)

# Closes

# Closes

## [Definition](./closes.md)

Holds an array of **ISeries`<double>`** objects holding historical bar close prices. A **ISeries`<double>`** object is added to this array when calling the [AddDataSeries()](./adddataseries.md) method. Its purpose is to provide access to the closing prices of all **Bars** objects in a multi\-instrument or multi\-time frame script.

## [Property Value](./closes.md)

An array of **ISeries`<double>`** objects.

## [Syntax](./closes.md)

`Closes[int barSeriesIndex][int barsAgo]`

## [Examples](./closes.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.Configure)
     {
         // Adds a 5-minute Bars object to the strategy and is automatically assigned
         // a Bars object index of 1 since the primary data the strategy is run against
         // set by the UI takes the index of 0.
         AddDataSeries("AAPL", BarsPeriodType.Minute, 5);
     }
}

protected override void OnBarUpdate()
{
     // Compares the primary bar's close price to the 5-minute bar's close price
     if (Closes[0][0] > Closes[1][0])
         Print("The primary bar's close price is greater");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./closes.md)
*   [Property Value](./closes.md)
*   [Syntax](./closes.md)
*   [Examples](./closes.md)