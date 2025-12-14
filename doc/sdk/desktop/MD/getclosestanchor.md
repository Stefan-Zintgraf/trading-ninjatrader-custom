**Path**: [ChartAnchor](./chartanchor.md) > [GetClosestAnchor()](./getclosestanchor.md)

# GetClosestAnchor()

# GetClosestAnchor()

## [Definition](./getclosestanchor.md)

Returns the closest chart anchor within a specified maximum distance from the mouse cursor.

## [Method Return Value](./getclosestanchor.md)

This method returns an existing **ChartAnchor**.

## [Syntax](./getclosestanchor.md)

`GetClosestAnchor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, double maxDist, Point point)`

## [Method Parameters](./getclosestanchor.md)

**chartControl**

A **ChartControl** representing the x\-axis

**chartPanel**

A **ChartPanel** representing the panel for the chart

**chartScale**

A **ChartScale** representing the y\-axis

**maxDist**

A **double** value representing the cursor's sensitivity used to detect the nearest anchor

**point**

A **Point** in device pixels representing the current mouse cursor position

## [Examples](./getclosestanchor.md)

```csharp

public override Cursor GetCursor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)
{
   // get the closest anchor to where the user has clicked
   ChartAnchor closest = GetClosestAnchor(chartControl, chartPanel, chartScale, 10, point);

   if (closest != null)
   {
     // set cursor to indicate that it can be moved
     return Cursors.SizeNWSE;
   }
   // otherwise set cursor back to arrow
   else return Cursors.Arrow;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getclosestanchor.md)
*   [Method Return Value](./getclosestanchor.md)
*   [Syntax](./getclosestanchor.md)
*   [Method Parameters](./getclosestanchor.md)
*   [Examples](./getclosestanchor.md)