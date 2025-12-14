**Path**: [PriceSeries<double>](./priceseries.md) > [Inputs](./inputs.md)

# Inputs

# Inputs

## [Definition](./inputs.md)

Holds an array of **ISeries`<double>`** objects holding the main data input. A **ISeries`<double>`** object is added to this array when calling the [**AddDataSeries()**](./adddataseries.md) method. Its purpose is to provide access to the main input all **Bars** objects in a multi\-instrument or multi\-time frame script.

## [Property Value](./inputs.md)

An array of **ISeries`<double>`** objects.

## [Syntax](./inputs.md)

`Inputs[int barSeriesIndex][int barsAgo]`

## [Examples](./inputs.md)

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
     // Compares the primary bar's input price to the 5-minute bar's input price
     if (Inputs[0][0] > Inputs[1][0])
         Print("The primary bar's input is greater");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./inputs.md)
*   [Property Value](./inputs.md)
*   [Syntax](./inputs.md)
*   [Examples](./inputs.md)