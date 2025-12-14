**Path**: [ChartControl](./chartcontrol.md)

# ChartControl

# ChartControl

The **ChartControl** class provides access to a wide range of properties and methods related to the location of objects on a chart and other chart\-related properties. The **ChartControl** object provides information related to the entire hosting grid of the chart, which overlap with the [ChartPanel](./chartpanel.md), [ChartScale](./chartscale.md) and [ChartBars](./chartbars.md).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The **ChartControl** object is ONLY guaranteed to be available when a **NinjaScript** type initiates from a Chart Window. There are situations where an indicator or strategy starts from another Windows (such as the Control Center's Strategies Grid, or from a Strategy Analyzer), where the **ChartControl** object is NOT accessible. Therefore, the **ChartControl** object should always be safely accessed (e.g., from within a try\-catch, or conditionally using null reference checks).

![ChartControl_1](https://cdn.sanity.io/images/1hlwceal/production/2f45233e112f2ddc307e272a11ed424dfd8f9629-639x525.png)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: The **ChartControl** and its methods and properties should ONLY be accessed once the **State** has reached **State.Historical**.

## [Methods and Properties](./chartcontrol.md)

Method/Property

Description

[AxisXHeight](./axisxheight.md)

Measures the distance (in pixels) between the x\-axis and the top of the horizontal scroll bar

[AxisYLeftWidth](./axisyleftwidth.md)

Measures the distance (in pixels) between the y\-axis and the left margin of a chart

[AxisYRightWidth](./axisyrightwidth.md)

Measures the distance (in pixels) between the y\-axis and the right margin of a chart

[BarMarginLeft](./barmarginleft.md)

Measures the margin to the left of each bar on the chart, in pixels

[BarsArray](./barsarray.md)

Provides a collection of [ChartBars](./chartbars.md) objects currently configured on the chart

[BarSpacingType](./barspacingtype.md)

Provides the type of bar spacing used for the primary [Bars](./bars.md) object on the chart

[BarsPeriod](./chartcontrol_barsperiod.md)

Provides the period (interval) used for the primary [Bars](./bars.md) object on the chart

[BarWidth](./chartcontrol_barwidth.md)

Measures the value of the bar width set for the primary [Bars](./bars.md) object on the chart

[BarWidthArray](./barwidtharray.md)

An array containing the values of the [BarWidth](./barwidth.md) properties of all [Bars](./bars.md) objects on the chart

[CanvasLeft](./canvasleft.md)

Indicates the x\-coordinate (in pixels) of the beginning of the chart canvas area

[CanvasRight](./canvasright.md)

Indicates the x\-coordinate (in pixels) of the end of the chart canvas area

[CanvasZoomState](./canvaszoomstate.md)

Indicates the current state of the Zoom tool on the chart

[ChartPanels](./chartpanels.md)

Holds a collection of [ChartPanel](./chartpanel.md) objects

[CrosshairType](./crosshairtype.md)

Indicates the [Cross Hair](https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English.html?cross_hair.htm) type currently enabled on the chart

[FirstTimePainted](./firsttimepainted.md)

Indicates a time value of the first bar painted on the chart

[GetBarPaintWidth()](./getbarpaintwidth.md)

Returns the width of the bars in the primary [Bars](./bars.md) object on the chart, in pixels

[GetSlotIndexByTime()](./getslotindexbytime.md)

Returns the slot index of the primary [Bars](./bars.md) object on the chart corresponding to a specified time value

[GetSlotIndexByX()](./getslotindexbyx.md)

Returns the slot index of the primary [Bars](./bars.md) object on the chart corresponding to a specified x\-coordinate on the visible chart canvas

[GetTimeBySlotIndex()](./gettimebyslotindex.md)

Returns a time value corresponding to a specified slot index of the primary [Bars](./bars.md) object on the chart

[GetTimeByX()](./gettimebyx.md)

Returns a time value related to the primary [Bars](./bars.md)' slot index at a specified x\-coordinate on the chart canvas

[GetXByBarIndex()](./getxbybarindex.md)

Returns the chart\-canvas x\-coordinate of the bar at a specified index of a specified [ChartBars](./chartbars.md) object on the chart

[GetXByTime()](./getxbytime.md)

Returns the chart\-canvas x\-coordinate of the slot index of the primary [Bars](./bars.md) object corresponding to a specified time

[Indicators](./indicators.md)

Returns a collection of indicators currently configured on the chart

[IsScrollArrowVisible](./isscrollarrowvisible.md)

Indicates the time\-axis scroll arrow is visible in the top\-right corner of the chart

[IsStayInDrawMode](./isstayindrawmode.md)

Indicates the [Stay in Draw Mode](https://ninjatrader.com/support/helpGuides/nt8/?working_with_drawing_tools__ob.htm) is currently enabled on the chart

[IsYAxisDisplayedLeft](./isyaxisdisplayedleft.md)

Indicates the y\-axis displays (in any chart panel) to the left side of the chart canvas

[IsYAxisDisplayedOverlay](./isyaxisdisplayedoverlay.md)

Indicates an object on the chart is using the Overlay scale justification

[IsYAxisDisplayedRight](./chartcontrol_isyaxisdisplayedright.md)

Indicates the y\-axis displays (in any chart panel) to the right side of the chart canvas

[LastSlotPainted](./lastslotpainted.md)

Indicates the slot index of the most recently painted bar on the primary [Bars](./bars.md) object configured on the chart

[LastTimePainted](./lasttimepainted.md)

Indicates the time of the most recently painted bar on the primary [Bars](./bars.md) object configured on the chart

[MouseDownPoint](./mousedownpoint.md)

Indicates the x\- and y\-coordinates of the mouse cursor at the most recent **OnMouseDown()** event

[Properties](./chartcontrol_properties.md)

A collection of properties related to the configuration of the Chart

[SlotsPainted](./slotspainted.md)

Indicates the number of index slots in which bars are painted within the chart canvas area

[Strategies](./strategies.md)

A collection of strategies configured on the chart

[TimePainted](./timepainted.md)

Indicates the range of time in which bars are painted on the visible chart canvas

#### ON THIS PAGE

*   [Methods and Properties](./chartcontrol.md)