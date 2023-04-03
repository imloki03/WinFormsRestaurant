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
    public partial class Dashboard : Form
    {
        public Button currentButton;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lb_date.Text = dt_date.Text;

        }
        public Dashboard()
        {
            InitializeComponent();
        }
        public void ShiftButtonClickUI(object button)
        {
            var btn = (Button)button;
            //highlight button
            btn.BackColor = bt_shift1.FlatAppearance.BorderColor;
            //btn.ForeColor = Color.White;
            //unhighlight button
            if (currentButton!=null && currentButton!=btn)
            {
                currentButton.BackColor = Color.FromArgb(219, 250, 255);
            }
            currentButton = btn;
        }

        private void bt_shift1_Click(object sender, EventArgs e)
        {

            ShiftButtonClickUI(sender);
        }

        private void bt_shift2_Click(object sender, EventArgs e)
        {

            ShiftButtonClickUI(sender);
        }

        private void bt_shift3_Click(object sender, EventArgs e)
        {

            ShiftButtonClickUI(sender);
        }

        private void lb_date_Click(object sender, EventArgs e)
        {
            dt_date.Select();
            SendKeys.Send("%{DOWN}"); //Alt+Down
        }

        private void dt_date_ValueChanged(object sender, EventArgs e)
        {
            lb_date.Text = dt_date.Text;
        }


    }
}
