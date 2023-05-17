using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }
        Methods methods = new Methods();
        private void bt_Dashboard_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Dashboard(), 1);
        }

        private void bt_ManageAccount_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new ManageAccount(), 1);
        }

        private void bt_ManageShift_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new ShiftManagement(), 1);
        }

        private void bt_SummarizeSalary_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new SalarySummary(), 1);
        }

        private void bt_statistics_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Statics(), 1);
        }

        private void Manage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
