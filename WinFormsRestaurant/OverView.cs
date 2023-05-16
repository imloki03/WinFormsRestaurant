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
using VisioForge.MediaFramework.Classes;
using VisioForge.MediaFramework.ONVIF;
using Color = System.Drawing.Color;
using DateTime = System.DateTime;

namespace WinFormsRestaurant
{
    public partial class OverView : Form
    {
        public OverView()
        {
            InitializeComponent();
        }
        Shift_Class shift = new Shift_Class();
        Methods methods = new Methods();
        WorkSchedule_Class workSchedule = new WorkSchedule_Class();
  
        private void bt_changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }
        public void fillGrid(DateTime start, DateTime end)
        {
            dv_workschedule.Rows.Clear();
            dv_workschedule.Columns.Clear();
            DateTime current = start;
            SqlCommand cmd = new SqlCommand("SELECT * FROM WorkSchedule w, Shifts s, Employee e WHERE w.ShiftID = s.ShiftID AND e.EmployeeID=w.EmployeeID AND e.Account = '" + StaticVars_Class.username + "'");
            DataTable table = workSchedule.getWorkSchedule(cmd);
            for (int i = 0; i < 7; i++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                col.HeaderText = current.AddDays(i).ToString("dddd");
                dv_workschedule.Columns.Add(col);
            }
            string[] rowheaders = { "Breakfast", "Lunch", "Dinner" };
            for (int i = 0; i < 3; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = rowheaders[i];
                for (int j = 0; j < dv_workschedule.Columns.Count; j++)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    row.Cells.Add(cell);
                }
                dv_workschedule.Rows.Add(row);
            }
            Color[] colors = { Color.Pink, Color.Green, Color.Blue, Color.Red };
            int st = 0,r=0; 
            while (((DateTime)table.Rows[st][5]).Date != current.Date.AddDays(r))
            {
                st++;
                if (st == table.Rows.Count)
                {
                    st = 0;
                    r++;
                }
            }
            string[] shifttime = { "6:00AM - 10:00AM", "11:00AM - 3:00PM", "6:00PM - 10:00PM" };
            for (int i = 0; i < dv_workschedule.ColumnCount; i++)
            {
                for (int j = 0; j < dv_workschedule.Rows.Count; j++)
                {
                    if (st == table.Rows.Count)
                        break;
                    if (((DateTime)table.Rows[st][5]).Date == current.AddDays(i).Date && shifttime[j] == table.Rows[st][6].ToString())
                    {
                        dv_workschedule.Rows[j].Cells[i].Style.BackColor = colors[0];
                        DateTime checkin = DateTime.MinValue;
                        DateTime checkout = DateTime.MinValue;
                        if (table.Rows[st][2] != DBNull.Value)
                            checkin = ((DateTime)table.Rows[st][2]);
                        if (table.Rows[st][3] != DBNull.Value)
                            checkout = ((DateTime)table.Rows[st][3]);
                        if (current.AddDays(i).Date<DateTime.Now.Date)
                        {
                            if (checkin == DateTime.MinValue)
                            {
                                dv_workschedule.Rows[j].Cells[i].Style.BackColor = colors[3];
                            }
                            else
                            {
                                if ((checkout - checkin).TotalMinutes >= 225)
                                    dv_workschedule.Rows[j].Cells[i].Style.BackColor = colors[1];
                                else
                                    dv_workschedule.Rows[j].Cells[i].Style.BackColor = colors[2];
                            }
                        }
                        st++;
                    }
                }
            }
        }

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
            lb_state.Text = StaticVars_Class.state;
            //byte[] imageData = (byte[])table_emp.Rows[0]["Picture"];
            //Bitmap imageBitmap = new Bitmap(new MemoryStream(imageData));
            //overView.pb_avatar.Image = imageBitmap;
            bool gender = Convert.ToBoolean(table_emp.Rows[0]["Gender"]);

            if (gender)
                rb_male.Checked = true;
            else
                rb_female.Checked = true;

            methods.standardrizeDtgridview(dv_workschedule);
    
            Shift_Class.DayRange circle = new Shift_Class.DayRange(shift.getFirstDayinCircle(), shift.getLastDayinCircle());
            DateTime current = circle.start;
            DataTable data = new DataTable();

            DataColumn column1 = new DataColumn();
            column1.DataType = typeof(string);
            column1.ColumnName = "Display";
            data.Columns.Add(column1);

            DataColumn column2 = new DataColumn();
            column2.DataType = typeof(Shift_Class.DayRange);
            column2.ColumnName = "Value";
            data.Columns.Add(column2);

            while (current <= circle.end)
            {
                Shift_Class.DayRange range = new Shift_Class.DayRange();
                range.start = current;
                for (int i = 0; i < 6; i++)
                    current = current.AddDays(1);
                range.end = current;
                current = current.AddDays(1);
                data.Rows.Add(range.start.ToString("dd/MM/yyyy") + " - " + range.end.ToString("dd/MM/yyyy"), range);
            }
            cb_dayRange.DisplayMember = "Display";
            cb_dayRange.ValueMember = "Value";
            cb_dayRange.DataSource = data;

            if (workSchedule.checkhaveWorkSchedule() == false)
            {
                bt_checkin.Enabled = false;
                bt_checkout.Enabled = false;
            }
            else
            {
                workSchedule.checkstate();
                if(StaticVars_Class.state == StaticVars_Class.loginstate[0])
                {
                    bt_checkin.Enabled = true;
                    bt_checkout.Enabled = false;
                }
                if (StaticVars_Class.state == StaticVars_Class.loginstate[1])
                {
                    bt_checkin.Enabled = false;
                    bt_checkout.Enabled = true;
                }
                if (StaticVars_Class.state == StaticVars_Class.loginstate[2])
                {
                    bt_checkin.Enabled = false;
                    bt_checkout.Enabled = false;
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
            if (StaticVars_Class.shifttime != StaticVars_Class.closetime)
            {
                CheckIN_OUT checkIN_OUT = new CheckIN_OUT();
                checkIN_OUT.Show();
            }
            else
                MessageBox.Show(StaticVars_Class.closetime);
        }

        private void cb_dayRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shift_Class.DayRange range = (Shift_Class.DayRange)cb_dayRange.SelectedValue;
            fillGrid(range.start, range.end);
        }
    }
}
