**Path**: [ChartAnchor](./chartanchor.md) > [DrawnOnBar](./drawnonbar.md)

# DrawnOnBar

# DrawnOnBar

## [Definition](./drawnonbar.md)

Gets the current bar value that the chart anchor is drawn by a **NinjaScript** object. Please see the [Drawing](./drawing.md) section for more information.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This value will NOT work on manually drawn objects. This property is reserved for chart anchors which were drawn by another **NinjaScript** object (e.g., using a Draw method in an indicator). For manually drawn objects, please see the [SlotIndex](./barindex.md) property.

## [Property Value](./drawnonbar.md)

A int value that value which the current bar the chart anchor is drawn. This property is read\-only.

## [Syntax](./drawnonbar.md)

`<chartanchor>.DrawnOnBar`

## [Examples](./drawnonbar.md)

```csharp
// Places text if high is 2419 and prints what bar the text was drawn on
if (High[0] == 2419)
{
    Text myText = Draw.Text(this, @"Text " + CurrentBar, @"High is 2419" , 0, High[0]);
    Print("Text is on bar " + myText.Anchor.DrawnOnBar);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./drawnonbar.md)
*   [Property Value](./drawnonbar.md)
*   [Syntax](./drawnonbar.md)
*   [Examples](./drawnonbar.md)