#region Using declarations
using NinjaTrader;
using NinjaTrader.Core;
using NinjaTrader.Data;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.NinjaScript;
using NinjaTrader.NinjaScript.Indicators;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
#endregion

namespace NinjaTrader.NinjaScript.Indicators
{
    /// <summary>
    /// Volumenberechnungsmodus für HVN-Erkennung
    /// </summary>
    public enum VolumeCalculationMode
    {
        Total,      // Ask + Bid Volumen (Standard)
        AskOnly,    // Nur Ask-Volumen
        BidOnly,    // Nur Bid-Volumen
        Delta       // Ask - Bid Volumen
    }

    /// <summary>
    /// Multi High Volume Node Indikator
    /// Identifiziert High Volume Nodes (HVN) und Multi-HVNs basierend auf Orderflow-Volumendaten
    /// </summary>
    public class _MhvnIndi : Indicator
    {

        #region Parameters
        [NinjaScriptProperty]
        [Range(0, double.MaxValue)]
        [Display(Name = "Price Level Size", Description = "Größe der Preislevel-Buckets in Preis-Einheiten. Definiert die Granularität der Volumenaggregation.", Order = 1, GroupName = "Volumenberechnung")]
        public double PriceLevelSize { get; set; } = 1.0;

        [NinjaScriptProperty]
        [Display(Name = "Volume Calculation Mode", Description = "Methode zur Volumenberechnung pro Preislevel", Order = 2, GroupName = "Volumenberechnung")]
        public VolumeCalculationMode VolumeCalcMode { get; set; } = VolumeCalculationMode.Total;

        [NinjaScriptProperty]
        [Range(0, double.MaxValue)]
        [Display(Name = "Benchmark Volume", Description = "Schwellenwert für HVN-Erkennung. HVN-Werte müssen größer als dieser Wert sein.", Order = 1, GroupName = "HVN-Erkennung")]
        public double BenchmarkVolume { get; set; } = 1000.0;

        [NinjaScriptProperty]
        [Range(1, int.MaxValue)]
        [Display(Name = "Min Consecutive HVNs", Description = "Mindestanzahl aufeinanderfolgender HVNs auf demselben Preislevel für Multi-HVN-Erkennung", Order = 2, GroupName = "HVN-Erkennung")]
        public int MinConsecutiveHVNs { get; set; } = 2;

        [NinjaScriptProperty]
        [Display(Name = "Show HVN Values", Description = "HVN-Werte rechts von den Bars anzeigen", Order = 1, GroupName = "Visualisierung")]
        public bool ShowHVNValues { get; set; } = true;

        [NinjaScriptProperty]
        [Display(Name = "HVN Text Color", Description = "Farbe der HVN-Werte", Order = 2, GroupName = "Visualisierung")]
        public System.Windows.Media.Color HVNTextColor { get; set; } = System.Windows.Media.Colors.White;

        [NinjaScriptProperty]
        [Display(Name = "Show Circle On Signal", Description = "Kreis um HVN-Wert zeichnen, wenn Signal ausgelöst wird", Order = 3, GroupName = "Visualisierung")]
        public bool ShowCircleOnSignal { get; set; } = true;

        [NinjaScriptProperty]
        [Display(Name = "Circle Color", Description = "Farbe des Kreises bei Signal", Order = 4, GroupName = "Visualisierung")]
        public System.Windows.Media.Color CircleColor { get; set; } = System.Windows.Media.Colors.White;

        [NinjaScriptProperty]
        [Range(0, 100)]
        [Display(Name = "HVN Text Offset", Description = "Offset für Textposition rechts vom Bar (in Pixeln)", Order = 5, GroupName = "Visualisierung")]
        public int HVNTextOffset { get; set; } = 5;

        [NinjaScriptProperty]
        [Display(Name = "Show Ask/Bid Volume", Description = "Ask- und Bid-Volumen separat auf jedem Preislevel anzeigen", Order = 6, GroupName = "Visualisierung")]
        public bool ShowAskBidVolume { get; set; } = false;

        [NinjaScriptProperty]
        [Display(Name = "Ask Volume Color", Description = "Farbe für Ask-Volumen", Order = 7, GroupName = "Visualisierung")]
        public System.Windows.Media.Color AskVolumeColor { get; set; } = System.Windows.Media.Colors.Gray;

