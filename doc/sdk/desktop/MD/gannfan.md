**Path**: [Draw.GannFan()](./draw_gannfan.md) > [GannFan](./gannfan.md)

# GannFan

# GannFan

## [Definition](./gannfan.md)

Represents an interface that exposes information regarding a Gann Fan **IDrawingTool**.

## [Methods and Properties](./gannfan.md)

Parameter

Description

Anchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

[PriceLevels](./pricelevels.md)

A collection of prices calculated by the drawing object

GannFanDirection

Possible values:

*   **GannFanDirection.DownLeft**
    
*   **GannFanDirection.DownRight**
    
*   **GannFanDirection.UpLeft**
    
*   **GannFanDirection.UpRight**
    

PointsPerBar

A **double** value representing the number of points per bar

IsTextDisplayed

A bool value representing if text will be drawn along with the draw object

## [Examples](./gannfan.md)

```csharp
// Instantiate a GannFan object
GannFan myFan = Draw.GannFan(this, "tag1", true, 0, Low[0]);

// Instantiate a new PriceLevel to be used in the step below
PriceLevel myLevel = new PriceLevel(99, Brushes.Black);

// Change the object's price level at index 3
myFan.PriceLevels[3] = myLevel;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gannfan.md)
*   [Methods and Properties](./gannfan.md)
*   [Examples](./gannfan.md)