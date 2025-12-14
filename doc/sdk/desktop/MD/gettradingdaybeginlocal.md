**Path**: [SessionIterator](./sessioniterator.md) > [GetTradingDayBeginLocal()](./gettradingdaybeginlocal.md)

# GetTradingDayBeginLocal()

# GetTradingDayBeginLocal()

## [Definition](./gettradingdaybeginlocal.md)

Converts the trading day begin time from the exchange timezone to local time, and returns a DateTime object in the local timezone. The **ActualTradingDayExchange** property can be passed into **GetTradingDayBeginLocal()** for a quick timezone conversion.

## [Property Value](./gettradingdaybeginlocal.md)

A DateTime object representing the exchange\-based trading day begin time converted to local time.

## [Syntax](./gettradingdaybeginlocal.md)

`<sessioniterator>.GetTradingDayBeginLocal(DateTime tradingDayExchange)`

## [Parameters](./gettradingdaybeginlocal.md)

tradingDayExchange

The DateTime value used to calculate the trading day.

## [Examples](./gettradingdaybeginlocal.md)

```csharp
private SessionIterator sessionIterator;

protected override void OnStateChange()
{
    if (State == State.DataLoaded)
    {
        //stores the sessions once bars are ready, but before OnBarUpdate is called
        sessionIterator = new SessionIterator(Bars);
    }
}

protected override void OnBarUpdate()
{
    // Only process strategy logic starting three hours after trading begins at the exchange
    if (Core.Globals.Now >= sessionIterator.GetTradingDayBeginLocal(sessionIterator.ActualTradingDayExchange).AddHours(3))
    {
        // Strategy logic here
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettradingdaybeginlocal.md)
*   [Property Value](./gettradingdaybeginlocal.md)
*   [Syntax](./gettradingdaybeginlocal.md)
*   [Parameters](./gettradingdaybeginlocal.md)
*   [Examples](./gettradingdaybeginlocal.md)