**Path**: [Draw.Ellipse()](./draw_ellipse.md) > [Ellipse](./ellipse.md)

# Ellipse

# Ellipse

## [Definition](./ellipse.md)

Represents an interface that exposes information regarding an Ellipse **IDrawingTool**.

## [Methods and Properties](./ellipse.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

AreaBrush

A **Brush** class representing the fill color of the draw object

AreaOpacity

An **int** value representing the opacity of the area color

OutlineStroke

The **Stroke** object used to draw the object's outline

## [Examples](./ellipse.md)

```csharp
// Paint a red ellipse on the current bar
Ellipse myEllipse = Draw.Ellipse(this, "tag1", true, 5, Close[5], 0, Close[0], Brushes.Red, Brushes.Red, 5);

// Change the AreaOpacity of the Ellipse
myEllipse.AreaOpacity = 0;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ellipse.md)
*   [Methods and Properties](./ellipse.md)
*   [Examples](./ellipse.md)