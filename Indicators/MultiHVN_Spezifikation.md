# Multi High Volume Node Indikator - Spezifikation

## Übersicht

Diese Spezifikation beschreibt die Implementierung eines NinjaTrader-Indikators für Multi High Volume Nodes (Multi HVN) sowie die zugehörige Trading-Strategie.

---

## Teil 1: Multi HVN Indikator

### Anforderungen

#### 1. Volumenberechnung

**Referenzimplementierung**: Verwende zur Berechnung der Volumes der einzelnen Preislevels dieselben Mechanismen wie in `C:\Users\szint\Documents\NinjaTrader 8\bin\Custom\Indicators\SimbaIndi.cs`

**Berechnungsmethode:**
- **Price-Level-Buckets**: Das Volumen wird in Preislevel-Buckets akkumuliert
- **Level-Berechnung**: 
  - Preis wird in Ticks umgewandelt: `iPrice(price, tickSize)`
  - Level wird berechnet: `level = iPrice(price, tickSize) / step`
  - `step = iPrice(PriceLevelSize, tickSize)` (wenn step <= 0, dann step = 1)
- **Akkumulation**: 
  - Jedes Trade-Execution-Event wird einem Preislevel zugeordnet
  - Volumen wird pro Level in Dictionaries akkumuliert (`_askCur[level]`, `_bidCur[level]`)
  - Separate Speicherung für Ask- und Bid-Volumen
- **Separate vs. gemeinsame Akkumulation**:
  - Wenn verschiedene PriceLevelSizes verwendet werden → separate Dictionaries
  - Wenn gleiche PriceLevelSize → gemeinsame Akkumulation

**Einstellbare Parameter:**
- **PriceLevelSize** (double, Standard: 1.0): Größe der Preislevel-Buckets in Preis-Einheiten
  - Definiert die Granularität der Volumenaggregation
  - Beispiel: PriceLevelSize = 1.0 bedeutet 1 Tick pro Level
  - Beispiel: PriceLevelSize = 0.25 bedeutet 0.25 Ticks pro Level (feinere Granularität)
- **VolumeCalculationMode** (enum, Standard: Total): Methode zur Volumenberechnung pro Preislevel
  - **Total** (Standard): Ask + Bid Volumen (Gesamtvolumen)
  - **AskOnly**: Nur Ask-Volumen
  - **BidOnly**: Nur Bid-Volumen
  - **Delta**: Ask - Bid Volumen (Volumen-Differenz)
- **Volumenquelle**: Orderflow-Execution-Daten (e.Volume, e.Price)
- **Ask/Bid-Trennung**: Automatische Unterscheidung zwischen Ask- und Bid-Trades

#### 2. Visualisierung
- **HVN-Werte anzeigen**: Zeige die HVN-Werte rechts von den entsprechenden Bars in **weißer Farbe**
- Die Werte sollen klar lesbar und den jeweiligen Bars zugeordnet sein

#### 3. Parametrierung
Erstelle Vorschläge für folgende Parameter:
- **Benchmark-Parameter**: Schwellenwert für die HVN-Erkennung
- **Mindestanzahl aufeinanderfolgender HVNs**: Für Multi-HVN-Erkennung (Standard: 2)
- **Volumenberechnungsmethode**: Anpassbare Einstellungen
- **Anzeigeoptionen**: Ein-/Ausblenden von Werten, Farbanpassungen

#### 4. Signalgenerierung
- **Benchmark-Vergleich**: Wenn der HVN-Wert größer als der Benchmark-Parameter wird:
  - Zeichne einen **Kreis um den HVN-Wert**
  - Löse ein **Signal aus**, das eine Trading-Strategie auswerten kann
  - Ähnlich wie `SimbaIndi.cs` bei `Bigtrade`

#### 5. Datei- und Indikatornamen
Die Datei soll lauten MhvnIndi.cs, der Indikator _MhvnIndi
---

## Teil 2: Multi HVN Orderflow Strategie

### Strategie-Übersicht

#### Einführung
Dieses Setup wurde entwickelt, um institutionelle Händler aufzuspüren. Dies gelingt durch die Identifikation von High Volume Nodes (HVN). Die Software umrahmt diese schwarz. Für ein gültiges Signal benötigen wir mindestens zwei aufeinanderfolgende Footprints, die ihren High Volume Node auf demselben Preislevel haben - einen sogenannten **Multi HVN**.

