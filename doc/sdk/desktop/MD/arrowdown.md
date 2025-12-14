**Path**: [Draw.ArrowDown()](./draw_arrowdown.md) > [ArrowDown](./arrowdown.md)

# ArrowDown

# ArrowDown

## [Definition](./arrowdown.md)

Represents an interface that exposes information regarding an Arrow Down IDrawingTool.

## [Methods and Properties](./arrowdown.md)

Anchor

An IDrawingTool's ChartAnchor representing the point of the drawing object

AreaBrush

A Brush object representing the fill color of the draw object

OutlineBrush

A Brush object representing the color of the draw object's outline

## [Example](./arrowdown.md)

```csharp
// Instantiate an ArrowDown object
ArrowDown myArrow = Draw.ArrowDown(this, "tag1", true, Time[0], High[0] + (2 * TickSize), Brushes.Green);

// Set the outline color of the Arrow
myArrow.OutlineBrush = Brushes.Black;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./arrowdown.md)
*   [Methods and Properties](./arrowdown.md)
*   [Example](./arrowdown.md)