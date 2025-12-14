**Path**: [ChartAnchor](./chartanchor.md) > [GetCursor()](./getcursor.md)

# GetCursor()

# GetCursor()

## [Definition](./getcursor.md)

An event driven method which is called when a chart object is selected. This method can be used to change the cursor image used in various states.

## [Method Return Value](./getcursor.md)

This method returns a **Cursor** used to paint the mouse pointer.

## [Syntax](./getcursor.md)

You must override the method in your Drawing Tool with the following syntax:

`public override Cursor GetCursor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)`

## [Method Parameters](./getcursor.md)

**chartControl**

A [ChartControl](./chartcontrol.md) representing the x\-axis

**chartPanel**

A [ChartPanel](./chartpanel.md) representing the panel for the chart

**chartScale**

A [ChartScale](./chartscale.md) representing the y\-axis

**point**

A Point in device pixels representing the current mouse cursor position

## [Examples](./getcursor.md)

```csharp
public override Cursor GetCursor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)
{
    switch (DrawingState)
    {
        //when drawing, display the cursor as a pen
        case DrawingState.Building:   return Cursors.Pen;

        // when moving, display a four-headed sizing cursor
        case DrawingState.Moving:   return Cursors.SizeAll;

        default: return Cursors.Pen;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getcursor.md)
*   [Method Return Value](./getcursor.md)
*   [Syntax](./getcursor.md)
*   [Method Parameters](./getcursor.md)
*   [Examples](./getcursor.md)