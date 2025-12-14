**Path**: [Account Class](./account_class.md) > [Name](./name_account.md)

# Name

# Name

## [Definition](./name_account.md)

Indicates the name of the specified account

## [Property Value](./name_account.md)

A **string** representing the name of the account

## [Syntax](./name_account.md)

`<account>.Name`

## [Examples](./name_account.md)

```csharp
protected override void OnStateChange()
 if (State == State.SetDefaults) 
 {
		 // Initialize myAccount
 }

private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e) 
{
	 // Print the name of each account updated
	 Print(String.Format("{0} account updated", myAccount.Name));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./name_account.md)
*   [Property Value](./name_account.md)
*   [Syntax](./name_account.md)
*   [Examples](./name_account.md)