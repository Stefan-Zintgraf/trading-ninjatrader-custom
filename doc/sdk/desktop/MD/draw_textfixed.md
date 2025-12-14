**Path**: [Draw.TextFixed()](./draw_textfixed.md)

# Draw.TextFixed()

# Draw.TextFixed()

## [Definition](./draw_textfixed.md)

Draws text in one of 5 available pre\-defined fixed locations on panel 1 (price panel) of a chart. Please note the **Z\-Order** is internally set for the method to always be drawn on top.

## [Method Return Value](./draw_textfixed.md)

A **[TextFixed](./textfixed.md)** object that represents the draw object.

## [Syntax](./draw_textfixed.md)

`Draw.TextFixed(NinjaScriptBase owner, string tag, string text, TextPosition textPosition, Brush textBrush, SimpleFont font, Brush outlineBrush, Brush areaBrush, int areaOpacity)`

`Draw.TextFixed(NinjaScriptBase owner, string tag, string text, TextPosition textPosition)`

`Draw.TextFixed(NinjaScriptBase owner, string tag, string text, TextPosition textPosition, bool isGlobal, string templateName)`

## [Parameters](./draw_textfixed.md)

owner

The hosting **NinjaScript** object which is calling the draw method. Typically will be the object which is calling the draw method (e.g., "this").

tag

A user defined unique id used to reference the draw object. For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time.

text

The text you wish to draw.

TextPosition

**TextPosition.BottomLeft**

**TextPosition.BottomRight**

**TextPosition.Center**

**TextPosition.TopLeft**

**TextPosition.TopRight**

textBrush

The brush used to color the text of the draw object ([reference](./brushes.md)).

font

A **SimpleFont** object.

outlineBrush

The brush used to color the text box outline ([reference](http://msdn.microsoft.com/en-us/library/system.drawing.color_members(v=vs.90).aspx)).

areaBrush

The brush used to color the text box fill area ([reference](http://msdn.microsoft.com/en-us/library/system.drawing.color_members(v=vs.90).aspx)).

areaOpacity

Sets the level of transparency for the fill color. Valid values between 0 \- 100. (0 = completely transparent, 100 = no opacity).

isGlobal

Determines if the draw object will be global across all charts which match the instrument.

templateName

The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead).

## [Examples](./draw_textfixed.md)

```csharp
// Draws text in the upper right corner of panel 1
Draw.TextFixed(this, "tag1", "Text to draw", TextPosition.TopRight);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tip: In some cases, it may be useful to pass in the ChartControl.Properties **TextFont brush as well as the LabelFont**SimpleFont object to render your custom text. This will help ensure that the text will be visible and match what a user has configured for their chart label display settings.

```csharp
// match the text brush to what the user has configured on their chart
Draw.TextFixed(this, "myTextFixed", "Hello world!", TextPosition.BottomRight, ChartControl.Properties.ChartText, ChartControl.Properties.LabelFont, Brushes.Blue, Brushes.Transparent, 0);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./draw_textfixed.md)
*   [Method Return Value](./draw_textfixed.md)
*   [Syntax](./draw_textfixed.md)
*   [Parameters](./draw_textfixed.md)
*   [Examples](./draw_textfixed.md)