**Path**: [Drawing Tools](./drawing_tools.md) > [AddPastedOffset()](./addpastedoffset.md)

# AddPastedOffset()

# AddPastedOffset()

## [Definition](./addpastedoffset.md)

A [virtual method](https://msdn.microsoft.com/en-us/library/9fkccyh4.aspx) which is called every time a DrawingTool is copied and pasted to a chart. The default behavior will offset the chart anchors price value down by 1, percent. However, this behavior can be overridden for your custom drawing tool if desired.

## [Method Return Value](./addpastedoffset.md)

This method does not return a value

## [Syntax](./addpastedoffset.md)

You must override this method using the following syntax:

`public override void AddPastedOffset(ChartPanel panel, ChartScale chartScale)`

## [Method Parameters](./addpastedoffset.md)

panel

chartScale

A ChartPanel representing the the panel for the chart

A ChartScale representing the Y\-axis

## [Examples](./addpastedoffset.md)

```csharp
public override void AddPastedOffset(ChartPanel chartPanel, ChartScale chartScale)
{      
   foreach (ChartAnchor anchor in Anchors)
   {
     //bump each anchor 1 minute to the right
     DateTime tmpTime = anchor.Time;
     anchor.Time = tmpTime.AddMinutes(1);        
   }         
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./addpastedoffset.md)
*   [Method Return Value](./addpastedoffset.md)
*   [Syntax](./addpastedoffset.md)
*   [Method Parameters](./addpastedoffset.md)
*   [Examples](./addpastedoffset.md)