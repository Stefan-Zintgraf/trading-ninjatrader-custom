**Path**: [Share Service](./share_service.md) > [CharactersReservedPerMedia](./charactersreservedpermedia.md)

# CharactersReservedPerMedia

# CharactersReservedPerMedia

## [Definition](./charactersreservedpermedia.md)

Sets the number of characters allowed when attaching an image to ensure that character count is properly calculated.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Social networks which limit the number of characters for each post, will have a defined number of characters that are reserved when an image or other media is attached.

## [Property Value](./charactersreservedpermedia.md)

A int value that represents the number of characters reserved when attaching an image or other media.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./charactersreservedpermedia.md)

`CharactersReservedPerMedia`

## [Examples](./charactersreservedpermedia.md)

```csharp
protected override void OnStateChange()
{                     
    if (State == State.SetDefaults)
    {
        CharactersReservedPerMedia = 40;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./charactersreservedpermedia.md)
*   [Property Value](./charactersreservedpermedia.md)
*   [Syntax](./charactersreservedpermedia.md)
*   [Examples](./charactersreservedpermedia.md)