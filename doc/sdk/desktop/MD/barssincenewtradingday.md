**Path**: [Bars](./bars.md) > [BarsSinceNewTradingDay](./barssincenewtradingday.md)

# BarsSinceNewTradingDay

# BarsSinceNewTradingDay

## [Definition](./barssincenewtradingday.md)

Returns the number of bars elapsed since the start of the trading day relative to the current bar processing.

## [Property Value](./barssincenewtradingday.md)

An **int** value representing the number of bars elapsed. This property cannot be set.

## [Syntax](./barssincenewtradingday.md)

`Bars.BarsSinceNewTradingDay`

## [Examples](./barssincenewtradingday.md)

```csharp

// Only process strategy logic after five bars have posted since the start of the trading day
protected override void OnBarUpdate()
{
   if (Bars.BarsSinceNewTradingDay >= 5)
   {
     //Strategy logic here
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barssincenewtradingday.md)
*   [Property Value](./barssincenewtradingday.md)
*   [Syntax](./barssincenewtradingday.md)
*   [Examples](./barssincenewtradingday.md)