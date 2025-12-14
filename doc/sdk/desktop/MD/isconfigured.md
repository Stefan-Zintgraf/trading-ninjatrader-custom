**Path**: [Share Service](./share_service.md) > [IsConfigured](./isconfigured.md)

# IsConfigured

# IsConfigured

## [Definition](./isconfigured.md)

Sets when the Share Service is correctly configured. Typically this would be set after the account is authorized, at which point the adapter will allow for the user to share content to the sharing service.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

It is not required for a Share Service to authorize a user, therefore it is possible to set **IsConfigured** to true in **State.SetDefaults** which will bypass any sort of authorization or additional setup that may be needed for the share adapter.

## [Property Value](./isconfigured.md)

A bool value when true determines if the Share Adapter is properly configured.

## [Syntax](./isconfigured.md)

`IsConfigured`

## [Examples](./isconfigured.md)

```csharp
public override void OnAuthorizeAccount()
{
   //Authorization logic would be here, after success, set **IsConfigured** to true.

   IsConfigured = true;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isconfigured.md)
*   [Property Value](./isconfigured.md)
*   [Syntax](./isconfigured.md)
*   [Examples](./isconfigured.md)