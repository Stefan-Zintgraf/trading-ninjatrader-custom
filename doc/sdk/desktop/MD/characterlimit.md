**Path**: [Share Service](./share_service.md) > [CharacterLimit](./characterlimit.md)

# CharacterLimit

# CharacterLimit

## [Definition](./characterlimit.md)

Determines the maximum number of characters the social network allows. Signature, text, and links all contribute to this character count displayed on the share window.

A value of **int.MaxValue** determines no practical limit and will make the character count not appear on the Share window.

## [Property Value](./characterlimit.md)

A **int** value that represents the maximum number of characters the social network allows.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./characterlimit.md)

`CharacterLimit`

## [Examples](./characterlimit.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        CharacterLimit = 280;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./characterlimit.md)
*   [Property Value](./characterlimit.md)
*   [Syntax](./characterlimit.md)
*   [Examples](./characterlimit.md)