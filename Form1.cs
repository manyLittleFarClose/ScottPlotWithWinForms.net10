using ScottPlot;
using ScottPlot.WinForms;

namespace WinCharts_first_try_nail
{
    public partial class Form1 : Form
    {
        double[] dataX = { 1, 2, 3, 4, 5, 6 };
        double[] dataY = { 1, 4, 9, 16, 25, 36 };
        ScottPlot.Plot myPlot = new();
        //Добавить переключалку тем
        public Form1()
        {
            InitializeComponent();
            //formsPlot1 = new FormsPlot()
            //{
            //    Dock = DockStyle.Fill
            //};
            var sig = formsPlot1.Plot.Add.Scatter(dataX, dataY); ;//Signal(Generate.SquareWaveFromSines());
            sig.Color = new("#2b9433");
            //sig.AlwaysUseLowDensityMode = true;
            sig.LineWidth = 3;
            var fillColor = ScottPlot.Color.FromHex("#888888");

            formsPlot1.Plot.FigureBackground.Color = new("#1c1c1e");
            formsPlot1.Plot.Axes.Color(ScottPlot.Colors.Bisque);

            formsPlot1.Plot.Grid.XAxisStyle.FillColor1 = fillColor.WithAlpha(10);
            formsPlot1.Plot.Grid.YAxisStyle.FillColor1 = fillColor.WithAlpha(10);

            formsPlot1.Plot.DataBackground.Color = ScottPlot.Colors.DarkGrey;

            formsPlot1.Plot.Grid.XAxisStyle.MajorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(15);
            formsPlot1.Plot.Grid.YAxisStyle.MajorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(15);
            formsPlot1.Plot.Grid.XAxisStyle.MinorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(5);
            formsPlot1.Plot.Grid.YAxisStyle.MinorLineStyle.Color = ScottPlot.Colors.White.WithAlpha(5);

            formsPlot1.Plot.Grid.XAxisStyle.MinorLineStyle.Width = 1;
            formsPlot1.Plot.Grid.YAxisStyle.MinorLineStyle.Width = 1;

            formsPlot1.Plot.Add.Scatter(dataX, dataY);
            this.Controls.Add(formsPlot1);
            formsPlot1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scottPlotStaled1_Load(object sender, EventArgs e)
        {

        }
    }
}
