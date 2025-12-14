**Path**: [ChartAnchor](./chartanchor.md) > [OnMouseMove()](./onmousemove.md)

# OnMouseMove()

# OnMouseMove()

## [Definition](./onmousemove.md)

An event driven method which is called any time the mouse pointer is over the chart control and a mouse is moving.

## [Method Return Value](./onmousemove.md)

This method does not return a value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one.

## [Syntax](./onmousemove.md)

You must override the method in your Drawing Tool with the following syntax.

`public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) { }`

## [Method Parameters](./onmousemove.md)

**chartControl**

A [ChartControl](./chartcontrol.md) representing the x\-axis

**chartPanel**

A [ChartPanel](./chartpanel.md) representing the the panel for the chart

**chartScale**

A [ChartScale](./chartscale.md) representing the y\-axis

**dataPoint**

A [ChartAnchor](./chartanchor.md) representing a point where the user is moving the mouse

## [Examples](./onmousemove.md)

```csharp
private ChartAnchor lastMouseMoveAnchor = new ChartAnchor();
private ChartAnchor MyAnchor;

public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
    // add any logic for when the mouse is moved here
    if (DrawingState == DrawingState.Moving)
    {
        //move the chart anchor when the drawing tool is in a moving state
        MyAnchor.MoveAnchor(lastMouseMoveAnchor, dataPoint, chartControl, chartPanel, chartScale, this);
        // dont forget to update delta point to last used!
        dataPoint.CopyDataValues(lastMouseMoveAnchor);
    }         
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onmousemove.md)
*   [Method Return Value](./onmousemove.md)
*   [Syntax](./onmousemove.md)
*   [Method Parameters](./onmousemove.md)
*   [Examples](./onmousemove.md)