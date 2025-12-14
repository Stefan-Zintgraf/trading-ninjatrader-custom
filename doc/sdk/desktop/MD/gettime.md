**Path**: [Bars](./bars.md) > [GetTime()](./gettime.md)

# GetTime()

# GetTime()

## [Definition](./gettime.md)

Returns the time stamp at the current bar index value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method will return what is displayed in the chart's data box. For formatting purposes, the value returned is NOT guaranteed to be equal to the **[TimeSeries](./timeseries.md)** value. If you are using daily bars and need the session end time, you should use **[Bars.GetSessionEndTime()](./getsessionendtime.md)** instead.

## [Method Return Value](./gettime.md)

A DateTime structure that represents the time stamp at the desired bar index.

## [Syntax](./gettime.md)

`Bars.GetTime(int index)`

## [Parameters](./gettime.md)

Parameter

Description

index

An int representing an absolute bar index value

## [Examples](./gettime.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);
    // loop through only the rendered bars on the chart
    for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)
    {
        // get the time stamp at the selected bar index value
        DateTime timeValue = Bars.GetTime(barIndex);
        Print("Bar #" + barIndex + " time stamp is " + timeValue);
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettime.md)
*   [Method Return Value](./gettime.md)
*   [Syntax](./gettime.md)
*   [Parameters](./gettime.md)
*   [Examples](./gettime.md)