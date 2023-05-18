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
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }
        Methods methods = new Methods();
        private void button1_Click(object sender, EventArgs e)
        {
            ShiftStatics shiftStatics = new ShiftStatics();
            methods.fillPanel(pn_main, shiftStatics, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryStatics salaryStatics = new SalaryStatics();
            methods.fillPanel(pn_main, salaryStatics, 1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkTimeStatics workTimeStatics = new WorkTimeStatics();
            methods.fillPanel(pn_main, workTimeStatics, 1);
        }
    }
}