**Wichtige Eigenschaften:**
- Je mehr aufeinanderfolgende High Volume Nodes, desto stärker das Signal
- Vorzugsweise sind die Multi HVN in einem Trend oder in einer starken Preisabneigung entstanden
- Funktioniert ohne BID- und ASK-Werte, kann somit auch im Forex gehandelt werden
- Optional: Timing-Setup für verbessertes Ein- und Ausstiegs-Timing

### Handelsregeln

#### 1. Chart-Setup
- **Timeframe**: 30 Minuten Chart
- **Orderflow-Einstellung**: Nur das Volumen anzeigen (keine BID/ASK-Ansicht erforderlich)

#### 2. Multi HVN Identifikation
- Halte Ausschau nach einem oder mehreren Multi HVN
- **Multi HVN Definition**: Mindestens zwei aufeinanderfolgende Footprints mit HVN auf demselben Preislevel
- Markiere diese Stelle mit einer **horizontalen Linie im Chart** - dies ist der **Trigger (Auslöser)**

#### 3. Trade-Voraussetzungen
Nach dem Multi HVN müssen sich **mindestens zwei vollständige Footprints** ober- oder unterhalb des Triggers gebildet haben.

#### 4. Trade-Auslösung
- Warte, bis der Kurs wieder in die Richtung des Multi HVN dreht
- **LONG-Signal**: Wirst du von oben getriggert (Kurs kommt von oben zum Trigger), eröffne LONG
- **SHORT-Signal**: Kommt der Kurs von unten in deinen Trigger, eröffne SHORT
- **Wichtig**: Nur den ersten Kontakt mit dem Trigger handeln = **First Touch**

### Beispiele (aus Dokumentation)
- Multi HVN - SHORT Beispiel mit starker Preisabneigung
- Multi HVN - LONG Beispiel im Sojabohnen Future
- Multi HVN - SHORT Setup in einer Preisabneigung
- Multi HVN - Failed SHORT Beispiel im Euro Future
- Multi HVN - SHORT Beispiel im Silber Future mit 3fachem High Volume Node

---

## Teil 3: Stop-Loss Strategie (#3 - Orderflow)

### Konzept
Die Orderflowansicht ist für die Stoppsetzung bestens geeignet. Der STOP-LOSS wird oberhalb bzw. unterhalb einer Heavy Volume Zone, in eine volumenschwache Zone gesetzt.

### Mechanismus
- **Heavy Volume Cluster** wirken wie Unterstützung oder Widerstand
- Der Kurs sollte diese Zonen nicht so einfach passieren
- Der STOP-LOSS wird **tickgenau** definiert
- **Positionierung**: Entgegen der Handelsrichtung, oberhalb oder unterhalb der Heavy Volume Zone, in den Bereich mit dem niedrigsten Volumen

### Wichtige Hinweise
- **Individuelle Anpassung**: STOP-LOSS sollte individuell nach Depotgröße, Risikobereitschaft und Bedürfnissen angepasst werden
- **Chancen-Risiko-Verhältnis**: 
  - Zu weit entfernt = verfehltes Chancen-Risiko-Verhältnis
  - Zu nah am Einstieg = unnötig ausgestoppt
- **Verhältnis**: Möglicher Gewinn zu möglichem Verlust sollte mindestens **5:1** sein
- **Kein fester STOP-LOSS**: Ein fixer STOP-LOSS mit immer gleicher Tickzahl, Prozentsatz oder Betrag funktioniert auf Dauer nicht
- **Trailing Stop**: Ist das Gewinnziel zu 70% oder höher erreicht, kann situationsbedingt der STOP-LOSS auf das Einstiegslevel nachgezogen werden

---

## Teil 4: Take-Profit Strategie

### Konzept
Die Gewinnmitnahme erfolgt gebunden an einen Plan, nicht emotional oder nach Tageslaune.

### Orderflow-Ansatz
- **Faustregel**: Gewinne vor volumenstarken Zonen mitnehmen
- Der Kurs dreht oftmals schon vor dem Kontakt mit Widerstand/Unterstützung
- Der TAKE-PROFIT wird **ein paar Ticks vor** diese Zonen gesetzt
- **Warnung**: Wer hier gierig wird, den bestraft der Markt erbarmungslos

### Entscheidungskriterien
- **Zu nah am Einstieg**: Wenn die nächste markante High Volume Area zu nah am Einstiegslevel ist, kann man den Trade auslassen
- **Weit entfernt**: Ist sie vom Einstieg weit entfernt und der Kurs bewegt sich in die gewünschte Richtung, zieht man den STOP-LOSS immer wieder nach
- **Erlernbar**: Diese Technik braucht Übung, ist aber erlernbar

