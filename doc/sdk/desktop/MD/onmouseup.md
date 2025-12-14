**Path**: [ChartAnchor](./chartanchor.md) > [OnMouseUp()](./onmouseup.md)

# OnMouseUp()

# OnMouseUp()

## [Definition](./onmouseup.md)

An event driven method is called any time the mouse pointer is over the chart control and a mouse button is being released.

## [Method Return Value](./onmouseup.md)

This method does not return a value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one.

## [Syntax](./onmouseup.md)

You must override the method with the following syntax.

`public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)`

## [Method Parameters](./onmouseup.md)

**chartControl**

A [ChartControl](./chartcontrol.md) representing the x\-axis

**chartPanel**

A [ChartPanel](./chartpanel.md) representing the the panel for the chart

**chartScale**

A [ChartScale](./chartscale.md) representing the y\-axis

**dataPoint**

A [ChartAnchor](./chartanchor.md) representing a point where the user is releasing the mouse

## [Examples](./onmouseup.md)

```csharp
public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
   //when the user releases the mouse, ensure the drawing state is set to normal
   if (DrawingState == DrawingState.Editing || DrawingState == DrawingState.Moving)
     DrawingState = DrawingState.Normal;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onmouseup.md)
*   [Method Return Value](./onmouseup.md)
*   [Syntax](./onmouseup.md)
*   [Method Parameters](./onmouseup.md)
*   [Examples](./onmouseup.md)