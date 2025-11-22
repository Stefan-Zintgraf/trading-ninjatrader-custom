#region Using declarations
using NinjaTrader.Cbi;
using NinjaTrader.Data;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.NinjaScript;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;                // Stopwatch + Debugger.Launch()
using System.Linq;
using System.Threading;                  // Interlocked
using System.Windows.Threading;          // Dispatcher
using System.Xml.Serialization;
using Brush = System.Windows.Media.Brush;
#endregion

// ============================================================================
// Moving Bars – Indicator (SharpDX overlay), TickReplay-ready
// - OHLCV per second from OnMarketData (MarketDataType.Last)
// - Slot index = (current second) % PeriodSeconds
// - One slot finalized per elapsed second (with gap-fill rules)
// - Throttled redraw (default 1000 ms) marshaled onto UI thread
// - Debugger.Launch() available via parameter (default: off)
// - DEBUG RENDER: draws ONLY slot index 0 (offset 0 seconds) as requested
// ============================================================================

namespace NinjaTrader.NinjaScript.Indicators
{
    public class MovingBarsIndicator : Indicator
    {
        #region === Public parameters ===
        [NinjaScriptProperty, Range(1, 3600)]
        [Display(Name = "PeriodSeconds", GroupName = "Parameters", Order = 0)]
        public int PeriodSeconds { get; set; } = 60;

        [NinjaScriptProperty, Range(0, 3600)]
        [Display(Name = "MaxSubSeries (0 = auto)", GroupName = "Parameters", Order = 1)]
        public int MaxSubSeries { get; set; } = 0;  // >= PeriodSeconds

        [NinjaScriptProperty, Range(1, 5000)]
        [Display(Name = "HistoryVisible (per slot)", GroupName = "Parameters", Order = 2)]
        public int HistoryVisible { get; set; } = 200;

        [NinjaScriptProperty]
        [Display(Name = "UseSessionFilter", GroupName = "Parameters", Order = 3)]
        public bool UseSessionFilter { get; set; } = true;

        [NinjaScriptProperty]
        [Display(Name = "EnsureMinBodyPixels", GroupName = "Parameters", Order = 4)]
        public bool EnsureMinBodyPixels { get; set; } = false;

        [NinjaScriptProperty, Range(100, 5000)]
        [Display(Name = "RedrawThrottleMs", GroupName = "Performance", Order = 20)]
        public int RedrawThrottleMs { get; set; } = 1000;   // 1 draw/sec by default

        [NinjaScriptProperty]
        [Display(Name = "EnableDebuggerLaunch", GroupName = "Diagnostics", Order = 30)]
        public bool EnableDebuggerLaunch { get; set; } = false;

        // Styling
        [XmlIgnore, Display(Name = "Up Brush", GroupName = "Style", Order = 40)]
        public Brush UpBrush { get; set; } = System.Windows.Media.Brushes.LimeGreen;
        [Browsable(false)] public string UpBrushSerializable { get => Serialize.BrushToString(UpBrush); set => UpBrush = Serialize.StringToBrush(value); }

        [XmlIgnore, Display(Name = "Down Brush", GroupName = "Style", Order = 41)]
        public Brush DownBrush { get; set; } = System.Windows.Media.Brushes.OrangeRed;
        [Browsable(false)] public string DownBrushSerializable { get => Serialize.BrushToString(DownBrush); set => DownBrush = Serialize.StringToBrush(value); }

        [XmlIgnore, Display(Name = "Outline Brush", GroupName = "Style", Order = 42)]
        public Brush OutlineBrush { get; set; } = System.Windows.Media.Brushes.Gray;
        [Browsable(false)] public string OutlineBrushSerializable { get => Serialize.BrushToString(OutlineBrush); set => OutlineBrush = Serialize.StringToBrush(value); }
        #endregion

        #region === Internal data structures ===
        private class SlotBar
        {
            public DateTime Time;
            public double Open, High, Low, Close;
            public long Volume;
            public bool HasData;

            public void Reset(DateTime start)
            {
                Time = start;
                Open = High = Low = Close = double.NaN;
                Volume = 0;
                HasData = false;
            }

