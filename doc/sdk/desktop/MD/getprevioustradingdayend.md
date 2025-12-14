**Path**: [Trading Hours](./tradinghours.md) > [GetPreviousTradingDayEnd()](./getprevioustradingdayend.md)

# GetPreviousTradingDayEnd()

# GetPreviousTradingDayEnd()

## [Definition](./getprevioustradingdayend.md)

Returns the end date and time of the previous trading session regarding the time passed in the methods parameters.

## [Method Return Value](./getprevioustradingdayend.md)

A **DateTime** structure representing the previous trading days end date and time.

## [Syntax](./getprevioustradingdayend.md)

`GetPreviousTradingDayEnd(DateTime timeLocal)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This method is resource intensive and should ONLY be reserved for situations when calculations would be limited to a few specific use cases. For example, calling this method for each bar in the `OnBarUpdate()` method would NOT be recommended.

## [Parameters](./getprevioustradingdayend.md)

Parameter

Description

**timeLocal**

An **DateTime** structure which is used to calculate the current trading day

## [Examples](./getprevioustradingdayend.md)

```csharp
protected override void OnBarUpdate()
{
    if (Bars.IsFirstBarOfSession)
    {
        DateTime previousEndDate = TradingHours.GetPreviousTradingDayEnd(Time[0]);

        Print(string.Format("The current bars date is {0} - the previous trading session ended on {1}", Time[0], previousEndDate));
    }
    //Output:  The current bars date is 2/18/2015 12:35:00 PM - the previous trading session ended on 2/17/2015 3:15:00 PM
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getprevioustradingdayend.md)
*   [Method Return Value](./getprevioustradingdayend.md)
*   [Syntax](./getprevioustradingdayend.md)
*   [Parameters](./getprevioustradingdayend.md)
*   [Examples](./getprevioustradingdayend.md)