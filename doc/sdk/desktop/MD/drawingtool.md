**Path**: [ChartAnchor](./chartanchor.md) > [DrawingTool](./drawingtool.md)

# DrawingTool

# DrawingTool

## [Definition](./drawingtool.md)

The **DrawingTool** object which owns a chart anchor.

## [Property Value](./drawingtool.md)

A **IDrawingTool** object representing the owner of the chart anchor.

## [Syntax](./drawingtool.md)

`<chartanchor>.DrawingTool`

## [Examples](./drawingtool.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {   
						Name = "SampleDrawingTool";       
						MyAnchor = new ChartAnchor();
						MyAnchor.DrawingTool = this; // NinjaTrader.NinjaScript.DrawingTools.SampleDrawingTool
			}
     else if (State == State.Configure)
     {

     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./drawingtool.md)
*   [Property Value](./drawingtool.md)
*   [Syntax](./drawingtool.md)
*   [Examples](./drawingtool.md)