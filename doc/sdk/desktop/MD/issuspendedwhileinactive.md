**Path**: [AddPlot()](./addplot.md) > [IsSuspendedWhileInactive](./issuspendedwhileinactive.md)

# IsSuspendedWhileInactive

# IsSuspendedWhileInactive

## [Definition](./issuspendedwhileinactive.md)

Prevents **OnBarUpdate** from being raised while the indicators display is not in use. Enabling this property in your indicator helps save CPU cycles while the indicator is suspended and not in use by a user. Once the indicator is in a state that would no longer be considered suspended, the historical **OnBarUpdate()** events will be triggered allowing the indicator to catch up to current real\-time values.

Suspension occurs in the following scenarios:

*   Minimized Chart
*   Minimized Market Analyzer
*   Minimized Hot List Analyzer
*   Minimized SuperDOM
*   Background tabs of above features are considered "minimized"
*   Inactive workspaces in the background

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Since events in **OnBarUpdate()** will not be processed while the indicator is suspended, internal NinjaScript functions such as [Alert](./alert.md), [PlaySound](./playsound.md), [Share](./share.md), [Print](./print.md), etc \- or any other method that would be used to notify a user of activity will NOT be processed until the indicator is un\-suspended.

## [Scenarios where suspension will not occur](./issuspendedwhileinactive.md)

The **IsSuspendedWhileInactive** property will be ignored and real\-time events will be processed as normal under the following cases:

*   Indicators running in [Automated NinjaScript Strategies](https://ninjatrader.com/support/helpGuides/nt8/?running_a_ninjascript_strategy.htm)
*   Indicators which have [manually configured alerts](./alert_debug_share.md)
*   Indicators which have been [manually attached to orders](https://ninjatrader.com/support/helpguides/nt8/NT%20HelpGuide%20English.html?attachingorderstoindicators.htm)

## [Property Value](./issuspendedwhileinactive.md)

This property returns true if indicator can take advantage of suspension optimization; otherwise, false. Default set to false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property is overridden to "true" automatically by the [NinjaScript Code Wizard](./ninjascript_wizard.md). You will need to remove the property to return to the default value or manually set it to false to disable this behavior.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./issuspendedwhileinactive.md)

`IsSuspendedWhileInactive`

## [Examples](./issuspendedwhileinactive.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsSuspendedWhileInactive = true;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./issuspendedwhileinactive.md)
*   [Scenarios where suspension will not occur](./issuspendedwhileinactive.md)
*   [Property Value](./issuspendedwhileinactive.md)
*   [Syntax](./issuspendedwhileinactive.md)
*   [Examples](./issuspendedwhileinactive.md)