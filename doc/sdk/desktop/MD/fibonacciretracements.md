**Path**: [Draw.FibonacciRetracements()](./draw_fibonacciretracements.md) > [FibonacciRetracements](./fibonacciretracements.md)

# FibonacciRetracements

# FibonacciRetracements

## [Definition](./fibonacciretracements.md)

Represents an interface that exposes information regarding a Fibonacci Retracements **IDrawingTool**.

## [Methods and Properties](./fibonacciretracements.md)

Parameter

Description

StartAnchor

An IDrawingTool's ChartAnchor representing the starting point of the drawing object

EndAnchor

An IDrawingTool's ChartAnchor representing the end point of the drawing object

[PriceLevels](./pricelevels.md)

A collection of prices calculated by the drawing object

TextLocation

An enum determining the text location; can be set to **TextLocation.Off** to remove text

IsExtendedLinesLeft

A bool value determining if the draw object should draw lines to the far left side of the screen

IsExtendedLinesRight

A bool value determining if the draw object should draw lines to the far right side of the screen

## [Examples](./fibonacciretracements.md)

```csharp
// Instantiate a FibonacciRetracements object
FibonacciRetracements myFibRet = Draw.FibonacciRetracements(this, "tag1", true, 10, Low[10], 0, High[0]);

// Set the object's lines to extend to the right
myFibRet.IsExtendedLinesRight = true;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./fibonacciretracements.md)
*   [Methods and Properties](./fibonacciretracements.md)
*   [Examples](./fibonacciretracements.md)