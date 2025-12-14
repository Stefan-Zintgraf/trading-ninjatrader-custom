**Path**: [Draw.GannFan()](./draw_gannfan.md)

# Draw.GannFan()

# Draw.GannFan()

## [Definition](./draw_gannfan.md)

Draws a Gann Fan.

## [Method Return Value](./draw_gannfan.md)

A **[GannFan](./gannfan.md)** object that represents the draw object.

## [Syntax](./draw_gannfan.md)

`Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, int barsAgo, double y)`

`Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime time, double y)`

`Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, int barsAgo, double y, bool isGlobal, string templateName)`

`Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime time, double y, bool isGlobal, string templateName)`

## [Parameters](./draw_gannfan.md)

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

isGlobal

Determines if the draw object will be global across all charts which match the instrument.

templateName

The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead).

## [Examples](./draw_gannfan.md)

```csharp
// Draws a Gann Fan at the current bar low  
Draw.GannFan(this, "tag1", true, 0, Low[0]);


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./draw_gannfan.md)
*   [Method Return Value](./draw_gannfan.md)
*   [Syntax](./draw_gannfan.md)
*   [Parameters](./draw_gannfan.md)
*   [Examples](./draw_gannfan.md)