            public void Update(double price, long vol, DateTime tickTime)
            {
                if (!HasData)
                {
                    Open = High = Low = Close = price;
                    Time = tickTime; // keep ms from first tick
                    Volume = vol;
                    HasData = true;
                }
                else
                {
                    if (price > High) High = price;
                    if (price < Low) Low = price;
                    Close = price;
                    Volume += vol;
                }
            }

            public void GapFillFrom(double closeRef)
            {
                Open = High = Low = Close = closeRef;
                Volume = 0;
                HasData = false; // synthetic
            }

            public SlotBar CloneFinal() => new SlotBar
            {
                Time = Time,
                Open = Open,
                High = High,
                Low = Low,
                Close = Close,
                Volume = Volume,
                HasData = HasData
            };
        }

        private class Slot
        {
            public readonly int Index;
            public readonly Deque<SlotBar> History;
            public SlotBar Current;

            public Slot(int index, int historyCapacity)
            {
                Index = index;
                History = new Deque<SlotBar>(Math.Max(8, historyCapacity));
                Current = new SlotBar();
                Current.Reset(DateTime.MinValue);
            }

            public void EnsureCapacity(int historyVisible)
            {
                History.Capacity = Math.Max(History.Capacity, Math.Max(8, historyVisible));
            }
        }

        // tiny deque with capacity
        private class Deque<T> : LinkedList<T>
        {
            public int Capacity { get; set; }
            public Deque(int capacity) { Capacity = capacity; }
            public void PushBack(T item)
            {
                AddLast(item);
                while (Count > Capacity)
                    RemoveFirst();
            }
        }

        private readonly object mSync = new object();
        private List<Slot> mSlots;
        private int mSlotCount;
        private DateTime mLastProcessedSecond = DateTime.MinValue;
        private int mActiveSlot = -1;
        private double mLastKnownClose = double.NaN;

        // Sessions
        private SessionIterator mSessionIterator;
        private DateTime mSessBegin = Core.Globals.MinDate;
        private DateTime mSessEnd = Core.Globals.MinDate;

        // DX brushes
        private SolidColorBrush mUpDx, mDownDx, mOutlineDx;

        // Throttle state (Stopwatch-based monotonic ms)
        private long _nextRedrawAtMs = 0;
        #endregion

        #region === NinjaScript plumbing ===
        protected override void OnStateChange()
        {
            if (State == State.SetDefaults)
            {
                Name = "_Moving Bars";
                Description = "Per-second OHLCV visualization built from Last ticks. Enable Tick Replay for historical.";
                Calculate = Calculate.OnEachTick;
                IsOverlay = true;              // only here!
                IsSuspendedWhileInactive = true;
            }
            else if (State == State.Configure)
            {
                mSlotCount = Math.Max(1, PeriodSeconds);
                if (MaxSubSeries > 0 && MaxSubSeries < mSlotCount)
                    MaxSubSeries = mSlotCount;
            }
            else if (State == State.DataLoaded)
            {
                if (EnableDebuggerLaunch && !Debugger.IsAttached)
                {
                    // as requested: keep Debugger.Launch() in the code
                    //Debugger.Launch();
                }

                lock (mSync)
                {
                    mSlots = new List<Slot>(mSlotCount);
                    for (int i = 0; i < mSlotCount; i++)
                        mSlots.Add(new Slot(i, HistoryVisible));

                    mLastProcessedSecond = DateTime.MinValue;
                    mActiveSlot = -1;
                    mLastKnownClose = double.NaN;

                    mSessionIterator = Bars != null ? new SessionIterator(Bars) : null;
                    mSessBegin = mSessEnd = Core.Globals.MinDate;

                    _nextRedrawAtMs = 0; // reset throttle
                }
            }
            else if (State == State.Terminated)
            {
                DisposeDeviceResources();
            }
        }

        protected override void OnBarUpdate() { /* not used */ }

        public override void OnRenderTargetChanged()
        {
            DisposeDeviceResources();
            if (RenderTarget == null) return;
            mUpDx = new SolidColorBrush(RenderTarget, ToColor4(UpBrush));
            mDownDx = new SolidColorBrush(RenderTarget, ToColor4(DownBrush));
            mOutlineDx = new SolidColorBrush(RenderTarget, ToColor4(OutlineBrush));
        }

        protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
        {
            if (chartControl == null || chartScale == null || mSlots == null) return;
            var panel = ChartPanel; if (panel == null) return;

            DateTime tMin = chartControl.GetTimeByX((int)panel.X);
            DateTime tMax = chartControl.GetTimeByX((int)(panel.X + panel.W));

            int px0 = chartControl.GetXByTime(tMin);
            int px1 = chartControl.GetXByTime(tMin.AddSeconds(1));
            float candleWidth = Math.Max(1f, Math.Abs(px1 - px0) - 1f);

            // ===== DEBUG VIEW: draw ONLY slot index 0 (offset 0 seconds) =====
            lock (mSync)
            {
                if (mSlots.Count > 0)
                {
                    var slot0 = mSlots[0];

                    foreach (var bar in slot0.History)
                    {
                        if (bar.Time < tMin || bar.Time > tMax) continue;
                        DrawCandle(chartControl, chartScale, bar, candleWidth);
                    }

                    if (mActiveSlot == 0 && slot0.Current != null && !double.IsNaN(slot0.Current.Open))
                    {
                        var b = slot0.Current.CloneFinal();
                        if (b.Time >= tMin && b.Time <= tMax)
                            DrawCandle(chartControl, chartScale, b, candleWidth);
                    }
                }
            }
            // ===== /DEBUG VIEW =====
        }
        #endregion

        #region === Market data & slot mechanics ===
        protected override void OnMarketData(MarketDataEventArgs e)
        {
            if (e.MarketDataType != MarketDataType.Last) return;

            lock (mSync)
            {
                DateTime tickTime = e.Time;

                // Session-Filter
                if (UseSessionFilter && Bars != null && mSessionIterator != null)
                {
                    if (!IsTimeInSession(tickTime))
                    {
                        if (mLastProcessedSecond == DateTime.MinValue)
                            mLastProcessedSecond = FloorToSecond(tickTime);
                        return;
                    }
                }

                var secNow = FloorToSecond(tickTime);
                int slotIdx = SlotForTime(tickTime);

                // finalize every elapsed second
                if (mLastProcessedSecond != DateTime.MinValue)
                {
                    var prev = mLastProcessedSecond;
                    while (prev < secNow)
                    {
                        prev = prev.AddSeconds(1);
                        int toFinalize = SlotForTime(prev);
                        bool gapAllowed = !UseSessionFilter || IsTimeInSession(prev);
                        FinalizeSlot(toFinalize, prev, gapAllowed);
                    }
                }

                // slot switch?
                if (mActiveSlot != slotIdx)
                {
                    if (mActiveSlot >= 0)
                        FinalizeSlot(mActiveSlot, secNow, gapAllowed: true);

                    mActiveSlot = slotIdx;
                    var s = mSlots[mActiveSlot];
                    if (double.IsNaN(s.Current.Open))
                        s.Current.Reset(tickTime);
                }

                // update current slot with this tick
                var slot = mSlots[mActiveSlot];
                if (double.IsNaN(slot.Current.Open))
                    slot.Current.Reset(tickTime);

                slot.Current.Update(e.Price, SafeVol(e.Volume), tickTime);
                mLastKnownClose = slot.Current.Close;
                mLastProcessedSecond = secNow;
            }

            // Redraw (throttled)
            RequestRedrawThrottled();
        }

        private void FinalizeSlot(int slotIndex, DateTime barEndSecond, bool gapAllowed)
        {
            var s = mSlots[slotIndex];

            if (double.IsNaN(s.Current.Open))
                s.Current.Reset(barEndSecond);

            if (!s.Current.HasData && gapAllowed)
            {
                double closeRef =
                    s.History.Count > 0 ? s.History.Last.Value.Close :
                    (!double.IsNaN(mLastKnownClose) && !double.IsInfinity(mLastKnownClose) ? mLastKnownClose : 0.0);

                s.Current.Time = barEndSecond;
                s.Current.GapFillFrom(closeRef);
            }
            else if (!s.Current.HasData && !gapAllowed)
            {
                s.Current.Reset(DateTime.MinValue);
                return;
            }

            if (!double.IsNaN(s.Current.Open))
                s.History.PushBack(s.Current.CloneFinal());

            s.EnsureCapacity(HistoryVisible);
            s.Current.Reset(DateTime.MinValue);

            if (s.History.Count > 0)
                mLastKnownClose = s.History.Last.Value.Close;
        }
        #endregion

