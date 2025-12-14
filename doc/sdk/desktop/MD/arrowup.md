**Path**: [Draw.ArrowUp()](./draw_arrowup.md) > [ArrowUp](./arrowup.md)

# ArrowUp

# ArrowUp

## [Definition](./arrowup.md)

Represents an interface that exposes information regarding an Arrow Up [IDrawingTool](./idrawingtool.md).

## [Methods and Properties](./arrowup.md)

Anchor

An [IDrawingTool](./idrawingtool.md)'s **ChartAnchor** representing the point of the drawing object

AreaBrush

A **Brush** object representing the fill color of the draw object

OutlineBrush

A **Brush** object representing the color of the draw object's outline

## [Example](./arrowup.md)

```csharp
// Instantiate an ArrowDown object
ArrowUp myArrow = Draw.ArrowUp(this, "tag1", true, Time[0], Low[0] - (2 * TickSize), Brushes.Green);

// Set the outline color of the Arrow
myArrow.OutlineBrush = Brushes.Black;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./arrowup.md)
*   [Methods and Properties](./arrowup.md)
*   [Example](./arrowup.md)