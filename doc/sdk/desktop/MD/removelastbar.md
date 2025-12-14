**Path**: [Bars Type](./bars_type.md) > [RemoveLastBar()](./removelastbar.md)

# RemoveLastBar()

# RemoveLastBar()

## [Definition](./removelastbar.md)

Removes the last data point for the Bars Type. There may be cases where your custom bar type may need to amend the last values added on a bar that has already closed. Calling **RemoveLastBar()** will remove the last points for that bar type and allow you to call **AddBar()** with the updated values.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   In order to use this method, the [**IsRemoveLastBarSupported**](./isremovelastbarsupported.md) method must be true.
*   **RemoveLastBar()** CANNOT be used with [**TickReplay**](https://ninjatrader.com/support/helpGuides/nt8/?tick_replay.htm)

## [Syntax](./removelastbar.md)

`RemoveLastBar(Bars bars)`

## [Parameters](./removelastbar.md)

Parameter

Description

**bars**

The Bars object of your bars type

## [Examples](./removelastbar.md)

```csharp
RemoveLastBar(bars);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./removelastbar.md)
*   [Syntax](./removelastbar.md)
*   [Parameters](./removelastbar.md)
*   [Examples](./removelastbar.md)