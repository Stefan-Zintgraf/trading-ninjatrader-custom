**Path**: [NTTabPage Class](./nttabpage.md) > [GetHeaderPart()](./getheaderpart.md)

# GetHeaderPart()

# GetHeaderPart()

## [Definition](./getheaderpart.md)

Indicates the tab header name.

## [Examples](./getheaderpart.md)

```csharp

// NTTabPage member. Required for determining the tab header name
protected override string GetHeaderPart(string variable)
{
     // Determine the text for the tab header name
     switch (variable)
     {
         case "@INSTRUMENT": return Instrument == null ? Resource.GuiNewTab : Instrument.MasterInstrument.Name;
         case "@INSTRUMENT_FULL": return Instrument == null ? Resource.GuiNewTab : Instrument.FullName;
     }
     return variable;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getheaderpart.md)
*   [Examples](./getheaderpart.md)