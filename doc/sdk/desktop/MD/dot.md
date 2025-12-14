**Path**: [Draw.Dot()](./draw_dot.md) > [Dot](./dot.md)

# Dot

# Dot

## [Definition](./dot.md)

Represents an interface that exposes information regarding a Dot **IDrawingTool**.

## [Methods and Properties](./dot.md)

Parameter

Description

Anchor

An **IDrawingTool's ChartAnchor** representing the point of the drawing object

AreaBrush

A **Brush** object representing the fill color of the draw object

OutlineBrush

A **Brush** object representing the color of the draw object's outline

## [Examples](./dot.md)

```csharp
// Instantiates a red dot on the current bar 1 tick below the low
Dot myDot = Draw.Dot(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);

// Disable the dot's Auto Scale property
myDot.IsAutoScale = false;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./dot.md)
*   [Methods and Properties](./dot.md)
*   [Examples](./dot.md)