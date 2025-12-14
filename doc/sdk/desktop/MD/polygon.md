**Path**: [Draw.Polygon()](./draw_polygon.md) > [Polygon](./polygon.md)

# Polygon

# Polygon

## [Definition](./polygon.md)

Represents an interface that exposes information regarding a **Polygon** **IDrawingTool**.

## [Methods and Properties](./polygon.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

Stroke

A **Stroke** object used to draw the object

## [Examples](./polygon.md)

```csharp
// Instantiate a Polygon object
Polygon myPolygon = Draw.Polygon(this, "tag1", false, 20, 194, 10, 184, 13, 176, 25, 182);

// Set a new area brush for the object
myPolygon.AreaBrush = Brushes.Green;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./polygon.md)
*   [Methods and Properties](./polygon.md)
*   [Examples](./polygon.md)