**Path**: [Alert and Debug Concepts](./alert_and_debug_concepts.md) > [RearmAlert()](./alert_rearmalert.md)

# RearmAlert()

# RearmAlert()

## [Definition](./alert_rearmalert.md)

Rearms an existing alert event by the string "id" parameter created via the [AlertCallback()](./alertcallback.md) method. A NinjaScript generated alert by may need to be rearmed after the alert is triggered depending on the Alert()'s rearmSeconds parameter.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The NinjaScriptBase has a non\-static method implemented with the same name. Please see the [RearmAlert()](./rearmalert.md) method for Indicator or Strategies.

## [Method Return Value](./alert_rearmalert.md)

This method does not return a value.

## [Syntax](./alert_rearmalert.md)

`NinjaTrader.NinjaScript.Alert.RearmAlert(string id)`

## [Parameters](./alert_rearmalert.md)

id

A unique string id representing an alert id to reset

## [Examples](./alert_rearmalert.md)

```csharp
if (resetCondition) 
{
   NinjaTrader.NinjaScript.Alert.ResetAlertRearmById("someId");
   resetCondition = false;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./alert_rearmalert.md)
*   [Method Return Value](./alert_rearmalert.md)
*   [Syntax](./alert_rearmalert.md)
*   [Parameters](./alert_rearmalert.md)
*   [Examples](./alert_rearmalert.md)