**Path**: [SessionIterator](./sessioniterator.md) > [IsTradingDayDefined()](./istradingdaydefined.md)

# IsTradingDayDefined()

# IsTradingDayDefined()

## [Definition](./istradingdaydefined.md)

Indicates a trading day is defined for a specific date.

## [Property Value](./istradingdaydefined.md)

A **bool** value when true indicates that the date passed in as an argument is defined as a full or partial trading day in the configured Trading Hours template; otherwise false. Also returns false if the specified date is marked as a full\-day exchange holiday.

## [Syntax](./istradingdaydefined.md)

`<sessioniterator>.IsTradingDayDefined(DateTime time)`

## [Parameters](./istradingdaydefined.md)

date

The DateTime value representing the date to check

## [Examples](./istradingdaydefined.md)

```csharp
DateTime thanksGivingDay = new DateTime(2017, 11, 23);

// Determine if the current instrument's exchange is open for trading on Thanksgiving day in 2017
if(Bars.SessionIterator.IsTradingDayDefined(thanksGivingDay))
    Print(String.Format("{0} will be open for trading on Thanksgiving day, {1}", Instrument.MasterInstrument.Name, thanksGivingDay.Date));

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./istradingdaydefined.md)
*   [Property Value](./istradingdaydefined.md)
*   [Syntax](./istradingdaydefined.md)
*   [Parameters](./istradingdaydefined.md)
*   [Examples](./istradingdaydefined.md)