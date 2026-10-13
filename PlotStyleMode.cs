using Microsoft.VisualBasic.ApplicationServices;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinCharts_first_try_nail
{
    internal class PlotStyleMode
    {
        public void Apply(FormsPlot plotControl)
        {
            plotControl.Plot.FigureBackground.Color = BackgroundStyleColor;
            plotControl.Plot.Axes.Color(AxisColor);
            plotControl.Plot.Grid.XAxisStyle.FillColor1 = AxisStyleFillColor;
            plotControl.Plot.Grid.YAxisStyle.FillColor1 = AxisStyleFillColor;

            plotControl.Plot.Grid.XAxisStyle.MajorLineStyle.Color = MajoreLineStyleColor;
            plotControl.Plot.Grid.YAxisStyle.MajorLineStyle.Color = MajoreLineStyleColor;

            plotControl.Plot.Grid.XAxisStyle.MinorLineStyle.Color = MinoreLineStyleColor;
            plotControl.Plot.Grid.YAxisStyle.MinorLineStyle.Color = MinoreLineStyleColor;

            plotControl.Plot.Grid.XAxisStyle.MinorLineStyle.Width = MinoreLineStyleWidth;
            plotControl.Plot.Grid.YAxisStyle.MinorLineStyle.Width = MinoreLineStyleWidth;

            plotControl.Plot.Grid.XAxisStyle.MajorLineStyle.Width = MajoreLineStyleWidth;
            plotControl.Plot.Grid.YAxisStyle.MinorLineStyle.Width = MajoreLineStyleWidth;

            IEnumerable<SignalXY> splots = plotControl.Plot.GetPlottables<SignalXY>();
            foreach(SignalXY signal in splots)
            {
                signal.LineWidth = LineWidth;
            }
        }
        public ScottPlot.Color PlotColor { get; set; } = ScottPlot.Colors.Black;
        public ScottPlot.Color FillColor { get; set; } = ScottPlot.Colors.White;
        public ScottPlot.Color BackgroundStyleColor { get; set; } = ScottPlot.Colors.DarkGray;
        public ScottPlot.Color AxisStyleFillColor { get; set; } = ScottPlot.Colors.DarkGray.WithAlpha(0.1f);
        public ScottPlot.Color MajoreLineStyleColor { get; set; } = ScottPlot.Colors.DarkGray.WithAlpha(0.15f);
        public ScottPlot.Color MinoreLineStyleColor { get; set; } = ScottPlot.Colors.DarkGray.WithAlpha(0.05f);
        public ScottPlot.Color AxisColor { get; set; } = ScottPlot.Colors.Black;
        public float LineWidth { get; set; } = 3;
        public float MinoreLineStyleWidth { get; set; } = 1;
        public float MajoreLineStyleWidth { get; set; } = 2;
         
    }
}
