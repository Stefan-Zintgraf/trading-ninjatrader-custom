**Path**: [OnAccountItemUpdate()](./onaccountitemupdate.md)

# OnAccountItemUpdate()

# OnAccountItemUpdate()

## [Definition](./onaccountitemupdate.md)

An event driven method used for strategies which is called for each **AccountItem** update for the account on which the strategy is running.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

**OnAccountItemUpdate()** will be called continually in real\-time if a position exists on the account on which the strategy is running. This is to provide updates on the current Unrealized Profit and Loss and associated risk values.

## [Method Return Value](./onaccountitemupdate.md)

This method does not return a value.

## [Syntax](./onaccountitemupdate.md)

You must override the method in your strategy with the following syntax:

`protected override void OnAccountItemUpdate(Account account, AccountItem accountItem, double value)`

## [Method Parameters](./onaccountitemupdate.md)

**account**

The [Account](./account.md) updated

**accountItem**

The [AccountItem](./accountitem.md) updated

**value**

The value of the AccountItem updated

## [Examples](./onaccountitemupdate.md)

```csharp
protected override void OnAccountItemUpdate(Account account, AccountItem accountItem, double value)
{ 
   Print(string.Format("{0} {1} {2}", account.Name, accountItem, value));
   
   // output:
   // Sim101 BuyingPower 103962.5
   // Sim101 CashValue 103962.5
   // Sim101 GrossRealizedProfitLoss 3962.5
   // Sim101 RealizedProfitLoss 3962.5
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onaccountitemupdate.md)
*   [Method Return Value](./onaccountitemupdate.md)
*   [Syntax](./onaccountitemupdate.md)
*   [Method Parameters](./onaccountitemupdate.md)
*   [Examples](./onaccountitemupdate.md)