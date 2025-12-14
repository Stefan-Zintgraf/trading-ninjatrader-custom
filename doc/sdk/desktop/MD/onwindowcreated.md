**Path**: [NTTabPage Class](./nttabpage.md) > [OnWindowCreated()](./onwindowcreated.md)

# OnWindowCreated()

# OnWindowCreated()

## [Definition](./onwindowcreated.md)

This method is called whenever a new **NTWindow** is created. It will be called in the thread of that window. This is where you would install your AddOn to an existing window, or if creating your own custom window, add a Menu item to the NinjaTrader Control Center.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method will also be called on a recompile of the NinjaTrader.Custom project (e.g., when you compile an indicator, strategy, or add\-on).

## [Method Return Value](./onwindowcreated.md)

This method does not return a value.

## [Syntax](./onwindowcreated.md)

`OnWindowCreated(Window window)`

## [Parameters](./onwindowcreated.md)

window

A Window object which is being added to the workspace

## [Examples](./onwindowcreated.md)

```csharp
public class MyWindowAddOn : AddOnBase
{
    private NTMenuItem myMenuItem;
    private NTMenuItem existingMenuItem;

    protected override void OnStateChange()
    {
        if (State == State.SetDefaults)
        {
            Description = "Our custom MyWindow add on";
            Name       = "MyWindow";
        }
    }

    // Will be called as a new NTWindow is created. It will be called in the thread of that window
    protected override void OnWindowCreated(Window window)
    {
        // We want to place our add on in the Control Center's menus
        ControlCenter cc = window as ControlCenter;
        if (cc == null)
            return;

        /* Determine we want to place our add on in the Control Center's "New" menu
         Other menus can be accessed via the control's Automation ID. For example: toolsMenuItem,   
         workspacesMenuItem, connectionsMenuItem, helpMenuItem. */
        existingMenuItem = cc.FindFirst("ControlCenterMenuItemNew") as NTMenuItem;
        if (existingMenuItem == null)
            return;

        // 'Header' sets the name of our add on seen in the menu structure
        myMenuItem = new NTMenuItem { Header = "My Menu Item",
            Style = Application.Current.TryFindResource("MainMenuItem") as Style };

        // Place our add on into the "New" menu
        existingMenuItem.Items.Add(myMenuItem);

        // Subscribe to the event for when the user presses our add on's menu item
        myMenuItem.Click += OnMenuItemClick;
    }

    // Open our add on's window when the menu item is clicked on
    private void OnMenuItemClick(object sender, RoutedEventArgs e)
    {
        // Show the NTWindow "MyWindow"
        Core.Globals.RandomDispatcher.InvokeAsync(new Action(() => new MyWindow().Show()));
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onwindowcreated.md)
*   [Method Return Value](./onwindowcreated.md)
*   [Syntax](./onwindowcreated.md)
*   [Parameters](./onwindowcreated.md)
*   [Examples](./onwindowcreated.md)