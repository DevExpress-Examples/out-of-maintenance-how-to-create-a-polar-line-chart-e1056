Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_PolarLineChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            ' Create a new chart.
            Dim polarLineChart As New ChartControl()

            ' Add a polar series to it.
            Dim series1 As New Series("Series 1", ViewType.PolarLine)

            ' Populate the series with points.
            series1.Points.Add(New SeriesPoint(0, 90))
            series1.Points.Add(New SeriesPoint(90, 70))
            series1.Points.Add(New SeriesPoint(180, 50))
            series1.Points.Add(New SeriesPoint(270, 100))

            ' Add the series to the chart.
            polarLineChart.Series.Add(series1)

            ' Flip the diagram (if necessary).
            CType(polarLineChart.Diagram, PolarDiagram).StartAngleInDegrees = 180
            CType(polarLineChart.Diagram, PolarDiagram).RotationDirection = _
                RadarDiagramRotationDirection.Counterclockwise

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Polar Line Chart"
            polarLineChart.Titles.Add(chartTitle1)
            polarLineChart.Legend.Visible = False

            ' Add the chart to the form.
            polarLineChart.Dock = DockStyle.Fill
            Me.Controls.Add(polarLineChart)
        End Sub

	End Class
End Namespace