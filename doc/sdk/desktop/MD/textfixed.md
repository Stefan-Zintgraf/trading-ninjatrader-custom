**Path**: [Draw.TextFixed()](./draw_textfixed.md) > [TextFixed](./textfixed.md)

# TextFixed

# TextFixed

## [Definition](./textfixed.md)

Represents an interface that exposes information regarding a Text Fixed **IDrawingTool**.

## [Methods and Properties](./textfixed.md)

Anchor

YPixelOffset

Alignment

AreaOpacity

AreaBrush

DisplayText

TextBrush

Font

OutlineStroke

TextPosition

An **IDrawingTool's ChartAnchor** representing the point of the drawing object

An **int** value representing the offset value in pixels from within the text box area

Possible values are:

**TextAlignment.Center**  
**TextAlignment.Far**  
**TextAlignment.Near**  
**TextAlignment.Justify**  
([reference](https://msdn.microsoft.com/en-us/library/system.windows.textalignment%28v=vs.110%29.aspx))

An **int** value representing the opacity of the area color

A **Brush** class representing the fill color of the text box

A **string** value representing the text to be drawn

A **Brush** class representing the color of the text

A **Font** object representing the font for the text

The **Stroke** object used to outline the text box

Possible values are:

**TextPosition.BottomLeft**  
**TextPosition.BottomRight**  
**TextPosition.Center**  
**TextPosition.TopLeft**  
**TextPosition.TopRight**

## [Examples](./textfixed.md)

```csharp
// Instantiate a TextFixed object
TextFixed myTF = Draw.TextFixed(this, "tag1", "Text to draw", TextPosition.TopRight);
 
// Change the object's TextPosition
myTF.TextPosition = TextPosition.Center;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./textfixed.md)
*   [Methods and Properties](./textfixed.md)
*   [Examples](./textfixed.md)