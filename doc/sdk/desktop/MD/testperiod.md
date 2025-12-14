**Path**: [SystemPerformance](./systemperformance.md) > [TestPeriod](./testperiod.md)

# TestPeriod

# TestPeriod

## [Definition](./testperiod.md)

Reserved for **Walk\-Forward Optimization**, this property determines the number of days used for the "out of sample" backtest period for a given strategy. See also **OptimizationPeriod**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property should ONLY be called from the **OnStateChange()** method during State.SetDefaults.

## [Property Value](./testperiod.md)

An **int** value representing the number of "out of sample" days used for walk\-forward optimization; Default value is set to 28.

## [Syntax](./testperiod.md)

`TestPeriod`

## [Examples](./testperiod.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {         
        //set the default TestPeriod to 31 days for WFOs
        TestPeriod = 31;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./testperiod.md)
*   [Property Value](./testperiod.md)
*   [Syntax](./testperiod.md)
*   [Examples](./testperiod.md)