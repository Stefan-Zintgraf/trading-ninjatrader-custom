**Path**: [NTTabPage Class](./nttabpage.md) > [CleanUp()](./cleanup.md)

# CleanUp()

# CleanUp()

## [Definition](./cleanup.md)

Unregisters LinkControls (**IInstrumentProvider**) and calls **Cleanup()** on **ICleanable** controls on the **NTTabPage**. Override this to, e.g., unsubscribe from events or perform any other cleanup operations when the tab is closed.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When overriding **Cleanup()**, it is strongly recommended when you call **base.Cleanup()** which ensures any link controls are also unregistered. The base implementation will also handle cleaning up any controls which implement **ICleanable**: **AccountSelector**, **AtmStrategySelector**, **InstrumentSelector**, **IntervalSelector**, **TifSelector**.

## [Method Return Value](./cleanup.md)

This method does not return a value.

## [Syntax](./cleanup.md)

`public override void Cleanup()`

## [Parameters](./cleanup.md)

This method does not accept any parameters.

## [Examples](./cleanup.md)

```csharp
public override void Cleanup()
{
    // unregister from any custom events
    Connection.ConnectionStatusUpdate -= OnConnectionStatusUpdate;

    // a call to base.Cleanup() will loop through the visual tree looking for all ICleanable children
    // i.e., AccountSelector, AtmStrategySelector, InstrumentSelector, IntervalSelector, TifSelector,
    // as well as unregister any link control events

    base.Cleanup();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./cleanup.md)
*   [Method Return Value](./cleanup.md)
*   [Syntax](./cleanup.md)
*   [Parameters](./cleanup.md)
*   [Examples](./cleanup.md)