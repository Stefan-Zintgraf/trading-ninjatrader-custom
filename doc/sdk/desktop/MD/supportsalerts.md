**Path**: [ChartAnchor](./chartanchor.md) > [SupportsAlerts](./supportsalerts.md)

# SupportsAlerts

# SupportsAlerts

## [Definition](./supportsalerts.md)

Determines if the drawing tool can be used for manually configured alerts through the UI.

## [Property Value](./supportsalerts.md)

A bool which when true determines that user can setup an alert based off this drawing tool; otherwise false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property is false by default and MUST be overridden upon initialization to allow for manually configured alerts. You cannot set this during run\-time.

## [Syntax](./supportsalerts.md)

`SupportsAlerts`

You may choose to override this property using the following syntax:

**public override bool SupportsAlerts**

## [Examples](./supportsalerts.md)

```csharp
public override bool SupportsAlerts { get { return true; } }

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./supportsalerts.md)
*   [Property Value](./supportsalerts.md)
*   [Syntax](./supportsalerts.md)
*   [Examples](./supportsalerts.md)