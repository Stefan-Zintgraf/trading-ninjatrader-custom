**Path**: [Draw.Ray()](./draw_ray.md)

# Draw.Ray()

# Draw.Ray()

## [Definition](./draw_ray.md)

Draws a line which has an infinite end point in one direction.

## [Method Return Value](./draw_ray.md)

A **[Ray](./ray.md)** object that represents the draw object.

## [Syntax](./draw_ray.md)

`Draw.Ray(NinjaScriptBase owner, string tag, int startBarsAgo, double startY, int endBarsAgo, double endY, Brush brush)`

`Draw.Ray(NinjaScriptBase owner, string tag, bool isAutoScale, int startBarsAgo, double startY, int endBarsAgo, double endY, Brush brush, DashStyleHelper dashStyle, int width)`

`Draw.Ray(NinjaScriptBase owner, string tag, DateTime startTime, double startY, DateTime endTime, double endY, Brush brush)`

`Draw.Ray(NinjaScriptBase owner, string tag, DateTime startTime, double startY, DateTime endTime, double endY, Brush brush, DashStyleHelper dashStyle, int width)`

`Draw.Ray(NinjaScriptBase owner, string tag, bool isAutoScale, int startBarsAgo, double startY, int endBarsAgo, double endY, Brush brush, DashStyleHelper dashStyle, int width, bool drawOnPricePanel)`

`Draw.Ray(NinjaScriptBase owner, string tag, DateTime startTime, double startY, DateTime endTime, double endY, Brush brush, DashStyleHelper dashStyle, int width, bool drawOnPricePanel)`

`Draw.Ray(NinjaScriptBase owner, string tag, int startBarsAgo, double startY, int endBarsAgo, double endY, bool isGlobal, string templateName)`

`Draw.Ray(NinjaScriptBase owner, string tag, DateTime startTime, double startY, DateTime endTime, double endY, bool isGlobal, string templateName)`

## [Parameters](./draw_ray.md)

owner

The hosting **NinjaScript** object which is calling the draw method. Typically will be the object which is calling the draw method (e.g., "this").

tag

A user defined unique id used to reference the draw object. For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time.

isAutoScale

Determines if the draw object will be included in the y\-axis scale. Default value is false.

startBarsAgo

The number of bars ago (x value) of the 1st anchor point.

startTime

The time of the 1st anchor point.

startY

The y value of the 1st anchor point.

endBarsAgo

The number of bars ago (x value) of the 2nd anchor point.

endTime

The time of the 2nd anchor point.

endY

The y value of the 2nd anchor point.

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

drawOnPricePanel

Determines if the draw\-object should be on the price panel or a separate panel.

isGlobal

Determines if the draw object will be global across all charts which match the instrument.

templateName

The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Drawing objects with y values very far off the visible canvas can lead to performance hits. Fancier DashStyles like **DashDotDot** will also require more resources than simple DashStyles like **Solid**.

## [Examples](./draw_ray.md)

```csharp
// Draws a lime green ray from 10 bars back through the current bar  
Draw.Ray(this, "tag1", 10, 1000, 0, 1001, **Brushes.LimeGreen**);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./draw_ray.md)
*   [Method Return Value](./draw_ray.md)
*   [Syntax](./draw_ray.md)
*   [Parameters](./draw_ray.md)
*   [Examples](./draw_ray.md)