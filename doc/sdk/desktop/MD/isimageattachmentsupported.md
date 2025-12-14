**Path**: [Share Service](./share_service.md) > [IsImageAttachmentSupported](./isimageattachmentsupported.md)

# IsImageAttachmentSupported

# IsImageAttachmentSupported

## [Definition](./isimageattachmentsupported.md)

Determines if the Share Service will allow for images as attachments.

## [Property Value](./isimageattachmentsupported.md)

A bool value when false, screenshots will be unable to be sent to the social network.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during **State.SetDefaults** or **State.Configure**.

## [Syntax](./isimageattachmentsupported.md)

`IsImageAttachmentSupported`

## [Examples](./isimageattachmentsupported.md)

```csharp
protected override void OnStateChange()
{         
   if (State == State.SetDefaults)
   {
      IsImageAttachmentSupported = false;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isimageattachmentsupported.md)
*   [Property Value](./isimageattachmentsupported.md)
*   [Syntax](./isimageattachmentsupported.md)
*   [Examples](./isimageattachmentsupported.md)