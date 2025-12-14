**Path**: [SessionIterator](./sessioniterator.md) > [GetTradingDay()](./gettradingday.md)

# GetTradingDay()

# GetTradingDay()

## [Definition](./gettradingday.md)

Returns the actual trading date based on the exchange, calculated from a DateTime object passed with the local time. **GetTradingDay()** calls **CalculateTradingDay()** on a custom **SessionIterator** object created by passing in a **Bars** object as an argument.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: This method can ONLY be called when a **SessionIterator** was created with a 'Bars' parameter.

## [Property Value](./gettradingday.md)

A **DateTime** object representing the [ActualTradingDayExchange](./actualtradingdayexchange.md).

## [Syntax](./gettradingday.md)

`<sessioniterator>.GetTradingDay(DateTime timeLocal)`

## [Parameters](./gettradingday.md)

timeLocal

The **DateTime** value used to calculate the next trading day.

## [Examples](./gettradingday.md)

```csharp
// Declare a new custom SessionIterator
SessionIterator mySessionIterator;

protected override void OnStateChange()
{
    if (State == State.Historical)
    {
        // Instantiate mySessionIterator once in State.Configure
        mySessionIterator = new SessionIterator(BarsArray[0]);
    }
}

protected override void OnBarUpdate()
{
    // Obtain the ActualTradingDayExchange value for mySessionIterator, based on today's date
    Print(mySessionIterator.GetTradingDay(DateTime.Now).ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettradingday.md)
*   [Property Value](./gettradingday.md)
*   [Syntax](./gettradingday.md)
*   [Parameters](./gettradingday.md)
*   [Examples](./gettradingday.md)