**Path**: [OnBarUpdate()](./onbarupdate.md)

# OnBarUpdate()

# OnBarUpdate()

## [Definition](./onbarupdate.md)

An event driven method which is called whenever a bar is updated. The frequency in which **OnBarUpdate** is called will be determined by the "[Calculate](./calculate.md)" property. **OnBarUpdate()** is the method where all of your script's core bar based calculation logic should be contained.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Notes:

*   For [multi\-timeframe and instrument scripts](./multi_time_frame_instruments.md), the **OnBarUpdate** method is called for each Bars object of a strategy. You MUST filter for the exact bar update events using the "[BarsInProgress](./barsinprogress.md)" property you want your system logic to execute against.
*   Hosted indicators will need to be accessed by the hosting script to ensure **OnBarUpdate** functionality. This can be done by:
    1.  Calling [Update](./update.md) on the hosted indicator within the host script,
    2.  Including a plot in the hosted indicator and accessing the plot in the host script,
    3.  Including a plot in the hosted indicator and adding the indicator to the chart with [AddChartIndicator](./addchartindicator.md) (strategies only)

## [Related Methods and Properties](./onbarupdate.md)

Method

Description

[BarsPeriod](./barsperiod.md)

The primary Bars object time frame (period type and interval).

[Calculate](./calculate.md)

Determines how often **OnBarUpdate()** is called for each bar.

[Count](./count.md)

The total number of bars or data points.

[CurrentBar](./currentbar.md)

A number representing the current bar in a Bars object that the **OnBarUpdate()** method in an indicator or strategy is currently processing.

[IsDataSeriesRequired](./isdataseriesrequired.md)

Determines if a Data Series is required for calculating this NinjaScript object.

[IsFirstTickOfBar](./isfirsttickofbar.md)

Indicates if the incoming tick is the first tick of a new bar.

[IsResetOnNewTradingDays](./isresetonnewtradingdays.md)

Determines if the specified bar series is using Break at EOD.

[IsTickReplays](./istickreplays.md)

Indicates the specified bar series is using Tick Replay.

[Update()](./update.md)

Forces the **OnBarUpdate()** method to be called so that indicator values are updated to the current bar.

## [Method Return Value](./onbarupdate.md)

This method does not return a value.

## [Syntax](./onbarupdate.md)

You must override this method with the following syntax:

**protected override void OnBarUpdate()**

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tip: The NinjaScript code wizards automatically generates the method syntax for you.

## [Parameters](./onbarupdate.md)

This method does not take any parameters.

## [Examples](./onbarupdate.md)

```csharp
protected override void OnBarUpdate()
{
     if (CurrentBar < 1)
         return;

     // Compares the primary bar's low price to the 5-minute bar's low price
     if (Low[0] > Lows[1])
         Print("The current bar's low price is greater");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onbarupdate.md)
*   [Related Methods and Properties](./onbarupdate.md)
*   [Method Return Value](./onbarupdate.md)
*   [Syntax](./onbarupdate.md)
*   [Parameters](./onbarupdate.md)
*   [Examples](./onbarupdate.md)