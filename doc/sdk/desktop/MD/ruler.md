**Path**: [Draw.Ruler()](./draw_ruler.md) > [Ruler](./ruler.md)

# Ruler

# Ruler

## [Definition](./ruler.md)

Represents an interface that exposes information regarding a Ruler **IDrawingTool**.

## [Methods and Properties](./ruler.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

TextAnchor

An **IDrawingTool's ChartAnchor** representing the text point of the drawing object

TextColor

A **Brush** class representing the fill color of the draw object's text area

LineColor

A **Stroke** object used to draw the object

## [Examples](./ruler.md)

```csharp
// Instantiate a Ruler object
Ruler myRuler = Draw.Ruler(this, "tag1", true, 4, Low[4], 3, High[3], 1, Low[1]);

// Change the object's text color to white
myRuler.TextColor = Brushes.White;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ruler.md)
*   [Methods and Properties](./ruler.md)
*   [Examples](./ruler.md)