        [NinjaScriptProperty]
        [Display(Name = "Bid Volume Color", Description = "Farbe für Bid-Volumen", Order = 8, GroupName = "Visualisierung")]
        public System.Windows.Media.Color BidVolumeColor { get; set; } = System.Windows.Media.Colors.Gray;
        #endregion

        #region Variables
        // Volumen-Akkumulation pro Preislevel (wie in SimbaIndi.cs)
        private Dictionary<int, long> _askCur;
        private Dictionary<int, long> _bidCur;
        private int _askMinKey, _askMaxKey, _bidMinKey, _bidMaxKey;
        private long _askSumCur, _bidSumCur;

        // Ring-Buffer für Bar-Historie (wie in SimbaIndi.cs)
        private const int BufCap = 512; // Muss Potenz von 2 sein
        private readonly Dictionary<int, long>[] _askLevelsBuf = new Dictionary<int, long>[BufCap];
        private readonly Dictionary<int, long>[] _bidLevelsBuf = new Dictionary<int, long>[BufCap];
        private int _head = 0;
        private int _count = 0;
        private int _curBarIndex = -1;
        private bool IsNewBar = false;

        // HVN-Datenstrukturen
        private struct HVNData
        {
            public int Level;
            public double Price;
            public long Volume;
            public int BarIndex;
            public bool IsSignal; // Signal ausgelöst (über Benchmark)
        }

        // Multi-HVN Tracking: Level -> Liste von aufeinanderfolgenden HVNs (persistent über Bars)
        private Dictionary<int, List<HVNData>> _multiHVNLevels = new Dictionary<int, List<HVNData>>();
        private List<HVNData> _currentBarHVNs = new List<HVNData>();
        
        // Signal-Tracking: Level -> BarIndex -> IsSignal (für schnellen Zugriff beim Rendering)
        private Dictionary<int, Dictionary<int, bool>> _signalCache = new Dictionary<int, Dictionary<int, bool>>();
        
        // Multi-HVN-Sequenzen für Rechteck-Rendering: Level -> Liste von Bar-Indizes der Sequenz
        private Dictionary<int, List<int>> _multiHVNSequences = new Dictionary<int, List<int>>();

        // Rendering
        private TextFormat _tfNormal;
        private TextFormat _tfBold;
        private SolidColorBrush _dxWhiteBrush;
        private SolidColorBrush _dxCircleBrush;
        private SolidColorBrush _dxAskBrush;
        private SolidColorBrush _dxBidBrush;
        private SolidColorBrush _dxGrayBrush;
        private double mDigitsSize;
        private const float HorizontalPx = 10f; // Abstand vom Bar (wie in SimbaIndi)

        // Tick Size
        private double _tickSize;
        #endregion

        #region OnStateChange
        protected override void OnStateChange()
        {
            if (State == State.SetDefaults)
            {
                Description = @"Multi High Volume Node Indikator - Identifiziert HVNs und Multi-HVNs basierend auf Orderflow-Volumendaten";
                Name = "_MhvnIndi";
                IsOverlay = true;
                Calculate = Calculate.OnEachTick;
                IsAutoScale = false;
            }
            else if (State == State.Configure)
            {
                // Initialisiere Ring-Buffer
                for (int i = 0; i < BufCap; i++)
                {
                    _askLevelsBuf[i] = new Dictionary<int, long>(64);
                    _bidLevelsBuf[i] = new Dictionary<int, long>(64);
                }
            }
            else if (State == State.DataLoaded)
            {
                // Berechne Tick-Size (wie in SimbaIndi.cs)
                _tickSize = Instrument.MasterInstrument.TickSize;
                var tickSize = _tickSize;
                var digits = 0;
                while (Math.Abs((int)tickSize - tickSize) > double.Epsilon)
                {
                    tickSize *= 10;
                    digits++;
                }
                mDigitsSize = 1.0 / Math.Pow(10, digits);
            }
        }
        #endregion

