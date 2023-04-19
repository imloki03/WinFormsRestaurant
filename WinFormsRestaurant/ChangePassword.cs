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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            string password = tb_currentpassword.Text;
            string newpassword = tb_newpassword.Text;
            string confirmpassword = tb_confirmpassword.Text;
            Login_Class login = new Login_Class();
            if (login.changepassword(password, StaticVars_Class.username, newpassword, confirmpassword))
            {
                MessageBox.Show("Change Password Succesfully","Change Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Change Password Failed", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