        #region === Helpers ===
        private static DateTime FloorToSecond(DateTime t) =>
            new DateTime(t.Year, t.Month, t.Day, t.Hour, t.Minute, t.Second, t.Kind);

        private int SlotForTime(DateTime t) =>
            Math.Abs((int)(t - t.Date).TotalSeconds) % Math.Max(1, PeriodSeconds);

        private bool IsTimeInSession(DateTime t)
        {
            if (Bars == null || mSessionIterator == null) return true;

            if (mSessBegin != Core.Globals.MinDate && mSessEnd != Core.Globals.MinDate &&
                t >= mSessBegin && t < mSessEnd) return true;

            mSessionIterator.GetNextSession(t, true);
            mSessBegin = mSessionIterator.ActualSessionBegin;
            mSessEnd = mSessionIterator.ActualSessionEnd;
            return t >= mSessBegin && t < mSessEnd;
        }

        private static long SafeVol(double v)
        {
            if (double.IsNaN(v) || double.IsInfinity(v)) return 0;
            if (v < 0) return 0;
            if (v > long.MaxValue) return long.MaxValue;
            return (long)Math.Round(v);
        }

        private static Color4 ToColor4(Brush b)
        {
            var solid = b as System.Windows.Media.SolidColorBrush;
            var c = (solid ?? System.Windows.Media.Brushes.White).Color;
            return new Color4(c.ScR, c.ScG, c.ScB, c.ScA);
        }

        private void DisposeDeviceResources()
        {
            mUpDx?.Dispose(); mUpDx = null;
            mDownDx?.Dispose(); mDownDx = null;
            mOutlineDx?.Dispose(); mOutlineDx = null;
        }

        private static long NowMs()
        {
            // monotonic clock from Stopwatch
            return (long)(Stopwatch.GetTimestamp() * 1000.0 / Stopwatch.Frequency);
        }

        private void RequestRedrawThrottled()
        {
            var cc = ChartControl;
            if (cc == null) return;
            var disp = cc.Dispatcher;
            if (disp == null) return;

            long now = NowMs();
            int throttle = Math.Max(50, RedrawThrottleMs);

            long next = Interlocked.Read(ref _nextRedrawAtMs);
            if (now < next) return;

            Interlocked.Exchange(ref _nextRedrawAtMs, now + throttle);

            if (disp.CheckAccess())
                cc.InvalidateVisual();
            else
                disp.BeginInvoke(DispatcherPriority.Render, (Action)(() =>
                {
                    try { cc.InvalidateVisual(); } catch { /* chart may be disposed */ }
                }));
        }

        private void DrawCandle(ChartControl cc, ChartScale cs, SlotBar bar, float candleWidth)
        {
            if (RenderTarget == null) return;
            if (double.IsNaN(bar.Open) || double.IsNaN(bar.Close) || double.IsNaN(bar.High) || double.IsNaN(bar.Low))
                return;

            int x0 = cc.GetXByTime(bar.Time);
            int x1 = cc.GetXByTime(bar.Time.AddSeconds(1));
            float x = x0;
            float w = Math.Max(1f, Math.Min(Math.Abs(x1 - x0) - 1f, candleWidth));

            float yOpen = (float)cs.GetYByValue(bar.Open);
            float yClose = (float)cs.GetYByValue(bar.Close);
            float yHigh = (float)cs.GetYByValue(bar.High);
            float yLow = (float)cs.GetYByValue(bar.Low);

            bool up = bar.Close >= bar.Open;
            var fill = up ? mUpDx : mDownDx;
            var outline = mOutlineDx;

            float top = Math.Min(yOpen, yClose);
            float bot = Math.Max(yOpen, yClose);
            if (EnsureMinBodyPixels && Math.Abs(bot - top) < 1f)
            {
                float mid = (yOpen + yClose) * 0.5f;
                top = mid - 0.5f;
                bot = mid + 0.5f;
            }

            var rect = new RectangleF(x - w * 0.5f, top, x + w * 0.5f, bot);
            RenderTarget.FillRectangle(rect, fill);
            RenderTarget.DrawRectangle(rect, outline, 1f);

            RenderTarget.DrawLine(new Vector2(x, yHigh), new Vector2(x, top), outline, 1f);
            RenderTarget.DrawLine(new Vector2(x, bot), new Vector2(x, yLow), outline, 1f);
        }
        #endregion
    }
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private MovingBarsIndicator[] cacheMovingBarsIndicator;
		public MovingBarsIndicator MovingBarsIndicator(int periodSeconds, int maxSubSeries, int historyVisible, bool useSessionFilter, bool ensureMinBodyPixels, int redrawThrottleMs, bool enableDebuggerLaunch)
		{
			return MovingBarsIndicator(Input, periodSeconds, maxSubSeries, historyVisible, useSessionFilter, ensureMinBodyPixels, redrawThrottleMs, enableDebuggerLaunch);
		}