        #region OnMarketData
        protected override void OnMarketData(MarketDataEventArgs e)
        {
            if (Bars == null || CurrentBar < 0) return;

            // Nur Last-Ticks für Volumenberechnung (wie in SimbaIndi.cs)
            if (e.MarketDataType != MarketDataType.Last) return;

            // Bar-Wechsel erkennen
            int bi = Bars.GetBar(e.Time);
            IsNewBar = _curBarIndex != bi;

            if (IsNewBar)
            {
                // HVN-Erkennung für VORHERIGE Bar durchführen (bevor wir den Buffer vorrücken)
                if (_count > 0 && _askCur != null && _bidCur != null)
                {
                    int previousBarIndex = _curBarIndex >= 0 ? _curBarIndex : bi - 1;
                    ProcessHVNDetection(previousBarIndex);
                }

                // Ring-Buffer vorrücken
                _head = (_head + 1) % BufCap;
                if (_count < BufCap) _count++;

                // Neue Bar-Dictionaries initialisieren
                _askCur = new Dictionary<int, long>(64);
                _bidCur = new Dictionary<int, long>(64);
                _askMinKey = int.MaxValue;
                _askMaxKey = int.MinValue;
                _bidMinKey = int.MaxValue;
                _bidMaxKey = int.MinValue;
                _askSumCur = 0;
                _bidSumCur = 0;

                // In Ring-Buffer speichern
                _askLevelsBuf[_head] = _askCur;
                _bidLevelsBuf[_head] = _bidCur;

                _curBarIndex = bi;
            }

            // Volumen akkumulieren (basierend auf SimbaIndi.cs)
            long vol = e.Volume;
            
            // Ask/Bid-Erkennung (wie in SimbaIndi.cs)
            double bid = e.Bid;   // provided by Tick Replay on Last
            double ask = e.Ask;   // provided by Tick Replay on Last
            
            // Require a sane book snapshot
            if (!(ask > bid))
            {
                return;
            }
            
            bool isAskTrade = e.Price >= ask;
            bool isBidTrade = e.Price <= bid;
            if (!isAskTrade && !isBidTrade)
            {
                return;
            }

            // Preislevel berechnen
            int step = iPrice(PriceLevelSize, mDigitsSize);
            if (step <= 0) step = 1;
            int level = iPrice(e.Price, mDigitsSize) / step;

            // Volumen akkumulieren
            if (isAskTrade)
            {
                if (_askCur.TryGetValue(level, out var va))
                    _askCur[level] = va + vol;
                else
                {
                    _askCur[level] = vol;
                    if (level < _askMinKey) _askMinKey = level;
                    if (level > _askMaxKey) _askMaxKey = level;
                }
                _askSumCur += vol;
            }
            else // bid trade
            {
                if (_bidCur.TryGetValue(level, out var vb))
                    _bidCur[level] = vb + vol;
                else
                {
                    _bidCur[level] = vol;
                    if (level < _bidMinKey) _bidMinKey = level;
                    if (level > _bidMaxKey) _bidMaxKey = level;
                }
                _bidSumCur += vol;
            }
        }
        #endregion

        #region HVN Detection
        /// <summary>
        /// Verarbeitet HVN-Erkennung für eine bestimmte Bar
        /// </summary>
        private void ProcessHVNDetection(int barIndex)
        {
            if (_askCur == null || _bidCur == null) return;

            _currentBarHVNs.Clear();

            // Volumen pro Level berechnen basierend auf VolumeCalcMode
            int startLevel = Math.Min(_askMinKey, _bidMinKey);
            int endLevel = Math.Max(_askMaxKey, _bidMaxKey);

            for (int level = startLevel; level <= endLevel; level++)
            {
                _askCur.TryGetValue(level, out long askVol);
                _bidCur.TryGetValue(level, out long bidVol);

                long volume = 0;
                switch (VolumeCalcMode)
                {
                    case VolumeCalculationMode.Total:
                        volume = askVol + bidVol;
                        break;
                    case VolumeCalculationMode.AskOnly:
                        volume = askVol;
                        break;
                    case VolumeCalculationMode.BidOnly:
                        volume = bidVol;
                        break;
                    case VolumeCalculationMode.Delta:
                        volume = askVol - bidVol;
                        break;
                }

                // HVN-Erkennung: Volumen über Benchmar
                if (volume > BenchmarkVolume)
                {
                    double price = PriceFromLevel(level);
                    HVNData hvn = new HVNData
                    {
                        Level = level,
                        Price = price,
                        Volume = volume,
                        BarIndex = barIndex,
                        IsSignal = false // Wird später durch Multi-HVN-Erkennung gesetzt
                    };

                    _currentBarHVNs.Add(hvn);

                    // Multi-HVN Tracking: Prüfe ob aufeinanderfolgende HVNs auf demselben Level
                    TrackMultiHVN(level, hvn);
                }
            }
        }

