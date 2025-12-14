**Path**: [ChartAnchor](./chartanchor.md) > [IsEditing](./isediting.md)

# IsEditing

# IsEditing

## [Definition](./isediting.md)

Determines if the anchor can be edited.

## [Property Value](./isediting.md)

A bool value which when true determines if the chart anchor is currently in a state it can be edited. Default is false.

## [Syntax](./isediting.md)

`<chartanchor>.IsEditing`

## [Examples](./isediting.md)

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)
{
    if (DrawingState == DrawingState.Building)
    {
        // if drawing tool is currently editing, update to current mouse point
        if (MyAnchor.IsEditing)
        {
            MyAnchor.UpdateFromPoint(point, chartControl, chartScale);

            //set the anchor to disable editing when done updating
            MyAnchor.IsEditing = false;
        }
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isediting.md)
*   [Property Value](./isediting.md)
*   [Syntax](./isediting.md)
*   [Examples](./isediting.md)