**Path**: [Alert, Debug, Share](./alert_debug_share.md) > [RearmAlert()](./rearmalert.md)

# RearmAlert()

# RearmAlert()

## [Definition](./rearmalert.md)

Rearms an alert created via the **Alert()** method.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

A NinjaScript generated alert may need to be rearmed after the alert is triggered depending on the **Alert()** method's **rearmSeconds** parameter.

## [Method Return Value](./rearmalert.md)

This method does not return a value.

## [Syntax](./rearmalert.md)

`RearmAlert(string id)`

## [Parameters](./rearmalert.md)

Parameter

Description

id

A unique string id representing an alert id to rearm

## [Examples](./rearmalert.md)

```csharp
protected override void OnBarUpdate()
{
   //rearms "myAlert" on each new trading session
   if(Bars.IsFirstBarOfSession)
     RearmAlert("myAlert");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./rearmalert.md)
*   [Method Return Value](./rearmalert.md)
*   [Syntax](./rearmalert.md)
*   [Parameters](./rearmalert.md)
*   [Examples](./rearmalert.md)