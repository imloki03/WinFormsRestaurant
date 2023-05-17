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
    public partial class WorkTimeStatics : Form
    {
        public WorkTimeStatics()
        {
            InitializeComponent();
        }
        Statics_Class statics = new Statics_Class();
        private void WorkTimeStatics_Load(object sender, EventArgs e)
        {
            Series series = new Series();
            chart_worktime.Series.Clear();
            chart_worktime.ChartAreas[0].AxisX.Interval = 1;
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            series.IsVisibleInLegend = false;
            DataTable table = statics.getTimeWorkingStatics();
            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row[1], row[2]);
            }
            chart_worktime.Series.Add(series);
            chart_worktime.Titles.Add("Work Time Statics");
            chart_worktime.Titles[0].Font = new Font(chart_worktime.Titles[0].Font.FontFamily, 20, FontStyle.Bold);
            chart_worktime.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_worktime.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_worktime.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_worktime.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_worktime.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_worktime.ChartAreas[0].AxisY.Title = "(Hour)";
            chart_worktime.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chart_worktime.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;
        }
    }
}
