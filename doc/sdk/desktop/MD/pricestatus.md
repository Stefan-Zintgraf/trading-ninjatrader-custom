**Path**: [Connection](./connection_class.md) > [PriceStatus](./pricestatus.md)

# PriceStatus

# PriceStatus

## [Definition](./pricestatus.md)

Indicates the current status of the price feed of the primary data connection

## [Syntax](./pricestatus.md)

`<connection>.PriceStatus`

## [Examples](./pricestatus.md)

```csharp
private int priceLost;
private int mainLost;

private void OnAccountItemUpdate(object sender, AccountItemEventArgs e)
{
    // Count the number of times OnAccountItemUpdate() is called with a lost price connection
    if (myAccount.Connection.PriceStatus == ConnectionStatus.ConnectionLost)
        priceLost += 1;

    // Count the number of times OnAccountItemUpdate() is called with a lost primary connection
    if (myAccount.Connection.Status == ConnectionStatus.ConnectionLost)
        mainLost += 1;

    // Print the number of times each connection was lost during OnAccountItemUpdate()
    if (mainLost > 0 || priceLost > 0)
        Print(String.Format("Main connection lost {0} times. Price feed lost {1} times.", mainLost, priceLost));

}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./pricestatus.md)
*   [Syntax](./pricestatus.md)
*   [Examples](./pricestatus.md)