**Path**: [IWorkspacePersistence Interface](./iworkspacepersistence_interface.md) > [Save()](./iworkspacepersistence_save.md)

# Save()

# Save()

## [Definition](./iworkspacepersistence_save.md)

Saves the window to workspaces.

## [Examples](./iworkspacepersistence_save.md)

```csharp
// IWorkspacePersistence member. Required for saving window to workspaces
public void Save(XDocument document, XElement element)
{

  if (MainTabControl != null)
    MainTabControl.SaveToXElement(element);

}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./iworkspacepersistence_save.md)
*   [Examples](./iworkspacepersistence_save.md)