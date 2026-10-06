using System;
using System.Collections.Generic;
using System.Text;
using ScottPlot.WinForms;
namespace WinCharts_first_try_nail
{
    public class ScottPlotStaled : FormsPlot
    {
        private PlotStyle _plotStyle;
        protected PlotStyle plotStyle{ get { return _plotStyle; } set { _plotStyle = value; applyStyle(); } }
        public ScottPlotStaled(PlotStyle style) 
        {
            plotStyle = style; 
        }
        public ScottPlotStaled()
        {
            plotStyle = new PlotStyle();
        }
        protected void applyStyle()
        {
            Plot.FigureBackground.Color = _plotStyle.plotBackgroundColor;
            Plot.Axes.Color(_plotStyle.axesColor);

            Plot.Grid.XAxisStyle.FillColor1 = _plotStyle.fillColor.WithAlpha(10);
            Plot.Grid.YAxisStyle.FillColor1 = _plotStyle.fillColor.WithAlpha(10);

            Plot.DataBackground.Color = _plotStyle.dataPlotBackgroundColor;

            Plot.Grid.XAxisStyle.MajorLineStyle.Color = _plotStyle.majoreGridLineStyle.WithAlpha(15);
            Plot.Grid.YAxisStyle.MajorLineStyle.Color = _plotStyle.majoreGridLineStyle.WithAlpha(15);
            Plot.Grid.XAxisStyle.MinorLineStyle.Color = _plotStyle.minoreGridLineStyle.WithAlpha(5);
            Plot.Grid.YAxisStyle.MinorLineStyle.Color = _plotStyle.minoreGridLineStyle.WithAlpha(5);

            Plot.Grid.XAxisStyle.MinorLineStyle.Width = _plotStyle.minoreGridLineWidth;
            Plot.Grid.YAxisStyle.MinorLineStyle.Width = _plotStyle.minoreGridLineWidth;
            Plot.Grid.XAxisStyle.MajorLineStyle.Width = _plotStyle.majoreGridLineWidth;
            Plot.Grid.YAxisStyle.MajorLineStyle.Width = _plotStyle.majoreGridLineWidth;
        }

    }
}
