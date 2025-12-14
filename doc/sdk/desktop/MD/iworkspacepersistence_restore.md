**Path**: [IWorkspacePersistence Interface](./iworkspacepersistence_interface.md) > [Restore()](./iworkspacepersistence_restore.md)

# Restore()

# Restore()

## [Definition](./iworkspacepersistence_restore.md)

Restores the window from workspaces.

## [Examples](./iworkspacepersistence_restore.md)

```csharp
// IWorkspacePersistence member. Required for restoring window from workspaces
public void Restore(XDocument document, XElement)
{

  if (MainTabControl != null)

    MainTabControl.RestoreFromXElement(element);

}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./iworkspacepersistence_restore.md)
*   [Examples](./iworkspacepersistence_restore.md)