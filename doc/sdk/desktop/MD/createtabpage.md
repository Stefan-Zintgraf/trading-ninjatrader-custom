**Path**: [INTTabFactory Interface](./inttabfactory_interface.md) > [CreateTabPage()](./createtabpage.md)

# CreateTabPage()

# CreateTabPage()

This determines which **NTTabPage** is created whenever a new tab is needed in our parent window for our Add On.

## [Examples](./createtabpage.md)

```csharp
// INTTabFactory member. Creates new tab pages whenever the user presses the + button
public NTTabPage CreateTabPage(string typeName, bool isNewWindow = false)
{
   return new MyWindowTabPage();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Examples](./createtabpage.md)