**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Net Change Display](./net_change_display.md)

# Net Change Display

# Net Change Display

## [Description](./net_change_display.md)

Displays net change on the chart.

## [Syntax](./net_change_display.md)

`NetChangeDisplay(PerformanceUnit, NetChangePosition location)`

`NetChangeDisplay(ISeries<double> input, PerformanceUnit, NetChangePosition location)`

## [Return Value](./net_change_display.md)

double

## [Parameters](./net_change_display.md)

**input**

Indicator source data ([Series<`T`\>](./seriest.md))

**PerformanceUnit**

Format of the calculation of net change

**NetChangePosition**

Location to display net change on the chart

## [Examples](./net_change_display.md)

```csharp

// Runs on realtime since there is no historical data for this indicator
if (State == State.Historical)
	return;
else if (State >= State.Realtime)
{
	// Prints the current tick value of the net change
	var ncd = NetChangeDisplay(PerformanceUnit.Ticks, NetChangePosition.BottomRight);
	Print("The current Net Change value is " + ncd.NetChange);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This indicator only plots real\-time. Historical values will print as 0.

#### ON THIS PAGE

*   [Description](./net_change_display.md)
*   [Syntax](./net_change_display.md)
*   [Return Value](./net_change_display.md)
*   [Parameters](./net_change_display.md)
*   [Examples](./net_change_display.md)