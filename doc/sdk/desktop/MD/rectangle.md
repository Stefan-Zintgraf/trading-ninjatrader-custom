**Path**: [Draw.Rectangle()](./draw_rectangle.md) > [Rectangle](./rectangle.md)

# Rectangle

# Rectangle

## [Definition](./rectangle.md)

Represents an interface that exposes information regarding a Rectangle **IDrawingTool**.

## [Methods and Properties](./rectangle.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

AreaBrush

A **Brush** object representing the fill color of the draw object

AreaOpacity

An **int** value representing the opacity of the area color

OutlineStroke

The **Stroke** object used to draw the object's outline

## [Examples](./rectangle.md)

```csharp
// Instantiate a Rectangle object
Rectangle myRec = Draw.Rectangle(this, "tag1", 10, Low[10] - TickSize, 5, High[5] + TickSize, Brushes.Blue);

// Set the object's AreaBrush to Blue
myRec.AreaBrush = Brushes.Blue;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./rectangle.md)
*   [Methods and Properties](./rectangle.md)
*   [Examples](./rectangle.md)