### Wichtige Hinweise
- **Kein fester TAKE-PROFIT**: Von einem fixen TAKE-PROFIT ist dringend abzuraten
- **Kein Zufallsprinzip**: Feste TAKE-PROFITs nach hartem Maßstab (Tickzahl, Prozentsatz, Betrag) beruhen auf Zufallsprinzip und führen nicht zum gewünschten Erfolg

---

## Implementierungsvorschläge

### Indikator-Parameter
```csharp
// Vorgeschlagene Parameterstruktur

// Volumenberechnung (basierend auf SimbaIndi.cs)
- PriceLevelSize: double (Größe der Preislevel-Buckets, Standard: 1.0)
  // Definiert die Granularität der Volumenaggregation pro Preislevel
  // Beispiel: 1.0 = 1 Tick pro Level, 0.25 = feinere Granularität

// HVN-Erkennung
- BenchmarkVolume: double (Schwellenwert für HVN-Erkennung)
- MinConsecutiveHVNs: int (Mindestanzahl aufeinanderfolgender HVNs, Standard: 2)
- VolumeCalculationMode: enum (Standard: Total, Optionen: AskOnly, BidOnly, Delta)
  // Total: Ask + Bid Volumen (Standard) - Gesamtvolumen pro Preislevel
  // AskOnly: Nur Ask-Volumen für HVN-Berechnung
  // BidOnly: Nur Bid-Volumen für HVN-Berechnung  
  // Delta: Ask - Bid Volumen (Volumen-Differenz)

// Visualisierung
- ShowHVNValues: bool (HVN-Werte anzeigen)
- HVNTextColor: Color (Farbe der HVN-Werte, Standard: Weiß)
- ShowCircleOnSignal: bool (Kreis um HVN bei Signal)
- CircleColor: Color (Farbe des Kreises)
- HVNTextOffset: int (Offset für Textposition rechts vom Bar)
```

### Strategie-Parameter
```csharp
// Vorgeschlagene Parameterstruktur
- Timeframe: int (Standard: 30 Minuten)
- MinFootprintsAfterHVN: int (Mindestanzahl Footprints nach HVN, Standard: 2)
- FirstTouchOnly: bool (Nur First Touch handeln, Standard: true)
- RiskRewardRatio: double (Mindestverhältnis Gewinn:Verlust, Standard: 5.0)
- TrailingStopActivation: double (Prozent für Trailing Stop, Standard: 0.70)
- UseOrderflowStopLoss: bool (Orderflow-basierter Stop-Loss)
- UseOrderflowTakeProfit: bool (Orderflow-basierter Take-Profit)
```

### Optimierungsvorschläge

1. **Multi-Timeframe-Analyse**: 
   - Integration höherer Timeframes zur Bestätigung
   - Trend-Erkennung über mehrere Timeframes

2. **Volumen-Filter**:
   - Relative Volumenstärke im Vergleich zu historischen Werten
   - Volumen-Profile-Analyse für bessere HVN-Identifikation

3. **Dynamische Anpassung**:
   - Automatische Anpassung des Benchmark-Parameters basierend auf Marktvolatilität
   - Adaptive Stop-Loss- und Take-Profit-Levels

4. **Signal-Filter**:
   - Zusätzliche Bestätigung durch Preisaktion
   - Trend-Filter zur Vermeidung von Trades gegen den Trend

5. **Performance-Metriken**:
   - Tracking der Multi-HVN-Stärke (Anzahl aufeinanderfolgender HVNs)
   - Statistische Auswertung der Signalqualität

---

## Technische Anforderungen

### Abhängigkeiten
- NinjaTrader 8 Framework
- Referenz auf `SimbaIndi.cs` für Volumenberechnung
- Orderflow-Datenquelle

### Implementierungsreihenfolge
1. **Phase 1**: Multi HVN Indikator mit Volumenberechnung
2. **Phase 2**: Visualisierung und Signalgenerierung
3. **Phase 3**: Strategie-Implementierung mit Entry-Logik
4. **Phase 4**: Stop-Loss-Implementierung (Orderflow-basiert)
5. **Phase 5**: Take-Profit-Implementierung (Orderflow-basiert)
6. **Phase 6**: Testing und Optimierung

---

## Dokumentationsanforderungen

- Code-Kommentare in deutscher Sprache
- XML-Dokumentation für alle öffentlichen Methoden und Properties
- Beispiel-Konfigurationen für verschiedene Märkte
- Performance-Tests und Backtesting-Ergebnisse

---

*Erstellt basierend auf Strategie1_MultiHVN.docx*

