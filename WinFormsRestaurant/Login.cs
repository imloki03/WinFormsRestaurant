﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
       
            panel1.BackColor = Color.FromArgb(100, panel1.BackColor);
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Login_Class login = new Login_Class();
            string user = tb_username.Text;
            string password = tb_password.Text; 
            if (login.checklogin(user,password))
            { 
                OverView overView = new OverView();
                StaticVars_Class.username = user; 
                overView.Show(this);
            }
            else
                MessageBox.Show("Ivalid Username or Password","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void pb_hidepassword_Click(object sender, EventArgs e)
        {
            if (tb_password.PasswordChar == '\0')
                tb_password.PasswordChar = '*';
            else
                tb_password.PasswordChar = '\0';
        }
    }
}
