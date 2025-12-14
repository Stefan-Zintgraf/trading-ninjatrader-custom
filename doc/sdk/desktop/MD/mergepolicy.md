**Path**: [MasterInstrument](./masterinstrument.md) > [MergePolicy](./mergepolicy.md)

# MergePolicy

# MergePolicy

## [Definition](./mergepolicy.md)

Indicates the Merge Policy configured for the **Master Instrument properties**.

## [Syntax](./mergepolicy.md)

`Bars.Instrument.MasterInstrument.MergePolicy`

## [Property Value](./mergepolicy.md)

Represents the MergePolicy that is configured for the current master instrument.

Possible values are:

Value

Description

**DoNotMerge**

No merge policy is applied

**MergeBackAdjusted**

Merge policy is applied between contracts along with rollover offsets

**MergeNonBackAdjusted**

Merge policy is applied between contracts without offsets

**UseGlobalSettings**

Uses the value configured from Tools \-> Options \-> Market Data

## [Examples](./mergepolicy.md)

```csharp
//Prints a warning, indicating what merge policy is in use if not using global settings**
if (Bars.Instrument.MasterInstrument.MergePolicy != MergePolicy.UseGlobalSettings)
{
 Print("Warning: Instrument has merge policy of " + Bars.Instrument.MasterInstrument.MergePolicy);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./mergepolicy.md)
*   [Syntax](./mergepolicy.md)
*   [Property Value](./mergepolicy.md)
*   [Examples](./mergepolicy.md)