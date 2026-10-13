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
        void generateGraphic(List <double> dataX, List <double> dataY)
        { 
            for(int i = 0; i < 20000; i++)
            {
                int k = i - 10000;
                dataY.Add(k * k);
                dataX.Add(k);
            }
        }
        PlotStyleMode generateRandomeStyle()
        {
            PlotStyleMode StyleMode;
            Random random = new Random();
            List<ScottPlot.Color> col = new List<ScottPlot.Color> { ScottPlot.Colors.Gray, ScottPlot.Colors.Aqua, ScottPlot.Colors.Pink, ScottPlot.Colors.DeepPink, ScottPlot.Colors.HotPink, ScottPlot.Colors.LightPink, ScottPlot.Colors.Bisque, ScottPlot.Colors.Brown, ScottPlot.Colors.DarkRed, 
                ScottPlot.Colors.Gold};
            StyleMode.AxisColor = random.Next();
            return ;
        }
        //Добавить переключалку тем
        public Form1()
        {
            InitializeComponent();

            generateGraphic(dataX, dataY);
            double[] xArray = dataX.ToArray();
            double[] yArray = dataY.ToArray();
            
            var sig = formsPlot1.Plot.Add.SignalXY(xArray, yArray); ;//Signal(Generate.SquareWaveFromSines());
            stylesPlot.Add(new PlotStyleMode());
            stylesPlot[0].Apply(formsPlot1);
            
            /*
            IEnumerable<IPlottable> plots = formsPlot1.Plot.GetPlottables();
            foreach (var p in plots)
            {
                if (p is SignalXY s)
                {
                    s.Color = new ScottPlot.Color("#ff0000");
                }
            }

            foreach (var p in plots)
            {
                if (p is SignalXY)
                {
                    SignalXY s = (SignalXY) p ;
                    s.Color = new ScottPlot.Color("#ff0000");
                }
            }
            */
            
            formsPlot1.Refresh();
            
        }


    }
}
