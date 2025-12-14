**Path**: [Draw.TrendChannel()](./draw_trendchannel.md) > [TrendChannel](./trendchannel.md)

# TrendChannel

# TrendChannel

## [Definition](./trendchannel.md)

Represents an interface that exposes information regarding a Trend Channel [IDrawingTool](./idrawingtool.md).

## [Methods and Properties](./trendchannel.md)

Parameter

Description

TrendStartAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the starting point of the drawing object

TrendEndAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the end point of the drawing object

ParallelStartAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the starting point of the second line used in the trend channel

[PriceLevels](./pricelevels.md)

A collection of prices calculated by the drawing object

## [Example](./trendchannel.md)

```csharp
// Instantiate a TrendChannel object  
TrendChannel myTC = Draw.TrendChannel(this, "tag1", true, 10, Low[10], 0, High[0], 10, High[10] + 5 * TickSize);            
   
// Increase the y-axis position of the object's TrendEndAnchor  
myTC.TrendEndAnchor.Price += 15;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./trendchannel.md)
*   [Methods and Properties](./trendchannel.md)
*   [Example](./trendchannel.md)