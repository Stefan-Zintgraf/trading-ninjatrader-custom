**Path**: [Draw.Diamond()](./draw_diamond.md) > [Diamond](./diamond.md)

# Diamond

# Diamond

## [Definition](./diamond.md)

Represents an interface that exposes information regarding a Diamond **IDrawingTool**.

## [Methods and Properties](./diamond.md)

Parameter

Description

Anchor

An **IDrawingTool's ChartAnchor** representing the point of the drawing object

AreaBrush

A **Brush** object representing the fill color of the draw object

OutlineBrush

A **Brush** object representing the color of the draw object's outline

## [Examples](./diamond.md)

```csharp
// Instantiates a red diamond on the current bar 1 tick below the low
Diamond myDiamond = Draw.Diamond(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);

// Set the area fill color to Red
myDiamond.AreaBrush = Brushes.Red;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./diamond.md)
*   [Methods and Properties](./diamond.md)
*   [Examples](./diamond.md)