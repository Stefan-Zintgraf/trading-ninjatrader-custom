**Path**: [Draw.HorizontalLine()](./draw_horizontal_line.md)

# Draw.HorizontalLine()

# Draw.HorizontalLine()

## [Definition](./draw_horizontal_line.md)

Draws a horizontal line.

## [Method Return Value](./draw_horizontal_line.md)

A **[HorizontalLine](./horizontalline.md)** object that represents the draw object.

## [Syntax](./draw_horizontal_line.md)

`Draw.HorizontalLine(NinjaScriptBase owner, string tag, double y, Brush brush)`

`Draw.HorizontalLine(NinjaScriptBase owner, string tag, bool isAutoScale, double y, Brush brush, DashStyleHelper dashStyle, int width)`

`Draw.HorizontalLine(NinjaScriptBase owner, string tag, bool isAutoscale, double y, Brush brush, bool drawOnPricePanel)`

`Draw.HorizontalLine(NinjaScriptBase owner, string tag, double y, Brush brush, DashStyleHelper dashStyle, int width, bool drawOnPricePanel)`

`Draw.HorizontalLine(NinjaScriptBase owner, string tag, double y, bool isGlobal, string templateName)`

## [Parameters](./draw_horizontal_line.md)

owner

The hosting **NinjaScript** object which is calling the draw method. Typically will be the object which is calling the draw method (e.g., "this").

tag

A user defined unique id used to reference the draw object. For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time.

isAutoScale

Determines if the draw object will be included in the y\-axis scale. Default value is false.

y

The y value.

brush

The brush used to color draw object ([reference](./brushes.md)).

dashStyle

Possible values include:

*   **DashStyleHelper.Dash**,
*   **DashStyleHelper.DashDot**,
*   **DashStyleHelper.DashDotDot**,
*   **DashStyleHelper.Dot**,
*   **DashStyleHelper.Solid**.

width

The width of the draw object.

isDrawOnPricePanel

Determines if the draw\-object should be on the price panel or a separate panel.

isGlobal

Determines if the draw object will be global across all charts which match the instrument.

templateName

The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Drawing objects with y values very far off the visible canvas can lead to performance hits. Fancier DashStyles like **DashDotDot** will also require more resources than simple DashStyles like **Solid**.

## [Examples](./draw_horizontal_line.md)

```csharp
// Draws a horizontal line
Draw.HorizontalLine(this, "tag1", 1000, Brushes.Black);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./draw_horizontal_line.md)
*   [Method Return Value](./draw_horizontal_line.md)
*   [Syntax](./draw_horizontal_line.md)
*   [Parameters](./draw_horizontal_line.md)
*   [Examples](./draw_horizontal_line.md)