		public MovingBarsIndicator MovingBarsIndicator(ISeries<double> input, int periodSeconds, int maxSubSeries, int historyVisible, bool useSessionFilter, bool ensureMinBodyPixels, int redrawThrottleMs, bool enableDebuggerLaunch)
		{
			if (cacheMovingBarsIndicator != null)
				for (int idx = 0; idx < cacheMovingBarsIndicator.Length; idx++)
					if (cacheMovingBarsIndicator[idx] != null && cacheMovingBarsIndicator[idx].PeriodSeconds == periodSeconds && cacheMovingBarsIndicator[idx].MaxSubSeries == maxSubSeries && cacheMovingBarsIndicator[idx].HistoryVisible == historyVisible && cacheMovingBarsIndicator[idx].UseSessionFilter == useSessionFilter && cacheMovingBarsIndicator[idx].EnsureMinBodyPixels == ensureMinBodyPixels && cacheMovingBarsIndicator[idx].RedrawThrottleMs == redrawThrottleMs && cacheMovingBarsIndicator[idx].EnableDebuggerLaunch == enableDebuggerLaunch && cacheMovingBarsIndicator[idx].EqualsInput(input))
						return cacheMovingBarsIndicator[idx];
			return CacheIndicator<MovingBarsIndicator>(new MovingBarsIndicator(){ PeriodSeconds = periodSeconds, MaxSubSeries = maxSubSeries, HistoryVisible = historyVisible, UseSessionFilter = useSessionFilter, EnsureMinBodyPixels = ensureMinBodyPixels, RedrawThrottleMs = redrawThrottleMs, EnableDebuggerLaunch = enableDebuggerLaunch }, input, ref cacheMovingBarsIndicator);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.MovingBarsIndicator MovingBarsIndicator(int periodSeconds, int maxSubSeries, int historyVisible, bool useSessionFilter, bool ensureMinBodyPixels, int redrawThrottleMs, bool enableDebuggerLaunch)
		{
			return indicator.MovingBarsIndicator(Input, periodSeconds, maxSubSeries, historyVisible, useSessionFilter, ensureMinBodyPixels, redrawThrottleMs, enableDebuggerLaunch);
		}

		public Indicators.MovingBarsIndicator MovingBarsIndicator(ISeries<double> input , int periodSeconds, int maxSubSeries, int historyVisible, bool useSessionFilter, bool ensureMinBodyPixels, int redrawThrottleMs, bool enableDebuggerLaunch)
		{
			return indicator.MovingBarsIndicator(input, periodSeconds, maxSubSeries, historyVisible, useSessionFilter, ensureMinBodyPixels, redrawThrottleMs, enableDebuggerLaunch);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.MovingBarsIndicator MovingBarsIndicator(int periodSeconds, int maxSubSeries, int historyVisible, bool useSessionFilter, bool ensureMinBodyPixels, int redrawThrottleMs, bool enableDebuggerLaunch)
		{
			return indicator.MovingBarsIndicator(Input, periodSeconds, maxSubSeries, historyVisible, useSessionFilter, ensureMinBodyPixels, redrawThrottleMs, enableDebuggerLaunch);
		}

		public Indicators.MovingBarsIndicator MovingBarsIndicator(ISeries<double> input , int periodSeconds, int maxSubSeries, int historyVisible, bool useSessionFilter, bool ensureMinBodyPixels, int redrawThrottleMs, bool enableDebuggerLaunch)
		{
			return indicator.MovingBarsIndicator(input, periodSeconds, maxSubSeries, historyVisible, useSessionFilter, ensureMinBodyPixels, redrawThrottleMs, enableDebuggerLaunch);
		}
	}
}

#endregion
