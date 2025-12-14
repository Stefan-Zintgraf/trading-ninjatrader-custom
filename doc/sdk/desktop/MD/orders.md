**Path**: [Account Class](./account_class.md) > [Orders](./orders.md)

# Orders

# Orders

## [Definition](./orders.md)

A collection of Order objects generated for the specified account

## [Property Value](./orders.md)

An **Collection** of Order objects

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Please keep in mind that orders placed when in **State.Historical** are not submitted live to an account.

## [Syntax](./orders.md)

`<account>.Orders`

## [Examples](./orders.md)

```csharp
private Account myAccount;

protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {
       // Initialize myAccount
   }
}

private void OnAccountItemUpdate(object sender, AccountItemEventArgs e)
{
   // Print the name and order action of each order processed on the account
   foreach (Order order in myAccount.Orders)
   {
       Print(String.Format("Order placed: {0} - {1}", order.Name, order.OrderAction));
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./orders.md)
*   [Property Value](./orders.md)
*   [Syntax](./orders.md)
*   [Examples](./orders.md)