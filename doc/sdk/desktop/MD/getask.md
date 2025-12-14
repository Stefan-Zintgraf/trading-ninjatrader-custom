**Path**: [Bars](./bars.md) > [GetAsk()](./getask.md)

# GetAsk()

# GetAsk()

## [Definition](./getask.md)

Returns the ask price value at a selected absolute bar index value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   This method does NOT return the current real\-time asking price, but rather the historical / real\-time asking price at the desired index. For obtaining the current real\-time asking price, please use **GetCurrentAsk**().
*   This method returns expected values when 1 tick bid / ask stamped data is used and available from **your provider**.

## [Method Return Value](./getask.md)

A **double** value that represents the asking price at the desired bar index.

## [Syntax](./getask.md)

`Bars.GetAsk(int index)`

## [Parameters](./getask.md)

Parameter

Description

**index**

The absolute bar index value used

## [Examples](./getask.md)

```csharp
protected override void OnBarUpdate()
{
    // If the Highs of the two most recent bars are falling, place a long stop market order 
    // at the Ask price 
    if (High[0] < High[1] && High[1] < High[2])
    {
        EnterLongStopMarket(Bars.GetAsk(CurrentBar));
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getask.md)
*   [Method Return Value](./getask.md)
*   [Syntax](./getask.md)
*   [Parameters](./getask.md)
*   [Examples](./getask.md)