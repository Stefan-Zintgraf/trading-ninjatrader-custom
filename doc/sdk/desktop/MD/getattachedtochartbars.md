**Path**: [ChartAnchor](./chartanchor.md) > [GetAttachedToChartBars()](./getattachedtochartbars.md)

# GetAttachedToChartBars()

# GetAttachedToChartBars()

## [Definition](./getattachedtochartbars.md)

Returns information which relate to the underlying bars series in which the drawing tool is attached. If the drawing tool is attached to an indicator rather than a bar series, the indicator's bars series used for input will be returned.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For drawing tools made global, this method will not be returning meaningful values \- since those are not attached to a specific bars series.

## [Method Return Value](./getattachedtochartbars.md)

A **ChartBars** object

## [Syntax](./getattachedtochartbars.md)

`GetAttachedToChartBars()`

## [Method Parameters](./getattachedtochartbars.md)

This method does not accept any parameters.

## [Examples](./getattachedtochartbars.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{   
   // get the attached chart bars
   ChartBars myBars = GetAttachedToChartBars();
   
   Print(myBars.Bars.ToChartString()); // NQ 03-15 (1 Minute)
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getattachedtochartbars.md)
*   [Method Return Value](./getattachedtochartbars.md)
*   [Syntax](./getattachedtochartbars.md)
*   [Method Parameters](./getattachedtochartbars.md)
*   [Examples](./getattachedtochartbars.md)