        /// <summary>
        /// Verfolgt Multi-HVNs: aufeinanderfolgende HVNs auf demselben Preislevel
        /// </summary>
        private void TrackMultiHVN(int level, HVNData hvn)
        {
            if (!_multiHVNLevels.TryGetValue(level, out var hvnList))
            {
                hvnList = new List<HVNData>();
                _multiHVNLevels[level] = hvnList;
            }

            // Prüfe ob letzter Eintrag auf vorheriger Bar war (aufeinanderfolgend)
            if (hvnList.Count > 0)
            {
                var lastHVN = hvnList[hvnList.Count - 1];
                if (hvn.BarIndex == lastHVN.BarIndex + 1)
                {
                    // Aufeinanderfolgend - hinzufügen
                    hvnList.Add(hvn);
                }
                else
                {
                    // Nicht aufeinanderfolgend - neue Sequenz starten
                    hvnList.Clear();
                    hvnList.Add(hvn);
                }
            }
            else
            {
                // Erste HVN auf diesem Level
                hvnList.Add(hvn);
            }

            // Prüfe ob Multi-HVN-Bedingung erfüllt (mindestens MinConsecutiveHVNs)
            if (hvnList.Count >= MinConsecutiveHVNs)
            {
                // Multi-HVN erkannt - alle als Signal markieren und in Cache speichern
                List<int> barIndices = new List<int>();
                for (int i = 0; i < hvnList.Count; i++)
                {
                    var h = hvnList[i];
                    h.IsSignal = true;
                    hvnList[i] = h;
                    barIndices.Add(h.BarIndex);
                    
                    // In Signal-Cache speichern für schnellen Zugriff beim Rendering
                    if (!_signalCache.TryGetValue(level, out var barDict))
                    {
                        barDict = new Dictionary<int, bool>();
                        _signalCache[level] = barDict;
                    }
                    barDict[h.BarIndex] = true;
                }
                
                // Multi-HVN-Sequenz speichern für Rechteck-Rendering
                _multiHVNSequences[level] = barIndices;
            }
        }

