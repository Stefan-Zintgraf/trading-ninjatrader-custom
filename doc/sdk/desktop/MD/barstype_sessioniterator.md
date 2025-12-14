**Path**: [Bars Type](./bars_type.md) > [SessionIterator](./barstype_sessioniterator.md)

# SessionIterator

# SessionIterator

## [Definition](./barstype_sessioniterator.md)

Provides trading session information to the bars type. Must be built using the bars object.

## [Property Value](./barstype_sessioniterator.md)

A [SessionIterator](./sessioniterator.md) object which is used to calculate trading day/session information.

## [Syntax](./barstype_sessioniterator.md)

`SessionIterator`

## [Examples](./barstype_sessioniterator.md)

```csharp
protected override void OnDataPoint(Bars bars, double open, double high, double low, double close, DateTime time, long volume, bool isBar, double bid, double ask)
{
   // build a session iterator from the bars object being updated
   if (SessionIterator == null)
     SessionIterator = new SessionIterator(bars);

   // check if we are in a new trading session based on the trading hours selected by the user
   bool isNewSession = SessionIterator.IsNewSession(time, isBar);

   // calculate the new trading day
   if (isNewSession)
     SessionIterator.CalculateTradingDay(time, isBar);

   Print(SessionIterator.ActualTradingDayExchange);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barstype_sessioniterator.md)
*   [Property Value](./barstype_sessioniterator.md)
*   [Syntax](./barstype_sessioniterator.md)
*   [Examples](./barstype_sessioniterator.md)