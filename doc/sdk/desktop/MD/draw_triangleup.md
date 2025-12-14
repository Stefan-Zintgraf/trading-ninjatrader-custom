**Path**: [Draw.TriangleUp()](./draw_triangleup.md)

# Draw.TriangleUp()

# Draw.TriangleUp()

## [Definition](./draw_triangleup.md)

Draws a triangle pointing up.

## [Method Return Value](./draw_triangleup.md)

A **[TriangleUp](./triangleup.md)** object that represents the draw object.

## [Syntax](./draw_triangleup.md)

`Draw.TriangleUp(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime time, double y, Brush brush)`

`Draw.TriangleUp(NinjaScriptBase owner, string tag, bool isAutoScale, int barsAgo, double y, Brush brush)`

`Draw.TriangleUp(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime time, double y, Brush brush, bool drawOnPricePanel)`

`Draw.TriangleUp(NinjaScriptBase owner, string tag, bool isAutoScale, int barsAgo, double y, Brush brush, bool drawOnPricePanel)`

`Draw.TriangleUp(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime time, double y, bool isGlobal, string templateName)`

`Draw.TriangleUp(NinjaScriptBase owner, string tag, bool isAutoScale, int barsAgo, double y, bool isGlobal, string templateName)`

## [Parameters](./draw_triangleup.md)

owner

The hosting **NinjaScript** object which is calling the draw method. Typically will be the object which is calling the draw method (e.g., "this").

tag

A user defined unique id used to reference the draw object. For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time.

isAutoScale

Determines if the draw object will be included in the y\-axis scale.

barsAgo

The bar the object will be drawn at. A value of 10 would be 10 bars ago.

time

The time the object will be drawn at.

y

The y value.

brush

The brush used to color draw object ([reference](./brushes.md)).

drawOnPricePanel

Determines if the draw\-object should be on the price panel or a separate panel.

isGlobal

Determines if the draw object will be global across all charts which match the instrument.

templateName

The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tip: The size of the triangle is tied to the chart's BarWidth and thus will scale automatically as the chart is resized.

## [Examples](./draw_triangleup.md)

```csharp
// Paints a red triangle pointing up on the current bar 1 tick below the low
Draw.TriangleUp(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./draw_triangleup.md)
*   [Method Return Value](./draw_triangleup.md)
*   [Syntax](./draw_triangleup.md)
*   [Parameters](./draw_triangleup.md)
*   [Examples](./draw_triangleup.md)