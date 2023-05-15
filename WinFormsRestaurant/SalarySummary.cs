using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Libs.ZXing.QrCode.Internal;

namespace WinFormsRestaurant
{
    public partial class SalarySummary : Form
    {
        public SalarySummary()
        {
            InitializeComponent();
        }
        Salary_Class salary = new Salary_Class();
        public void fillGrid(SqlCommand cmd)
        {
            list_salary.RowTemplate.Height = 50;
            list_salary.DataSource = salary.getSalarySummary(cmd);
            list_salary.Columns[0].HeaderText = "ID";
            list_salary.Columns[1].HeaderText = "Name";
            list_salary.Columns[2].HeaderText = "Time Working";
            list_salary.Columns[3].HeaderText = "Total Time Working";
            list_salary.Columns[4].HeaderText = "Working Time Salary";
            list_salary.Columns[5].HeaderText = "Fine";
            list_salary.Columns[6].HeaderText = "Temporary Salary";
            list_salary.Columns[7].HeaderText = "Actually Received Salary";

            list_salary.Columns[0].Width = 60;
            list_salary.Columns[1].Width = 200;
            list_salary.Columns[2].Width = 200;
            list_salary.Columns[3].Width = 70;
            list_salary.Columns[4].Width = 100;
            list_salary.Columns[5].Width = 100;
            list_salary.Columns[6].Width = 100;

            for (int i = 2; i<=7;i++)
                list_salary.Columns[i].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
        }
        private void SalarySummary_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * from Employee"));
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * from Employee where EmployeeID+' '+Name like '%" + tb_search.Text + "%'"));
        }
    }
}
