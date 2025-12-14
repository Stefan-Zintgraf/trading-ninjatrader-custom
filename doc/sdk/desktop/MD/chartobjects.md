**Path**: [ChartPanel](./chartpanel.md) > [ChartObjects](./chartobjects.md)

# ChartObjects

# ChartObjects

## [Definition](./chartobjects.md)

A collection of objects configured on the chart panel.

## [Property Value](./chartobjects.md)

An **IList** of **Gui.NinjaScript.IChartObject** instances containing references to the objects configured on the panel.

## [Syntax](./chartobjects.md)

`ChartPanel.ChartObjects`

## [Examples](./chartobjects.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);

    IList<Gui.NinjaScript.IChartObject> myObjects = ChartPanel.ChartObjects;

    foreach (Gui.NinjaScript.IChartObject thisObject in myObjects)
    {
        Print(String.Format("{0} is of type {1}", thisObject.Name, thisObject.GetType()));
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

The image below shows the output of the code example above, while applied in a chart panel with three objects.

![ChartPanel_ChartObjects](https://cdn.sanity.io/images/1hlwceal/production/c9531d702404228d0f41d521c92ded9a8cc0f2ac-774x488.png)

#### ON THIS PAGE

*   [Definition](./chartobjects.md)
*   [Property Value](./chartobjects.md)
*   [Syntax](./chartobjects.md)
*   [Examples](./chartobjects.md)