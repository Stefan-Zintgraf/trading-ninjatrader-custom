**Path**: [Draw.PathTool()](./draw_pathtool.md) > [PathTool](./pathtool.md)

# PathTool

# PathTool

## [Definition](./pathtool.md)

Represents an interface that exposes information regarding a PathTool **IDrawingTool**.

## [Methods and Properties](./pathtool.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

Stroke

A **Stroke** object used to draw the object

## [Examples](./pathtool.md)

```csharp
// Instantiate a PathTool object
PathTool myPathTool = Draw.PathTool(this, "tag1", false, 20, 194, 10, 184, 13, 176, 25, 182);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./pathtool.md)
*   [Methods and Properties](./pathtool.md)
*   [Examples](./pathtool.md)