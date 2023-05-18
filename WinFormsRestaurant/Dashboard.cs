using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsRestaurant
{
    public partial class Dashboard : Form
    {
        public Button currentButton;
        Employee_Class emp = new Employee_Class();
        Dashboard_Class dashboard = new Dashboard_Class();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            lb_date.Text = dt_date.Text;
            currentButton = bt_shift1;
            ShiftButtonClickUI(currentButton);
            lb_total.Text = "" + emp.amountOfEmloyees();
            updateLabel(6, 10);
            list_ingredient.DataSource = dashboard.getIngredient();
            list_ingredient.Columns[0].Width = 300;
        }
        public Dashboard()
        {
            InitializeComponent();
        }
        public void ShiftButtonClickUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = bt_shift1.FlatAppearance.BorderColor;
            if (currentButton!=null && currentButton!=btn)
            {
                currentButton.BackColor = Color.FromArgb(219, 250, 255);
            }
            currentButton = btn;
        }
        DateTime currentDate = DateTime.Now.Date;
        public void updateLabel(int startHour, int endHour)
        {
            lb_scheduled.Text = "" + emp.scheduledToday(currentButton.Text);
            lb_checkin.Text = "" + emp.checkedIN(currentButton.Text);
            lb_working.Text = "" + emp.working(currentButton.Text);
            DateTime start = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, startHour, 0, 0);
            DateTime end = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, endHour, 0, 0);
            lb_orders.Text = "" + dashboard.numberOfOrders(start, end);
            lb_diners.Text = "" + dashboard.numberOfDiners(start, end);
            lb_revenue.Text = "" + dashboard.totalOfRevenue(start, end);

            //pie
            chart_bestseller.Series.Clear();
            chart_bestseller.Titles.Clear();
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;

            foreach (DataRow row in dashboard.getBestSeller(start, end).Rows)
            {
                string name = row["name"].ToString();
                double total = Convert.ToDouble(row["total"]);

                series2.Points.AddXY(name, total);
            }

            chart_bestseller.Series.Add(series2);
            chart_bestseller.Titles.Add("Best Seller");
            chart_bestseller.Titles[0].Font = new Font(chart_bestseller.Titles[0].Font.FontFamily, 20, FontStyle.Bold);

            //col
            Series series = new Series();
            chart_order.Series.Clear();
            chart_order.Titles.Clear();
            chart_order.ChartAreas[0].AxisX.Interval = 1;
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            series.IsVisibleInLegend = false;
            DataTable table = dashboard.getOrdersperHour(start,end);
            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row[0], row[1]);
            }
            chart_order.Series.Add(series);
            chart_order.Titles.Add("Orders By Hours");
            chart_order.Titles[0].Font = new Font(chart_order.Titles[0].Font.FontFamily, 20, FontStyle.Bold);
            chart_order.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_order.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_order.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_order.ChartAreas[0].AxisX.Title = "(Orders)";
            chart_order.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_order.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_order.ChartAreas[0].AxisY.Title = "(Hour)";
            chart_order.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chart_order.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;
        }
        private void bt_shift1_Click(object sender, EventArgs e)
        {

            ShiftButtonClickUI(sender);
            updateLabel(6, 10);
        }

        private void bt_shift2_Click(object sender, EventArgs e)
        {

            ShiftButtonClickUI(sender);
            updateLabel(11, 15);
        }

        private void bt_shift3_Click(object sender, EventArgs e)
        {

            ShiftButtonClickUI(sender);
            updateLabel(18, 22);
        }

        private void lb_date_Click(object sender, EventArgs e)
        {
            //dt_date.Select();
            //SendKeys.Send("%{DOWN}"); //Alt+Down
        }

        private void dt_date_ValueChanged(object sender, EventArgs e)
        {
            lb_date.Text = dt_date.Text;
        }


    }
}
