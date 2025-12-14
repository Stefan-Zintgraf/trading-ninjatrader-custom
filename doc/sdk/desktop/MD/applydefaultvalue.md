**Path**: [Bars Type](./bars_type.md) > [ApplyDefaultValue](./applydefaultvalue.md)

# ApplyDefaultValue

# ApplyDefaultValue

## [Definition](./applydefaultvalue.md)

Sets the default **BarsPeriod** values used for a custom Bar Type.

## [Method Return Value](./applydefaultvalue.md)

This method does not return a value.

## [Parameters](./applydefaultvalue.md)

period

The [BarsPeriod](./barsperiod.md) chosen by the user when utilizing this Bars type

## [Syntax](./applydefaultvalue.md)

You must override the method in your Bars Type with the following syntax:

`public override void ApplyDefaultValue(BarsPeriod period) { }`

## [Examples](./applydefaultvalue.md)

```csharp
public override void ApplyDefaultValue(BarsPeriod period)
{
		period.BarsPeriodTypeName = "MyBarType";
		period.Value = 1;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./applydefaultvalue.md)
*   [Method Return Value](./applydefaultvalue.md)
*   [Parameters](./applydefaultvalue.md)
*   [Syntax](./applydefaultvalue.md)
*   [Examples](./applydefaultvalue.md)