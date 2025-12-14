**Path**: [Bars Type](./bars_type.md) > [BuiltFrom](./builtfrom.md)

# BuiltFrom

# BuiltFrom

## [Definition](./builtfrom.md)

Determines the base dataset used to build the **BarsType** (i.e., Tick, Minute, Day). The **BuiltFrom** property will control the frequency in which [**OnDataPoint()**](./ondatapoint.md) processes historical data.

## [Property Value](./builtfrom.md)

A [**BarsPeriodType**](./barsperiod.md) enum. Values that will be recognized include:

*   **BarsPeriodType.Tick**
*   **BarsPeriodType.Minute**
*   **BarsPeriodType.Day**

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: Using other bars period types (e.g., Range, Volume, or other custom bars types) is NOT supported. The **BarsPeriodType** values mentioned above represent all of the fundamental data points needed to build a bar.

## [Syntax](./builtfrom.md)

`BuiltFrom`

## [Examples](./builtfrom.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name     = "MyCustomBarsType";
        BarsPeriod   = new BarsPeriod { BarsPeriodType = (BarsPeriodType) 15, BarsPeriodTypeName = "MyCustomBarsType(15)", Value = 1 };
        BuiltFrom   = BarsPeriodType.Minute; // update OnDataPoint() every minute on historical data
        DaysToLoad   = 5;
    }

    else if (State == State.Configure)
    {
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./builtfrom.md)
*   [Property Value](./builtfrom.md)
*   [Syntax](./builtfrom.md)
*   [Examples](./builtfrom.md)