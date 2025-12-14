**Path**: [Draw.Arc()](./draw_arc.md) > [Arc](./arc.md)

# Arc

# Arc

## [Definition](./arc.md)

Represents an interface that exposes information regarding an Arc **IDrawingTool**.

## [Methods and Properties](./arc.md)

Parameter

Description

StartAnchor

An IDrawingTool's ChartAnchor representing the starting point of the drawing object

EndAnchor

An IDrawingTool's ChartAnchor representing the end point of the drawing object

AreaBrush

A Brush object representing the fill color of the draw object

AreaOpacity

An int value representing the opacity of the area color

ArcStroke

The Stroke object used to draw the arc line of the object's outline

Stroke

The Stroke object used to draw the straight line of the object's outline

## [Example](./arc.md)

```csharp
// Draw an Arc object
Arc myArc = Draw.Arc(this, "myArc", Time[10], Close[10], Time[0], Close[0], Brushes.Blue);

// Set the opacity of the shading between the arc and the chord
myArc.AreaOpacity = 100;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./arc.md)
*   [Methods and Properties](./arc.md)
*   [Example](./arc.md)