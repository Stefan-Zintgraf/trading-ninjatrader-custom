**Path**: [IWorkspacePersistence Interface](./iworkspacepersistence_interface.md) > [NewsSubscription](./newssubscription.md)

# NewsSubscription

# NewsSubscription

## [Definition](./newssubscription.md)

**NewsSubscription** can be used for subscribing to News events.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Remember to unsubscribe if you are no longer using the subscription.

## [Properties](./newssubscription.md)

Update

Event handler for subscribing/unsubscribing to market depth events

## [Syntax](./newssubscription.md)

`NewsSubscription`

## [Examples](./newssubscription.md)

```csharp
/* Example of subscribing/unsubscribing to news from an Add On. The concept can be carried over
to any NinjaScript object you may be working on. */
public class MyAddOnTab : NTTabPage
{
     private NewsSubscription newsSubscription;
     private NewsItems       newsItems;

     public MyAddOnTab()
     {
          // Subscribe to news
          newsSubscription         = new NewsSubscription();
          newsSubscription.Update += OnNews;
          newsItems               = new NewsItems(10);
     }

     // This method is fired as new News events come in. Old News events are not provided when you subscribe.
     private void OnNews(object sender, NewsEventArgs e)
     {
          // Print the headline of the news
          NinjaTrader.Code.Output.Process(string.Format("ID: {0} News Provider: {1} Headline: {2}",
               e.Id,
               e.NewsProvider,
               e.Headline), PrintTo.OutputTab1);

          // Maintain the news items
          newsItems.Update(e);
     }

     // Called by TabControl when tab is being removed or window is closed
     public override void Cleanup()
     {
          // Make sure to unsubscribe to the News subscription
          if (newsSubscription != null)
               newsSubscription.Update -= OnNews;
     }

     // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./newssubscription.md)
*   [Properties](./newssubscription.md)
*   [Syntax](./newssubscription.md)
*   [Examples](./newssubscription.md)