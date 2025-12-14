**Path**: [Draw.Line()](./draw_line.md) > [Line](./line.md)

# Line

# Line

## [Definition](./line.md)

Represents an interface that exposes information regarding a Line [IDrawingTool](./idrawingtool.md).

## [Methods and Properties](./line.md)

StartAnchor

An [IDrawingTool's ChartAnchor](./idrawingtool.md) representing the starting point of the drawing object

EndAnchor

An [IDrawingTool's ChartAnchor](./idrawingtool.md) representing the end point of the drawing object

Stroke

A [Stroke](./stroke_class.md) object used to draw the object

## [Examples](./line.md)

```csharp
// Instantiate a Line object
NinjaTrader.NinjaScript.DrawingTools.Line myLine = Draw.Line(this, "tag1", false, 10, 1000, 0, 1001, Brushes.LimeGreen, DashStyleHelper.Dot, 2);

// Set a new Stroke for the object
myLine.Stroke = new Stroke(Brushes.Green, DashStyleHelper.Dash, 5);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

To differentiate between NinjaTrader.NinjaScript.DrawingTools.Line and NinjaTrader.Gui.Line when assigning a Line object, you will need to invoke the former path explicitly, as seen in the example above.

#### ON THIS PAGE

*   [Definition](./line.md)
*   [Methods and Properties](./line.md)
*   [Examples](./line.md)