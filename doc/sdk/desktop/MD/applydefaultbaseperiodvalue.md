**Path**: [Bars Type](./bars_type.md) > [ApplyDefaultBasePeriodValue()](./applydefaultbaseperiodvalue.md)

# ApplyDefaultBasePeriodValue()

# ApplyDefaultBasePeriodValue()

## [Definition](./applydefaultbaseperiodvalue.md)

Sets the default base values used for the **BarsPeriod** selected by the user (e.g., the default PeriodValue, DaysToLoad, etc.) for your custom Bar Type.

## [Method Return Value](./applydefaultbaseperiodvalue.md)

This method does not return a value.

## [Parameters](./applydefaultbaseperiodvalue.md)

period

The **BarsPeriod** chosen by the user when utilizing this Bars type

## [Syntax](./applydefaultbaseperiodvalue.md)

You must override the method in your Bars Type with the following syntax:

`public override void ApplyDefaultBasePeriodValue(BarsPeriod period) { }`

## [Examples](./applydefaultbaseperiodvalue.md)

```csharp
public override void ApplyDefaultBasePeriodValue(BarsPeriod period)
{
    //sets the default Minute bars period value to 1, and days to load to 5
    if (period.BaseBarsPeriodType == BarsPeriodType.Minute)
    {
        period.BaseBarsPeriodValue = 1;
        DaysToLoad = 5;
    }
    //sets the default Tick bars period value to 150, and days to load to 3
    else if (period.BaseBarsPeriodType == BarsPeriodType.Tick)
    {
        period.BaseBarsPeriodValue = 150;
        DaysToLoad = 3;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./applydefaultbaseperiodvalue.md)
*   [Method Return Value](./applydefaultbaseperiodvalue.md)
*   [Parameters](./applydefaultbaseperiodvalue.md)
*   [Syntax](./applydefaultbaseperiodvalue.md)
*   [Examples](./applydefaultbaseperiodvalue.md)