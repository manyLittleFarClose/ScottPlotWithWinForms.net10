using System;
using System.Collections.Generic;
using System.Text;
using ScottPlot;
using ScottPlot.WinForms;
namespace WinCharts_first_try_nail
{
    
    public class PlotStyle
    {
        public ScottPlot.Color plotBackgroundColor { get; set; } = ScottPlot.Colors.White;
        public ScottPlot.Color dataPlotBackgroundColor { get; set; } = ScottPlot.Colors.White;
        public ScottPlot.Color axesColor { get; set; } = ScottPlot.Colors.Black;
        public ScottPlot.Color fillColor { get; set; } = ScottPlot.Colors.Black;
        public ScottPlot.Color majoreGridLineStyle { get; set; } = ScottPlot.Colors.Black;
        public ScottPlot.Color minoreGridLineStyle { get; set; } = ScottPlot.Colors.Black;
        public float minoreGridLineWidth { get; set; } = 0.5f;
        public float majoreGridLineWidth { get; set; } = 0.5f;
    }
}
