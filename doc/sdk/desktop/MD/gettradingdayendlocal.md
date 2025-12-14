**Path**: [SessionIterator](./sessioniterator.md) > [GetTradingDayEndLocal()](./gettradingdayendlocal.md)

# GetTradingDayEndLocal()

# GetTradingDayEndLocal()

## [Definition](./gettradingdayendlocal.md)

Converts the trading day end time from the exchange timezone to local time, and returns a DateTime object in the local timezone. The **ActualTradingDayExchange** property can be passed into **GetTradingDayEndLocal()** for a quick timezone conversion.

## [Property Value](./gettradingdayendlocal.md)

A DateTime object representing the exchange\-based trading day end time converted to local time.

## [Syntax](./gettradingdayendlocal.md)

`<sessioniterator>.GetTradingDayEndLocal(DateTime tradingDayExchange)`

## [Parameters](./gettradingdayendlocal.md)

tradingDayExchange

The DateTime value used to calculate the trading day.

## [Examples](./gettradingdayendlocal.md)

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
    // Only process strategy logic up until three hours prior to the end of the trading day at the exchange
    if (Core.Globals.Now <= sessionIterator.GetTradingDayEndLocal(sessionIterator.ActualTradingDayExchange).AddHours(-3))
    {
        // Strategy logic here
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettradingdayendlocal.md)
*   [Property Value](./gettradingdayendlocal.md)
*   [Syntax](./gettradingdayendlocal.md)
*   [Parameters](./gettradingdayendlocal.md)
*   [Examples](./gettradingdayendlocal.md)