        /// <summary>
        /// Prüft ob ein Level/Bar-Kombination ein Multi-HVN-Signal ist
        /// </summary>
        private bool IsMultiHVNSignal(int level, int barIndex)
        {
            // Zuerst im Cache prüfen (schneller)
            if (_signalCache.TryGetValue(level, out var barDict))
            {
                if (barDict.TryGetValue(barIndex, out bool isSignal))
                    return isSignal;
            }
            
            // Fallback: In Multi-HVN-Liste prüfen
            if (!_multiHVNLevels.TryGetValue(level, out var hvnList))
                return false;

            // Prüfe ob dieser Bar-Index Teil einer Multi-HVN-Sequenz ist
            return hvnList.Any(h => h.BarIndex == barIndex && h.IsSignal);
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Konvertiert Preis in Ticks (wie in SimbaIndi.cs)
        /// </summary>
        private static int iPrice(double dPrice, double tickSize)
        {
            return Math.Sign(dPrice) * (int)(0.5 + Math.Abs(dPrice) / tickSize);
        }

        /// <summary>
        /// Konvertiert Ticks zurück in Preis (wie in SimbaIndi.cs)
        /// </summary>
        private static double dPrice(uint iPrice, double tickSize)
        {
            return tickSize * iPrice;
        }

        /// <summary>
        /// Konvertiert Level zurück in Preis
        /// </summary>
        private double PriceFromLevel(int level)
        {
            int stepTicks = iPrice(PriceLevelSize, mDigitsSize);
            if (stepTicks <= 0) stepTicks = 1;
            long totalTicks = (long)level * stepTicks;
            if (totalTicks < 0) totalTicks = 0;
            return dPrice((uint)totalTicks, mDigitsSize);
        }

        /// <summary>
        /// Holt Volumendaten für einen bestimmten Bar-Index aus dem Ring-Buffer
        /// </summary>
        private (Dictionary<int, long> ask, Dictionary<int, long> bid) GetLevelsForBar(int barOffset)
        {
            if (barOffset < 0 || barOffset >= _count) return (null, null);
            int idx = (_head - barOffset + BufCap) % BufCap;
            return (_askLevelsBuf[idx], _bidLevelsBuf[idx]);
        }
        #endregion

        #region OnRender
        protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
        {
            if (_count == 0 || !ShowHVNValues) return;
            if (RenderTarget == null) return;

            // Rendering-Objekte initialisieren (müssen bei jedem RenderTarget-Wechsel neu erstellt werden)
            if (_tfNormal == null)
            {
                _tfNormal = new TextFormat(Core.Globals.DirectWriteFactory, "Arial", FontWeight.Normal, FontStyle.Normal, 10);
            }
            if (_tfBold == null)
            {
                _tfBold = new TextFormat(Core.Globals.DirectWriteFactory, "Arial", FontWeight.Bold, FontStyle.Normal, 10);
            }
            if (_dxWhiteBrush == null)
            {
                _dxWhiteBrush = new SolidColorBrush(RenderTarget, new Color4(
                    (float)HVNTextColor.R / 255f,
                    (float)HVNTextColor.G / 255f,
                    (float)HVNTextColor.B / 255f,
                    1f));
            }
            if (_dxCircleBrush == null)
            {
                _dxCircleBrush = new SolidColorBrush(RenderTarget, new Color4(
                    (float)CircleColor.R / 255f,
                    (float)CircleColor.G / 255f,
                    (float)CircleColor.B / 255f,
                    1f));
            }
            if (_dxGrayBrush == null)
            {
                // Grau für Ask/Bid (wie in SimbaIndi)
                _dxGrayBrush = new SolidColorBrush(RenderTarget, new Color4(0.85f, 0.85f, 0.85f, 1f));
            }
            if (_dxAskBrush == null)
            {
                _dxAskBrush = new SolidColorBrush(RenderTarget, new Color4(
                    (float)AskVolumeColor.R / 255f,
                    (float)AskVolumeColor.G / 255f,
                    (float)AskVolumeColor.B / 255f,
                    1f));
            }
            if (_dxBidBrush == null)
            {
                _dxBidBrush = new SolidColorBrush(RenderTarget, new Color4(
                    (float)BidVolumeColor.R / 255f,
                    (float)BidVolumeColor.G / 255f,
                    (float)BidVolumeColor.B / 255f,
                    1f));
            }

            // Sichtbaren Bereich bestimmen
            int firstBar = ChartBars.FromIndex;
            int lastBar = ChartBars.ToIndex;
            int dataLast = Math.Min(CurrentBar, Close.Count - 1);

            // Sammle Multi-HVN-Rechteck-Koordinaten pro Bar
            Dictionary<int, List<(float top, float bottom)>> rectCoordsByBar = new Dictionary<int, List<(float top, float bottom)>>();

            // Rendere ALLE Preislevels für sichtbare Bars
            for (int k = 0; k < _count && k <= dataLast; k++)
            {
                int biAbs = dataLast - k;
                if (biAbs < firstBar || biAbs > lastBar) continue;

                // Volumendaten für diese Bar holen
                var (askLevels, bidLevels) = GetLevelsForBar(k);
                if (askLevels == null || bidLevels == null) continue;

                // Alle Levels dieser Bar durchgehen
                int startLevel = Math.Min(
                    askLevels.Keys.DefaultIfEmpty(int.MaxValue).Min(),
                    bidLevels.Keys.DefaultIfEmpty(int.MaxValue).Min());
                int endLevel = Math.Max(
                    askLevels.Keys.DefaultIfEmpty(int.MinValue).Max(),
                    bidLevels.Keys.DefaultIfEmpty(int.MinValue).Max());

                if (startLevel == int.MaxValue || endLevel == int.MinValue) continue;

                float xCenter = chartControl.GetXByBarIndex(ChartBars, biAbs);
                float dx = HorizontalPx;

                for (int level = startLevel; level <= endLevel; level++)
                {
                    askLevels.TryGetValue(level, out long askVol);
                    bidLevels.TryGetValue(level, out long bidVol);

                    long volume = 0;
                    switch (VolumeCalcMode)
                    {
                        case VolumeCalculationMode.Total:
                            volume = askVol + bidVol;
                            break;
                        case VolumeCalculationMode.AskOnly:
                            volume = askVol;
                            break;
                        case VolumeCalculationMode.BidOnly:
                            volume = bidVol;
                            break;
                        case VolumeCalculationMode.Delta:
                            volume = askVol - bidVol;
                            break;
                    }

                    // Preis und Position berechnen
                    double price = PriceFromLevel(level);
                    float y = chartScale.GetYByValue(price);

                    // Bid-Volumen IMMER links anzeigen (grau) - nah am Bar (auch bei 0, wie in SimbaIndi)
                    string bidText = bidVol.ToString("N0", CultureInfo.InvariantCulture);
                    using (var bidLayout = new TextLayout(Core.Globals.DirectWriteFactory, bidText, _tfNormal, 1000, 1000))
                    {
                        float bidWidth = bidLayout.Metrics.Width;
                        float bidHeight = bidLayout.Metrics.Height;
                        float xBid = xCenter - dx - bidWidth; // Links vom Bar, nah am Bar
                        float yBid = y - bidHeight / 2f;
                        RenderTarget.DrawTextLayout(new Vector2(xBid, yBid), bidLayout, _dxGrayBrush);
                    }

                    // Ask-Volumen IMMER rechts anzeigen (grau) - nah am Bar (auch bei 0, wie in SimbaIndi)
                    string askText = askVol.ToString("N0", CultureInfo.InvariantCulture);
                    using (var askLayout = new TextLayout(Core.Globals.DirectWriteFactory, askText, _tfNormal, 1000, 1000))
                    {
                        float askWidth = askLayout.Metrics.Width;
                        float askHeight = askLayout.Metrics.Height;
                        float xAsk = xCenter + dx; // Rechts vom Bar, nah am Bar
                        float yAsk = y - askHeight / 2f;
                        RenderTarget.DrawTextLayout(new Vector2(xAsk, yAsk), askLayout, _dxGrayBrush);
                    }

                    // Nur HVNs rendern (über Benchmark)
                    if (volume > BenchmarkVolume)
                    {
                        // Prüfe ob Multi-HVN (Signal)
                        bool isSignal = IsMultiHVNSignal(level, biAbs);

                        // Hauptvolumen (berechnet) anzeigen - weiter rechts mit Offset
                        string volumeText = volume.ToString("N0", CultureInfo.InvariantCulture);
                        float xText = xCenter + dx + HVNTextOffset; // Weiter rechts mit Offset
                        
                        // Text rendern
                        using (var textLayout = new TextLayout(Core.Globals.DirectWriteFactory, volumeText, _tfNormal, 1000, 1000))
                        {
                            float textWidth = textLayout.Metrics.Width;
                            float textHeight = textLayout.Metrics.Height;
                            float yText = y - textHeight / 2f;
                            RenderTarget.DrawTextLayout(new Vector2(xText, yText), textLayout, _dxWhiteBrush);

                            // Rechteck-Koordinaten für Multi-HVN sammeln
                            if (isSignal)
                            {
                                if (!rectCoordsByBar.TryGetValue(biAbs, out var coords))
                                {
                                    coords = new List<(float top, float bottom)>();
                                    rectCoordsByBar[biAbs] = coords;
                                }
                                coords.Add((y - textHeight / 2f, y + textHeight / 2f));
                            }
                        }
                    }
                }
            }

            // Rechtecke um Multi-HVN-Sequenzen zeichnen
            if (ShowCircleOnSignal)
            {
                foreach (var kvp in _multiHVNSequences)
                {
                    int level = kvp.Key;
                    List<int> barIndices = kvp.Value;
                    if (barIndices.Count < MinConsecutiveHVNs) continue;

                    // Finde alle sichtbaren Bars dieser Sequenz mit ihren X-Positionen
                    List<(int barIndex, float x, float y)> visibleBars = new List<(int, float, float)>();
                    float maxTextWidth = 0f;
                    float maxTextHeight = 0f;
                    
                    foreach (int barIdx in barIndices)
                    {
                        if (barIdx < firstBar || barIdx > lastBar) continue;
                        int barsAgo = dataLast - barIdx;
                        if (barsAgo < 0 || barsAgo >= _count) continue;

                        // Volumendaten für diese Bar holen
                        var (askLevels, bidLevels) = GetLevelsForBar(barsAgo);
                        if (askLevels == null || bidLevels == null) continue;

                        askLevels.TryGetValue(level, out long askVol);
                        bidLevels.TryGetValue(level, out long bidVol);

                        long volume = 0;
                        switch (VolumeCalcMode)
                        {
                            case VolumeCalculationMode.Total:
                                volume = askVol + bidVol;
                                break;
                            case VolumeCalculationMode.AskOnly:
                                volume = askVol;
                                break;
                            case VolumeCalculationMode.BidOnly:
                                volume = bidVol;
                                break;
                            case VolumeCalculationMode.Delta:
                                volume = askVol - bidVol;
                                break;
                        }

                        double price = PriceFromLevel(level);
                        float y = chartScale.GetYByValue(price);
                        float xCenter = chartControl.GetXByBarIndex(ChartBars, barIdx);
                        float dx = HorizontalPx;
                        float xText = xCenter + dx + HVNTextOffset;

                        // Textbreite und -höhe berechnen
                        string volumeText = volume.ToString("N0", CultureInfo.InvariantCulture);
                        using (var textLayout = new TextLayout(Core.Globals.DirectWriteFactory, volumeText, _tfNormal, 1000, 1000))
                        {
                            float textWidth = textLayout.Metrics.Width;
                            float textHeight = textLayout.Metrics.Height;
                            if (textWidth > maxTextWidth) maxTextWidth = textWidth;
                            if (textHeight > maxTextHeight) maxTextHeight = textHeight;
                        }

                        visibleBars.Add((barIdx, xText, y));
                    }

                    if (visibleBars.Count == 0) continue;

                    // Alle HVNs einer Multi-HVN-Sequenz sind auf demselben Preislevel
                    // Berechne vertikale Grenzen (um die Text-Höhe herum)
                    float yCenter = visibleBars[0].y; // Alle haben die gleiche Y-Position
                    float yTop = yCenter - maxTextHeight / 2f - 4f; // Padding oben
                    float yBottom = yCenter + maxTextHeight / 2f + 4f; // Padding unten

                    // Berechne horizontale Grenzen (über alle Bars der Sequenz)
                    float xLeft = visibleBars.Min(b => b.x) - 5f; // Links mit Padding
                    float xRight = visibleBars.Max(b => b.x) + maxTextWidth + 5f; // Rechts mit Padding

                    // Zeichne ein Rechteck um alle HVNs der Sequenz
                    var rect = new RectangleF(xLeft, yTop, xRight - xLeft, yBottom - yTop);
                    RenderTarget.DrawRectangle(rect, _dxCircleBrush, 1.0f);
                }
            }
        }
        #endregion

        #region Cleanup
        public override void OnRenderTargetChanged()
        {
            DisposeDxResources();
            base.OnRenderTargetChanged();
        }

        private void DisposeDxResources()
        {
            _tfNormal?.Dispose();
            _tfNormal = null;
            _tfBold?.Dispose();
            _tfBold = null;
            _dxWhiteBrush?.Dispose();
            _dxWhiteBrush = null;
            _dxCircleBrush?.Dispose();
            _dxCircleBrush = null;
            _dxGrayBrush?.Dispose();
            _dxGrayBrush = null;
            _dxAskBrush?.Dispose();
            _dxAskBrush = null;
            _dxBidBrush?.Dispose();
            _dxBidBrush = null;
        }
        #endregion
    }
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private _MhvnIndi[] cache_MhvnIndi;
		public _MhvnIndi _MhvnIndi(double priceLevelSize, VolumeCalculationMode volumeCalcMode, double benchmarkVolume, int minConsecutiveHVNs, bool showHVNValues, System.Windows.Media.Color hVNTextColor, bool showCircleOnSignal, System.Windows.Media.Color circleColor, int hVNTextOffset, bool showAskBidVolume, System.Windows.Media.Color askVolumeColor, System.Windows.Media.Color bidVolumeColor)
		{
			return _MhvnIndi(Input, priceLevelSize, volumeCalcMode, benchmarkVolume, minConsecutiveHVNs, showHVNValues, hVNTextColor, showCircleOnSignal, circleColor, hVNTextOffset, showAskBidVolume, askVolumeColor, bidVolumeColor);
		}

