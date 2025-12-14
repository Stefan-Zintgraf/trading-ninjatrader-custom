**Path**: [Alert, Debug, Share](./alert_debug_share.md) > [Share()](./share.md)

# Share()

# Share()

## [Definition](./share.md)

Sends a message or screen shot to a social network or Share Service.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  This method can only be called once the **State** has reached **State.Realtime**. Calls to this method in any other State will be silently ignored.
2.  You MUST configure an account with a Share Service provider from the **General Options**.

## [Method Return Value](./share.md)

This method does not return a value.

## [Syntax](./share.md)

`Share(string serviceName, string message)`

`Share(string serviceName, string message, object[] args)`

`Share(string serviceName, string message, string screenshotPath)`

`Share(string serviceName, string message, string screenshotPath, object[] args)`

## [Parameters](./share.md)

Parameter

Description

**serviceName**

A **string** value representing the share service to be used

**message**

A **string** value representing the text body sent to the social network or other Share providers. Note: The message is what appears in the text box of the Share window

**screenshotPath**

Optional string path to screenshot or other images sent to the social network or other Share providers

**args**

A generic object\[\] array used to designate additional information sent to the share service

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  The "args" parameter differs for each share service used. If you are using a custom developed share adapter, you need to work with the developer of that adapter to understand what the "args" parameter represents for that adapter.
2.  For the default NinjaTrader share adapters, the "args" array represents the following:
    *   Mail share service:
        *   args\[0\] = A string representing the email "To" field,
        *   args\[1\] = A string representing the email "Subject" field
    *   StockTwits share service:
        *   args\[0\] = An enum representing the "StockTwitsSentiment" parameter

## [Examples](./share.md)

```csharp
// using "args" as the Mail "To" and "Subject" parameters
Share("Gmail", "Test Message", new object[]{ "example@test.com", "Test Subject Line" });

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./share.md)
*   [Method Return Value](./share.md)
*   [Syntax](./share.md)
*   [Parameters](./share.md)
*   [Examples](./share.md)