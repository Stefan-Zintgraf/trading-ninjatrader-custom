**Path**: [Draw.Square()](./draw_square.md) > [Square](./square.md)

# Square

# Square

## [Definition](./square.md)

Represents an interface that exposes information regarding a Square **IDrawingTool**.

## [Methods and Properties](./square.md)

Parameter

Description

Anchor

An **IDrawingTool's ChartAnchor** representing the point of the drawing object

OutlineBrush

A **Brush** used for the outline of the square

AreaBrush

A **Brush** object representing the fill color of the draw object

## [Examples](./square.md)

```csharp
// Instantiate a Square object
Square mySquare = Draw.Square(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);
 
// Change the object's OutlineBrush
mySquare.OutlineBrush = Brushes.Blue;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./square.md)
*   [Methods and Properties](./square.md)
*   [Examples](./square.md)