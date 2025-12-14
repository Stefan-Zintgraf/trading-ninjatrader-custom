**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Volume Up Down](./volume_up_down.md)

# Volume Up Down

# Volume Up Down

## [Description](./volume_up_down.md)

Variation of the [VOL](./volume.md) (Volume) indicator that colors the volume histogram different color depending if the current bar is up or down bar.

## [Syntax](./volume_up_down.md)

`VolumeUpDown()`

`VolumeUpDown(ISeries<double> input)`

**Returns default value**

`VolumeUpDown()[int barsAgo]`

`VolumeUpDown(ISeries<double> input](int barsAgo)`

## [Return Value](./volume_up_down.md)

**double**; Accessing this method via an index value `[int barsAgo]` returns the indicator value of the referenced bar.

## [Parameters](./volume_up_down.md)

Parameter

Description

input

Indicator source data ([Series<`T`\>](./seriest.md))

period

Number of bars used in the calculation

## [Example](./volume_up_down.md)

```csharp
// Prints the current value VolumeUpDown  
double value = VolumeUpDown()[0];  
Print("The current Volume value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./volume_up_down.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./volume_up_down.md)
*   [Syntax](./volume_up_down.md)
*   [Return Value](./volume_up_down.md)
*   [Parameters](./volume_up_down.md)
*   [Example](./volume_up_down.md)
*   [Source Code](./volume_up_down.md)