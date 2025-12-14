**Path**: [TimeSeries<datetime>](./timeseries.md) > [Times](./times.md)

# Times

# Times

## [Definition](./times.md)

Holds an array of **ISeries<`datetime`\>** objects holding historical bar times. A **ISeries<`datetime`\>** object is `added` to this array when calling the [AddDataSeries()](./adddataseries.md) method. Its purpose is to provide access to the times of all Bars objects in a multi\-instrument or multi\-time frame script.

## [Property Value](./times.md)

An array of **ISeries<`datetime`\>** objects.

## [Syntax](./times.md)

`Times[int barSeriesIndex][int barsAgo]`

## [Examples](./times.md)

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
     // Compares the primary bar's time to the 5-minute bar's time
     if (Times[0][0].Ticks > Times[1][0].Ticks)
         Print("The current bar's time is greater");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./times.md)
*   [Property Value](./times.md)
*   [Syntax](./times.md)
*   [Examples](./times.md)