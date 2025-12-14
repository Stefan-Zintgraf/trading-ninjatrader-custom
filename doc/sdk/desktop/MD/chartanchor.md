**Path**: [ChartAnchor](./chartanchor.md)

# ChartAnchor

# ChartAnchor

## [Definition](./chartanchor.md)

Defines objects used by Drawing Tools which represent a point on the chart where the Drawing Tool is located.

## [Syntax](./chartanchor.md)

`class ChartAnchor`

## [Constructors](./chartanchor.md)

Constructor

Description

**new ChartAnchor()**

Initializes a new instance of the ChartAnchor object

**new ChartAnchor(DateTime time, double price, [ChartControl](./chartcontrol.md))**

Initializes a new instance of the ChartAnchor object using time, price, and relative chart control

**new ChartAnchor(DateTime time, double yValue, int currentBar, [ChartControl](./chartcontrol.md))**

Initializes a new instance of the ChartAnchor object using time, y\-axis coordinates, current bar, and relative chart control

## [Methods and Properties](./chartanchor.md)

Method/Property

Description

**[CopyDataValues()](./copydatavalues.md)**

Copies the ChartAnchor time and price values from one anchor to another

**[DisplayName](./displayname.md)**

A **string** value which sets the name prefix used for all properties for a chart anchor

**[DrawingTool](./drawingtool.md)**

The drawing tool which owns a chart anchor

**[DrawnOnBar](./drawnonbar.md)**

Gets the current bar value that the chart anchor is drawn by a NinjaScript object.

**[GetPoint()](./getpoint.md)**

Returns a chart anchor's data points.

**[IsBrowsable](./isbrowsable.md)**

A bool value determining if the anchor is visible on the UI.

**[IsEditing](./isediting.md)**

A bool value determining if the anchor is currently being edited

**[IsNinjaScriptDrawn](./isninjascriptdrawn.md)**

Indicates if the chart anchor was drawn by a NinjaScript object

**[IsXPropertiesVisible](./isypropertyvisibile.md)**

A bool value determining if the X properties are visible on the UI

**[IsYPropertyVisible](./isypropertyvisibile.md)**

A bool value determining if the Y data value is visible on the UI

**[MoveAnchor()](./moveanchor.md)**

Moves a Chart Anchor's x and y values from start point by a delta point amount.

**[MoveAnchorX()](./moveanchorx.md)**

Moves an anchor's x values from start point by a delta point amount

**[MoveAnchorY()](./moveanchory.md)**

Moves an anchor's y values from start point by a delta point amount

**[Price](./price.md)**

Determines the price value the chart anchor is drawn.

**[SlotIndex](./barindex.md)**

Indicates the nearest bar slot where the anchor is drawn.

**[Time](./chartanchor_time.md)**

Determines the date/time value the chart anchor is drawn.

**[UpdateFromPoint()](./updatefrompoint.md)**

Updates an anchor's x and y values from a given point (in device pixels)

**[UpdateXFromPoint()](./updatexfrompoint.md)**

Updates an anchor's X values from a given point (in device pixels)

**[UpdateYFromPoint()](./updateyfrompoint.md)**

Updates an anchor's Y value from a given point (in device pixels)

## [Examples](./chartanchor.md)

```csharp

public ChartAnchor MyAnchor { get; set; } // declares the "MyAnchor" ChartAnchor object
public override IEnumerable<chartanchor> Anchors { get { return new[] { MyAnchor }; } } //adds the "MyAnchor" ChartAnchor object to a collection of anchors used to interact with your anchors
protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
     Description = @"Drawing tool example";
     Name = "SampleDrawingTool";

     MyAnchor = new ChartAnchor(); //creates a new instance of the ChartAnchor object
     MyAnchor.IsEditing = true;
     MyAnchor.DrawingTool = this;
     MyAnchor.IsBrowsable = false;
   }
}

public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
   if (DrawingState == DrawingState.Editing)
   {
     if (MyAnchor.IsEditing)
     {
         //if anchor is editing, update anchor point
         dataPoint.CopyDataValues(MyAnchor);
     }
   }


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./chartanchor.md)
*   [Syntax](./chartanchor.md)
*   [Constructors](./chartanchor.md)
*   [Methods and Properties](./chartanchor.md)
*   [Examples](./chartanchor.md)