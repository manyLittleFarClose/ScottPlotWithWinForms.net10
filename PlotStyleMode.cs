using System;
using System.Collections.Generic;
using System.Text;

namespace WinCharts_first_try_nail
{
    internal class PlotStyleMode
    {
        public ScottPlot.Color PlotColor { get; set; } = ScottPlot.Colors.Black;
        public ScottPlot.Color FillColor { get; set; } = ScottPlot.Colors.White;
        public ScottPlot.Color BackgroundStyleColor { get; set; } = ScottPlot.Colors.DarkGray;
        public ScottPlot.Color AxisStyleFillColor { get; set; } = ScottPlot.Colors.DarkGray.WithAlpha(0.1f);
        public ScottPlot.Color MajoreLineStyleColor { get; set; } = ScottPlot.Colors.DarkGray.WithAlpha(0.15f);
        public ScottPlot.Color MinoreLineStyleColor { get; set; } = ScottPlot.Colors.DarkGray.WithAlpha(0.05f);

        public double LineWidth { get; set; } = 3;
        public double MinoreLineStyleWidth { get; set; } = 1;
        public double MaxoreLineStyleWidth { get; set; } = 2;
         
    }
}
