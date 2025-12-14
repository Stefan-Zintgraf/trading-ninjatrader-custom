**Path**: [Share Service](./share_service.md) > [OnShare()](./onshare.md)

# OnShare()

# OnShare()

## [Definition](./onshare.md)

This method is called when the user clicks OK on the Share window in **NinjaTrader**. This method can also be called by Alerts and general **NinjaScript** objects.

## [Method Return Value](./onshare.md)

This method does not return a value.

## [Parameters](./onshare.md)

**text**

The message being sent to the social network or other Share provider. This is what appears in the textbox of the Share window.

**imageFilePath**

Optional path to screenshot or other image to be sent to the social network or other Share provider.

## [Syntax](./onshare.md)

You must override the method in your Share Service with the following syntax.

`public override void OnShare(string text, string imageFilePath)`

## [Examples](./onshare.md)

```csharp
public override void OnShare(string text, string imgFilePath)
{
  // place your share service logic here
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onshare.md)
*   [Method Return Value](./onshare.md)
*   [Parameters](./onshare.md)
*   [Syntax](./onshare.md)
*   [Examples](./onshare.md)