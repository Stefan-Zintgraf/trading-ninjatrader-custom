**Path**: [Account Class](./account_class.md) > [AccountStatusUpdate](./accountstatusupdate.md)

# AccountStatusUpdate

# AccountStatusUpdate

## [Definition](./accountstatusupdate.md)

AccountStatusUpdate can be used for subscribing to account status events from all accounts.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Remember to unsubscribe if you are no longer using the subscription.

## [Syntax](./accountstatusupdate.md)

`AccountStatusUpdate`

## [Examples](./accountstatusupdate.md)

```csharp
/* Example of subscribing/unsubscribing to account status update events from an Add On. The concept can be carried over
to any NinjaScript object you may be working on. */
public class MyAddOnTab : NTTabPage
{
     public MyAddOnTab()
     {
          // Subscribe to account status updates
          Account.AccountStatusUpdate += OnAccountStatusUpdate;
     }

     // This method is fired on any status change of any account
     private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e)
     {
          // Output the account name and status
          NinjaTrader.Code.Output.Process(string.Format("Account: {0} Status: {1}",
               e.Account.Name, e.Status), PrintTo.OutputTab1);
     }

     // Called by TabControl when tab is being removed or window is closed
     public override void Cleanup()
     {
          // Make sure to unsubscribe to the account status subscription
          Account.AccountStatusUpdate -= OnAccountStatusUpdate;
     }

     // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.
}
```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./accountstatusupdate.md)
*   [Syntax](./accountstatusupdate.md)
*   [Examples](./accountstatusupdate.md)