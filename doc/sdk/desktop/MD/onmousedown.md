**Path**: [ChartAnchor](./chartanchor.md) > [OnMouseDown()](./onmousedown.md)

# OnMouseDown()

# OnMouseDown()

## [Definition](./onmousedown.md)

An event driven method which is called any time the mouse pointer over the chart control has the mouse button pressed.

## [Method Return Value](./onmousedown.md)

This method does not return a value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one.

## [Syntax](./onmousedown.md)

You must override the method in your Drawing Tool with the following syntax.

`public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) { }`

## [Method Parameters](./onmousedown.md)

**chartControl**

A [ChartControl](./chartcontrol.md) representing the x\-axis

**chartPanel**

A [ChartPanel](./chartpanel.md) representing the the panel for the chart

**chartScale**

A [ChartScale](./chartscale.md) representing the y\-axis

**dataPoint**

A [ChartAnchor](./chartanchor.md) representing a point where the user clicked

## [Examples](./onmousedown.md)

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
   switch (DrawingState)
   {
     case DrawingState.Building:
         dataPoint.CopyDataValues(Anchor);
         Anchor.IsEditing   = false;
         DrawingState     = DrawingState.Normal;
         IsSelected         = false;
         break;
     case DrawingState.Normal:
         // make sure they clicked near us. use GetCursor incase something has more than one point
         Point point = dataPoint.GetPoint(chartControl, chartPanel, chartScale);
         if (GetCursor(chartControl, chartPanel, chartScale, point) != null)
           DrawingState = DrawingState.Moving;
         else
           IsSelected = false;
         break;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onmousedown.md)
*   [Method Return Value](./onmousedown.md)
*   [Syntax](./onmousedown.md)
*   [Method Parameters](./onmousedown.md)
*   [Examples](./onmousedown.md)