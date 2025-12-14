**Path**: [Bars](./bars.md) > [ToChartString()](./tochartstring.md)

# ToChartString()

# ToChartString()

## [Definition](./tochartstring.md)

Returns the bars series as a formatted string, including the **Instrument.FullName**, **BarsPeriod** Value, and **BarsPeriodType** name.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

To obtain a return value which matches the user configured **ChartBars Label property**, please see the **ChartBars.ToChartString()** method.

## [Syntax](./tochartstring.md)

`Bars.ToChartString()`

## [Return Value](./tochartstring.md)

A **string** value that represents the bars series.

## [Parameters](./tochartstring.md)

This method does not accept any parameters.

## [Examples](./tochartstring.md)

```csharp
protected override void OnBarUpdate()
{
   // print the chart string on start up
   if(CurrentBar == 0)
     Print(Bars.ToChartString()); // ES 09-15 (60 Minute)      
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./tochartstring.md)
*   [Syntax](./tochartstring.md)
*   [Return Value](./tochartstring.md)
*   [Parameters](./tochartstring.md)
*   [Examples](./tochartstring.md)