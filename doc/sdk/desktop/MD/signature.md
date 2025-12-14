**Path**: [Share Service](./share_service.md) > [Signature](./signature.md)

# Signature

# Signature

## [Definition](./signature.md)

Sets the text appended to the end of the user's message. It is uneditable by the user, and contributes to the character count of the overall message.

You can set it to an empty string if it does not apply to your adapter. In that case, the Signature label will not appear in the Share window.

## [Property Value](./signature.md)

A **string** value which is appended to the end of the user's message.

## [Syntax](./signature.md)

`Signature`

## [Examples](./signature.md)

```csharp
// example #1, adds text "This message was sent from NinjaTrader" at the end of the message.

protected override void OnStateChange()

{
   if (State == State.SetDefaults)

   {

      Signature   = "This message was sent from NinjaTrader";

   }

}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// example #2, uses an empty string which does not add any additional text to the message
protected override void OnStateChange()
{         
   if (State == State.SetDefaults)
   {
      Signature   = string.Empty;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./signature.md)
*   [Property Value](./signature.md)
*   [Syntax](./signature.md)
*   [Examples](./signature.md)