using Gst;
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
using DateTime = System.DateTime;

namespace WinFormsRestaurant
{
    public partial class OverView : Form
    {
        public OverView()
        {
            InitializeComponent();
        }

        Methods methods = new Methods();
        WorkSchedule_Class workSchedule = new WorkSchedule_Class();
  
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

            methods.standardrizeDtgridview(dv_workschedule);
            SqlCommand cmd = new SqlCommand("SELECT * FROM WorkSchedule w, Shifts s, Employee e WHERE w.ShiftID = s.ShiftID AND e.EmployeeID=w.EmployeeID AND e.Account = '"+StaticVars_Class.username+"'");
            DataTable table = workSchedule.getWorkSchedule(cmd);
            for(int i=0; i < (((DateTime)table.Rows[table.Rows.Count - 1][5] - DateTime.Now.AddDays(1)).TotalDays); i++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                col.HeaderText = DateTime.Now.AddDays(i+1).ToString("dddd");
                dv_workschedule.Columns.Add(col);
            }
            string[] rowheaders = { "Morning", "Noon", "Afternoon" };
            for(int i=0;i<3;i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = rowheaders[i];
                for (int j = 0; j < dv_workschedule.Columns.Count; j++)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell(); // Use an appropriate cell template
                    row.Cells.Add(cell);
                }
                dv_workschedule.Rows.Add(row);
            }
            Color[] colors = { Color.Pink, Color.Green, Color.Blue, Color.Red };
            int st = 0;
            string[] shifttime = { "6:00AM - 10:00AM", "11:00AM - 3:00PM", "6:00PM - 10:00PM" };
            for(int i=0;i<dv_workschedule.ColumnCount;i++)
            {
                for (int j=0;j<dv_workschedule.Rows.Count;j++)
                {
                    if (((DateTime)table.Rows[st][5]).Date == DateTime.Now.AddDays(i + 1).Date && shifttime[j] == table.Rows[st][6].ToString() )
                    {
                        dv_workschedule.Rows[j].Cells[i].Style.BackColor = colors[0];
                        st++;
                    }
                }
            }
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
