**Path**: [SessionIterator](./sessioniterator.md) > [ActualTradingDayEndLocal](./actualtradingdayendlocal.md)

# ActualTradingDayEndLocal

# ActualTradingDayEndLocal

## [Definition](./actualtradingdayendlocal.md)

Returns the session's End\-Of\-Day (EOD) in the user's configured timezone.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In order to obtain historical ActualTradingDayEndLocal information, you must call [GetNextSession](./getnextsession.md) from a stored SessionIterator object.

## [Property Value](./actualtradingdayendlocal.md)

A DateTime structure that represents end of a trading day (EOD).

## [Syntax](./actualtradingdayendlocal.md)

`SessionIterator.ActualTradingDayEndLocal`

## [Example](./actualtradingdayendlocal.md)

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

        Print("The current session end of day is " + sessionIterator.ActualTradingDayEndLocal);
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./actualtradingdayendlocal.md)
*   [Property Value](./actualtradingdayendlocal.md)
*   [Syntax](./actualtradingdayendlocal.md)
*   [Example](./actualtradingdayendlocal.md)