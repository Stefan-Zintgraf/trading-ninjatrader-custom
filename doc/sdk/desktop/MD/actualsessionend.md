**Path**: [SessionIterator](./sessioniterator.md) > [ActualSessionEnd](./actualsessionend.md)

# ActualSessionEnd

# ActualSessionEnd

## [Definition](./actualsessionend.md)

Obtains the session's end date and end time converted to the user's configured Time Zone.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In order to obtain historical ActualSessionEnd information, you must call [GetNextSession](./getnextsession.md) from a stored SessionIterator object.

## [Property Value](./actualsessionend.md)

A **DateTime** structure that represents end of a trading session.

## [Syntax](./actualsessionend.md)

`SessionIterator.ActualSessionEnd`

## [Example](./actualsessionend.md)

```csharp
SessionIterator sessionIterator;

protected override void OnStateChange()
{
   if (State == State.Historical)
   {
     sessionIterator = new SessionIterator(Bars);
   }
}

protected override void OnBarUpdate()
{
   // on new bars session, find the next trading session
   if (Bars.IsFirstBarOfSession)
   {
     // use the current bar time to calculate the next session
     sessionIterator.GetNextSession(Time[0], true);

     Print("The current session end time is " + sessionIterator.ActualSessionEnd);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./actualsessionend.md)
*   [Property Value](./actualsessionend.md)
*   [Syntax](./actualsessionend.md)
*   [Example](./actualsessionend.md)