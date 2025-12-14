**Path**: [Alert, Debug, Share](./alert_debug_share.md) > [SendMail()](./sendmail.md)

# SendMail()

# SendMail()

## [Definition](./sendmail.md)

Sends an email message through the default email sharing service.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Notes:

1.  This method can only be called once the **State** has reached **State.Realtime**. Calls to this method in any other State will be silently ignored (in contrast to the implementation for **AddOns**).
2.  You MUST configure an email account as a default "Mail" Share Service from the **General Options**.

## [Method Return Value](./sendmail.md)

This method does not return a value.

## [Syntax](./sendmail.md)

`SendMail(string to, string subject, string text)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

If mail is not received, please check the `Log` tab of the control center for any specific errors which could be related to delivering the message.

## [Parameters](./sendmail.md)

Parameter

Description

**to**

The email recipient

**subject**

Subject line of email

**text**

Message body of email

## [Examples](./sendmail.md)

```csharp
// Generates an email message
SendMail("customer@winners.com", "Trade Alert", "Buy ES");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./sendmail.md)
*   [Method Return Value](./sendmail.md)
*   [Syntax](./sendmail.md)
*   [Parameters](./sendmail.md)
*   [Examples](./sendmail.md)