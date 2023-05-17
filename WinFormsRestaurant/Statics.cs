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

        private void button1_Click(object sender, EventArgs e)
        {
            ShiftStatics shiftStatics = new ShiftStatics();
            shiftStatics.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryStatics salaryStatics = new SalaryStatics();
            salaryStatics.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkTimeStatics workTimeStatics = new WorkTimeStatics();
            workTimeStatics.Show(this);
        }
    }
}
