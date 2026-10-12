using ScottPlot;
using ScottPlot.Plottables;
using ScottPlot.WinForms;

namespace WinCharts_first_try_nail
{
    /*
     * В ScottPlot  плох для отрисовывания миллионов точек
     * По этой причине будет исспользован SignalXY
     * Можно переписать под работу с массивами (менее затратная работа по памяти)
     */
    
    public partial class Form1 : Form
    {
        List<PlotStyleMode> stylesPlot = new();
        List<double> dataX = new();
        List<double> dataY = new();
        
        ScottPlot.Plot myPlot = new();
        private void addStyle()
        {

        }
        void generateGraphic(List <double> dataX, List <double> dataY)
        { 
            for(int i = 0; i < 20000; i++)
            {
                int k = i - 10000;
                dataY.Add(k * k);
                dataX.Add(k);
            }
        }
        
        //Добавить переключалку тем
        public Form1()
        {
            InitializeComponent();

            generateGraphic(dataX, dataY);
            double[] xArray = dataX.ToArray();
            double[] yArray = dataY.ToArray();
            var sig = formsPlot1.Plot.Add.SignalXY(xArray, yArray); ;//Signal(Generate.SquareWaveFromSines());
            sig.Color = new("#2b9433");
            sig.LineWidth = 3;

            var fillColor = ScottPlot.Color.FromHex("#888888");
            formsPlot1.Plot.FigureBackground.Color = new("#1c1c1e");
            formsPlot1.Plot.Axes.Color(new("#888888"));
            formsPlot1.Plot.Grid.XAxisStyle.FillColor1 = fillColor.WithAlpha(0.1f);
            formsPlot1.Plot.Grid.YAxisStyle.FillColor1 = fillColor.WithAlpha(0.1f);

            formsPlot1.Plot.DataBackground.Color = ScottPlot.Colors.DarkGrey;

            formsPlot1.Plot.Grid.XAxisStyle.MajorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(0.15f);
            formsPlot1.Plot.Grid.YAxisStyle.MajorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(0.15f);
            formsPlot1.Plot.Grid.XAxisStyle.MinorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(0.05f);
            formsPlot1.Plot.Grid.YAxisStyle.MinorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(0.05f);

            formsPlot1.Plot.Grid.XAxisStyle.MinorLineStyle.Width = 1;
            formsPlot1.Plot.Grid.YAxisStyle.MinorLineStyle.Width = 1;

           
            formsPlot1.Refresh();
            
        }


    }
}
