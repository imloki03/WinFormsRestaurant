using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    public partial class OverView : Form
    {
        public OverView()
        {
            InitializeComponent();
        }

        private void bt_changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        string python = "C:\\Users\\21110\\AppData\\Local\\Programs\\Python\\Python311\\python.exe";
        string script = "E:\\Python\\FaceRecog\\recognition.py";
        private void OverView_Load(object sender, EventArgs e)
        {
            Employee_Class employee = new Employee_Class();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE account = @acc");
            command.Parameters.Add("@acc", SqlDbType.NVarChar).Value = StaticVars_Class.username;
            DataTable table_emp = employee.getEmployee(command);
            lb_fullname.Text = table_emp.Rows[0]["Name"].ToString();
            DateTime dateOnly = (DateTime)table_emp.Rows[0]["BirthDate"];
            lb_birth.Text = dateOnly.Date.ToString("dd/MM/yyyy");
            lb_phone.Text = table_emp.Rows[0]["Phone"].ToString();
            lb_jobtitle.Text = table_emp.Rows[0]["JobTitle"].ToString();
            //byte[] imageData = (byte[])table_emp.Rows[0]["Picture"];
            //Bitmap imageBitmap = new Bitmap(new MemoryStream(imageData));
            //overView.pb_avatar.Image = imageBitmap;
            bool gender = Convert.ToBoolean(table_emp.Rows[0]["Gender"]);

            if (gender)
                rb_male.Checked = true;
            else
                rb_female.Checked = true;
        }

        private void bt_checkout_Click(object sender, EventArgs e)
        {
            CheckIN_OUT checkIN_OUT = new CheckIN_OUT();
            checkIN_OUT.Show();
        }

        private void bt_checkin_Click(object sender, EventArgs e)
        {
            CheckIN_OUT checkIN_OUT = new CheckIN_OUT();
            checkIN_OUT.Show();
        }
    }
}
