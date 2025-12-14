**Path**: [Account Class](./account_class.md) > [Get()](./get.md)

# Get()

# Get()

## [Definition](./get.md)

Returns the value of an **AccountItem**, such as **BuyingPower**, **CashVal**, etc.

## [Method Return Value](./get.md)

A double representing the value of the requested **AccountItem**.

## [Syntax](./get.md)

`Get(AccountItem itemType, Cbi.Currency currency)`

## [Parameters](./get.md)

**itemType**

The desired **AccountItem** to return

**Currency**

The account currency the value should be denoted (required parameter, but has no effect on returned value)

## [Examples](./get.md)

```csharp
// Evaluates to see if the account has more than $25000
if (Account.Get(AccountItem.CashValue, Currency.UsDollar) > 25000)
{
   // Do something; 
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./get.md)
*   [Method Return Value](./get.md)
*   [Syntax](./get.md)
*   [Parameters](./get.md)
*   [Examples](./get.md)