		public _MhvnIndi _MhvnIndi(ISeries<double> input, double priceLevelSize, VolumeCalculationMode volumeCalcMode, double benchmarkVolume, int minConsecutiveHVNs, bool showHVNValues, System.Windows.Media.Color hVNTextColor, bool showCircleOnSignal, System.Windows.Media.Color circleColor, int hVNTextOffset, bool showAskBidVolume, System.Windows.Media.Color askVolumeColor, System.Windows.Media.Color bidVolumeColor)
		{
			if (cache_MhvnIndi != null)
				for (int idx = 0; idx < cache_MhvnIndi.Length; idx++)
					if (cache_MhvnIndi[idx] != null && cache_MhvnIndi[idx].PriceLevelSize == priceLevelSize && cache_MhvnIndi[idx].VolumeCalcMode == volumeCalcMode && cache_MhvnIndi[idx].BenchmarkVolume == benchmarkVolume && cache_MhvnIndi[idx].MinConsecutiveHVNs == minConsecutiveHVNs && cache_MhvnIndi[idx].ShowHVNValues == showHVNValues && cache_MhvnIndi[idx].HVNTextColor == hVNTextColor && cache_MhvnIndi[idx].ShowCircleOnSignal == showCircleOnSignal && cache_MhvnIndi[idx].CircleColor == circleColor && cache_MhvnIndi[idx].HVNTextOffset == hVNTextOffset && cache_MhvnIndi[idx].ShowAskBidVolume == showAskBidVolume && cache_MhvnIndi[idx].AskVolumeColor == askVolumeColor && cache_MhvnIndi[idx].BidVolumeColor == bidVolumeColor && cache_MhvnIndi[idx].EqualsInput(input))
						return cache_MhvnIndi[idx];
			return CacheIndicator<_MhvnIndi>(new _MhvnIndi(){ PriceLevelSize = priceLevelSize, VolumeCalcMode = volumeCalcMode, BenchmarkVolume = benchmarkVolume, MinConsecutiveHVNs = minConsecutiveHVNs, ShowHVNValues = showHVNValues, HVNTextColor = hVNTextColor, ShowCircleOnSignal = showCircleOnSignal, CircleColor = circleColor, HVNTextOffset = hVNTextOffset, ShowAskBidVolume = showAskBidVolume, AskVolumeColor = askVolumeColor, BidVolumeColor = bidVolumeColor }, input, ref cache_MhvnIndi);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators._MhvnIndi _MhvnIndi(double priceLevelSize, VolumeCalculationMode volumeCalcMode, double benchmarkVolume, int minConsecutiveHVNs, bool showHVNValues, System.Windows.Media.Color hVNTextColor, bool showCircleOnSignal, System.Windows.Media.Color circleColor, int hVNTextOffset, bool showAskBidVolume, System.Windows.Media.Color askVolumeColor, System.Windows.Media.Color bidVolumeColor)
		{
			return indicator._MhvnIndi(Input, priceLevelSize, volumeCalcMode, benchmarkVolume, minConsecutiveHVNs, showHVNValues, hVNTextColor, showCircleOnSignal, circleColor, hVNTextOffset, showAskBidVolume, askVolumeColor, bidVolumeColor);
		}

		public Indicators._MhvnIndi _MhvnIndi(ISeries<double> input , double priceLevelSize, VolumeCalculationMode volumeCalcMode, double benchmarkVolume, int minConsecutiveHVNs, bool showHVNValues, System.Windows.Media.Color hVNTextColor, bool showCircleOnSignal, System.Windows.Media.Color circleColor, int hVNTextOffset, bool showAskBidVolume, System.Windows.Media.Color askVolumeColor, System.Windows.Media.Color bidVolumeColor)
		{
			return indicator._MhvnIndi(input, priceLevelSize, volumeCalcMode, benchmarkVolume, minConsecutiveHVNs, showHVNValues, hVNTextColor, showCircleOnSignal, circleColor, hVNTextOffset, showAskBidVolume, askVolumeColor, bidVolumeColor);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators._MhvnIndi _MhvnIndi(double priceLevelSize, VolumeCalculationMode volumeCalcMode, double benchmarkVolume, int minConsecutiveHVNs, bool showHVNValues, System.Windows.Media.Color hVNTextColor, bool showCircleOnSignal, System.Windows.Media.Color circleColor, int hVNTextOffset, bool showAskBidVolume, System.Windows.Media.Color askVolumeColor, System.Windows.Media.Color bidVolumeColor)
		{
			return indicator._MhvnIndi(Input, priceLevelSize, volumeCalcMode, benchmarkVolume, minConsecutiveHVNs, showHVNValues, hVNTextColor, showCircleOnSignal, circleColor, hVNTextOffset, showAskBidVolume, askVolumeColor, bidVolumeColor);
		}

		public Indicators._MhvnIndi _MhvnIndi(ISeries<double> input , double priceLevelSize, VolumeCalculationMode volumeCalcMode, double benchmarkVolume, int minConsecutiveHVNs, bool showHVNValues, System.Windows.Media.Color hVNTextColor, bool showCircleOnSignal, System.Windows.Media.Color circleColor, int hVNTextOffset, bool showAskBidVolume, System.Windows.Media.Color askVolumeColor, System.Windows.Media.Color bidVolumeColor)
		{
			return indicator._MhvnIndi(input, priceLevelSize, volumeCalcMode, benchmarkVolume, minConsecutiveHVNs, showHVNValues, hVNTextColor, showCircleOnSignal, circleColor, hVNTextOffset, showAskBidVolume, askVolumeColor, bidVolumeColor);
		}
	}
}

#endregion
