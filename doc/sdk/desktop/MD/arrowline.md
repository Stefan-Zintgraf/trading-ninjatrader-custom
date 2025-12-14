**Path**: [Draw.ArrowLine()](./draw_arrowline.md) > [ArrowLine](./arrowline.md)

# ArrowLine

# ArrowLine

## [Definition](./arrowline.md)

Represents an interface that exposes information regarding an Arrow Line **IDrawingTool**.

## [Methods and Properties](./arrowline.md)

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

Stroke

A **Stroke** object used to draw the object

## [Example](./arrowline.md)

```csharp
// Draw an ArrowLine object
ArrowLine myArrow = Draw.ArrowLine(this, "myArrowLine", 3, High[3], 1, High[1], Brushes.Blue, DashStyleHelper.DashDot, 3);

// Disable the arrow's visibility
myArrow.IsVisible = false;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./arrowline.md)
*   [Methods and Properties](./arrowline.md)
*   [Example](./arrowline.md)