using Emgu.CV.Saliency;
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
using VisioForge.Libs.TagLib.Jpeg;

namespace WinFormsRestaurant
{
    public partial class SalaryStatics : Form
    {
        public SalaryStatics()
        {
            InitializeComponent();
        }
        Statics_Class statics = new Statics_Class();
        private void SalaryStatics_Load(object sender, EventArgs e)
        {
            Series series = new Series();
            chart_salary.Series.Clear();
            chart_salary.ChartAreas[0].AxisX.Interval = 1;
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            series.IsVisibleInLegend = false;
            DataTable table = statics.getSalaryStatics();
            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row[1], row[2]);
            }
            chart_salary.Series.Add(series);
            chart_salary.Titles.Add("Salary Statics");
            chart_salary.Titles[0].Font = new Font(chart_salary.Titles[0].Font.FontFamily, 20, FontStyle.Bold);
            chart_salary.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_salary.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_salary.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_salary.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_salary.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_salary.ChartAreas[0].AxisY.Title = "(VND)";
            chart_salary.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chart_salary.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;
        }
    }
}
