**Path**: [Draw.ExtendedLine()](./draw_extendedline.md) > [ExtendedLine](./extendedline.md)

# ExtendedLine

# ExtendedLine

## [Definition](./extendedline.md)

Represents an interface that exposes information regarding an Extended Line **IDrawingTool**.

## [Methods and Properties](./extendedline.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

Stroke

A **Stroke** object used to draw the object

## [Examples](./extendedline.md)

```csharp
// Instantiate a dotted lime green Extended Line
ExtendedLine myLine = Draw.ExtendedLine(this, "tag1", 10, Close[10], 0, Close[0], Brushes.LimeGreen, DashStyleHelper.Dot, 2);

// Make the line a Global Drawing Object
myLine.IsGlobalDrawingTool = true;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./extendedline.md)
*   [Methods and Properties](./extendedline.md)
*   [Examples](./extendedline.md)