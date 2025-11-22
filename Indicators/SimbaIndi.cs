/* MIT License
Copyright (c) 2025 Quantrosoft Pty. Ltd.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/|| sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies || substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/

#region Usings
using NinjaTrader;
using NinjaTrader.Core;
using NinjaTrader.Data;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.NinjaScript;
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.Strategies;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using static NinjaTrader.NinjaScript.Indicators.SimbaIndi;
#endregion

namespace NinjaTrader.NinjaScript.Indicators
{
	public enum CompareOp
	{
		Equal,
		NotEqual,
		GreaterThan,
		GreaterOrEqual,
		LessThan,
		LessOrEqual,
		IsNull,
		NotNull,
		IsNullOrEmpty,
		NotNullOrEmpty,
	}

    #region CategoryOrder
    [CategoryOrder("Delta Volume", 1)]
    [CategoryOrder("Delta Change", 2)]
    [CategoryOrder("Stacked Imbalance", 3)]
    [CategoryOrder("Stacked Absorption", 4)]
    [CategoryOrder("Big Trade", 5)]
    [CategoryOrder("Management", 6)]
    #endregion

    [TypeConverter("NinjaTrader.NinjaScript.Indicators.ConditionalVisibilityConverter")]
    public class SimbaIndi : Indicator
    {

        #region Parameters

        #region Delta Volume
        // --- Delta Volume ---
        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All), Display(Name = sIsDeltaVolume,
            GroupName = "Delta Volume", Description = dIsDeltaVolume, Order = 90)]
        public bool IsDeltaVolume { get; set; } = true;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaVolume), CompareOp.Equal, true),
        Display(Name = sDeltaVolume1,
            GroupName = "Delta Volume", Description = dDeltaVolume1, Order = 100)]
        public double DeltaVolume1 { get; set; } = 0;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaVolume), CompareOp.Equal, true),
        Display(Name = sDeltaVolume2,
            GroupName = "Delta Volume", Description = dDeltaVolume2, Order = 101)]
        public double DeltaVolume2 { get; set; } = 100;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaVolume), CompareOp.Equal, true),
        Display(Name = sDeltaVolume3,
            GroupName = "Delta Volume", Description = dDeltaVolume3, Order = 102)]
        public double DeltaVolume3 { get; set; } = 100;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaVolume), CompareOp.Equal, true),
        Display(Name = sDeltaVolume4,
            GroupName = "Delta Volume", Description = dDeltaVolume4, Order = 103)]
        public double DeltaVolume4 { get; set; } = 100;
        #endregion

        #region Delta Change
        // --- Delta Change ---
        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All), Display(Name = sIsDeltaChange, GroupName = "Delta Change", Description = dIsDeltaChange, Order = 90)]
        public bool IsDeltaChange { get; set; } = true;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaChange), CompareOp.Equal, true),
        Display(Name = sDeltaChange1, GroupName = "Delta Change", Description = dDeltaChange1, Order = 100)]
        public double DeltaChange1 { get; set; } = 0;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaChange), CompareOp.Equal, true),
        Display(Name = sDeltaChange2, GroupName = "Delta Change", Description = dDeltaChange2, Order = 101)]
        public double DeltaChange2 { get; set; } = 100;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaChange), CompareOp.Equal, true),
        Display(Name = sDeltaChange3, GroupName = "Delta Change", Description = dDeltaChange3, Order = 102)]
        public double DeltaChange3 { get; set; } = 100;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(IsDeltaChange), CompareOp.Equal, true),
        Display(Name = sDeltaChange4, GroupName = "Delta Change", Description = dDeltaChange4, Order = 103)]
        public double DeltaChange4 { get; set; } = 100;
        #endregion

        #region Stacked Imbalance
        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        Range(0, double.MaxValue),
        Display(Name = sPriceLevelSize,
            GroupName = "Stacked Imbalance", Description = dPriceLevelSize, Order = 1)]
        public double ImbaPriceLevelSize { get; set; } = 1;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Display(Name = sImbaAbsoCalcMode,
            GroupName = "Stacked Imbalance", Description = dImbaAbsoCalcMode, Order = 2)]
        public ImbaAbsoCalcModes ImbaCalcMode { get; set; } = ImbaAbsoCalcModes.Diagonal;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sImbaThreshold,
            GroupName = "Stacked Imbalance", Description = dImbaThreshold, Order = 3)]
        public double ImbaThreshold { get; set; } = 300;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sSimbaBidMin,
            GroupName = "Stacked Imbalance", Description = dSimbaBidMin, Order = 4)]
        public double ImbaBidMin { get; set; } = 1;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sImbaBidMax,
            GroupName = "Stacked Imbalance", Description = dImbaBidMax, Order = 5)]
        public double ImbaBidMax { get; set; } = 1000;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sImbaAskMin,
            GroupName = "Stacked Imbalance", Description = dImbaAskMin, Order = 6)]
        public double ImbaAskMin { get; set; } = 1;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sImbaAskMax,
            GroupName = "Stacked Imbalance", Description = dImbaAskMax, Order = 7)]
        public double ImbaAskMax { get; set; } = 1000;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, int.MaxValue),
        Display(Name = sImbaAbsoStackCount,
            GroupName = "Stacked Imbalance", Description = dImbaAbsoStackCount, Order = 8)]
        public int ImbaStackCount { get; set; } = 2;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, 100),
        Display(Name = sImbaAbsoLocation,
            GroupName = "Stacked Imbalance", Description = dImbaAbsoLocation, Order = 9)]
        public double ImbaLocation { get; set; } = 25;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(ImbaPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, int.MaxValue),
        Display(Name = sImbaAbsoMinVolumeSum,
            GroupName = "Stacked Imbalance", Description = dImbaAbsoMinVolumeSum, Order = 10)]
        public int ImbaMinVolumeSum { get; set; }
        #endregion

        #region Stacked Absorption
        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        Range(0, double.MaxValue),
        Display(Name = sPriceLevelSize,
            GroupName = "Stacked Absorption", Description = dPriceLevelSize, Order = 1)]
        public double AbsoPriceLevelSize { get; set; } = 1;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Display(Name = sImbaAbsoCalcMode,
            GroupName = "Stacked Absorption", Description = dImbaAbsoCalcMode, Order = 2)]
        public ImbaAbsoCalcModes AbsoCalcMode { get; set; } = ImbaAbsoCalcModes.Diagonal;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sAbsoThreshold,
            GroupName = "Stacked Absorption", Description = dAbsoThreshold, Order = 3)]
        public double AbsoThreshold { get; set; } = 100;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sAbsoBidMin,
            GroupName = "Stacked Absorption", Description = dAbsoBidMin, Order = 4)]
        public double AbsoBidMin { get; set; } = 1;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sAbsoBidMax,
            GroupName = "Stacked Absorption", Description = dAbsoBidMax, Order = 5)]
        public double AbsoBidMax { get; set; } = 1000;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sAbsoAskMin,
            GroupName = "Stacked Absorption", Description = dAbsoAskMin, Order = 6)]
        public double AbsoAskMin { get; set; } = 1;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, double.MaxValue),
        Display(Name = sAbsoAskMax,
            GroupName = "Stacked Absorption", Description = dAbsoAskMax, Order = 7)]
        public double AbsoAskMax { get; set; } = 1000;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, int.MaxValue),
        Display(Name = sImbaAbsoStackCount,
            GroupName = "Stacked Absorption", Description = dAbsoStackCount, Order = 8)]
        public int AbsoStackCount { get; set; } = 2;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, 100),
        Display(Name = sImbaAbsoLocation,
            GroupName = "Stacked Absorption", Description = dAbsoLocation, Order = 9)]
        public double AbsoLocation { get; set; } = 25;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, int.MaxValue),
        Display(Name = sImbaAbsoMinVolumeSum,
            GroupName = "Stacked Absorption", Description = dAbsoMinVolumeSum, Order = 10)]
        public int AbsoMinVolumeSum { get; set; }

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(AbsoPriceLevelSize), CompareOp.NotEqual, 0),
        Range(0, int.MaxValue),
        Display(Name = sAbsoDepth,
            GroupName = "Stacked Absorption", Description = dAbsoDepth, Order = 11)]
        public int AbsoDepth { get; set; } = 5;
        #endregion

        #region Big Trade
        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All), 
            Range(0, double.MaxValue), Display(Name = sPriceLevelSize,
            GroupName = "Big Trade", Description = dPriceLevelSize, Order = 1)]
        public double BigTradePriceLevelSize { get; set; } = 1;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(BigTradePriceLevelSize), CompareOp.NotEqual, 0),
        Range(0.0, double.MaxValue), Display(Name = sTradeFilterMin,
            GroupName = "Big Trade", Description = dTradeFilterMin, Order = 2)]
        public double TradeFilterMin { get; set; } = 50.0;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(BigTradePriceLevelSize), CompareOp.NotEqual, 0),
        Range(-1.0, double.MaxValue), Display(Name = sTradeFilterMax,
            GroupName = "Big Trade", Description = dTradeFilterMax, Order = 3)]
        public double TradeFilterMax { get; set; } = -1.0;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(BigTradePriceLevelSize), CompareOp.NotEqual, 0),
        Display(Name = sReconstructTape,
            GroupName = "Big Trade", Description = dReconstructTape, Order = 4)]
        public bool ReconstructTape { get; set; } = true;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(BigTradePriceLevelSize), CompareOp.NotEqual, 0),
        ShowIf(nameof(ReconstructTape), CompareOp.Equal, true),
        Display(Name = sReconstructTape_UseTimestampsOnly,
            GroupName = "Big Trade", Description = dReconstructTape_UseTimestampsOnly, Order = 5)]
        public bool ReconstructTape_UseTimestampsOnly { get; set; } = false;

        [NinjaScriptProperty, RefreshProperties(RefreshProperties.All),
        ShowIf(nameof(BigTradePriceLevelSize), CompareOp.NotEqual, 0),
        Display(Name = sBigTradeInvers,
            GroupName = "Big Trade", Description = dBigTradeInvers, Order = 6)]
        public bool BigTradeInvers { get; set; } = false;
        #endregion

        #region Common
        [NinjaScriptProperty, Display(Name = "Direction", GroupName = "Management", Order = 1)]
        public TradeDirections R2sTradeDirection { get; set; } = TradeDirections.None;
        #endregion

        #endregion

        #region Enums, Structs, Constants, Members
        public enum ImbaAbsoCalcModes
        {
            Diagonal,
            Horizontal
        }

        public enum TradeDirections
        {
            None,
            Long,
            Short,
        }

        public struct ImbalanceStackInfo
        {
            public bool IsValid;
            public List<ImbalanceLevel> ValidLevels;
            public double BorderPrice;
            public double CurrentLocationPct;
            public long TotalVolumeSum;

            public static ImbalanceStackInfo Invalid => new ImbalanceStackInfo { IsValid = false };
        }

        public struct ImbalanceLevel
        {
            public int Level;
            public double Price;
            public long AskVolUsed;    // Volume used in ratio calculation
            public long BidVolUsed;    // Volume used in ratio calculation
            public double Ratio;
            public long AskVolRaw;     // Original volume at level (for rendering)
            public long BidVolRaw;     // Original volume at level (for rendering)
        }

        public struct AbsorptionStackInfo
        {
            public bool IsValid;
            public List<AbsorptionLevel> ValidLevels;
            public double BorderPrice;
            public double CurrentLocationPct;
            public long TotalVolumeSum;

            public static AbsorptionStackInfo Invalid => new AbsorptionStackInfo { IsValid = false };
        }

        public struct AbsorptionLevel
        {
            public int Level;
            public double Price;
            public long AskVolUsed;   // volume used in ratio calc (opposite side for long)
            public long BidVolUsed;   // volume used in ratio calc (same side for long)
            public double Ratio;
            public long AskVolRaw;    // raw volumes at level (for rendering/log)
            public long BidVolRaw;
        }

        // Trade class to accumulate ticks (like MZpack Trade.cs)
        private class BigTrade
        {
            public long Id { get; private set; }
            public bool IsBidSide { get; private set; }  // true for Bid, false for Ask
            public DateTime Time { get; private set; }
            public long Volume { get; private set; }
            public double StartPrice { get; private set; }
            public double StopPrice { get; private set; }
            public int StartBarIdx { get; private set; }
            public int StopBarIdx { get; private set; }
            public Dictionary<double, long> TickProfile { get; private set; }  // Price -> Volume mapping
            public List<TickData> Ticks { get; private set; }
            
            private static long _priorId = 0;
            
            public BigTrade(bool isBidSide, DateTime time)
            {
                Id = ++_priorId;
                IsBidSide = isBidSide;
                Time = time;
                Volume = 0;
                TickProfile = new Dictionary<double, long>();
                Ticks = new List<TickData>();
            }
            
            public void AddTick(double price, long volume, int barIdx)
            {
                Ticks.Add(new TickData { Price = price, Volume = volume, BarIdx = barIdx });
                Volume += volume;
                
                if (TickProfile.TryGetValue(price, out var existingVol))
                    TickProfile[price] = existingVol + volume;
                else
                    TickProfile[price] = volume;
                
                if (StartBarIdx == 0)
                    StartBarIdx = barIdx;
                StopBarIdx = barIdx;
                
                if (StartPrice == 0.0)
                    StartPrice = price;
                StopPrice = price;
            }
            
            public double GetPOC()
            {
                if (TickProfile.Count == 0) return 0.0;
                return TickProfile.OrderByDescending(kv => kv.Value).First().Key;
            }
            
            public double GetHi() => TickProfile.Count > 0 ? TickProfile.Keys.Max() : 0.0;
            public double GetLo() => TickProfile.Count > 0 ? TickProfile.Keys.Min() : 0.0;
        }
        
        private struct TickData
        {
            public double Price;
            public long Volume;
            public int BarIdx;
        }

        public struct BigTradeSignal
        {
            public double Price;
            public long Volume;
            public bool IsBidSide;  // true for bid side (red circle), false for ask side (green circle)
            public DateTime Time;
            public int Level;
            public int BarIndex;    // bar index where the signal occurred
        }

        // Callbacks/Delegates for Big Trade signal notifications
        public delegate void BigTradeSignalCallback(BigTradeSignal signal);

        // Instance callbacks (per-indicator)
        [XmlIgnore, Browsable(false)]
        public BigTradeSignalCallback InstanceBigTradeCallback { get; set; }

        public override string DisplayName => "_Stacked ImbaAbso";

        internal const string sIsDeltaVolume = "Delta Volume";
        internal const string dIsDeltaVolume = "Delta Volume Signal an/aus";
        internal const string sDeltaVolume1 = "1. Min delta volume";
        internal const string dDeltaVolume1 = "Delta Volumen Wert für die erste (jüngste) Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";
        internal const string sDeltaVolume2 = "2. Min delta volume";
        internal const string dDeltaVolume2 = "Delta Volumen Wert für die zweite Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";
        internal const string sDeltaVolume3 = "3. Min delta volume";
        internal const string dDeltaVolume3 = "Delta Volume Wert für die dritte Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";
        internal const string sDeltaVolume4 = "4. Min delta volume";
        internal const string dDeltaVolume4 = "Delta Volume Wert für die vierte (älteste) Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";
        internal const string sIsSameColor = "Same Color";
        internal const string dIsSameColor = "Die betreffenden Bars müssen je nach Trade-Richting dieselbe Farbe haben. Alle Grün bei Long, alle Rot bei Short";

        internal const string sIsDeltaChange = "Delta Change";
        internal const string dIsDeltaChange = "Delta Change Signal an/aus";
        internal const string sDeltaChange1 = "1. Min delta change";
        internal const string dDeltaChange1 = "Delta Change Wert für die erste (jüngste) Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";
        internal const string sDeltaChange2 = "2. Min delta change";
        internal const string dDeltaChange2 = "Delta Change Wert für die zweite Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";
        internal const string sDeltaChange3 = "3. Min delta change";
        internal const string dDeltaChange3 = "Delta Change Wert für die dritte Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";
        internal const string sDeltaChange4 = "4. Min delta change";
        internal const string dDeltaChange4 = "Delta Change Wert für die vierte (älteste) Bar. 0 bedeutet \"nicht berücksichtigen\".\nz.B. 100 bedeutet alles ab 100 aufwärts\nz.B. -100 bedeutet alles unter -100 abwärts";

        internal const string sImbaAbsoCalcMode = "Calculation Mode";
        internal const string dImbaAbsoCalcMode = "Diagonal: Ask vom Preislevel, Bid von einem Preislevel darunter\nHorizontal vom selben Preislevel";
        internal const string sPriceLevelSize = "Price Level Size";
        internal const string dPriceLevelSize = "Wieviele Preislevels werden zusammengefasst für 1 Imbalance (Angabe in Preis)\nBei der Eingabe von 0,5 würden im NQ 2 Preislevels zusammengefasst, da 1 Tick 0,25 im Preis sind";
        internal const string sImbaThreshold = "Threshold in %";
        internal const string dImbaThreshold = "Schwellenwert in % (Imbalance-Ratio)";
        internal const string sSimbaBidMin = "Minimum Bid Volume";
        internal const string dSimbaBidMin = "Minimales Bid Volumen um ein Signal zu generieren";
        internal const string sImbaBidMax = "Maximum Bid Volume";
        internal const string dImbaBidMax = "Maximales Bid Volumen um ein Signal zu generieren";
        internal const string sImbaAskMin = "Minimum Ask Volume";
        internal const string dImbaAskMin = "Minimales Ask Volumen um ein Signal zu generieren";
        internal const string sImbaAskMax = "Maximum Ask Volume";
        internal const string dImbaAskMax = "Maximales Ask Volumen um ein Signal zu generieren";
        internal const string sImbaAbsoStackCount = "Minimum Stack Count";
        internal const string dImbaAbsoStackCount = "Stacked Imbalance (Anzahl der zusammenhängenden Imbalancen)";
        internal const string sImbaAbsoLocation = "Location in %";
        internal const string dImbaAbsoLocation = "%-Grenzwert innerhalb der Kerze für die signalgebende Imbalance\nLong: Grenzwert oder darunter, Short: Grenzwert oder darüber";
        internal const string sImbaAbsoMinVolumeSum = "Minimum Stack Volume";
        internal const string dImbaAbsoMinVolumeSum = "Minimum Summe der Stacked Imbalances um ein Signal auszulösen";

        internal const string sAbsoThreshold = "Threshold in %";
        internal const string dAbsoThreshold = "Schwellenwert in % (Absorption-Ratio)";
        internal const string sAbsoBidMin = "Minimum Bid Volume";
        internal const string dAbsoBidMin = "Minimales Bid Volumen um ein Signal zu generieren";
        internal const string sAbsoBidMax = "Maximum Bid Volume";
        internal const string dAbsoBidMax = "Maximales Bid Volumen um ein Signal zu generieren";
        internal const string sAbsoAskMin = "Minimum Ask Volume";
        internal const string dAbsoAskMin = "Minimales Ask Volumen um ein Signal zu generieren";
        internal const string sAbsoAskMax = "Maximum Ask Volume";
        internal const string dAbsoAskMax = "Maximales Ask Volumen um ein Signal zu generieren";
        internal const string dAbsoStackCount = "Stacked Absolance (Anzahl der zusammenhängenden Absolancen)";
        internal const string dAbsoLocation = "%-Grenzwert innerhalb der Kerze für die signalgebende Absolance\nLong: Grenzwert oder darunter, Short: Grenzwert oder darüber";
        internal const string dAbsoMinVolumeSum = "Minimum Summe der Stacked Absolances um ein Signal auszulösen";
        internal const string sAbsoDepth = "Minimum Distance to Close";
        internal const string dAbsoDepth = "Level Abstand zum Close in Cash";
        internal const string sTradeFilterMin = "Trade: min volume";
        internal const string dTradeFilterMin = "Minimal trade size";
        internal const string sTradeFilterMax = "Trade: max volume";
        internal const string dTradeFilterMax = "Maximal trade size (-1 for unlimited)";
        internal const string sReconstructTape = "Reconstruct tape: enable";
        internal const string dReconstructTape = "Aktiviert die Rekonstruktion von Trades (mehrere Ticks werden zu einem Trade zusammengefasst)";
        internal const string sReconstructTape_UseTimestampsOnly = "Reconstruct tape: timestamps only";
        internal const string dReconstructTape_UseTimestampsOnly = "Wenn aktiviert, wird nur der Zeitstempel für die Trade-Beendigung verwendet. Best Bid/Ask Events werden ignoriert. Ermöglicht exakte Übereinstimmung zwischen historischen und Live-Daten.";
        internal const string sBigTradeInvers = "Invers";
        internal const string dBigTradeInvers = "Kehrt die Trade-Richtung um: Aus Long wird Short und umgekehrt";

        [XmlIgnore, Browsable(false)]
        public bool IsNewBar { get; private set; } = false;

        // Colors
        private static readonly Color4 C_White = new Color4(1f, 1f, 1f, 1f);
        private static readonly Color4 C_Gray = new Color4(0.45f, 0.45f, 0.45f, 1f);
        private static readonly Color4 C_Cyan = new Color4(0f, 1f, 1f, 1f);      // ask imbalance
        private static readonly Color4 C_Violet = new Color4(0.56f, 0.0f, 1f, 1f); // bid imbalance
        private static readonly Color4 C_Gold = new Color4(1f, 0.84f, 0f, 1f);   // short absorption
        private static readonly Color4 C_Orange = new Color4(1f, 0.65f, 0f, 1f);  // long absorption
        private static readonly Color4 C_Green = new Color4(0f, 1f, 0f, 1f);
        private static readonly Color4 C_Red = new Color4(1f, 0f, 0f, 1f);
        private static readonly Color4 C_LightGray = new Color4(0.85f, 0.85f, 0.85f, 1f);

        private static readonly Color4 C_AbsoLong = new Color4(1f, 0.65f, 0f, 1f);   // absorption long
        private static readonly Color4 C_AbsoShort = new Color4(1f, 0.2f, 0.8f, 1f); // absorption short
        private static readonly Color4 C_Overlap = new Color4(1f, 1f, 0f, 1f);       // both at same level
        // Absorption colors - now using same colors as imbalance for consistency
        // Long uses Cyan (same as imbalance), Short uses Violet (same as imbalance)
        private static readonly Color4 C_Pink = new Color4(1.0f, 0.41f, 0.71f, 1f);     // overlap: imbalance + absorption

        // Constants
        private const int WarmMaxBars = 20;
        private const int HorizontalPx = 10;
        private const int BufCap = 512; // Must be power of 2 for bitwise ring buffer operations
        private const float RectanglePadding = 1.0f;
        private const float DeltaTextGap = 2.0f;
        private const float AutoFontMin = 6f;
        private const float AutoFontMax = 22f;

        // Compile-time validation that BufCap is power of 2
        static SimbaIndi()
        {
            if ((BufCap & BufCap - 1) != 0)
                throw new InvalidOperationException("BufCap must be a power of 2 for ring buffer operations");
        }

        private TextFormat _tfNormal;
        private TextFormat _tfBold;
        private SolidColorBrush _dxWhiteBrush, _dxGrayBrush, _dxCyanBrush, _dxVioletBrush, _dxGoldBrush, _dxOrangeBrush, _dxGreenBrush, _dxRedBrush;
        private SolidColorBrush _dxLightGrayBrush;

        private SolidColorBrush _dxAbsoLongBrush, _dxAbsoShortBrush, _dxOverlapBrush;

        private SolidColorBrush _dxPinkBrush;
        private StrokeStyle _dotStroke;

        // --- Per-bar ring buffers (high performance, no summation loops needed) ---
        private int _head = -1;           // index of current bar in ring
        private int _count = 0;           // #bars stored (<= BufCap)
        private int _curBarIndex = -1;    // Bars.GetBar(e.Time) for the current bar

        // Shared volume accumulation (for backward compatibility when both use same price level size)
        private readonly Dictionary<int, long>[] _askLevelsBuf = new Dictionary<int, long>[BufCap];
        private readonly Dictionary<int, long>[] _bidLevelsBuf = new Dictionary<int, long>[BufCap];

        private readonly int[] _askMinBuf = new int[BufCap];
        private readonly int[] _askMaxBuf = new int[BufCap];
        private readonly int[] _bidMinBuf = new int[BufCap];
        private readonly int[] _bidMaxBuf = new int[BufCap];

        private readonly long[] _askSumBuf = new long[BufCap];
        private readonly long[] _bidSumBuf = new long[BufCap];

        // Separate volume accumulation for imbalance (when different from absorption)
        private readonly Dictionary<int, long>[] _askLevelsImbaBuf = new Dictionary<int, long>[BufCap];
        private readonly Dictionary<int, long>[] _bidLevelsImbaBuf = new Dictionary<int, long>[BufCap];

        private readonly int[] _askMinImbaBuf = new int[BufCap];
        private readonly int[] _askMaxImbaBuf = new int[BufCap];
        private readonly int[] _bidMinImbaBuf = new int[BufCap];
        private readonly int[] _bidMaxImbaBuf = new int[BufCap];

        private readonly long[] _askSumImbaBuf = new long[BufCap];
        private readonly long[] _bidSumImbaBuf = new long[BufCap];

        // Separate volume accumulation for absorption (when different from imbalance)
        private readonly Dictionary<int, long>[] _askLevelsAbsoBuf = new Dictionary<int, long>[BufCap];
        private readonly Dictionary<int, long>[] _bidLevelsAbsoBuf = new Dictionary<int, long>[BufCap];

        private readonly int[] _askMinAbsoBuf = new int[BufCap];
        private readonly int[] _askMaxAbsoBuf = new int[BufCap];
        private readonly int[] _bidMinAbsoBuf = new int[BufCap];
        private readonly int[] _bidMaxAbsoBuf = new int[BufCap];

        private readonly long[] _askSumAbsoBuf = new long[BufCap];
        private readonly long[] _bidSumAbsoBuf = new long[BufCap];

        // Big Trade volume accumulation (completely independent)
        private readonly Dictionary<int, long>[] _askLevelsBigTradeBuf = new Dictionary<int, long>[BufCap];
        private readonly Dictionary<int, long>[] _bidLevelsBigTradeBuf = new Dictionary<int, long>[BufCap];

        private readonly int[] _askMinBigTradeBuf = new int[BufCap];
        private readonly int[] _askMaxBigTradeBuf = new int[BufCap];
        private readonly int[] _bidMinBigTradeBuf = new int[BufCap];
        private readonly int[] _bidMaxBigTradeBuf = new int[BufCap];

        private readonly long[] _askSumBigTradeBuf = new long[BufCap];
        private readonly long[] _bidSumBigTradeBuf = new long[BufCap];

        // Big Trade signal tracking
        private readonly List<BigTradeSignal> _bigTradeSignals = new List<BigTradeSignal>();
        private readonly HashSet<int> _bigTradeSignalsGenerated = new HashSet<int>(); // Track bars that have already generated signals
        
        // MZpack-style Big Trade accumulation
        private BigTrade _currentSingleTrade = null;      // Current single trade (one tick)
        private BigTrade _reconstructedTrade = null;      // Reconstructed trade (accumulated single trades)
        private bool _lastTradeSideWasBid = false;        // Track last trade side for SideChanged detection
        private bool _hasBestBidAskEvent = false;        // Track if Best Bid/Ask event occurred (PKqtCt73Dp equivalent)
        private double _bestBid = 0.0;
        private double _bestAsk = 0.0;
        private long _bestBidVolume = 0;
        private long _bestAskVolume = 0;
        
        // Helper method to get effective trade direction (considering BigTradeInvers)
        private TradeDirections GetEffectiveTradeDirection()
        {
            if (R2sTradeDirection == TradeDirections.None)
                return TradeDirections.None;
            
            if (BigTradeInvers)
            {
                // Invert direction: Long -> Short, Short -> Long
                return R2sTradeDirection == TradeDirections.Long ? TradeDirections.Short : TradeDirections.Long;
            }
            
            return R2sTradeDirection;
        }

        // Current-bar working refs to avoid lookups
        private Dictionary<int, long> _askCur, _bidCur;
        private int _askMinKey, _askMaxKey, _bidMinKey, _bidMaxKey;
        private long _askSumCur, _bidSumCur;

        // Separate current-bar working refs for imbalance and absorption
        private Dictionary<int, long> _askCurImba, _bidCurImba;
        private int _askMinKeyImba, _askMaxKeyImba, _bidMinKeyImba, _bidMaxKeyImba;
        private long _askSumCurImba, _bidSumCurImba;

        private Dictionary<int, long> _askCurAbso, _bidCurAbso;
        private int _askMinKeyAbso, _askMaxKeyAbso, _bidMinKeyAbso, _bidMaxKeyAbso;
        private long _askSumCurAbso, _bidSumCurAbso;

        private Dictionary<int, long> _askCurBigTrade, _bidCurBigTrade;
        private int _askMinKeyBigTrade, _askMaxKeyBigTrade, _bidMinKeyBigTrade, _bidMaxKeyBigTrade;
        private long _askSumCurBigTrade, _bidSumCurBigTrade;

        // Render throttling
        private long _lastRepaintSecond = -1;
        private volatile bool _pendingWarm = true;
        private int _lastFrom = int.MinValue, _lastTo = int.MinValue;

        private double mDigitsSize;

        // Reusable collections for performance
        private readonly List<(int level, float top, float bottom, double price)> _reusableCandidate
            = new List<(int level, float top, float bottom, double price)>();

        #endregion

        #region Ninja plumbing
        protected override void OnStateChange()
        {
            if (State == State.SetDefaults)
            {
                IsOverlay = true;
                Calculate = Calculate.OnEachTick;
                Name = DisplayName;
            }

            if (State == State.Configure)
            {
                //Debugger.Launch();
                
                // Parameter validation: If Big Trades are enabled (price level size != 0), minimum volume may not be 0
                // Big Trades is disabled if price level size == 0 OR minimum volume == 0
                if (BigTradePriceLevelSize != 0 && TradeFilterMin <= 0)
                {
                    throw new Exception("TradeFilterMin must be > 0 when Big Trades are enabled (BigTradePriceLevelSize != 0)");
                }
                if (BigTradePriceLevelSize != 0 && TradeFilterMax != -1.0 && TradeFilterMax < TradeFilterMin)
                {
                    throw new Exception("TradeFilterMax must be >= TradeFilterMin or -1 (unlimited)");
                }
            }

            if (State == State.DataLoaded)
            {
                // Calc Digits also for not 0.xxx1 instruments like NQ with 0.25 tick size
                var tickSize = Instrument.MasterInstrument.TickSize;
                var digits = 0;
                while (Math.Abs((int)tickSize - tickSize) > double.Epsilon)
                {
                    tickSize *= 10;
                    digits++;
                }
                mDigitsSize = 1.0 / Math.Pow(10, digits);
            }
        }

        protected override void OnBarUpdate()
        {
            if (CurrentBar < 0)
                return;

            // Warm initial paint once the chart has a valid visible range
            if (_pendingWarm && ChartBars != null)
            {
                var (wf, wt) = GetClampedVisibleRange();
                if (wf <= wt)
                {
                    _pendingWarm = false;
                    SafeInvalidateVisual();
                }
            }
        }

        protected override void OnMarketData(MarketDataEventArgs e)
        {
            if (Bars == null || CurrentBar < 0) return;
            
            // Handle Best Bid/Ask updates (like MZpack OnQuote)
            if (e.MarketDataType == MarketDataType.Bid || e.MarketDataType == MarketDataType.Ask)
            {
                ProcessBigTradeQuote(e);
                return;
            }
            
            if (e.MarketDataType != MarketDataType.Last) return;  // Tick Replay: only Last

            // ----- bar switch / ring buffer advance -----
            int bi = Bars.GetBar(e.Time);
            if (IsNewBar = _curBarIndex != bi)
            {
                // Finish Reconstructed Trade on bar switch (if it exists)
                if (_reconstructedTrade != null)
                {
                    FinishReconstructedTrade();
                }
                
                _head = (_head + 1) % BufCap;
                if (_count < BufCap) _count++;

                // Initialize shared buffers (for backward compatibility)
                _askCur = new Dictionary<int, long>(64);
                _bidCur = new Dictionary<int, long>(64);

                _askMinKey = int.MaxValue; _askMaxKey = int.MinValue;
                _bidMinKey = int.MaxValue; _bidMaxKey = int.MinValue;
                _askSumCur = 0; _bidSumCur = 0;

                _askLevelsBuf[_head] = _askCur; _bidLevelsBuf[_head] = _bidCur;
                _askMinBuf[_head] = _askMinKey; _askMaxBuf[_head] = _askMaxKey;
                _bidMinBuf[_head] = _bidMinKey; _bidMaxBuf[_head] = _bidMaxKey;
                _askSumBuf[_head] = _askSumCur; _bidSumBuf[_head] = _bidSumCur;

                // Initialize separate imbalance buffers
                _askCurImba = new Dictionary<int, long>(64);
                _bidCurImba = new Dictionary<int, long>(64);

                _askMinKeyImba = int.MaxValue; _askMaxKeyImba = int.MinValue;
                _bidMinKeyImba = int.MaxValue; _bidMaxKeyImba = int.MinValue;
                _askSumCurImba = 0; _bidSumCurImba = 0;

                _askLevelsImbaBuf[_head] = _askCurImba; _bidLevelsImbaBuf[_head] = _bidCurImba;
                _askMinImbaBuf[_head] = _askMinKeyImba; _askMaxImbaBuf[_head] = _askMaxKeyImba;
                _bidMinImbaBuf[_head] = _bidMinKeyImba; _bidMaxImbaBuf[_head] = _bidMaxKeyImba;
                _askSumImbaBuf[_head] = _askSumCurImba; _bidSumImbaBuf[_head] = _bidSumCurImba;

                // Initialize separate absorption buffers
                _askCurAbso = new Dictionary<int, long>(64);
                _bidCurAbso = new Dictionary<int, long>(64);

                _askMinKeyAbso = int.MaxValue; _askMaxKeyAbso = int.MinValue;
                _bidMinKeyAbso = int.MaxValue; _bidMaxKeyAbso = int.MinValue;
                _askSumCurAbso = 0; _bidSumCurAbso = 0;

                _askLevelsAbsoBuf[_head] = _askCurAbso; _bidLevelsAbsoBuf[_head] = _bidCurAbso;
                _askMinAbsoBuf[_head] = _askMinKeyAbso; _askMaxAbsoBuf[_head] = _askMaxKeyAbso;
                _bidMinAbsoBuf[_head] = _bidMinKeyAbso; _bidMaxAbsoBuf[_head] = _bidMaxKeyAbso;
                _askSumAbsoBuf[_head] = _askSumCurAbso; _bidSumAbsoBuf[_head] = _bidSumCurAbso;

                // Initialize Big Trade buffers (completely independent)
                _askCurBigTrade = new Dictionary<int, long>(64);
                _bidCurBigTrade = new Dictionary<int, long>(64);

                _askMinKeyBigTrade = int.MaxValue; _askMaxKeyBigTrade = int.MinValue;
                _bidMinKeyBigTrade = int.MaxValue; _bidMaxKeyBigTrade = int.MinValue;
                _askSumCurBigTrade = 0; _bidSumCurBigTrade = 0;

                _askLevelsBigTradeBuf[_head] = _askCurBigTrade; _bidLevelsBigTradeBuf[_head] = _bidCurBigTrade;
                _askMinBigTradeBuf[_head] = _askMinKeyBigTrade; _askMaxBigTradeBuf[_head] = _askMaxKeyBigTrade;
                _bidMinBigTradeBuf[_head] = _bidMinKeyBigTrade; _bidMaxBigTradeBuf[_head] = _bidMaxKeyBigTrade;
                _askSumBigTradeBuf[_head] = _askSumCurBigTrade; _bidSumBigTradeBuf[_head] = _bidSumCurBigTrade;

                _curBarIndex = bi;
            }

            // ---- classify THIS trade using quotes from THIS tick ----
            double bid = e.Bid;   // provided by Tick Replay on Last
            double ask = e.Ask;   // provided by Tick Replay on Last

            // Update Best Bid/Ask for Big Trade logic
            if (bid > 0) _bestBid = bid;
            if (ask > 0) _bestAsk = ask;

            // Require a sane book snapshot
            if (!(ask > bid))
            {
                ThrottledRepaint(e.Time);
                return;
            }

            bool isAskTrade = e.Price >= ask;
            bool isBidTrade = e.Price <= bid;
            if (!isAskTrade && !isBidTrade)
            {
                ThrottledRepaint(e.Time);
                return;
            }
            
            // ===== MZPACK-STYLE BIG TRADE LOGIC =====
            // Process Big Trade accumulation (like MZpack OrderFlowBaseMVC.OnExecution)
            if (BigTradePriceLevelSize != 0 && TradeFilterMin > 0)
            {
                ProcessBigTradeExecution(e, isBidTrade, bi);
            }

            // ---- accumulate into price-level buckets ----
            // ALWAYS accumulate for Delta Volume and Delta Change display (they need _askSumCur and _bidSumCur)
            // Also accumulate if Imbalance, Absorption, or Big Trades are enabled
            // Big Trades needs accumulation if price level size != 0 AND minimum volume != 0
            // Note: Delta Volume/Change accumulation is independent of their enable state - always accumulate for display
            bool shouldAccumulate = true; // Always accumulate for Delta Volume/Change display
            bool needsPriceLevelBuckets = ImbaPriceLevelSize != 0 || AbsoPriceLevelSize != 0 || 
                                         (BigTradePriceLevelSize != 0 && TradeFilterMin > 0);

            if (shouldAccumulate)
            {
            long vol = e.Volume;

                // Determine if we need separate accumulation (different price level sizes)
                bool useSeparateAccumulation = ImbaPriceLevelSize != 0 && AbsoPriceLevelSize != 0 && 
                                               Math.Abs(ImbaPriceLevelSize - AbsoPriceLevelSize) > double.Epsilon;

                if (useSeparateAccumulation)
                {
                    // Accumulate into separate buffers for imbalance and absorption
                    
                    // Imbalance accumulation
                    if (ImbaPriceLevelSize != 0)
                    {
                        int stepImba = iPrice(ImbaPriceLevelSize, mDigitsSize);
                        if (stepImba <= 0) stepImba = 1;
                        int levelImba = iPrice(e.Price, mDigitsSize) / stepImba;

                        if (isAskTrade)
                        {
                            if (_askCurImba.TryGetValue(levelImba, out var va)) _askCurImba[levelImba] = va + vol;
                            else
                            {
                                _askCurImba[levelImba] = vol;
                                if (levelImba < _askMinKeyImba) _askMinKeyImba = levelImba;
                                if (levelImba > _askMaxKeyImba) _askMaxKeyImba = levelImba;
                            }
                            _askSumCurImba += vol;
                        }
                        else // bid trade
                        {
                            if (_bidCurImba.TryGetValue(levelImba, out var vb)) _bidCurImba[levelImba] = vb + vol;
                            else
                            {
                                _bidCurImba[levelImba] = vol;
                                if (levelImba < _bidMinKeyImba) _bidMinKeyImba = levelImba;
                                if (levelImba > _bidMaxKeyImba) _bidMaxKeyImba = levelImba;
                            }
                            _bidSumCurImba += vol;
                        }
                    }

                    // Absorption accumulation
                    if (AbsoPriceLevelSize != 0)
                    {
                        int stepAbso = iPrice(AbsoPriceLevelSize, mDigitsSize);
                        if (stepAbso <= 0) stepAbso = 1;
                        int levelAbso = iPrice(e.Price, mDigitsSize) / stepAbso;

                        if (isAskTrade)
                        {
                            if (_askCurAbso.TryGetValue(levelAbso, out var va)) _askCurAbso[levelAbso] = va + vol;
                            else
                            {
                                _askCurAbso[levelAbso] = vol;
                                if (levelAbso < _askMinKeyAbso) _askMinKeyAbso = levelAbso;
                                if (levelAbso > _askMaxKeyAbso) _askMaxKeyAbso = levelAbso;
                            }
                            _askSumCurAbso += vol;
                        }
                        else // bid trade
                        {
                            if (_bidCurAbso.TryGetValue(levelAbso, out var vb)) _bidCurAbso[levelAbso] = vb + vol;
                            else
                            {
                                _bidCurAbso[levelAbso] = vol;
                                if (levelAbso < _bidMinKeyAbso) _bidMinKeyAbso = levelAbso;
                                if (levelAbso > _bidMaxKeyAbso) _bidMaxKeyAbso = levelAbso;
                            }
                            _bidSumCurAbso += vol;
                        }
                    }
                }
                else
                {
                    // Accumulate for Delta Volume/Change (always need _askSumCur and _bidSumCur for display)
                    // Also accumulate for Imbalance/Absorption if enabled (using shared price level buckets)
                    if (ImbaPriceLevelSize != 0 || AbsoPriceLevelSize != 0)
                    {
                        // Use shared accumulation (same price level size or only one feature enabled)
                        double priceLevelSize = ImbaPriceLevelSize != 0 ? ImbaPriceLevelSize : AbsoPriceLevelSize;
                        int step = iPrice(priceLevelSize, mDigitsSize);
                        if (step <= 0) step = 1;
                        int level = iPrice(e.Price, mDigitsSize) / step;

                        if (isAskTrade)
                        {
                            if (_askCur.TryGetValue(level, out var va)) _askCur[level] = va + vol;
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
                            if (_bidCur.TryGetValue(level, out var vb)) _bidCur[level] = vb + vol;
                            else
                            {
                                _bidCur[level] = vol;
                                if (level < _bidMinKey) _bidMinKey = level;
                                if (level > _bidMaxKey) _bidMaxKey = level;
                            }
                            _bidSumCur += vol;
                        }
                    }
                    else
                    {
                        // Delta Volume/Change: ALWAYS accumulate totals without price-level buckets
                        // This ensures values are always available for display, even when both are disabled
                        if (isAskTrade)
                        {
                            _askSumCur += vol;
                        }
                        else // bid trade
                        {
                            _bidSumCur += vol;
                        }
                    }
                }

                // Big Trade accumulation is now handled by ProcessBigTradeExecution (MZpack-style)
                // Old price-level accumulation removed - we now accumulate Trades, not price levels
            }

            // Big Trade signal generation is now handled in FinishReconstructedTrade
            // ProcessBigTradeSignals is kept for backward compatibility but is now empty

            // keep buffers synced with current bar
            _askLevelsBuf[_head] = _askCur; _bidLevelsBuf[_head] = _bidCur;
            _askMinBuf[_head] = _askMinKey; _askMaxBuf[_head] = _askMaxKey;
            _bidMinBuf[_head] = _bidMinKey; _bidMaxBuf[_head] = _bidMaxKey;
            _askSumBuf[_head] = _askSumCur; _bidSumBuf[_head] = _bidSumCur;

            // Keep separate buffers synced with current bar
            _askLevelsImbaBuf[_head] = _askCurImba; _bidLevelsImbaBuf[_head] = _bidCurImba;
            _askMinImbaBuf[_head] = _askMinKeyImba; _askMaxImbaBuf[_head] = _askMaxKeyImba;
            _bidMinImbaBuf[_head] = _bidMinKeyImba; _bidMaxImbaBuf[_head] = _bidMaxKeyImba;
            _askSumImbaBuf[_head] = _askSumCurImba; _bidSumImbaBuf[_head] = _bidSumCurImba;

            _askLevelsAbsoBuf[_head] = _askCurAbso; _bidLevelsAbsoBuf[_head] = _bidCurAbso;
            _askMinAbsoBuf[_head] = _askMinKeyAbso; _askMaxAbsoBuf[_head] = _askMaxKeyAbso;
            _bidMinAbsoBuf[_head] = _bidMinKeyAbso; _bidMaxAbsoBuf[_head] = _bidMaxKeyAbso;
            _askSumAbsoBuf[_head] = _askSumCurAbso; _bidSumAbsoBuf[_head] = _bidSumCurAbso;

            // Keep Big Trade buffers synced with current bar
            _askLevelsBigTradeBuf[_head] = _askCurBigTrade; _bidLevelsBigTradeBuf[_head] = _bidCurBigTrade;
            _askMinBigTradeBuf[_head] = _askMinKeyBigTrade; _askMaxBigTradeBuf[_head] = _askMaxKeyBigTrade;
            _bidMinBigTradeBuf[_head] = _bidMinKeyBigTrade; _bidMaxBigTradeBuf[_head] = _bidMaxKeyBigTrade;
            _askSumBigTradeBuf[_head] = _askSumCurBigTrade; _bidSumBigTradeBuf[_head] = _bidSumCurBigTrade;

            // Clean up old Big Trade signals and tracking data to prevent memory leaks
            int currentBarIndex = CurrentBar;
            int maxBarsToKeep = Math.Max(100, _count * 2); // Keep signals for reasonable number of bars
            
            // Remove old signals
            _bigTradeSignals.RemoveAll(signal => currentBarIndex - signal.BarIndex > maxBarsToKeep);
            
            // Remove old tracking data
            _bigTradeSignalsGenerated.RemoveWhere(barIndex => currentBarIndex - barIndex > maxBarsToKeep);

            ThrottledRepaint(e.Time);
        }

        // Handle Best Bid/Ask updates (like MZpack OnQuote)
        private void ProcessBigTradeQuote(MarketDataEventArgs e)
        {
            if (BigTradePriceLevelSize == 0 || TradeFilterMin <= 0 || !ReconstructTape)
                return;
            
            // Update Best Bid/Ask
            if (e.MarketDataType == MarketDataType.Bid)
            {
                _bestBid = e.Price;
                _bestBidVolume = e.Volume;
            }
            else if (e.MarketDataType == MarketDataType.Ask)
            {
                _bestAsk = e.Price;
                _bestAskVolume = e.Volume;
            }
            
            // Set flag that Best Bid/Ask event occurred (like MZpack PKqtCt73Dp = true, line 188)
            // This flag will be checked in ProcessBigTradeExecution
            _hasBestBidAskEvent = true;
            
            // Note: In MZpack, the trade is finished in OnExecution when PKqtCt73Dp is true
            // We handle this in ProcessBigTradeExecution instead
        }
        
        // MZpack-style Big Trade execution processing (like OrderFlowBaseMVC.OnExecution)
        private void ProcessBigTradeExecution(MarketDataEventArgs e, bool isBidTrade, int barIdx)
        {
            // Only process if ReconstructTape is enabled (like MZpack line 219)
            if (!ReconstructTape)
                return;
            
            // If direction is None, disable Big Trades completely (don't accumulate)
            if (GetEffectiveTradeDirection() == TradeDirections.None)
                return;
            
            // Check if Reconstructed Trade should be finished (like MZpack line 195-198)
            if (_reconstructedTrade != null)
            {
                bool sideChanged = _lastTradeSideWasBid != isBidTrade;
                bool timeLater = e.Time > _reconstructedTrade.Time;
                bool bestBidAskEvent = !ReconstructTape_UseTimestampsOnly && _hasBestBidAskEvent;
                
                // Finish Reconstructed Trade if: time later, Best Bid/Ask event (if enabled), or side changed
                // (exactly like MZpack line 197: e.Time > ReconstructedTrade.Time || !ReconstructTape_UseTimestampsOnly && PKqtCt73Dp || SideChanged)
                if (timeLater || bestBidAskEvent || sideChanged)
                {
                    FinishReconstructedTrade();
                }
            }
            
            // Create new Single Trade (like MZpack line 217)
            _currentSingleTrade = new BigTrade(isBidTrade, e.Time);
            _currentSingleTrade.AddTick(e.Price, e.Volume, barIdx);
            
            // Update last trade side for SideChanged detection
            _lastTradeSideWasBid = isBidTrade;
            
            // Create Reconstructed Trade if it doesn't exist (like MZpack line 219-220)
            if (_reconstructedTrade == null)
            {
                _reconstructedTrade = new BigTrade(isBidTrade, e.Time);
            }
            
            // Add Single Trade to Reconstructed Trade (like MZpack line 230)
            // Add all ticks from single trade to reconstructed trade
            foreach (var tick in _currentSingleTrade.Ticks)
            {
                _reconstructedTrade.AddTick(tick.Price, tick.Volume, tick.BarIdx);
            }
            
            // Reset Best Bid/Ask event flag (like MZpack line 248)
            _hasBestBidAskEvent = false;
        }
        
        // Finish Reconstructed Trade and check benchmark (like MZpack FinishReconstructedTrade)
        private void FinishReconstructedTrade()
        {
            if (_reconstructedTrade == null)
                return;
            
            // Get effective trade direction (considering BigTradeInvers)
            TradeDirections effectiveDirection = GetEffectiveTradeDirection();
            
            // If direction is None, disable Big Trades completely
            if (effectiveDirection == TradeDirections.None)
            {
                // Reset accumulator and don't show any trades
                _reconstructedTrade = null;
                _currentSingleTrade = null;
                return;
            }
            
            // Filter by direction: Long = Bid Trades, Short = Ask Trades
            // GetEffectiveTradeDirection() already handles BigTradeInvers inversion
            bool shouldShowTrade = false;
            if (effectiveDirection == TradeDirections.Long)
            {
                // Long: Show Bid Trades (MZpack: Bid Trade → Long Signal)
                shouldShowTrade = _reconstructedTrade.IsBidSide;
            }
            else if (effectiveDirection == TradeDirections.Short)
            {
                // Short: Show Ask Trades (MZpack: Ask Trade → Short Signal)
                shouldShowTrade = !_reconstructedTrade.IsBidSide;
            }
            
            // Only proceed if trade matches direction filter
            if (!shouldShowTrade)
            {
                // Reset accumulator even if not shown
                _reconstructedTrade = null;
                _currentSingleTrade = null;
                return;
            }
            
            // Check benchmark: Volume >= TradeFilterMin and (TradeFilterMax == -1 or Volume <= TradeFilterMax)
            // (like MZpack ValidateTradeFiltersHandler)
            double tradeVolume = (double)_reconstructedTrade.Volume;
            bool volumeInRange = tradeVolume >= TradeFilterMin && (TradeFilterMax < 0 || tradeVolume <= TradeFilterMax);
            if (volumeInRange)
            {
                // Create signal from Reconstructed Trade
                int currentBarIndex = CurrentBar;
                double poc = _reconstructedTrade.GetPOC();
                if (poc == 0.0) poc = _reconstructedTrade.StopPrice; // Fallback to stop price
                
                // Convert price to level for compatibility
                int stepBigTrade = iPrice(BigTradePriceLevelSize, mDigitsSize);
                if (stepBigTrade <= 0) stepBigTrade = 1;
                int level = iPrice(poc, mDigitsSize) / stepBigTrade;
                
                var signal = new BigTradeSignal
                {
                    Price = poc,
                    Volume = _reconstructedTrade.Volume,
                    IsBidSide = _reconstructedTrade.IsBidSide,
                    Time = _reconstructedTrade.Time,
                    Level = level,
                    BarIndex = _reconstructedTrade.StopBarIdx
                };
                
                // Check if signal already exists for this trade (by ID or bar)
                int existingIndex = _bigTradeSignals.FindIndex(s => 
                    s.BarIndex == signal.BarIndex && 
                    Math.Abs(s.Price - signal.Price) < 0.0001 &&
                    s.IsBidSide == signal.IsBidSide);
                
                if (existingIndex < 0)
                {
                    _bigTradeSignals.Add(signal);
                    _bigTradeSignalsGenerated.Add(signal.BarIndex);
                    
                    // Fire callback
                    if (InstanceBigTradeCallback != null)
                    {
                        InstanceBigTradeCallback.Invoke(signal);
                    }
                }
                else
                {
                    // Update existing signal with accumulated volume
                    var updated = _bigTradeSignals[existingIndex];
                    updated.Volume = signal.Volume;
                    updated.Time = signal.Time;
                    updated.Price = signal.Price;
                    _bigTradeSignals[existingIndex] = updated;
                }
            }
            
            // Reset accumulator (like MZpack line 284-285)
            _reconstructedTrade = null;
            _currentSingleTrade = null;
        }
        
        private void ProcessBigTradeSignals(DateTime currentTime)
        {
            // This method is now called after ProcessBigTradeExecution
            // Signals are created in FinishReconstructedTrade, so this can be empty or used for cleanup
            // Keeping for backward compatibility but logic moved to FinishReconstructedTrade
        }

        protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
        {
            if (chartControl == null || chartScale == null || ChartPanel == null || ChartBars == null)
                return;

            // Last available data bar (absolute index). Do not clamp this to the visual right edge.
            int dataLast = Close.Count - 1;
            if (dataLast < 0) return; // nothing to draw yet

            // Enable rendering for imbalance/absorption when their price level size is non-zero
            // (CalcMode is always either Diagonal or Horizontal; disabling is done via price level size = 0)
            bool imbalanceEnabled  = ImbaPriceLevelSize != 0
                                     && R2sTradeDirection != TradeDirections.None;
            bool absorptionEnabled = AbsoPriceLevelSize != 0
                                     && R2sTradeDirection != TradeDirections.None;
            // Big Trades is enabled if price level size != 0 AND minimum volume != 0
            // Use effective trade direction (considering BigTradeInvers)
            bool bigTradeEnabled = BigTradePriceLevelSize != 0 && TradeFilterMin > 0 && GetEffectiveTradeDirection() != TradeDirections.None;

            // Visual range from the chart (can extend beyond data to the right)
            int from = Math.Max(0, ChartBars.FromIndex);
            int to = ChartBars.ToIndex;
            if (from != _lastFrom || to != _lastTo)
            {
                _lastFrom = from; _lastTo = to; _pendingWarm = true;
            }

            var rt = RenderTarget;
            if (rt == null) return;

            EnsureDxResources(rt);

            float size = ComputeAutoFontSize(chartScale);
            UpdateTextFormats(size);

            var oldAA = rt.TextAntialiasMode;
            rt.TextAntialiasMode = TextAntialiasMode.Grayscale;

            try
            {
                // Render imbalances and/or absorption if either is enabled
                // Big Trades render additional labels on top, they no longer suppress the base volume labels
                if (imbalanceEnabled || absorptionEnabled)
                    RenderVolumeLabelsAndImbalances(rt, chartControl, chartScale, from, to, dataLast, imbalanceEnabled, absorptionEnabled);

                // Render Big Trade signals (circle + text) independently
                // We do NOT render a separate full Big Trade volume ladder to avoid clutter:
                // - When Big Trades are the only feature enabled, only the Big Trade levels are labeled.
                // - When Imbalance/Absorption are enabled, their ladder already provides full volume labels.
                if (bigTradeEnabled)
                {
                    RenderBigTradeSignals(rt, chartControl, chartScale, from, to, dataLast);
                }

                // DV/DC block is independent of Imbalance/Absorption mode and is always rendered
                RenderDeltaVolumeText(rt, chartControl, chartScale, from, to, dataLast);
            }
            finally
            {
                rt.TextAntialiasMode = oldAA;
            }
        }

        public override void OnRenderTargetChanged()
        {
            DisposeDxResources();
            base.OnRenderTargetChanged();
        }
        #endregion

        #region Unified Imbalance Validation Core
        // SINGLE SOURCE OF TRUTH - Used by both OnRender and ImbalanceSignal
        private ImbalanceStackInfo ValidateImbalanceStack(int barsAgo)
        {
            if (R2sTradeDirection == TradeDirections.None || ImbaPriceLevelSize == 0)
                return ImbalanceStackInfo.Invalid;

            if (barsAgo < 0 || barsAgo >= _count)
                return ImbalanceStackInfo.Invalid;

            // Use appropriate level getters based on whether separate accumulation is used
            bool useSeparateAccumulation = ImbaPriceLevelSize != 0 && AbsoPriceLevelSize != 0 && 
                                           Math.Abs(ImbaPriceLevelSize - AbsoPriceLevelSize) > double.Epsilon;
            
            var (ask, aMin, aMax) = useSeparateAccumulation ? GetAskLevelsImba(barsAgo) : GetAskLevels(barsAgo);
            var (bid, bMin, bMax) = useSeparateAccumulation ? GetBidLevelsImba(barsAgo) : GetBidLevels(barsAgo);
            if (!HasData(aMin, aMax) && !HasData(bMin, bMax))
                return ImbalanceStackInfo.Invalid;

            if (Close?.Count == 0 || Low?.Count == 0 || High?.Count == 0)
                return ImbalanceStackInfo.Invalid;

            int last = Close.Count - 1;
            int biAbs = last - barsAgo;
            if (biAbs < 0) return ImbalanceStackInfo.Invalid;

            int biClamped = Math.Max(0, Math.Min(biAbs, Close.Count - 1));
            double barClose = Close.GetValueAt(biClamped);
            double barLow = Low.GetValueAt(biClamped);
            double barHigh = High.GetValueAt(biClamped);

            bool isLong = R2sTradeDirection == TradeDirections.Long;
            int K = Math.Max(1, ImbaStackCount);

            // 1) collect all valid individual imbalances (with per-level gates)
            var validImbalances = FindAllValidImbalances(ask, bid, aMin, aMax, bMin, bMax, isLong, barClose, barLow, barHigh);
            if (validImbalances == null || validImbalances.Count < K)
                return ImbalanceStackInfo.Invalid;

            // 2) build all maximal consecutive stacks (len >= K)
            validImbalances.Sort((a, b) => a.Level.CompareTo(b.Level));
            var candidates = new List<List<ImbalanceLevel>>();
            int start = 0;
            while (start < validImbalances.Count)
            {
                int end = start;
                while (end + 1 < validImbalances.Count &&
                       validImbalances[end + 1].Level == validImbalances[end].Level + 1)
                    end++;
                int len = end - start + 1;
                if (len >= K) candidates.Add(validImbalances.GetRange(start, len));
                start = end + 1;
            }
            if (candidates.Count == 0) return ImbalanceStackInfo.Invalid;

            // 3) rank candidates (same deterministic rules as the prompt)
            candidates.Sort((A, B) =>
            {
                if (A.Count != B.Count) return B.Count.CompareTo(A.Count); // longest first
                long aVol = isLong ? A.Sum(x => x.AskVolUsed) : A.Sum(x => x.BidVolUsed);
                long bVol = isLong ? B.Sum(x => x.AskVolUsed) : B.Sum(x => x.BidVolUsed);
                if (aVol != bVol) return bVol.CompareTo(aVol);             // higher sum first
                double aBorder = isLong ? A.Max(x => x.Price) : A.Min(x => x.Price);
                double bBorder = isLong ? B.Max(x => x.Price) : B.Min(x => x.Price);
                return isLong ? bBorder.CompareTo(aBorder) : aBorder.CompareTo(bBorder);
            });

            // 4) validate in ranked order and return the first passing stack
            foreach (var cand in candidates)
            {
                var info = ApplyValidationGates(cand, isLong, barLow, barHigh, barClose);
                if (info.IsValid) return info;
            }

            return ImbalanceStackInfo.Invalid;
        }

        private List<ImbalanceLevel> FindBestConsecutiveStack(List<ImbalanceLevel> imbalances, int K, bool isLong)
        {
            if (imbalances == null || imbalances.Count < K)
                return null;

            // Sort by price level (ascending)
            imbalances.Sort((a, b) => a.Level.CompareTo(b.Level));

            // Collect all maximal consecutive sequences
            var candidates = new List<List<ImbalanceLevel>>();
            int start = 0;
            while (start < imbalances.Count)
            {
                int end = start;
                while (end + 1 < imbalances.Count && imbalances[end + 1].Level == imbalances[end].Level + 1)
                    end++;

                int len = end - start + 1;
                if (len >= K)
                    candidates.Add(imbalances.GetRange(start, len));

                start = end + 1;
            }

            if (candidates.Count == 0)
                return null;

            // Deterministic selection:
            // 1) Longest length wins.
            // 2) Tie-breaker: higher relevant volume sum (Long: AskSum, Short: BidSum).
            // 3) Tie-breaker: Long -> higher border price; Short -> lower border price.
            List<ImbalanceLevel> best = candidates[0];

            foreach (var cand in candidates)
            {
                if (cand.Count > best.Count)
                {
                    best = cand;
                    continue;
                }
                if (cand.Count == best.Count)
                {
                    long volBest = isLong ? best.Sum(x => x.AskVolUsed) : best.Sum(x => x.BidVolUsed);
                    long volCand = isLong ? cand.Sum(x => x.AskVolUsed) : cand.Sum(x => x.BidVolUsed);

                    if (volCand > volBest)
                    {
                        best = cand;
                        continue;
                    }
                    if (volCand == volBest)
                    {
                        double borderBest = isLong ? best.Max(x => x.Price) : best.Min(x => x.Price);
                        double borderCand = isLong ? cand.Max(x => x.Price) : cand.Min(x => x.Price);

                        bool takeCand = isLong ? borderCand > borderBest : borderCand < borderBest;
                        if (takeCand) best = cand;
                    }
                }
            }

            return best;
        }

        private ImbalanceStackInfo ApplyValidationGates(
            List<ImbalanceLevel> stack, bool isLong,
            double barLow, double barHigh, double barClose)
        {
            // Border price: top of the stack for Long, bottom for Short
            double borderPrice = isLong
                ? stack.Max(x => x.Price)
                : stack.Min(x => x.Price);

            // --- Location-Gate (corrected inequalities) ---
            // Compute percentage of the border inside the bar range and clamp to [0..100]
            double currentLocationPct;
            bool passesLocationGate;
            if (barHigh > barLow)
            {
                currentLocationPct = (borderPrice - barLow) / (barHigh - barLow) * 100.0;
                currentLocationPct = Math.Max(0.0, Math.Min(100.0, currentLocationPct));

                // FINAL REQUIREMENTS:
                // Long:  locationPct <= ImbaLocation (below/equal location) - Lower right
                // Short: locationPct >= ImbaLocation (above/equal location) - Upper left
                passesLocationGate = isLong
                    ? currentLocationPct <= ImbaLocation
                    : currentLocationPct >= ImbaLocation;
            }
            else
            {
                // Null-range bar: skip (auto-pass) location gate; draw ImbaLocation line at this price elsewhere
                currentLocationPct = 50.0;
                passesLocationGate = true;
            }

            // Close-Gate is now applied at individual level, not stack level

            // --- Volume-Sum-Gate ---
            long relevantVolumeSum = isLong
                ? stack.Sum(x => x.AskVolUsed)   // Long Imbalance: Right side (Ask side)
                : stack.Sum(x => x.BidVolUsed);  // Short Imbalance: Left side (Bid side)
            bool passesVolumeGate = relevantVolumeSum >= ImbaMinVolumeSum;

            bool isValid = passesLocationGate && passesVolumeGate;

            return new ImbalanceStackInfo
            {
                IsValid = isValid,
                ValidLevels = stack,
                BorderPrice = borderPrice,
                CurrentLocationPct = currentLocationPct,
                TotalVolumeSum = relevantVolumeSum
            };
        }

        private List<ImbalanceLevel> FindAllValidImbalances(Dictionary<int, long> ask, Dictionary<int, long> bid,
            int aMin, int aMax, int bMin, int bMax, bool isLong,
            double barClose, double barLow, double barHigh)
        {
            var validImbalances = new List<ImbalanceLevel>();
            int start = MergeMin(aMin, bMin);
            int end = MergeMax(aMax, bMax);

            for (int level = start; level <= end; level++)
            {
                var validLevel = ValidateIndividualLevel(level, ask, bid, isLong, barClose, barLow, barHigh);
                if (validLevel.HasValue)
                {
                    validImbalances.Add(validLevel.Value);
                }
            }

            return validImbalances;
        }

        private ImbalanceLevel? ValidateIndividualLevel(int level, Dictionary<int, long> ask, Dictionary<int, long> bid, bool isLong,
            double barClose, double barLow, double barHigh)
        {
            ask.TryGetValue(level, out var aVolRaw);
            bid.TryGetValue(level, out var bVolRaw);

            double ratio;
            long askVolUsed, bidVolUsed;
            double levelPrice = PriceFromLevelImba(level);

            if (ImbaCalcMode == ImbaAbsoCalcModes.Horizontal)
            {
                // Horizontal: Ask@level vs Bid@level
                askVolUsed = aVolRaw;
                bidVolUsed = bVolRaw;

                // Only volumes used in ratio calculation need validation
                // Allow 0 if min is 0 (division-by-zero protection handles it)
                bool askValid = askVolUsed >= ImbaAskMin && askVolUsed <= ImbaAskMax;
                bool bidValid = bidVolUsed >= ImbaBidMin && bidVolUsed <= ImbaBidMax;

                if (!askValid || !bidValid)
                    return null;

                if (isLong) // Long Imbalance: Right side (Ask side)
                {
                    // Right side: Ask/Bid
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = bidVolUsed == 0 ? 1.0 : (double)bidVolUsed;
                    ratio = askVolUsed / divisor * 100.0;
                }
                else // Short Imbalance: Left side (Bid side)
                {
                    // Left side: Bid/Ask
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = askVolUsed == 0 ? 1.0 : (double)askVolUsed;
                    ratio = bidVolUsed / divisor * 100.0;
                }
            }
            else // Diagonal
            {
                if (isLong) // Long Imbalance: Right side (Ask side) - Ask@level vs Bid@(level-1)
                {
                    // Diagonal rule: If Ask is numerator, Bid must be level-1
                    bid.TryGetValue(level - 1, out var bBelowRaw);
                    askVolUsed = aVolRaw;
                    bidVolUsed = bBelowRaw;

                    // Only volumes used in ratio calculation need validation
                    // Allow 0 if min is 0 (division-by-zero protection handles it)
                    bool askValid = askVolUsed >= ImbaAskMin && askVolUsed <= ImbaAskMax;
                    bool bidValid = bidVolUsed >= ImbaBidMin && bidVolUsed <= ImbaBidMax;

                    if (!askValid || !bidValid)
                        return null;

                    // Right side: Ask/Bid
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = bidVolUsed == 0 ? 1.0 : (double)bidVolUsed;
                    ratio = askVolUsed / divisor * 100.0;
                }
                else // Short Imbalance: Left side (Bid side) - Bid@level vs Ask@(level+1)
                {
                    // Diagonal rule: If Bid is numerator, Ask must be level+1
                    ask.TryGetValue(level + 1, out var aAboveRaw);
                    askVolUsed = aAboveRaw;
                    bidVolUsed = bVolRaw;

                    // Only volumes used in ratio calculation need validation
                    // Allow 0 if min is 0 (division-by-zero protection handles it)
                    bool askValid = askVolUsed >= ImbaAskMin && askVolUsed <= ImbaAskMax;
                    bool bidValid = bidVolUsed >= ImbaBidMin && bidVolUsed <= ImbaBidMax;

                    if (!askValid || !bidValid)
                        return null;

                    // Left side: Bid/Ask
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = askVolUsed == 0 ? 1.0 : (double)askVolUsed;
                    ratio = bidVolUsed / divisor * 100.0;
                }
            }

            // Check ratio threshold
            if (ratio < ImbaThreshold)
                return null;

            // Per-level Close-Gate
            bool passesCloseGate;
            if (isLong) // Long Imbalance
            {
                // Long Imbalance: level must be <= barClose (below/equal close) - Lower right
                passesCloseGate = levelPrice <= barClose;
            }
            else // Short Imbalance
            {
                // Short Imbalance: level must be >= barClose (above/equal close) - Upper left
                passesCloseGate = levelPrice >= barClose;
            }
            
            if (!passesCloseGate)
                return null;

            // Per-level Location-Gate (symmetric with inclusive inequalities)
            double locationPct;
            bool passesLocationGate;
            if (barHigh > barLow)
            {
                locationPct = (levelPrice - barLow) / (barHigh - barLow) * 100.0;
                locationPct = Math.Max(0.0, Math.Min(100.0, locationPct));
                passesLocationGate = isLong ? (locationPct <= ImbaLocation) : (locationPct >= ImbaLocation);
            }
            else
            {
                locationPct = 50.0;
                passesLocationGate = true; // null-range bar → auto-pass
            }

            if (!passesLocationGate)
                return null;

            return new ImbalanceLevel
            {
                Level = level,
                Price = levelPrice,
                AskVolUsed = askVolUsed,
                BidVolUsed = bidVolUsed,
                Ratio = ratio,
                AskVolRaw = aVolRaw,
                BidVolRaw = bVolRaw
            };
        }

        private List<ImbalanceLevel> FindConsecutiveStack(List<ImbalanceLevel> imbalances, int K)
        {
            if (imbalances.Count < K)
                return null;

            // Sort by level (ascending)
            imbalances.Sort((a, b) => a.Level.CompareTo(b.Level));

            // Find first consecutive sequence of exactly K levels
            for (int i = 0; i <= imbalances.Count - K; i++)
            {
                bool isConsecutive = true;

                // Check if K levels starting at i are consecutive
                for (int j = 1; j < K; j++)
                {
                    if (imbalances[i + j].Level != imbalances[i + j - 1].Level + 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }

                if (isConsecutive)
                {
                    return imbalances.GetRange(i, K);
                }
            }

            return null;
        }

        // === NEW METHODS (absorption, parallel to imbalance) =========================
        private AbsorptionStackInfo ValidateAbsorptionStack(int barsAgo)
        {
            if (R2sTradeDirection == TradeDirections.None || AbsoPriceLevelSize == 0)
                return AbsorptionStackInfo.Invalid;

            if (barsAgo < 0 || barsAgo >= _count)
                return AbsorptionStackInfo.Invalid;

            // Use appropriate level getters based on whether separate accumulation is used
            bool useSeparateAccumulation = ImbaPriceLevelSize != 0 && AbsoPriceLevelSize != 0 && 
                                           Math.Abs(ImbaPriceLevelSize - AbsoPriceLevelSize) > double.Epsilon;
            
            var (ask, aMin, aMax) = useSeparateAccumulation ? GetAskLevelsAbso(barsAgo) : GetAskLevels(barsAgo);
            var (bid, bMin, bMax) = useSeparateAccumulation ? GetBidLevelsAbso(barsAgo) : GetBidLevels(barsAgo);
            if (!HasData(aMin, aMax) && !HasData(bMin, bMax))
                return AbsorptionStackInfo.Invalid;

            if (Close?.Count == 0 || Low?.Count == 0 || High?.Count == 0)
                return AbsorptionStackInfo.Invalid;

            int last = Close.Count - 1;
            int biAbs = last - barsAgo;
            if (biAbs < 0) return AbsorptionStackInfo.Invalid;

            int biClamped = Math.Max(0, Math.Min(biAbs, Close.Count - 1));
            double barClose = Close.GetValueAt(biClamped);
            double barLow = Low.GetValueAt(biClamped);
            double barHigh = High.GetValueAt(biClamped);

            // INVERTED: Absorption uses inverted direction logic vs imbalance
            bool isLong = R2sTradeDirection == TradeDirections.Long;
            int K = Math.Max(1, AbsoStackCount);

            // 1) collect all valid individual absorptions (with per-level gates)
            var valid = FindAllValidAbsorptions(ask, bid, aMin, aMax, bMin, bMax, isLong, barClose, barLow, barHigh);
            if (valid == null || valid.Count < K)
                return AbsorptionStackInfo.Invalid;

            // 2) build all maximal consecutive stacks (len >= K)
            valid.Sort((x, y) => x.Level.CompareTo(y.Level));
            var candidates = new List<List<AbsorptionLevel>>();
            int start = 0;
            while (start < valid.Count)
            {
                int end = start;
                while (end + 1 < valid.Count &&
                       valid[end + 1].Level == valid[end].Level + 1)
                    end++;

                int len = end - start + 1;
                if (len >= K) candidates.Add(valid.GetRange(start, len));
                start = end + 1;
            }
            if (candidates.Count == 0) return AbsorptionStackInfo.Invalid;

            // 3) rank candidates (longest → highest relevant sum → border extremum)
            candidates.Sort((A, B) =>
            {
                if (A.Count != B.Count) return B.Count.CompareTo(A.Count);
                // INVERTED: Long sums Ask_used (like imbalance), Short sums Bid_used (like imbalance)
                long aSum = isLong ? A.Sum(z => z.AskVolUsed) : A.Sum(z => z.BidVolUsed);
                long bSum = isLong ? B.Sum(z => z.AskVolUsed) : B.Sum(z => z.BidVolUsed);
                if (aSum != bSum) return bSum.CompareTo(aSum);
                double aBorder = isLong ? A.Max(z => z.Price) : A.Min(z => z.Price);
                double bBorder = isLong ? B.Max(z => z.Price) : B.Min(z => z.Price);
                return isLong ? bBorder.CompareTo(aBorder) : aBorder.CompareTo(bBorder);
            });

            // 4) validate gates (incl. AbsoDepth) and return first passing stack
            foreach (var cand in candidates)
            {
                var info = ApplyAbsorptionValidationGates(cand, isLong, barLow, barHigh, barClose);
                if (info.IsValid) return info;
            }

            return AbsorptionStackInfo.Invalid;
        }

        private List<AbsorptionLevel> FindAllValidAbsorptions(
            Dictionary<int, long> ask, Dictionary<int, long> bid,
            int aMin, int aMax, int bMin, int bMax, bool isLong,
            double barClose, double barLow, double barHigh)
        {
            var result = new List<AbsorptionLevel>();
            int start = MergeMin(aMin, bMin);
            int end = MergeMax(aMax, bMax);

            for (int level = start; level <= end; level++)
            {
                var lvl = ValidateAbsorptionIndividualLevel(level, ask, bid, isLong, barClose, barLow, barHigh);
                if (lvl.HasValue) result.Add(lvl.Value);
            }
            return result;
        }

        private AbsorptionLevel? ValidateAbsorptionIndividualLevel(
            int level, Dictionary<int, long> ask, Dictionary<int, long> bid, bool isLong,
            double barClose, double barLow, double barHigh)
        {
            ask.TryGetValue(level, out var aRaw);
            bid.TryGetValue(level, out var bRaw);

            long askUsed, bidUsed;
            double ratio;
            double levelPrice = PriceFromLevelAbso(level);

            // Absorption calculation: Right side uses Ask/Bid, Left side uses Bid/Ask
            if (AbsoCalcMode == ImbaAbsoCalcModes.Horizontal)
            {
                // Horizontal Mode: AskVolume and BidVolume at current level
                askUsed = aRaw;
                bidUsed = bRaw;

                // Volume validation: Allow 0 if min is 0 (division-by-zero protection handles it)
                bool askOk = askUsed >= AbsoAskMin && askUsed <= AbsoAskMax;
                bool bidOk = bidUsed >= AbsoBidMin && bidUsed <= AbsoBidMax;
                if (!askOk || !bidOk) return null;

                // Absorption calculation: Right side uses Ask/Bid, Left side uses Bid/Ask
                if (isLong) // Long Absorption: Left side (Bid side)
                {
                    // Left side: Bid/Ask
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = askUsed == 0 ? 1.0 : (double)askUsed;
                    ratio = bidUsed / divisor * 100.0;
                }
                else // Short Absorption: Right side (Ask side)
                {
                    // Right side: Ask/Bid
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = bidUsed == 0 ? 1.0 : (double)bidUsed;
                    ratio = askUsed / divisor * 100.0;
                }
            }
            else // Diagonal
            {
                // Volume validation: Allow 0 if min is 0 (division-by-zero protection handles it)
                bool askOk, bidOk;
                
                if (isLong) // Long Absorption: Left side (Bid side) - Bid@level vs Ask@(level+1)
                {
                    // Diagonal rule: If Bid is numerator, Ask must be level+1
                    ask.TryGetValue(level + 1, out var aAbove);
                    askUsed = aAbove;
                    bidUsed = bRaw;
                }
                else // Short Absorption: Right side (Ask side) - Ask@level vs Bid@(level-1)
                {
                    // Diagonal rule: If Ask is numerator, Bid must be level-1
                    bid.TryGetValue(level - 1, out var bBelow);
                    askUsed = aRaw;
                    bidUsed = bBelow;
                }

                askOk = askUsed >= AbsoAskMin && askUsed <= AbsoAskMax;
                bidOk = bidUsed >= AbsoBidMin && bidUsed <= AbsoBidMax;
                    if (!askOk || !bidOk) return null;

                // Absorption calculation: Right side uses Ask/Bid, Left side uses Bid/Ask
                if (isLong) // Long Absorption: Left side (Bid side)
                {
                    // Left side: Bid/Ask
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = askUsed == 0 ? 1.0 : (double)askUsed;
                    ratio = bidUsed / divisor * 100.0;
                }
                else // Short Absorption: Right side (Ask side)
                {
                    // Right side: Ask/Bid
                    // Division-by-zero protection: use 0 as 1 if within min/max gates
                    double divisor = bidUsed == 0 ? 1.0 : (double)bidUsed;
                    ratio = askUsed / divisor * 100.0;
                }
            }

            // Ratio threshold
            if (ratio < AbsoThreshold)
                return null;

            // Per-level Close-Depth-Gate
            double priceDistance = AbsoDepth * AbsoPriceLevelSize;
            bool passesCloseDepth;
            if (isLong) // Long Absorption
            {
                // Long Absorption: level must be <= barClose - priceDistance (below or equal close - depth)
                passesCloseDepth = levelPrice <= barClose - priceDistance;
            }
            else // Short Absorption
            {
                // Short Absorption: level must be >= barClose + priceDistance (above or equal close + depth)
                passesCloseDepth = levelPrice >= barClose + priceDistance;
            }
            
            if (!passesCloseDepth)
                return null;

            // Per-level Location-Gate (symmetric: Long ABOVE AbsoLocation, Short BELOW AbsoLocation)
            double locationPct;
            bool passesLocation;
            if (barHigh > barLow)
            {
                locationPct = (levelPrice - barLow) / (barHigh - barLow) * 100.0;
                locationPct = Math.Max(0.0, Math.Min(100.0, locationPct));
                // FINAL REQUIREMENTS: Long BELOW or EQUAL AbsoLocation (lower left), Short ABOVE or EQUAL AbsoLocation (upper right)
                passesLocation = isLong ? (locationPct <= AbsoLocation) : (locationPct >= AbsoLocation);
            }
            else
            {
                locationPct = 50.0;
                passesLocation = true; // null-range bar → auto-pass
            }

            if (!passesLocation)
                return null;

            return new AbsorptionLevel
            {
                Level = level,
                Price = levelPrice,
                AskVolUsed = askUsed,
                BidVolUsed = bidUsed,
                Ratio = ratio,
                AskVolRaw = aRaw,
                BidVolRaw = bRaw
            };
        }

        private AbsorptionStackInfo ApplyAbsorptionValidationGates(
            List<AbsorptionLevel> stack, bool isLong,
            double barLow, double barHigh, double barClose)
        {
            // Border: top (long) / bottom (short)
            double border = isLong
                ? stack.Max(x => x.Price)
                : stack.Min(x => x.Price);

            // Close-Depth-Gate is now applied at individual level, not stack level

            // --- Volume Sum Gate (stack-level) ---
            // Long Absorption: Left side (Bid side) - Sum(Bid_used), Short Absorption: Right side (Ask side) - Sum(Ask_used)
            long volSum = isLong
                ? stack.Sum(x => x.BidVolUsed)
                : stack.Sum(x => x.AskVolUsed);

            bool passesVol = volSum >= AbsoMinVolumeSum;

            // Location percentage for output only (not gated at stack level)
            double locPct;
            if (barHigh > barLow)
            {
                locPct = (border - barLow) / (barHigh - barLow) * 100.0;
                locPct = Math.Max(0.0, Math.Min(100.0, locPct));
            }
            else
            {
                locPct = 50.0;
            }

            return new AbsorptionStackInfo
            {
                IsValid = passesVol,  // Only volume gate at stack level
                ValidLevels = stack,
                BorderPrice = border,
                CurrentLocationPct = locPct,
                TotalVolumeSum = volSum
            };
        }

        // Public signal helper (parallels ImbalanceSignal)
        // Gate rules: Long absorption ≥ close & ≤ location (lower left), Short absorption ≤ close & ≥ location (upper right).
        public bool AbsorptionSignal(StringBuilder sb, int barsAgo, bool isGetDebugOpenLog)
        {
            if (AbsoPriceLevelSize == 0)
                return false;

            var info = ValidateAbsorptionStack(barsAgo);
            bool signal = info.IsValid;

            if ((signal || isGetDebugOpenLog) && sb != null)
            {
                if (info.ValidLevels != null && info.ValidLevels.Count > 0)
                {
                    sb.Append(',').Append(info.ValidLevels.Count.ToString());
                    sb.Append(',').Append(info.CurrentLocationPct.ToString("F2", CultureInfo.InvariantCulture));
                    sb.Append(',').Append(info.TotalVolumeSum.ToString(CultureInfo.InvariantCulture));

                    // Ratios (highest level first)
                    for (int i = info.ValidLevels.Count - 1; i >= 0; i--)
                        sb.Append(',').Append(info.ValidLevels[i].Ratio.ToString("F1", CultureInfo.InvariantCulture));

                    // INVERTED: Passive-side volumes used (Ask for long, Bid for short) – highest first
                    if (R2sTradeDirection == TradeDirections.Long)
                        for (int i = info.ValidLevels.Count - 1; i >= 0; i--)
                            sb.Append(',').Append(info.ValidLevels[i].AskVolUsed.ToString(CultureInfo.InvariantCulture));
                    else
                        for (int i = info.ValidLevels.Count - 1; i >= 0; i--)
                            sb.Append(',').Append(info.ValidLevels[i].BidVolUsed.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    sb.Append(',').Append(",None");
                    sb.Append(",?"); // location
                    sb.Append(",?"); // vol sum
                    for (int i = 0; i < Math.Max(1, AbsoStackCount); i++) sb.Append(",?");
                    for (int i = 0; i < Math.Max(1, AbsoStackCount); i++) sb.Append(",?");
                }
            }

            return signal;
        }
        #endregion

        #region Rendering Methods
        // --- Always draw Volume labels; Imbalance visuals are suppressed when ImbaCalcMode == None ---
        private void RenderVolumeLabelsAndImbalances(RenderTarget rt, ChartControl chartControl, ChartScale chartScale,
            int firstBar, int lastBar, int dataLast, bool imbalanceEnabled, bool absorptionEnabled)
        {
            // Safety guard: if both Imbalance and Absorption are effectively disabled (no price level size),
            // do not render any volume ladder at all. This ensures that when only Big Trades are enabled,
            // no full ladder is drawn and only the Big Trade highlights remain.
            if (ImbaPriceLevelSize == 0 && AbsoPriceLevelSize == 0)
                return;

            float dx = HorizontalPx;

            if (_count <= 0 || dataLast < 0) return;

            for (int bi = firstBar; bi <= lastBar; bi++)
            {
                float xCenter = chartControl.GetXByBarIndex(ChartBars, bi);
                int biAbs = Math.Min(Math.Max(bi, 0), dataLast);
                int barsAgo = dataLast - biAbs;
                if (barsAgo < 0 || barsAgo >= _count)
                    continue;

                // Determine which level getters to use based on enabled features and separate accumulation
                bool useSeparateAccumulation = ImbaPriceLevelSize != 0 && AbsoPriceLevelSize != 0 && 
                                               Math.Abs(ImbaPriceLevelSize - AbsoPriceLevelSize) > double.Epsilon;

                var (ask, aMin, aMax) = GetAskLevels(barsAgo);
                var (bid, bMin, bMax) = GetBidLevels(barsAgo);
                
                // If separate accumulation is used, we need to get the appropriate levels for each feature
                var (askImba, aMinImba, aMaxImba) = useSeparateAccumulation && imbalanceEnabled ? GetAskLevelsImba(barsAgo) : (ask, aMin, aMax);
                var (bidImba, bMinImba, bMaxImba) = useSeparateAccumulation && imbalanceEnabled ? GetBidLevelsImba(barsAgo) : (bid, bMin, bMax);
                var (askAbso, aMinAbso, aMaxAbso) = useSeparateAccumulation && absorptionEnabled ? GetAskLevelsAbso(barsAgo) : (ask, aMin, aMax);
                var (bidAbso, bMinAbso, bMaxAbso) = useSeparateAccumulation && absorptionEnabled ? GetBidLevelsAbso(barsAgo) : (bid, bMin, bMax);
                if (!HasData(aMin, aMax) && !HasData(bMin, bMax))
                    continue;

                int start = MergeMin(aMin, bMin);
                int end = MergeMax(aMax, bMax);

                float maxBidW = 0f, maxAskW = 0f;

                // With ImbaPriceLevelSize == 0 we **do not** compute imbalances, stacks || draw any of those visuals.
                // Gate rules: Long imbalance ≤ close & ≤ location (lower right), Short imbalance ≥ close & ≥ location (upper right).
                var stackInfo = imbalanceEnabled ? ValidateImbalanceStack(barsAgo) : ImbalanceStackInfo.Invalid;
                // Absorption: compute independently (own params) with INVERTED behavior
                bool absoEnabled = AbsoPriceLevelSize != 0 && R2sTradeDirection != TradeDirections.None;
                var absoInfo = absoEnabled ? ValidateAbsorptionStack(barsAgo) : AbsorptionStackInfo.Invalid;

                // Decoration drawing per USER CLARIFICATION
                // Imbalance: Long=Ask(right), Short=Bid(left)
                bool drawAskImba = imbalanceEnabled && R2sTradeDirection == TradeDirections.Long;
                bool drawBidImba = imbalanceEnabled && R2sTradeDirection == TradeDirections.Short;
                
                // Absorption: Long on LEFT (Bid side), Short on RIGHT (Ask side)
                bool drawAskAbso = absoEnabled && R2sTradeDirection == TradeDirections.Short; // Short absorption on Ask side
                bool drawBidAbso = absoEnabled && R2sTradeDirection == TradeDirections.Long; // Long absorption on Bid side

                var validStackLevels = imbalanceEnabled && stackInfo.IsValid ? stackInfo.ValidLevels.Select(x => x.Level).ToHashSet() : new HashSet<int>();
                var validAbsoStackLevels = absoEnabled && absoInfo.IsValid ? absoInfo.ValidLevels.Select(x => x.Level).ToHashSet() : new HashSet<int>();

                var individualImbalances = new HashSet<int>();
                if (imbalanceEnabled)
                {
                    int biClamped = Math.Max(0, Math.Min(biAbs, Close.Count - 1));
                    double barClose = Close.GetValueAt(biClamped);
                    double barLow = Low.GetValueAt(biClamped);
                    double barHigh = High.GetValueAt(biClamped);
                    
                    bool isLong = R2sTradeDirection == TradeDirections.Long;
                    var allValidImbalances = FindAllValidImbalances(askImba, bidImba, aMinImba, aMaxImba, bMinImba, bMaxImba, isLong, barClose, barLow, barHigh);
                    individualImbalances = allValidImbalances.Select(x => x.Level).ToHashSet();
                }

                // For per-level absorption highlighting we reuse the absorption validator per bar
                var individualAbsorptions = new HashSet<int>();
                if (absoEnabled)
                {
                    int biClamped = Math.Max(0, Math.Min(biAbs, Close.Count - 1));
                    double barClose = Close.GetValueAt(biClamped);
                    double barLow = Low.GetValueAt(biClamped);
                    double barHigh = High.GetValueAt(biClamped);
                    
                    // INVERTED: Use same trade direction for absorption (but inverted behavior)
                    bool isLongA = R2sTradeDirection == TradeDirections.Long;
                    var allAbso = FindAllValidAbsorptions(askAbso, bidAbso, aMinAbso, aMaxAbso, bMinAbso, bMaxAbso, isLongA, barClose, barLow, barHigh);
                    individualAbsorptions = allAbso.Select(x => x.Level).ToHashSet();
                }

                var rectCoords = new List<(float top, float bottom, bool bidHigher)>();
                var rectCoordsAbso = new List<(float top, float bottom, bool bidHigher)>();

                for (int level = start; level <= end; level++)
                {
                    // Use appropriate volume data based on enabled features and separate accumulation
                    long aVolRaw = 0, bVolRaw = 0;
                    
                    if (useSeparateAccumulation)
                    {
                        // When separate accumulation is used, get volumes from appropriate dictionaries
                        if (imbalanceEnabled && absorptionEnabled)
                        {
                            // Both enabled - use shared volumes for display (this is a simplification for volume display)
                            ask.TryGetValue(level, out aVolRaw);
                            bid.TryGetValue(level, out bVolRaw);
                        }
                        else if (imbalanceEnabled)
                        {
                            // Only imbalance enabled - use imbalance volumes
                            askImba.TryGetValue(level, out aVolRaw);
                            bidImba.TryGetValue(level, out bVolRaw);
                        }
                        else if (absorptionEnabled)
                        {
                            // Only absorption enabled - use absorption volumes
                            askAbso.TryGetValue(level, out aVolRaw);
                            bidAbso.TryGetValue(level, out bVolRaw);
                        }
                    }
                    else
                    {
                        // Shared accumulation - use shared volumes
                        ask.TryGetValue(level, out aVolRaw);
                        bid.TryGetValue(level, out bVolRaw);
                    }

                    // Volume thresholds depend on which feature is enabled
                    bool askIn, bidIn;
                    if (imbalanceEnabled && !absorptionEnabled)
                    {
                        // Only imbalance enabled - use imbalance thresholds
                        askIn = aVolRaw >= ImbaAskMin && aVolRaw <= ImbaAskMax;
                        bidIn = bVolRaw >= ImbaBidMin && bVolRaw <= ImbaBidMax;
                    }
                    else if (!imbalanceEnabled && absorptionEnabled)
                    {
                        // Only absorption enabled - use absorption thresholds
                        askIn = aVolRaw >= AbsoAskMin && aVolRaw <= AbsoAskMax;
                        bidIn = bVolRaw >= AbsoBidMin && bVolRaw <= AbsoBidMax;
                    }
                    else
                    {
                        // Both enabled or both disabled - use imbalance thresholds as default
                        askIn = aVolRaw >= ImbaAskMin && aVolRaw <= ImbaAskMax;
                        bidIn = bVolRaw >= ImbaBidMin && bVolRaw <= ImbaBidMax;
                    }

                    // Only treat as "imbalance active" when imbalance visuals are enabled
                    bool isIndividualImbalance = imbalanceEnabled && individualImbalances.Contains(level);
                    bool isPartOfValidStack = imbalanceEnabled && validStackLevels.Contains(level);
                    bool isIndividualAbsorption = absoEnabled && individualAbsorptions.Contains(level);
                    bool isPartOfValidAbso = absoEnabled && validAbsoStackLevels.Contains(level);

                    bool askImbActive = isIndividualImbalance && drawAskImba;
                    bool bidImbActive = isIndividualImbalance && drawBidImba;

                    // Use appropriate price calculation based on enabled features and separate accumulation
                    double price;
                    if (useSeparateAccumulation)
                    {
                        if (imbalanceEnabled && absorptionEnabled)
                        {
                            // Both enabled - use shared price calculation for display
                            price = PriceFromLevel(level);
                        }
                        else if (imbalanceEnabled)
                        {
                            // Only imbalance enabled - use imbalance price calculation
                            price = PriceFromLevelImba(level);
                        }
                        else if (absorptionEnabled)
                        {
                            // Only absorption enabled - use absorption price calculation
                            price = PriceFromLevelAbso(level);
                        }
                        else
                        {
                            price = PriceFromLevel(level);
                        }
                    }
                    else
                    {
                        // Shared accumulation - use shared price calculation
                        price = PriceFromLevel(level);
                    }
                    float y = chartScale.GetYByValue(price);

                    bool forceGray = R2sTradeDirection == TradeDirections.None;

                    string sBid = bVolRaw.ToString("N0", CultureInfo.InvariantCulture);
                    string sAsk = aVolRaw.ToString("N0", CultureInfo.InvariantCulture);

                    bool askAbsoActive = isIndividualAbsorption && drawAskAbso; // absorption SHORT highlights ask side
                    bool bidAbsoActive = isIndividualAbsorption && drawBidAbso; // LONG highlights bid side

                    // Overlap color if both imbalance and absorption on same side
                    // Absorption: Long=Cyan, Short=Violet (consistent with dotted line and rectangle)
                    var bidBrush = forceGray ? _dxGrayBrush
                        : (bidImbActive && bidAbsoActive) ? _dxPinkBrush
                        : bidImbActive ? _dxVioletBrush
                        : bidAbsoActive ? (R2sTradeDirection == TradeDirections.Long ? _dxOrangeBrush : _dxGoldBrush)
                        : bidIn ? _dxWhiteBrush : _dxGrayBrush;

                    var askBrush = forceGray ? _dxGrayBrush
                        : (askImbActive && askAbsoActive) ? _dxPinkBrush
                        : askImbActive ? _dxCyanBrush
                        : askAbsoActive ? (R2sTradeDirection == TradeDirections.Long ? _dxOrangeBrush : _dxGoldBrush)
                        : askIn ? _dxWhiteBrush : _dxGrayBrush;

                    // Only make bold the side that should be highlighted based on drawing flags
                    bool bidActive = (bidImbActive || bidAbsoActive) || (isPartOfValidStack && drawBidImba) || (isPartOfValidAbso && drawBidAbso);
                    bool askActive = (askImbActive || askAbsoActive) || (isPartOfValidStack && drawAskImba) || (isPartOfValidAbso && drawAskAbso);
                    var tfBid = forceGray ? _tfNormal : bidActive ? _tfBold : _tfNormal;
                    var tfAsk = forceGray ? _tfNormal : askActive ? _tfBold : _tfNormal;

                    using (var tlBid = new TextLayout(Globals.DirectWriteFactory, sBid, tfBid, 1000, 1000))
                    using (var tlAsk = new TextLayout(Globals.DirectWriteFactory, sAsk, tfAsk, 1000, 1000))
                    {
                        float wBid = tlBid.Metrics.WidthIncludingTrailingWhitespace;
                        float wAsk = tlAsk.Metrics.WidthIncludingTrailingWhitespace;
                        float hBid = tlBid.Metrics.Height;
                        float hAsk = tlAsk.Metrics.Height;

                        if (wBid > maxBidW) maxBidW = wBid;
                        if (wAsk > maxAskW) maxAskW = wAsk;

                        float xBid = xCenter - dx - wBid;
                        float xAsk = xCenter + dx;

                        rt.DrawTextLayout(new Vector2(xBid, y - hBid * 0.5f), tlBid, bidBrush);
                        rt.DrawTextLayout(new Vector2(xAsk, y - hAsk * 0.5f), tlAsk, askBrush);

                        // Collect rectangle coordinates for valid stacks (around higher values)
                        if (isPartOfValidStack)
                        {
                            bool bidHigher = bVolRaw > aVolRaw;
                            float curTop = y - Math.Max(hBid, hAsk) * 0.5f;
                            float curBot = y + Math.Max(hBid, hAsk) * 0.5f;
                            rectCoords.Add((curTop, curBot, bidHigher));
                        }
                        if (isPartOfValidAbso)
                        {
                            bool bidHigher = bVolRaw > aVolRaw;
                            float curTop = y - Math.Max(hBid, hAsk) * 0.5f;
                            float curBot = y + Math.Max(hBid, hAsk) * 0.5f;
                            rectCoordsAbso.Add((curTop, curBot, bidHigher));
                        }
                    }
                }

                // Draw imbalance stack rectangles (around higher values only)
                if (imbalanceEnabled && stackInfo.IsValid && rectCoords.Count > 0)
                {
                    float yTop = rectCoords.Min(x => x.top) - RectanglePadding;
                    float yBot = rectCoords.Max(x => x.bottom) + RectanglePadding;

                    bool isLong = R2sTradeDirection == TradeDirections.Long;

                    // Determine which side to draw rectangle on based on higher values
                    bool hasBidHigher = rectCoords.Any(x => x.bidHigher && drawBidImba);
                    bool hasAskHigher = rectCoords.Any(x => !x.bidHigher && drawAskImba);

                    if (hasBidHigher)
                    {
                        // Draw rectangle on Bid side (left) - Short imbalance
                        float xL = xCenter - dx - maxBidW;
                        float xR = xCenter - dx;
                        var rect = new RectangleF(xL, yTop, xR - xL, yBot - yTop);
                        rt.DrawRectangle(rect, _dxVioletBrush, 1.0f);
                    }
                    
                    if (hasAskHigher)
                    {
                        // Draw rectangle on Ask side (right) - Long imbalance
                        float xL = xCenter + dx;
                        float xR = xCenter + dx + maxAskW;
                        var rect = new RectangleF(xL, yTop, xR - xL, yBot - yTop);
                        rt.DrawRectangle(rect, _dxCyanBrush, 1.0f);
                    }
                }

                // Draw absorption stack rectangles (around higher values only)
                if (absoEnabled && absoInfo.IsValid && rectCoordsAbso.Count > 0)
                {
                    float yTop = rectCoordsAbso.Min(x => x.top) - RectanglePadding;
                    float yBot = rectCoordsAbso.Max(x => x.bottom) + RectanglePadding;

                    bool isLong = R2sTradeDirection == TradeDirections.Long;
                    
                    // Determine which side to draw rectangle on based on higher values
                    bool hasBidHigher = rectCoordsAbso.Any(x => x.bidHigher && drawBidAbso);
                    bool hasAskHigher = rectCoordsAbso.Any(x => !x.bidHigher && drawAskAbso);

                    if (hasBidHigher)
                    {
                        // Draw rectangle on Bid side (left) - Long absorption
                        float xL = xCenter - dx - maxBidW;
                        float xR = xCenter - dx;
                        var rect = new RectangleF(xL, yTop, xR - xL, yBot - yTop);
                        rt.DrawRectangle(rect, _dxOrangeBrush, 1.5f);
                    }
                    
                    if (hasAskHigher)
                    {
                        // Draw rectangle on Ask side (right) - Short absorption
                        float xL = xCenter + dx;
                        float xR = xCenter + dx + maxAskW;
                        var rect = new RectangleF(xL, yTop, xR - xL, yBot - yTop);
                        rt.DrawRectangle(rect, _dxGoldBrush, 1.5f);
                    }
                }

                // ImbaLocation DOTTED LINE: only when visuals enabled (ImbaCalcMode != None)
                if ((imbalanceEnabled || absoEnabled) && R2sTradeDirection != TradeDirections.None
                    && (HasData(aMin, aMax) || HasData(bMin, bMax)))
                {
                    double barLow = Low.GetValueAt(biAbs);
                    double barHigh = High.GetValueAt(biAbs);

                    double imbaLocationPrice = barHigh > barLow
                        ? barLow + (barHigh - barLow) * ImbaLocation / 100.0
                        : barLow;
                    double absoLocationPrice = barHigh > barLow
                        ? barLow + (barHigh - barLow) * AbsoLocation / 100.0
                        : barLow; // null-range -> draw at this price

                    float yImbaLocation = chartScale.GetYByValue(imbaLocationPrice);
                    float yAbsoLocation = chartScale.GetYByValue(absoLocationPrice);
                    bool isLong = R2sTradeDirection == TradeDirections.Long;

                    if (isLong)
                    {
                        // Imbalance: Long on RIGHT (Ask side), color Cyan
                        if (imbalanceEnabled)
                        {
                            float lineStartX = xCenter;
                            float lineEndX = xCenter + dx + maxAskW;
                            rt.DrawLine(new Vector2(lineStartX, yImbaLocation), new Vector2(lineEndX, yImbaLocation), _dxCyanBrush, 2.0f, _dotStroke);
                        }
                        // Absorption: Long on LEFT (Bid side), color Orange
                        if (absoEnabled && R2sTradeDirection == TradeDirections.Long)
                        {
                            float lineStartX = xCenter - dx - maxBidW;
                            float lineEndX = xCenter;
                            rt.DrawLine(new Vector2(lineStartX, yAbsoLocation), new Vector2(lineEndX, yAbsoLocation), _dxOrangeBrush, 2.0f, _dotStroke);
                        }
                    }
                    else
                    {
                        // Imbalance: Short on LEFT (Bid side), color Violet
                        if (imbalanceEnabled)
                        {
                            float lineStartX = xCenter - dx - maxBidW;
                            float lineEndX = xCenter;
                            rt.DrawLine(new Vector2(lineStartX, yImbaLocation), new Vector2(lineEndX, yImbaLocation), _dxVioletBrush, 2.0f, _dotStroke);
                        }
                        // Absorption: Short on RIGHT (Ask side), color Gold
                        if (absoEnabled && R2sTradeDirection == TradeDirections.Short)
                        {
                            float lineStartX = xCenter;
                            float lineEndX = xCenter + dx + maxAskW;
                            rt.DrawLine(new Vector2(lineStartX, yAbsoLocation), new Vector2(lineEndX, yAbsoLocation), _dxGoldBrush, 2.0f, _dotStroke);
                        }
                    }
                }

            }
        }

        private void RenderBigTradeVolumeLabels(RenderTarget rt, ChartControl chartControl, ChartScale chartScale, int firstBar, int lastBar, int dataLast)
        {
            // Render gray volume labels for Big Trade when enabled (completely independent from imba/abso)
            if (_count <= 0 || dataLast < 0) return;

            float dx = HorizontalPx; // Use same spacing as absorption/imbalance

            for (int bi = firstBar; bi <= lastBar; bi++)
            {
                float xCenter = chartControl.GetXByBarIndex(ChartBars, bi);
                int biAbs = Math.Min(Math.Max(bi, 0), dataLast);
                int barsAgo = dataLast - biAbs;
                if (barsAgo < 0 || barsAgo >= _count)
                    continue;

                // Get Big Trade volume levels
                var (askLevels, askMin, askMax) = GetAskLevelsBigTrade(barsAgo);
                var (bidLevels, bidMin, bidMax) = GetBidLevelsBigTrade(barsAgo);

                if (!HasData(askMin, askMax) && !HasData(bidMin, bidMax))
                    continue;

                int start = MergeMin(askMin, bidMin);
                int end = MergeMax(askMax, bidMax);

                // Determine which side to show volumes based on trade direction and BigTradeInvers
                bool isLong = R2sTradeDirection == TradeDirections.Long;
                bool accumulateAsk = (isLong && !BigTradeInvers) || (!isLong && BigTradeInvers);
                bool accumulateBid = (!isLong && !BigTradeInvers) || (isLong && BigTradeInvers);

                for (int level = start; level <= end; level++)
                {
                    float y = chartScale.GetYByValue(PriceFromLevelBigTrade(level));

                    // Show Ask volumes on right side if accumulating ask volumes
                    if (accumulateAsk)
                    {
                        // Always show volume, even if 0 (not in dictionary)
                        long askVol = askLevels.TryGetValue(level, out var vol) ? vol : 0;
                        string volumeText = askVol.ToString("N0", CultureInfo.InvariantCulture);
                        using (var textLayout = new TextLayout(Globals.DirectWriteFactory, volumeText, _tfNormal, 100, 100))
                        {
                            float textWidth = textLayout.Metrics.Width;
                            float textHeight = textLayout.Metrics.Height;
                            float x = xCenter + dx; // Right side (ask) - use same spacing as absorption/imbalance
                            float textX = x - textWidth / 2.0f;
                            float textY = y - textHeight / 2.0f;
                            rt.DrawTextLayout(new Vector2(textX, textY), textLayout, _dxGrayBrush);
                        }
                    }

                    // Show Bid volumes on left side if accumulating bid volumes
                    if (accumulateBid)
                    {
                        // Always show volume, even if 0 (not in dictionary)
                        long bidVol = bidLevels.TryGetValue(level, out var vol) ? vol : 0;
                        string volumeText = bidVol.ToString("N0", CultureInfo.InvariantCulture);
                        using (var textLayout = new TextLayout(Globals.DirectWriteFactory, volumeText, _tfNormal, 100, 100))
                        {
                            float textWidth = textLayout.Metrics.Width;
                            float textHeight = textLayout.Metrics.Height;
                            float x = xCenter - dx - textWidth; // Left side (bid) - use same spacing as absorption/imbalance
                            float textX = x;
                            float textY = y - textHeight / 2.0f;
                            rt.DrawTextLayout(new Vector2(textX, textY), textLayout, _dxGrayBrush);
                        }
                    }
                }
            }
        }

        private void RenderBigTradeSignals(RenderTarget rt, ChartControl chartControl, ChartScale chartScale, int firstBar, int lastBar, int dataLast)
        {
            // Render Big Trade circles around existing volume labels when they meet the benchmark
            if (_bigTradeSignals.Count == 0) return;

            float dx = HorizontalPx; // Use same spacing as absorption/imbalance

            for (int bi = firstBar; bi <= lastBar; bi++)
            {
                float xCenter = chartControl.GetXByBarIndex(ChartBars, bi);
                int biAbs = Math.Min(Math.Max(bi, 0), dataLast);
                int barsAgo = dataLast - biAbs;
                if (barsAgo < 0 || barsAgo >= _count)
                    continue;

                // Only render Big Trade signals that occurred on this specific bar
                foreach (var signal in _bigTradeSignals)
                {
                    // Only render signals that occurred on this specific bar
                    if (signal.BarIndex != biAbs)
                        continue;

                    // Draw the Big Trade exactly at the price level where it occurred.
                    // We trust that signal.Price corresponds to a traded price inside the bar;
                    // if the circle appears visually outside, that indicates an issue in the data,
                    // not something to "fix" by clamping.
                    float y = chartScale.GetYByValue(signal.Price);
                    
                    // Determine circle color: Red for bid side, Green for ask side
                    var circleBrush = signal.IsBidSide ? _dxRedBrush : _dxGreenBrush;
                    
                    // Use the accumulated Seconds Range volume from the signal itself for the text inside the circle
                    long displayVolume = signal.Volume;
                    string volumeText = displayVolume.ToString("N0", CultureInfo.InvariantCulture);
                    using (var textLayout = new TextLayout(Globals.DirectWriteFactory, volumeText, _tfNormal, 100, 100))
                    {
                        float textWidth = textLayout.Metrics.Width;
                        float textHeight = textLayout.Metrics.Height;
                        
                        // Circle radius should be slightly larger than the text to fit properly
                        float radius = Math.Max(textWidth, textHeight) / 2.0f + 4.0f;
                        
                        // Use exact same positioning logic as volume labels for perfect symmetry
                        float circleCenterX, circleCenterY = y;
                        
                        if (signal.IsBidSide) // Left side (bid)
                        {
                            float x = xCenter - dx - textWidth; // Same as volume labels
                            circleCenterX = x + textWidth / 2.0f; // Center of the text
                        }
                        else // Right side (ask)
                        {
                            float x = xCenter + dx; // Same as volume labels
                            circleCenterX = x; // Ask side centers text at x position
                        }
                        
                   // Draw circle around the existing volume label
                   rt.DrawEllipse(new Ellipse(new Vector2(circleCenterX, circleCenterY), radius, radius), circleBrush, 2.0f);
                   
                   // Draw the volume in bold white inside the circle
                   using (var boldTextLayout = new TextLayout(Globals.DirectWriteFactory, volumeText, _tfBold, 100, 100))
                   {
                       float boldTextWidth = boldTextLayout.Metrics.Width;
                       float boldTextHeight = boldTextLayout.Metrics.Height;
                       float boldTextX = circleCenterX - boldTextWidth / 2.0f;
                       float boldTextY = circleCenterY - boldTextHeight / 2.0f;
                       rt.DrawTextLayout(new Vector2(boldTextX, boldTextY), boldTextLayout, _dxWhiteBrush);
                        }
                    }
                }
            }
        }

        // --- DV/DC block: always draw up to 4 groups, color per prompt ---
        private void RenderDeltaVolumeText(RenderTarget rt, ChartControl chartControl, ChartScale chartScale,
            int firstBar, int lastBar, int dataLast)
        {
            if (_count < 1) return;

            int maxGroups = 4; // fixed by spec
            int formingAbs = dataLast;
            int drawn = 0;

            double[] volBenches = { DeltaVolume1, DeltaVolume2, DeltaVolume3, DeltaVolume4 };
            double[] chgBenches = { DeltaChange1, DeltaChange2, DeltaChange3, DeltaChange4 };

            for (int k = 0; drawn < maxGroups; k++)
            {
                int biAbs = formingAbs - k;
                if (biAbs < 0 || biAbs >= Close.Count) break;
                if (biAbs < firstBar || biAbs > lastBar) continue;

                double dv_i = k < _count ? GetVolDiffForBar(k) : 0.0;  // DV of this bar
                double dv_nx = k + 1 < _count ? GetVolDiffForBar(k + 1) : 0.0;  // DV of next older
                double chgVal = dv_i - dv_nx;

                // Volume display depends on which features are enabled
                double volToDisplay = dv_i; // Default to volume difference
                
                if (ImbaPriceLevelSize == 0 && AbsoPriceLevelSize != 0)
                {
                    // Only absorption enabled - show Bid volume for absorption
                    var (bidLevels, _, _) = GetBidLevels(k);
                    if (bidLevels.Count > 0)
                    {
                        volToDisplay = bidLevels.Values.Sum();
                    }
                }
                else if (ImbaPriceLevelSize != 0 && AbsoPriceLevelSize == 0)
                {
                    // Only imbalance enabled - show volume difference (default behavior)
                    volToDisplay = dv_i;
                }
                else if (ImbaPriceLevelSize != 0 && AbsoPriceLevelSize != 0)
                {
                    // Both enabled - show volume difference (default behavior)
                    volToDisplay = dv_i;
                }
                else
                {
                    // Both disabled - show volume difference (shouldn't happen as rendering is disabled)
                    volToDisplay = dv_i;
                }

                string sVol = volToDisplay.ToString("N0", CultureInfo.InvariantCulture);
                string sChg = chgVal.ToString("N0", CultureInfo.InvariantCulture);
                string sMin = GetBarOpenMinute(biAbs);

                float xCenter = chartControl.GetXByBarIndex(ChartBars, biAbs);
                double barLow = Low.Count > 0
                    ? Low.GetValueAt(Math.Max(0, Math.Min(biAbs, Low.Count - 1)))
                    : Close.GetValueAt(Math.Max(0, Math.Min(biAbs, Close.Count - 1)));

                using (var tlVol = new TextLayout(Globals.DirectWriteFactory, sVol, _tfNormal, 1000, 1000))
                using (var tlChg = new TextLayout(Globals.DirectWriteFactory, sChg, _tfNormal, 1000, 1000))
                using (var tlMin = new TextLayout(Globals.DirectWriteFactory, sMin, _tfNormal, 1000, 1000))
                {
                    float hVol = tlVol.Metrics.Height;
                    float hChg = tlChg.Metrics.Height;
                    float hMin = tlMin.Metrics.Height;

                    float totalH = hVol + DeltaTextGap + hChg + DeltaTextGap + hMin;

                    float yLow = chartScale.GetYByValue(barLow);
                    float yTop = Math.Min(ChartPanel.Y + ChartPanel.H - totalH - 1f, yLow + 4f);
                    float yVol = yTop;
                    float yChg = yVol + hVol + DeltaTextGap;
                    float yMin = yChg + hChg + DeltaTextGap;

                    int slot = drawn; // 0..3

                    // --- Brushes per prompt ---
                    SolidColorBrush volBrush, chgBrush;

                    // DV row brush
                    if (R2sTradeDirection == TradeDirections.None) volBrush = _dxGrayBrush;
                    else if (!IsDeltaVolume) volBrush = _dxGrayBrush;
                    else if (slot >= volBenches.Length ||
                             Math.Abs(volBenches[slot]) <= double.Epsilon) volBrush = _dxLightGrayBrush;
                    else
                    {
                        double vBench = volBenches[slot];
                        // Benchmark logic: independent of direction
                        // If bench > 0: test passes when current value > bench
                        // If bench < 0: test passes when current value < bench
                        bool pass = vBench > 0 ? dv_i > vBench : (vBench < 0 ? dv_i < vBench : false);
                        volBrush = pass ? _dxGreenBrush : _dxRedBrush;
                    }

                    // DC row brush
                    if (R2sTradeDirection == TradeDirections.None) chgBrush = _dxGrayBrush;
                    else if (!IsDeltaChange) chgBrush = _dxGrayBrush;
                    else if (slot >= chgBenches.Length ||
                             Math.Abs(chgBenches[slot]) <= double.Epsilon) chgBrush = _dxLightGrayBrush;
                    else
                    {
                        double cBench = chgBenches[slot];
                        // Benchmark logic: independent of direction
                        // If bench > 0: test passes when current value > bench
                        // If bench < 0: test passes when current value < bench
                        bool pass = cBench > 0 ? chgVal > cBench : (cBench < 0 ? chgVal < cBench : false);
                        chgBrush = pass ? _dxGreenBrush : _dxRedBrush;
                    }

                    float xVol = xCenter - tlVol.Metrics.WidthIncludingTrailingWhitespace * 0.5f;
                    float xChg = xCenter - tlChg.Metrics.WidthIncludingTrailingWhitespace * 0.5f;
                    float xMin = xCenter - tlMin.Metrics.WidthIncludingTrailingWhitespace * 0.5f;

                    rt.DrawTextLayout(new Vector2(xVol, yVol), tlVol, volBrush);
                    rt.DrawTextLayout(new Vector2(xChg, yChg), tlChg, chgBrush);
                    rt.DrawTextLayout(new Vector2(xMin, yMin), tlMin, _dxLightGrayBrush);
                }

                drawn++;
            }
        }
        #endregion

        #region Helpers (buffers, sizing, DX, math)

        // --- Helper: minute string from THIS indicator's Time series ---
        private string GetBarOpenMinute(int absIndex)
        {
            if (Time == null || Time.Count == 0) return ":00";
            int idx = Math.Max(0, Math.Min(absIndex, Time.Count - 1));
            DateTime t = Time.GetValueAt(idx);
            return ":" + t.Minute.ToString("00", CultureInfo.InvariantCulture);
        }

        private (int from, int to) GetClampedVisibleRange()
        {
            if (ChartBars == null) return (int.MaxValue, int.MinValue);
            int from = Math.Max(0, ChartBars.FromIndex);
            int to = Math.Min(CurrentBar, ChartBars.ToIndex);
            if (from > to) return (int.MaxValue, int.MinValue);
            int width = to - from + 1;
            if (width > WarmMaxBars) from = Math.Max(0, to - WarmMaxBars + 1);
            return (from, to);
        }

        private void ThrottledRepaint(DateTime platformTime)
        {
            long sec = platformTime.Ticks / TimeSpan.TicksPerSecond;
            if (sec == Volatile.Read(ref _lastRepaintSecond)) return;
            Interlocked.Exchange(ref _lastRepaintSecond, sec);
            SafeInvalidateVisual();
        }

        private void SafeInvalidateVisual()
        {
            var cc = ChartControl;
            if (cc == null) return;
            if (cc.Dispatcher.CheckAccess()) cc.InvalidateVisual();
            else cc.Dispatcher.InvokeAsync(() => { try { cc.InvalidateVisual(); } catch { } },
                System.Windows.Threading.DispatcherPriority.Render);
        }

        private void EnsureDxResources(RenderTarget rt)
        {
            if (rt == null) return;

            if (_dxWhiteBrush == null) _dxWhiteBrush = new SolidColorBrush(rt, C_White);
            if (_dxGrayBrush == null) _dxGrayBrush = new SolidColorBrush(rt, C_Gray);
            if (_dxCyanBrush == null) _dxCyanBrush = new SolidColorBrush(rt, C_Cyan);
            if (_dxVioletBrush == null) _dxVioletBrush = new SolidColorBrush(rt, C_Violet);
            if (_dxGoldBrush == null) _dxGoldBrush = new SolidColorBrush(rt, C_Gold);
            if (_dxOrangeBrush == null) _dxOrangeBrush = new SolidColorBrush(rt, C_Orange);
            if (_dxGreenBrush == null) _dxGreenBrush = new SolidColorBrush(rt, C_Green);
            if (_dxRedBrush == null) _dxRedBrush = new SolidColorBrush(rt, C_Red);
            if (_dxLightGrayBrush == null) _dxLightGrayBrush = new SolidColorBrush(rt, C_LightGray);

            if (_dxAbsoLongBrush == null) _dxAbsoLongBrush = new SolidColorBrush(rt, C_AbsoLong);
            if (_dxAbsoShortBrush == null) _dxAbsoShortBrush = new SolidColorBrush(rt, C_AbsoShort);
            if (_dxOverlapBrush == null) _dxOverlapBrush = new SolidColorBrush(rt, C_Overlap);

            if (_dxPinkBrush == null) _dxPinkBrush = new SolidColorBrush(rt, C_Pink);

            if (_dotStroke == null)
                _dotStroke = new StrokeStyle(rt.Factory, new StrokeStyleProperties
                {
                    DashStyle = DashStyle.Dot,
                    StartCap = CapStyle.Round,
                    EndCap = CapStyle.Round,
                    DashCap = CapStyle.Round,
                    LineJoin = LineJoin.Miter,
                    MiterLimit = 1f
                });

            if (_tfNormal == null || _tfBold == null) UpdateTextFormats(12f);
        }

        private void DisposeDxResources()
        {
            _tfNormal?.Dispose(); _tfNormal = null;
            _tfBold?.Dispose(); _tfBold = null;
            _dxWhiteBrush?.Dispose(); _dxWhiteBrush = null;
            _dxGrayBrush?.Dispose(); _dxGrayBrush = null;
            _dxCyanBrush?.Dispose(); _dxCyanBrush = null;
            _dxVioletBrush?.Dispose(); _dxVioletBrush = null;
            _dxGoldBrush?.Dispose(); _dxGoldBrush = null;
            _dxOrangeBrush?.Dispose(); _dxOrangeBrush = null;
            _dxGreenBrush?.Dispose(); _dxGreenBrush = null;
            _dxRedBrush?.Dispose(); _dxRedBrush = null;
            _dxLightGrayBrush?.Dispose(); _dxLightGrayBrush = null;

            _dxAbsoLongBrush?.Dispose(); _dxAbsoLongBrush = null;
            _dxAbsoShortBrush?.Dispose(); _dxAbsoShortBrush = null;
            _dxOverlapBrush?.Dispose(); _dxOverlapBrush = null;

            _dxPinkBrush?.Dispose(); _dxPinkBrush = null;
            _dotStroke?.Dispose(); _dotStroke = null;
        }

        private void UpdateTextFormats(float size)
        {
            if (_tfNormal != null && Math.Abs(_tfNormal.FontSize - size) < 0.5f &&
                _tfBold != null && Math.Abs(_tfBold.FontSize - size) < 0.5f) return;

            _tfNormal?.Dispose(); _tfNormal = null;
            _tfBold?.Dispose(); _tfBold = null;

            var factory = Globals.DirectWriteFactory;
            if (factory != null)
            {
                _tfNormal = new TextFormat(factory, "Segoe UI", FontWeight.Normal, FontStyle.Normal, size);
                _tfBold = new TextFormat(factory, "Segoe UI", FontWeight.Bold, FontStyle.Normal, size);
            }
        }

        private float ComputeAutoFontSize(ChartScale cs)
        {
            if (Instrument?.MasterInstrument?.TickSize == null || Close?.Count == 0) return AutoFontMin;

            double tick = Instrument.MasterInstrument.TickSize;
            double mid = Close[0];
            float y0 = cs.GetYByValue(mid);
            float y1 = cs.GetYByValue(mid + tick);
            float pxPerTick = Math.Abs(y1 - y0);
            double raw = AutoFontMin + 2.0 * Math.Sqrt(Math.Max(0.0, pxPerTick));
            return (float)Math.Max(AutoFontMin, Math.Min(AutoFontMax, raw));
        }

        private static bool HasData(int minKey, int maxKey) => minKey <= maxKey;

        private static int MergeMin(int a, int b) => Math.Min(a, b);

        private static int MergeMax(int a, int b) => Math.Max(a, b);

        private double GetBarLowPriceAbs(int absIndex)
        {
            if (Low?.Count == 0) return double.NaN;

            int idx = Math.Max(0, Math.Min(absIndex, Low.Count - 1));
            return Low.GetValueAt(idx);
        }

        private double GetVolDiffForBar(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return 0.0;
            int slot = _head - barsAgo & BufCap - 1; // Explicit ring buffer wrapping
            return _askSumBuf[slot] - (double)_bidSumBuf[slot];
        }

        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetAskLevels(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_askLevelsBuf[slot] ?? s_empty, _askMinBuf[slot], _askMaxBuf[slot]);
        }

        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetBidLevels(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_bidLevelsBuf[slot] ?? s_empty, _bidMinBuf[slot], _bidMaxBuf[slot]);
        }

        // Separate methods for imbalance levels
        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetAskLevelsImba(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_askLevelsImbaBuf[slot] ?? s_empty, _askMinImbaBuf[slot], _askMaxImbaBuf[slot]);
        }

        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetBidLevelsImba(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_bidLevelsImbaBuf[slot] ?? s_empty, _bidMinImbaBuf[slot], _bidMaxImbaBuf[slot]);
        }

        // Separate methods for absorption levels
        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetAskLevelsAbso(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_askLevelsAbsoBuf[slot] ?? s_empty, _askMinAbsoBuf[slot], _askMaxAbsoBuf[slot]);
        }

        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetBidLevelsAbso(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_bidLevelsAbsoBuf[slot] ?? s_empty, _bidMinAbsoBuf[slot], _bidMaxAbsoBuf[slot]);
        }

        // Separate methods for Big Trade levels
        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetAskLevelsBigTrade(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_askLevelsBigTradeBuf[slot] ?? s_empty, _askMinBigTradeBuf[slot], _askMaxBigTradeBuf[slot]);
        }

        private (Dictionary<int, long> Levels, int MinKey, int MaxKey) GetBidLevelsBigTrade(int barsAgo)
        {
            if (barsAgo < 0 || barsAgo >= _count) return (s_empty, int.MaxValue, int.MinValue);
            int slot = _head - barsAgo & BufCap - 1;
            return (_bidLevelsBigTradeBuf[slot] ?? s_empty, _bidMinBigTradeBuf[slot], _bidMaxBigTradeBuf[slot]);
        }

        private static readonly Dictionary<int, long> s_empty = new Dictionary<int, long>(0);

        private double PriceFromLevel(int level)
        {
            // Use the enabled price level size (prefer imbalance, fallback to absorption)
            double priceLevelSize = ImbaPriceLevelSize != 0 ? ImbaPriceLevelSize : AbsoPriceLevelSize;
            int stepTicks = iPrice(priceLevelSize, mDigitsSize);
            if (stepTicks <= 0) stepTicks = 1;
            long totalTicks = (long)level * stepTicks;
            if (totalTicks < 0) totalTicks = 0;
            return dPrice((uint)totalTicks, mDigitsSize);
        }

        private double PriceFromLevelImba(int level)
        {
            int stepTicks = iPrice(ImbaPriceLevelSize, mDigitsSize);
            if (stepTicks <= 0) stepTicks = 1;
            long totalTicks = (long)level * stepTicks;
            if (totalTicks < 0) totalTicks = 0;
            return dPrice((uint)totalTicks, mDigitsSize);
        }

        private double PriceFromLevelAbso(int level)
        {
            int stepTicks = iPrice(AbsoPriceLevelSize, mDigitsSize);
            if (stepTicks <= 0) stepTicks = 1;
            long totalTicks = (long)level * stepTicks;
            if (totalTicks < 0) totalTicks = 0;
            return dPrice((uint)totalTicks, mDigitsSize);
        }

        private double PriceFromLevelBigTrade(int level)
        {
            int stepTicks = iPrice(BigTradePriceLevelSize, mDigitsSize);
            if (stepTicks <= 0) stepTicks = 1;
            long totalTicks = (long)level * stepTicks;
            if (totalTicks < 0) totalTicks = 0;
            return dPrice((uint)totalTicks, mDigitsSize);
        }

        private static int iPrice(double dPrice, double tickSize)
        {
            return Math.Sign(dPrice) * (int)(0.5 + Math.Abs(dPrice) / tickSize);
        }

        private static double dPrice(uint iPrice, double tickSize)
        {
            return tickSize * iPrice;
        }
        #endregion

        #region Signal providers
        public bool DeltaVolumeSignal(StringBuilder sb, bool isGetDebugOpenLog)
        {
            // ALWAYS calculate and show values, regardless of enable state
            // Enable state only controls signal pass/fail for trading decisions
            
            // Compute signal pass/fail (benches w/ direction); only when enabled
            bool canSignal = IsDeltaVolume && R2sTradeDirection != TradeDirections.None;
            double[] benches = { DeltaVolume1, DeltaVolume2, DeltaVolume3, DeltaVolume4 };

            bool anyRequired = false;
            bool passAll = true;

            for (int i = 0; i < 4; i++)
            {
                double bench = benches[i];
                if (Math.Abs(bench) <= double.Epsilon) continue; // don't care
                anyRequired = true;

                bool hasData = i + 1 < _count;
                if (!hasData) { passAll = false; continue; }

                double dv = GetVolDiffForBar(i + 1);
                // Benchmark logic: independent of direction
                // If bench > 0: test passes when current value > bench
                // If bench < 0: test passes when current value < bench
                bool pass = bench > 0 ? dv > bench : (bench < 0 ? dv < bench : false);
                if (!pass) passAll = false;
            }

            bool finalSignal = canSignal && anyRequired && passAll;

            // --- CSV: ALWAYS write values, independent of enable state ---
            if (sb != null)
            {
                // EXTRA = DV[5] (older)
                double extra = 5 < _count ? GetVolDiffForBar(5) : 0.0;
                sb.Append(',').Append(extra.ToString("0", CultureInfo.InvariantCulture));

                // DV[4], DV[3], DV[2], DV[1]
                for (int i = 4; i >= 1; i--)
                {
                    double v = i < _count ? GetVolDiffForBar(i) : 0.0;
                    sb.Append(',').Append(v.ToString("0", CultureInfo.InvariantCulture));
                }
            }

            return finalSignal;
        }

        public bool DeltaChangeSignal(StringBuilder sb, bool isGetDebugOpenLog)
        {
            // ALWAYS calculate and show values, regardless of enable state
            // Enable state only controls signal pass/fail for trading decisions
            
            // Compute signal pass/fail; only when enabled
            bool canSignal = IsDeltaChange && R2sTradeDirection != TradeDirections.None;
            double[] benches = { DeltaChange1, DeltaChange2, DeltaChange3, DeltaChange4 };

            bool anyRequired = false;
            bool passAll = true;

            for (int i = 0; i < 4; i++)
            {
                double bench = benches[i];
                if (Math.Abs(bench) <= double.Epsilon) continue; // don't care
                anyRequired = true;

                bool hasData = i + 2 < _count; // need DV[i+1] and DV[i+2]
                if (!hasData) { passAll = false; continue; }

                double dv_i = GetVolDiffForBar(i + 1);
                double dv_n1 = GetVolDiffForBar(i + 2);
                double dc = dv_i - dv_n1;

                // Benchmark logic: independent of direction
                // If bench > 0: test passes when current value > bench
                // If bench < 0: test passes when current value < bench
                bool pass = bench > 0 ? dc > bench : (bench < 0 ? dc < bench : false);
                if (!pass) passAll = false;
            }

            bool finalSignal = canSignal && anyRequired && passAll;

            // --- CSV: ALWAYS write values, independent of enable state ---
            if (sb != null)
            {
                // DC[4], DC[3], DC[2], DC[1]
                for (int i = 4; i >= 1; i--)
                {
                    double dc;
                    if (i + 1 < _count) // need DV[i] and DV[i+1] in our 1-based terms
                    {
                        double dv_i = GetVolDiffForBar(i);
                        double dv_n1 = GetVolDiffForBar(i + 1);
                        dc = dv_i - dv_n1;
                    }
                    else dc = 0.0;

                    sb.Append(',').Append(dc.ToString("0", CultureInfo.InvariantCulture));
                }
            }

            return finalSignal;
        }

        /// <summary>
        /// Returns true if there exists a valid imbalance stack using unified validation logic.
        /// If isGetDebugOpenLog is true, appends imbalance data to StringBuilder.
        /// Prompt rule: If ImbaPriceLevelSize == 0 -> no computation, signal is always false.
        /// Gate rules: Long imbalance ≤ close & ≤ location (lower right), Short imbalance ≥ close & ≥ location (upper right).
        /// </summary>
        public bool ImbalanceSignal(StringBuilder sb, int barsAgo, bool isGetDebugOpenLog)
        {
            // Hard gate per prompt: no computation, always false.
            if (ImbaPriceLevelSize == 0)
                return false;

            // Always try to get stack info to extract current values
            var stackInfo = ValidateImbalanceStack(barsAgo);
            bool finalSignal = stackInfo.IsValid;

            // Populate StringBuilder if there's a valid signal OR debug logging is requested
            if ((finalSignal || isGetDebugOpenLog) && sb != null)
            {
                // Always try to get current values, even if some gates failed
                if (stackInfo.ValidLevels != null && stackInfo.ValidLevels.Count > 0)
                {
                    // Append metadata
                    sb.Append(','); sb.Append(stackInfo.ValidLevels.Count.ToString());
                    sb.Append(','); sb.Append(stackInfo.CurrentLocationPct.ToString("F2", CultureInfo.InvariantCulture));
                    sb.Append(','); sb.Append(stackInfo.TotalVolumeSum.ToString());

                    // Append ratios (highest level first)
                    for (int i = stackInfo.ValidLevels.Count - 1; i >= 0; i--)
                        sb.Append(',').Append(stackInfo.ValidLevels[i].Ratio.ToString("F1", CultureInfo.InvariantCulture));

                    // Append bid volumes used (highest first)
                    for (int i = stackInfo.ValidLevels.Count - 1; i >= 0; i--)
                        sb.Append(',').Append(stackInfo.ValidLevels[i].BidVolUsed.ToString());

                    // Append ask volumes used (highest first)
                    for (int i = stackInfo.ValidLevels.Count - 1; i >= 0; i--)
                        sb.Append(',').Append(stackInfo.ValidLevels[i].AskVolUsed.ToString());
                }
                else
                {
                    // Placeholders when it's impossible to get current values
                    sb.Append(','); sb.Append(",None");
                    sb.Append(",?"); // location percentage placeholder
                    sb.Append(",?"); // total volume sum placeholder
                    for (int i = 0; i < ImbaStackCount; i++) sb.Append(",?");
                    for (int i = 0; i < ImbaStackCount; i++) sb.Append(",?");
                    for (int i = 0; i < ImbaStackCount; i++) sb.Append(",?");
                }
            }

            return finalSignal;
        }
        #endregion
    }

    #region Gui Helpers
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public sealed class ShowIfAttribute : Attribute
    {
        public string DependentProperty { get; }
        public CompareOp Op { get; }
        public object Value { get; }

        public ShowIfAttribute(string dependentProperty, CompareOp op)
        {
            DependentProperty = dependentProperty;
            Op = op;
            Value = null;
        }

        public ShowIfAttribute(string dependentProperty, CompareOp op, object value)
        {
            DependentProperty = dependentProperty;
            Op = op;
            Value = value;
        }

        // IMPORTANT: prevents AttributeCollection from deduping multiple ShowIfs
        public override object TypeId =>
            $"{GetType().FullName}|{DependentProperty}|{Op}|{(Value == null ? "null" : Convert.ToString(Value, CultureInfo.InvariantCulture))}";
    }

    public class ConditionalVisibilityConverter : IndicatorBaseConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context) => true;

        public override PropertyDescriptorCollection GetProperties(
            ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            // Always work on the live component instance
            var component = (context?.Instance as object[])?.FirstOrDefault()
                            ?? context?.Instance
                            ?? value;

            var all = base.GetProperties(context, component, attributes).Cast<PropertyDescriptor>();

            bool ShouldShow(PropertyDescriptor pd)
            {
                var rules = GetShowIfAttributes(pd, component);
                if (rules.Length == 0)
                    return true;

                foreach (var rule in rules)
                {
                    var dep = TypeDescriptor.GetProperties(component)[rule.DependentProperty];
                    if (dep == null) return true; // fail-open

                    var depVal = dep.GetValue(component);
                    if (depVal is string s) depVal = s.Trim(); // treat whitespace as empty

                    if (!Evaluate(depVal, rule))
                        return false; // hide if rule not satisfied
                }
                return true;
            }

            var filtered = all.Where(ShouldShow).ToArray();
            return new PropertyDescriptorCollection(filtered, true);
        }

        private static ShowIfAttribute[] GetShowIfAttributes(PropertyDescriptor pd, object component)
        {
            // 1) If the PD already has ShowIf, use those and skip reflection entirely.
            var fromPd = pd?.Attributes?.OfType<ShowIfAttribute>()?.ToArray();
            if (fromPd != null && fromPd.Length > 0)
                return fromPd;

            // 2) Otherwise, *safely* probe the declaring type chain.
            var t = component?.GetType();
            while (t != null)
            {
                try
                {
                    var pi = t.GetProperty(
                        pd.Name,
                        System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly);

                    if (pi != null)
                    {
                        var a = (ShowIfAttribute[])Attribute.GetCustomAttributes(pi, typeof(ShowIfAttribute), inherit: true);
                        if (a.Length > 0) return a;
                    }
                }
                catch (System.Reflection.AmbiguousMatchException)
                {
                    // Hidden/duplicated members on this level – treat as "no ShowIf" here.
                    return Array.Empty<ShowIfAttribute>();
                }
                t = t.BaseType;
            }

            return Array.Empty<ShowIfAttribute>();
        }

        private static bool Evaluate(object depVal, ShowIfAttribute rule)
        {
            switch (rule.Op)
            {
                case CompareOp.IsNull: return depVal == null;
                case CompareOp.NotNull: return depVal != null;
                case CompareOp.IsNullOrEmpty: return depVal == null || (depVal is string s1 && string.IsNullOrEmpty(s1));
                case CompareOp.NotNullOrEmpty: return depVal != null && (!(depVal is string s2) || !string.IsNullOrEmpty(s2));
            }

            // From here on, a compare value is expected
            var cmpVal = rule.Value;

            // String compare
            if (depVal is string ds && cmpVal is string cs)
            {
                int cmp = string.Compare(ds, cs, StringComparison.Ordinal);
                return CompareFromInt(cmp, rule.Op);
            }

            // Enum compare (cmpVal can be enum or string name)
            var depType = depVal?.GetType();
            if (depType != null && depType.IsEnum)
            {
                object rhs = cmpVal;
                if (cmpVal is string enumName)
                    rhs = Enum.Parse(depType, enumName, ignoreCase: false);

                int cmp = ((IComparable)Convert.ChangeType(depVal, Enum.GetUnderlyingType(depType), CultureInfo.InvariantCulture))
                            .CompareTo(Convert.ChangeType(rhs, Enum.GetUnderlyingType(depType), CultureInfo.InvariantCulture));
                return CompareFromInt(cmp, rule.Op);
            }

            // Numeric / IComparable compare
            if (depVal is IComparable)
            {
                // Try to unify via decimal first (covers most numeric types), else fall back to double
                try
                {
                    var left = ConvertToComparableNumber(depVal);
                    var right = ConvertToComparableNumber(cmpVal);
                    int cmp = left.CompareTo(right);
                    return CompareFromInt(cmp, rule.Op);
                }
                catch
                {
                    // Last resort: IComparable direct (works for DateTime, etc.)
                    try
                    {
                        var rhs = Convert.ChangeType(cmpVal, depVal.GetType(), CultureInfo.InvariantCulture);
                        int cmp = ((IComparable)depVal).CompareTo(rhs);
                        return CompareFromInt(cmp, rule.Op);
                    }
                    catch { /* fall through */ }
                }
            }

            // Fallback to Equals/NotEquals
            return rule.Op == CompareOp.Equal ? Equals(depVal, cmpVal)
                 : rule.Op == CompareOp.NotEqual ? !Equals(depVal, cmpVal)
                 : false;
        }

        private static decimal ConvertToComparableNumber(object o)
        {
            // Handles bool as 0/1 too, if ever needed
            if (o is null) throw new ArgumentNullException(nameof(o));
            if (o is decimal d) return d;
            if (o is IConvertible) return Convert.ToDecimal(o, CultureInfo.InvariantCulture);
            throw new InvalidCastException();
        }

        private static bool CompareFromInt(int cmp, CompareOp op)
        {
            // cmp < 0 : left < right, cmp == 0 : equal, cmp > 0 : left > right
            return op switch
            {
                CompareOp.Equal => cmp == 0,
                CompareOp.NotEqual => cmp != 0,
                CompareOp.GreaterThan => cmp > 0,
                CompareOp.GreaterOrEqual => cmp >= 0,
                CompareOp.LessThan => cmp < 0,
                CompareOp.LessOrEqual => cmp <= 0,
                _ => false
            };
        }
    }
    #endregion
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SimbaIndi[] cacheSimbaIndi;
		public SimbaIndi SimbaIndi(bool isDeltaVolume, double deltaVolume1, double deltaVolume2, double deltaVolume3, double deltaVolume4, bool isDeltaChange, double deltaChange1, double deltaChange2, double deltaChange3, double deltaChange4, double imbaPriceLevelSize, ImbaAbsoCalcModes imbaCalcMode, double imbaThreshold, double imbaBidMin, double imbaBidMax, double imbaAskMin, double imbaAskMax, int imbaStackCount, double imbaLocation, int imbaMinVolumeSum, double absoPriceLevelSize, ImbaAbsoCalcModes absoCalcMode, double absoThreshold, double absoBidMin, double absoBidMax, double absoAskMin, double absoAskMax, int absoStackCount, double absoLocation, int absoMinVolumeSum, int absoDepth, double bigTradePriceLevelSize, double tradeFilterMin, double tradeFilterMax, bool reconstructTape, bool reconstructTape_UseTimestampsOnly, bool bigTradeInvers, TradeDirections r2sTradeDirection)
		{
			return SimbaIndi(Input, isDeltaVolume, deltaVolume1, deltaVolume2, deltaVolume3, deltaVolume4, isDeltaChange, deltaChange1, deltaChange2, deltaChange3, deltaChange4, imbaPriceLevelSize, imbaCalcMode, imbaThreshold, imbaBidMin, imbaBidMax, imbaAskMin, imbaAskMax, imbaStackCount, imbaLocation, imbaMinVolumeSum, absoPriceLevelSize, absoCalcMode, absoThreshold, absoBidMin, absoBidMax, absoAskMin, absoAskMax, absoStackCount, absoLocation, absoMinVolumeSum, absoDepth, bigTradePriceLevelSize, tradeFilterMin, tradeFilterMax, reconstructTape, reconstructTape_UseTimestampsOnly, bigTradeInvers, r2sTradeDirection);
		}

		public SimbaIndi SimbaIndi(ISeries<double> input, bool isDeltaVolume, double deltaVolume1, double deltaVolume2, double deltaVolume3, double deltaVolume4, bool isDeltaChange, double deltaChange1, double deltaChange2, double deltaChange3, double deltaChange4, double imbaPriceLevelSize, ImbaAbsoCalcModes imbaCalcMode, double imbaThreshold, double imbaBidMin, double imbaBidMax, double imbaAskMin, double imbaAskMax, int imbaStackCount, double imbaLocation, int imbaMinVolumeSum, double absoPriceLevelSize, ImbaAbsoCalcModes absoCalcMode, double absoThreshold, double absoBidMin, double absoBidMax, double absoAskMin, double absoAskMax, int absoStackCount, double absoLocation, int absoMinVolumeSum, int absoDepth, double bigTradePriceLevelSize, double tradeFilterMin, double tradeFilterMax, bool reconstructTape, bool reconstructTape_UseTimestampsOnly, bool bigTradeInvers, TradeDirections r2sTradeDirection)
		{
			if (cacheSimbaIndi != null)
				for (int idx = 0; idx < cacheSimbaIndi.Length; idx++)
					if (cacheSimbaIndi[idx] != null && cacheSimbaIndi[idx].IsDeltaVolume == isDeltaVolume && cacheSimbaIndi[idx].DeltaVolume1 == deltaVolume1 && cacheSimbaIndi[idx].DeltaVolume2 == deltaVolume2 && cacheSimbaIndi[idx].DeltaVolume3 == deltaVolume3 && cacheSimbaIndi[idx].DeltaVolume4 == deltaVolume4 && cacheSimbaIndi[idx].IsDeltaChange == isDeltaChange && cacheSimbaIndi[idx].DeltaChange1 == deltaChange1 && cacheSimbaIndi[idx].DeltaChange2 == deltaChange2 && cacheSimbaIndi[idx].DeltaChange3 == deltaChange3 && cacheSimbaIndi[idx].DeltaChange4 == deltaChange4 && cacheSimbaIndi[idx].ImbaPriceLevelSize == imbaPriceLevelSize && cacheSimbaIndi[idx].ImbaCalcMode == imbaCalcMode && cacheSimbaIndi[idx].ImbaThreshold == imbaThreshold && cacheSimbaIndi[idx].ImbaBidMin == imbaBidMin && cacheSimbaIndi[idx].ImbaBidMax == imbaBidMax && cacheSimbaIndi[idx].ImbaAskMin == imbaAskMin && cacheSimbaIndi[idx].ImbaAskMax == imbaAskMax && cacheSimbaIndi[idx].ImbaStackCount == imbaStackCount && cacheSimbaIndi[idx].ImbaLocation == imbaLocation && cacheSimbaIndi[idx].ImbaMinVolumeSum == imbaMinVolumeSum && cacheSimbaIndi[idx].AbsoPriceLevelSize == absoPriceLevelSize && cacheSimbaIndi[idx].AbsoCalcMode == absoCalcMode && cacheSimbaIndi[idx].AbsoThreshold == absoThreshold && cacheSimbaIndi[idx].AbsoBidMin == absoBidMin && cacheSimbaIndi[idx].AbsoBidMax == absoBidMax && cacheSimbaIndi[idx].AbsoAskMin == absoAskMin && cacheSimbaIndi[idx].AbsoAskMax == absoAskMax && cacheSimbaIndi[idx].AbsoStackCount == absoStackCount && cacheSimbaIndi[idx].AbsoLocation == absoLocation && cacheSimbaIndi[idx].AbsoMinVolumeSum == absoMinVolumeSum && cacheSimbaIndi[idx].AbsoDepth == absoDepth && cacheSimbaIndi[idx].BigTradePriceLevelSize == bigTradePriceLevelSize && cacheSimbaIndi[idx].TradeFilterMin == tradeFilterMin && cacheSimbaIndi[idx].TradeFilterMax == tradeFilterMax && cacheSimbaIndi[idx].ReconstructTape == reconstructTape && cacheSimbaIndi[idx].ReconstructTape_UseTimestampsOnly == reconstructTape_UseTimestampsOnly && cacheSimbaIndi[idx].BigTradeInvers == bigTradeInvers && cacheSimbaIndi[idx].R2sTradeDirection == r2sTradeDirection && cacheSimbaIndi[idx].EqualsInput(input))
						return cacheSimbaIndi[idx];
			return CacheIndicator<SimbaIndi>(new SimbaIndi(){ IsDeltaVolume = isDeltaVolume, DeltaVolume1 = deltaVolume1, DeltaVolume2 = deltaVolume2, DeltaVolume3 = deltaVolume3, DeltaVolume4 = deltaVolume4, IsDeltaChange = isDeltaChange, DeltaChange1 = deltaChange1, DeltaChange2 = deltaChange2, DeltaChange3 = deltaChange3, DeltaChange4 = deltaChange4, ImbaPriceLevelSize = imbaPriceLevelSize, ImbaCalcMode = imbaCalcMode, ImbaThreshold = imbaThreshold, ImbaBidMin = imbaBidMin, ImbaBidMax = imbaBidMax, ImbaAskMin = imbaAskMin, ImbaAskMax = imbaAskMax, ImbaStackCount = imbaStackCount, ImbaLocation = imbaLocation, ImbaMinVolumeSum = imbaMinVolumeSum, AbsoPriceLevelSize = absoPriceLevelSize, AbsoCalcMode = absoCalcMode, AbsoThreshold = absoThreshold, AbsoBidMin = absoBidMin, AbsoBidMax = absoBidMax, AbsoAskMin = absoAskMin, AbsoAskMax = absoAskMax, AbsoStackCount = absoStackCount, AbsoLocation = absoLocation, AbsoMinVolumeSum = absoMinVolumeSum, AbsoDepth = absoDepth, BigTradePriceLevelSize = bigTradePriceLevelSize, TradeFilterMin = tradeFilterMin, TradeFilterMax = tradeFilterMax, ReconstructTape = reconstructTape, ReconstructTape_UseTimestampsOnly = reconstructTape_UseTimestampsOnly, BigTradeInvers = bigTradeInvers, R2sTradeDirection = r2sTradeDirection }, input, ref cacheSimbaIndi);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SimbaIndi SimbaIndi(bool isDeltaVolume, double deltaVolume1, double deltaVolume2, double deltaVolume3, double deltaVolume4, bool isDeltaChange, double deltaChange1, double deltaChange2, double deltaChange3, double deltaChange4, double imbaPriceLevelSize, ImbaAbsoCalcModes imbaCalcMode, double imbaThreshold, double imbaBidMin, double imbaBidMax, double imbaAskMin, double imbaAskMax, int imbaStackCount, double imbaLocation, int imbaMinVolumeSum, double absoPriceLevelSize, ImbaAbsoCalcModes absoCalcMode, double absoThreshold, double absoBidMin, double absoBidMax, double absoAskMin, double absoAskMax, int absoStackCount, double absoLocation, int absoMinVolumeSum, int absoDepth, double bigTradePriceLevelSize, double tradeFilterMin, double tradeFilterMax, bool reconstructTape, bool reconstructTape_UseTimestampsOnly, bool bigTradeInvers, TradeDirections r2sTradeDirection)
		{
			return indicator.SimbaIndi(Input, isDeltaVolume, deltaVolume1, deltaVolume2, deltaVolume3, deltaVolume4, isDeltaChange, deltaChange1, deltaChange2, deltaChange3, deltaChange4, imbaPriceLevelSize, imbaCalcMode, imbaThreshold, imbaBidMin, imbaBidMax, imbaAskMin, imbaAskMax, imbaStackCount, imbaLocation, imbaMinVolumeSum, absoPriceLevelSize, absoCalcMode, absoThreshold, absoBidMin, absoBidMax, absoAskMin, absoAskMax, absoStackCount, absoLocation, absoMinVolumeSum, absoDepth, bigTradePriceLevelSize, tradeFilterMin, tradeFilterMax, reconstructTape, reconstructTape_UseTimestampsOnly, bigTradeInvers, r2sTradeDirection);
		}

		public Indicators.SimbaIndi SimbaIndi(ISeries<double> input , bool isDeltaVolume, double deltaVolume1, double deltaVolume2, double deltaVolume3, double deltaVolume4, bool isDeltaChange, double deltaChange1, double deltaChange2, double deltaChange3, double deltaChange4, double imbaPriceLevelSize, ImbaAbsoCalcModes imbaCalcMode, double imbaThreshold, double imbaBidMin, double imbaBidMax, double imbaAskMin, double imbaAskMax, int imbaStackCount, double imbaLocation, int imbaMinVolumeSum, double absoPriceLevelSize, ImbaAbsoCalcModes absoCalcMode, double absoThreshold, double absoBidMin, double absoBidMax, double absoAskMin, double absoAskMax, int absoStackCount, double absoLocation, int absoMinVolumeSum, int absoDepth, double bigTradePriceLevelSize, double tradeFilterMin, double tradeFilterMax, bool reconstructTape, bool reconstructTape_UseTimestampsOnly, bool bigTradeInvers, TradeDirections r2sTradeDirection)
		{
			return indicator.SimbaIndi(input, isDeltaVolume, deltaVolume1, deltaVolume2, deltaVolume3, deltaVolume4, isDeltaChange, deltaChange1, deltaChange2, deltaChange3, deltaChange4, imbaPriceLevelSize, imbaCalcMode, imbaThreshold, imbaBidMin, imbaBidMax, imbaAskMin, imbaAskMax, imbaStackCount, imbaLocation, imbaMinVolumeSum, absoPriceLevelSize, absoCalcMode, absoThreshold, absoBidMin, absoBidMax, absoAskMin, absoAskMax, absoStackCount, absoLocation, absoMinVolumeSum, absoDepth, bigTradePriceLevelSize, tradeFilterMin, tradeFilterMax, reconstructTape, reconstructTape_UseTimestampsOnly, bigTradeInvers, r2sTradeDirection);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SimbaIndi SimbaIndi(bool isDeltaVolume, double deltaVolume1, double deltaVolume2, double deltaVolume3, double deltaVolume4, bool isDeltaChange, double deltaChange1, double deltaChange2, double deltaChange3, double deltaChange4, double imbaPriceLevelSize, ImbaAbsoCalcModes imbaCalcMode, double imbaThreshold, double imbaBidMin, double imbaBidMax, double imbaAskMin, double imbaAskMax, int imbaStackCount, double imbaLocation, int imbaMinVolumeSum, double absoPriceLevelSize, ImbaAbsoCalcModes absoCalcMode, double absoThreshold, double absoBidMin, double absoBidMax, double absoAskMin, double absoAskMax, int absoStackCount, double absoLocation, int absoMinVolumeSum, int absoDepth, double bigTradePriceLevelSize, double tradeFilterMin, double tradeFilterMax, bool reconstructTape, bool reconstructTape_UseTimestampsOnly, bool bigTradeInvers, TradeDirections r2sTradeDirection)
		{
			return indicator.SimbaIndi(Input, isDeltaVolume, deltaVolume1, deltaVolume2, deltaVolume3, deltaVolume4, isDeltaChange, deltaChange1, deltaChange2, deltaChange3, deltaChange4, imbaPriceLevelSize, imbaCalcMode, imbaThreshold, imbaBidMin, imbaBidMax, imbaAskMin, imbaAskMax, imbaStackCount, imbaLocation, imbaMinVolumeSum, absoPriceLevelSize, absoCalcMode, absoThreshold, absoBidMin, absoBidMax, absoAskMin, absoAskMax, absoStackCount, absoLocation, absoMinVolumeSum, absoDepth, bigTradePriceLevelSize, tradeFilterMin, tradeFilterMax, reconstructTape, reconstructTape_UseTimestampsOnly, bigTradeInvers, r2sTradeDirection);
		}

		public Indicators.SimbaIndi SimbaIndi(ISeries<double> input , bool isDeltaVolume, double deltaVolume1, double deltaVolume2, double deltaVolume3, double deltaVolume4, bool isDeltaChange, double deltaChange1, double deltaChange2, double deltaChange3, double deltaChange4, double imbaPriceLevelSize, ImbaAbsoCalcModes imbaCalcMode, double imbaThreshold, double imbaBidMin, double imbaBidMax, double imbaAskMin, double imbaAskMax, int imbaStackCount, double imbaLocation, int imbaMinVolumeSum, double absoPriceLevelSize, ImbaAbsoCalcModes absoCalcMode, double absoThreshold, double absoBidMin, double absoBidMax, double absoAskMin, double absoAskMax, int absoStackCount, double absoLocation, int absoMinVolumeSum, int absoDepth, double bigTradePriceLevelSize, double tradeFilterMin, double tradeFilterMax, bool reconstructTape, bool reconstructTape_UseTimestampsOnly, bool bigTradeInvers, TradeDirections r2sTradeDirection)
		{
			return indicator.SimbaIndi(input, isDeltaVolume, deltaVolume1, deltaVolume2, deltaVolume3, deltaVolume4, isDeltaChange, deltaChange1, deltaChange2, deltaChange3, deltaChange4, imbaPriceLevelSize, imbaCalcMode, imbaThreshold, imbaBidMin, imbaBidMax, imbaAskMin, imbaAskMax, imbaStackCount, imbaLocation, imbaMinVolumeSum, absoPriceLevelSize, absoCalcMode, absoThreshold, absoBidMin, absoBidMax, absoAskMin, absoAskMax, absoStackCount, absoLocation, absoMinVolumeSum, absoDepth, bigTradePriceLevelSize, tradeFilterMin, tradeFilterMax, reconstructTape, reconstructTape_UseTimestampsOnly, bigTradeInvers, r2sTradeDirection);
		}
	}
}

#endregion
