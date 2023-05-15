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
            DataTable table = statics.getSalaryStatics();
            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row[1], row[2]);
            }
            chart_salary.Series.Add(series);
        }
    }
}
