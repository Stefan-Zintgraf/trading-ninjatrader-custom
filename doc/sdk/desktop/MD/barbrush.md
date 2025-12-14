**Path**: [Drawing](./drawing.md) > [BarBrush](./barbrush.md)

# BarBrush

# BarBrush

## [Definition](./barbrush.md)

Sets the brush used for painting the color of a price bar's body.

## [Property Value](./barbrush.md)

A Brush object that represents the color of this price bar.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

To set the price bar color to an empty color which uses the default bar color property, set the BarBrush to null for that bar.

## [Syntax](./barbrush.md)

BarBrush

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

You may have up to 65,535 unique BarBrush instances, therefore, using static predefined brushes should be favored. Alternatively, in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created.

## [Examples](./barbrush.md)

```csharp
protected override void OnBarUpdate()
{
     // Sets the bar color to yellow
     BarBrush = Brushes.Yellow;

     // Sets the brush used for the bar color to its default color as defined in the chart properties dialog
     BarBrush = null;

     // Sets the bar color to yellow if the 20 SMA is above the 50 SMA and the closing
     // price is above the 20 SMA (see image below)
     if (SMA(20)[0] > SMA(50)[0] && Close[0] > SMA(20)[0])
         BarBrush = Brushes.Yellow;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barbrush.md)
*   [Property Value](./barbrush.md)
*   [Syntax](./barbrush.md)
*   [Examples](./barbrush.md)