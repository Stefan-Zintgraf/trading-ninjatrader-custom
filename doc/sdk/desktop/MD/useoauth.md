**Path**: [Share Service](./share_service.md) > [UseOAuth](./useoauth.md)

# UseOAuth

# UseOAuth

## [Definition](./useoauth.md)

If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call **OnAuthorizeAccount()** when the user clicks it.

## [Property Value](./useoauth.md)

A bool value determining if the **OnAuthorizeAccount()** method should be called in order to authorize the account to the social service.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults.

## [Syntax](./useoauth.md)

`UseOAuth`

## [Examples](./useoauth.md)

```csharp
protected override void OnStateChange()
{         
   if (State == State.SetDefaults)
   {
      UseOAuth = true;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./useoauth.md)
*   [Property Value](./useoauth.md)
*   [Syntax](./useoauth.md)
*   [Examples](./useoauth.md)