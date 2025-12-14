**Path**: [Draw.Ray()](./draw_ray.md) > [Ray](./ray.md)

# Ray

# Ray

## [Definition](./ray.md)

Represents an interface that exposes information regarding a Ray **IDrawingTool**.

## [Methods and Properties](./ray.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

Stroke

A **Stroke** object used to draw the object

## [Examples](./ray.md)

```csharp
// Instantiate a Ray object
Ray myRay = Draw.Ray(this, "tag1", 10, 1000, 0, 1001, Brushes.LimeGreen);
 
// Set a new Stroke for the object
myRay.Stroke = new Stroke(Brushes.Green, DashStyleHelper.DashDot, 3);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ray.md)
*   [Methods and Properties](./ray.md)
*   [Examples](./ray.md)