**Path**: [Draw.FibonacciCircle()](./draw_fibonaccicircle.md) > [FibonacciCircle](./fibonaccicircle.md)

# FibonacciCircle

# FibonacciCircle

## [Definition](./fibonaccicircle.md)

Represents an interface that exposes information regarding a Fibonacci Circle **IDrawingTool**.

## [Methods and Properties](./fibonaccicircle.md)

Parameter

Description

StartAnchor

An IDrawingTool's ChartAnchor representing the starting point of the drawing object

EndAnchor

An IDrawingTool's ChartAnchor representing the end point of the drawing object

PriceLevels

A collection of prices calculated by the drawing object

IsTimePriceDividedSeparately

A bool value which when true determines if the time and price are calculated together as a ratio, or independently

IsTextDisplayed

A bool value determining if the draw object should display text on the chart.

## [Examples](./fibonaccicircle.md)

```csharp
// Instantiate a Fibonacci circle
FibonacciCircle myFibCirc = Draw.FibonacciCircle(this, "tag1", true, 10, Low[10], 0, High[0]);

// Ensure that text is being displayed on the Drawing Object
myFibCirc.IsTextDisplayed = true;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./fibonaccicircle.md)
*   [Methods and Properties](./fibonaccicircle.md)
*   [Examples](./fibonaccicircle.md)