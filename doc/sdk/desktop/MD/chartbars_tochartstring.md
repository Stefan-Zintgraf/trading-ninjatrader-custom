**Path**: [ChartBars](./chartbars.md) > [ToChartString()](./chartbars_tochartstring.md)

# ToChartString()

# ToChartString()

## [Definition](./chartbars_tochartstring.md)

Returns a formatted string representing the **ChartBars.Properties.Label** property, **BarsPeriod** Value, and **BarsPeriodType** name.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The property returned is dependent on a user configured **Data Series** property, and results may return differently than expected. See also **Bars.ToChartString()** for a return value which is not subject to user\-defined variables.

## [Syntax](./chartbars_tochartstring.md)

`ChartBars.ToChartString()`

## [Return Value](./chartbars_tochartstring.md)

A **string** value that represents the ChartBars label and configured bars period.

## [Parameters](./chartbars_tochartstring.md)

This method does not accept any parameters.

## [Examples](./chartbars_tochartstring.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   if (ChartBars != null)
     Print(ChartBars.ToChartString()); // My Favorite Instrument (1 Minute)
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartbars_tochartstring.md)
*   [Syntax](./chartbars_tochartstring.md)
*   [Return Value](./chartbars_tochartstring.md)
*   [Parameters](./chartbars_tochartstring.md)
*   [Examples](./chartbars_tochartstring.md)