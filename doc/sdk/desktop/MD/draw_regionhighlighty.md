**Path**: [Draw.RegionHighlightY()](./draw_regionhighlighty.md)

# Draw.RegionHighlightY()

# Draw.RegionHighlightY()

## [Definition](./draw_regionhighlighty.md)

Draws a region highlight y on a chart.

## [Method Return Value](./draw_regionhighlighty.md)

A **[RegionHighlightY](./regionhighlighty.md)** object that represents the draw object.

## [Syntax](./draw_regionhighlighty.md)

`Draw.RegionHighlightY(NinjaScriptBase owner, string tag, double startY, double endY, Brush brush)`

`Draw.RegionHighlightY(NinjaScriptBase owner, string tag, bool isAutoScale, double startY, double endY, Brush brush, Brush areaBrush, int areaOpacity)`

`Draw.RegionHighlightY(NinjaScriptBase owner, string tag, double startY, double endY, bool isGlobal, string templateName)`

## [Parameters](./draw_regionhighlighty.md)

owner

The hosting **NinjaScript** object which is calling the draw method. Typically will be the object which is calling the draw method (e.g., "this").

tag

A user defined unique id used to reference the draw object. For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time.

isAutoScale

Determines if the draw object will be included in the y\-axis scale. Default value is false.

startY

The starting y value co\-ordinate where the draw object will be drawn.

endY

The ending y value co\-ordinate where the draw object will be drawn.

brush

The brush used to color the outline of draw object ([reference](./brushes.md)).

areaBrush

The brush used to color the fill area of the draw object ([reference](./brushes.md)).

areaOpacity

Sets the level of transparency for the fill color. Valid values between 0 \- 100. (0 = completely transparent, 100 = no opacity).

isGlobal

Determines if the draw object will be global across all charts which match the instrument.

templateName

The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead).

## [Examples](./draw_regionhighlighty.md)

```csharp
// Fills in the region between the startY and endY
Draw.RegionHighlightY(this, "tag1", true, High[0], Low[0], Brushes.Blue, Brushes.Green, 20);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./draw_regionhighlighty.md)
*   [Method Return Value](./draw_regionhighlighty.md)
*   [Syntax](./draw_regionhighlighty.md)
*   [Parameters](./draw_regionhighlighty.md)
*   [Examples](./draw_regionhighlighty.md)