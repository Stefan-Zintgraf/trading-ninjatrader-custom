**Path**: [Instrument](./instrument.md) > [Expiry](./expiry.md)

# Expiry

# Expiry

## [Definition](./expiry.md)

Indicates the expiration month of a futures contract.

## [Property Value](./expiry.md)

A **DateTime** structure representing the expiration month of a futures contract.

## [Syntax](./expiry.md)

`Instrument.Expiry`

## [Examples](./expiry.md)

```csharp
protected override void OnBarUpdate()
{
   // Print the expiry of the currently configured futures instrument
   Print(String.Format("You are viewing the {0} contract", Instrument.Expiry));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Additional Access Information](./expiry.md)

This property can be accessed without a null reference check in the **OnBarUpdate()** event handler. When the **OnBarUpdate()** event is triggered, there will always be an **Instrument** object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (**Instrument** != null)

#### ON THIS PAGE

*   [Definition](./expiry.md)
*   [Property Value](./expiry.md)
*   [Syntax](./expiry.md)
*   [Examples](./expiry.md)
*   [Additional Access Information](./expiry.md)