**Path**: [PositionAccount](./positionaccount.md) > [Positions](./positions.md)

# Positions

# Positions

## [Definition](./positions.md)

A collection of Position objects generated for the specified account

## [Property Value](./positions.md)

An **Collection** of Position objects

## [Syntax](./positions.md)

`Account.Positions`

`<account>.Positions`

## [Examples](./positions.md)

```csharp
private Account myAccount;

protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Find our Sim101 account
        lock (Account.All)
            myAccount = Account.All.FirstOrDefault(a => a.Name == "Sim101");
    }

    if (State == State.DataLoaded)
    {
        lock (myAccount.Positions)
        {
            Print("Positions in State.DataLoaded:");

            foreach (Position position in myAccount.Positions)
            {
                Print(String.Format("Position: {0} at {1}", position.MarketPosition, position.AveragePrice));
            }
        }
    }
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./positions.md)
*   [Property Value](./positions.md)
*   [Syntax](./positions.md)
*   [Examples](./positions.md)