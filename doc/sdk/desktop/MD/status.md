**Path**: [Connection](./connection_class.md) > [Status](./status.md)

# Status

# Status

## [Definition](./status.md)

Indicates the current status of the primary data connection.

## [Properties](./status.md)

`<connection>.Status`

## [Examples](./status.md)

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


Print(String.Format("Main connection lost {0} times. Price feed lost {1} times.", 
mainLost, priceLost));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./status.md)
*   [Properties](./status.md)
*   [Examples](./status.md)