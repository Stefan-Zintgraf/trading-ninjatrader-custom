**Path**: [Draw.HorizontalLine()](./draw_horizontal_line.md) > [HorizontalLine](./horizontalline.md)

# HorizontalLine

# HorizontalLine

## [Definition](./horizontalline.md)

Represents an interface that exposes information regarding a Horizontal Line **IDrawingTool**.

## [Methods and Properties](./horizontalline.md)

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

Stroke

A **Stroke** object used to draw the object

## [Examples](./horizontalline.md)

```csharp
// Instantiate a HorizontalLine object
HorizontalLine myLine = Draw.HorizontalLine(this, "tag1", 1000, Brushes.Black);

// Set a new Stroke for the object
myLine.Stroke = new Stroke(Brushes.Green, DashStyleHelper.Dash, 5);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./horizontalline.md)
*   [Methods and Properties](./horizontalline.md)
*   [Examples](./horizontalline.md)