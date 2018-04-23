using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_PolarLineChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl polarLineChart = new ChartControl();

            // Add a polar series to it.
            Series series1 = new Series("Series 1", ViewType.PolarLine);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint(0, 90));
            series1.Points.Add(new SeriesPoint(90, 70));
            series1.Points.Add(new SeriesPoint(180, 50));
            series1.Points.Add(new SeriesPoint(270, 100));

            // Add the series to the chart.
            polarLineChart.Series.Add(series1);

            // Flip the diagram (if necessary).
            ((PolarDiagram)polarLineChart.Diagram).StartAngleInDegrees = 180;
            ((PolarDiagram)polarLineChart.Diagram).RotationDirection =
                RadarDiagramRotationDirection.Counterclockwise;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Polar Line Chart";
            polarLineChart.Titles.Add(chartTitle1);
            polarLineChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            polarLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(polarLineChart);
        }

    }
}