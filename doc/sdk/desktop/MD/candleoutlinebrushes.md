**Path**: [Drawing](./drawing.md) > [CandleOutlineBrushes](./candleoutlinebrushes.md)

# CandleOutlineBrushes

# CandleOutlineBrushes

## [Definition](./candleoutlinebrushes.md)

A collection of historical outline brushes for candlesticks.

## [Property Value](./candleoutlinebrushes.md)

A brush series type object. Accessing this property via an index value **int barsAgo** returns a [brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) structure representing the referenced bar's outline color.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This will only return the color of a candlestick outline in which an explicit color overwrite was used. Otherwise it will return null.

## [Syntax](./candleoutlinebrushes.md)

`CandleOutlineBrushes`

`CandleOutlineBrushes[int barsAgo]`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: You may have up to 65,535 unique CandleOutlineBrushes instances, therefore, using [static predefined brushes](./working_with_brushes.md) should be favored. Alternatively, in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created.

## [Examples](./candleoutlinebrushes.md)

```csharp
// Sets the outline color of the current bar to black.
CandleOutlineBrushes[0] = Brushes.Black;

// Sets the outline color of the previous bar to blue.
CandleOutlineBrushes[1] = Brushes.Blue;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./candleoutlinebrushes.md)
*   [Property Value](./candleoutlinebrushes.md)
*   [Syntax](./candleoutlinebrushes.md)
*   [Examples](./candleoutlinebrushes.md)