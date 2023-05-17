using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsRestaurant
{
    public partial class ShiftStatics : Form
    {
        public ShiftStatics()
        {
            InitializeComponent();
        }
        Statics_Class statics = new Statics_Class();
        private void ShiftStatics_Load(object sender, EventArgs e)
        {
            Series series = new Series();
            Series series1 = new Series();
            Series series2 = new Series();
            series.Color = Color.Green;
            series1.Color = Color.Red;
            series2.Color = Color.Pink;
            series.LegendText = "Worked Shifts";
            series1.LegendText = "Absent Shifts";
            series2.LegendText = "Scheduled Shifts";
            chart_shift.Series.Clear();
            chart_shift.ChartAreas[0].AxisX.Interval = 1;
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            DataTable table = statics.getShiftStatics();
            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row[1], row[3]);
                series1.Points.AddXY(row[1], row[4]);
                series2.Points.AddXY(row[1], row[2]);
            }
            chart_shift.Series.Add(series);
            chart_shift.Series.Add(series1);
            chart_shift.Series.Add(series2);
            chart_shift.Titles.Add("Shift Statics");
            chart_shift.Titles[0].Font = new Font(chart_shift.Titles[0].Font.FontFamily, 20, FontStyle.Bold);
            chart_shift.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_shift.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_shift.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_shift.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_shift.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_shift.ChartAreas[0].AxisY.Title = "(Shift)";
            chart_shift.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chart_shift.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;

        }
    }
}
