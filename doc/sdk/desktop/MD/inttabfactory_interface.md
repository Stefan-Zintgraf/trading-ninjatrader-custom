**Path**: [INTTabFactory Interface](./inttabfactory_interface.md)

# INTTabFactory Interface

# INTTabFactory Interface

If you wish to have tab page functionality like adding, removing, moving, duplicating tabs you must create a class which implements the **INTTabFactory** interface.

This interface contains two methods which must be hidden:

## [Syntax](./inttabfactory_interface.md)

`NTWindow CreateParentWindow()`

`NTTabPage CreateTabPage(string typeName, bool isNewWindow = false)`

## [Examples](./inttabfactory_interface.md)

```csharp
public class MyWindowFactory : INTTabFactory
{
     // INTTabFactory member. Creates the parent window that contains tabs
     public NTWindow CreateParentWindow()
     {
         return new MyWindow();
     }

     // INTTabFactory member. Creates new tab pages whenever the user presses the + button
     public NTTabPage CreateTabPage(string typeName)
     {
         return new MyWindowTabPage();
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Syntax](./inttabfactory_interface.md)
*   [Examples](./inttabfactory_interface.md)