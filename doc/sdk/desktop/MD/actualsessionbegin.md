**Path**: [SessionIterator](./sessioniterator.md) > [ActualSessionBegin](./actualsessionbegin.md)

# ActualSessionBegin

# ActualSessionBegin

## [Definition](./actualsessionbegin.md)

Obtains the sessions start date and start time converted to the user's configured Time Zone.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In order to obtain historical ActualSessionBegin information, you must call [GetNextSession](./getnextsession.md) from a stored SessionIterator object.

## [Property Value](./actualsessionbegin.md)

A **DateTime** structure that represents beginning of a trading session.

## [Syntax](./actualsessionbegin.md)

`SessionIterator.ActualSessionBegin`

## [Example](./actualsessionbegin.md)

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

        Print("The current session start time is " + sessionIterator.ActualSessionBegin);
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./actualsessionbegin.md)
*   [Property Value](./actualsessionbegin.md)
*   [Syntax](./actualsessionbegin.md)
*   [Example](./actualsessionbegin.md)