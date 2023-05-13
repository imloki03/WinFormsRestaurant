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
using VisioForge.Libs.TagLib.Jpeg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsRestaurant
{

    public partial class ShiftManagement : Form
    {
        public ShiftManagement()
        {
            InitializeComponent();
        }
        Shift_Class shift = new Shift_Class();
        public void fillGrid(DateTime start, DateTime end)
        {
            list_shift.RowTemplate.Height = 150;
            list_shift.RowHeadersWidth = 90;
            list_shift.DataSource = shift.getEmployeeScheduled(start, end);
            DateTime current = start;
            list_shift.Columns[0].HeaderText = current.ToString("dddd"); current = current.AddDays(1);
            list_shift.Columns[1].HeaderText = current.ToString("dddd"); current = current.AddDays(1);
            list_shift.Columns[2].HeaderText = current.ToString("dddd"); current = current.AddDays(1);
            list_shift.Columns[3].HeaderText = current.ToString("dddd"); current = current.AddDays(1);
            list_shift.Columns[4].HeaderText = current.ToString("dddd"); current = current.AddDays(1);
            list_shift.Columns[5].HeaderText = current.ToString("dddd"); current = current.AddDays(1);
            list_shift.Columns[6].HeaderText = current.ToString("dddd");

            list_shift.Rows[0].HeaderCell.Value = "6:00AM - 10:00AM";
            list_shift.Rows[1].HeaderCell.Value = "11:00AM - 3:00PM";
            list_shift.Rows[2].HeaderCell.Value = "6:00PM - 10:00PM";
        }
        private void ShiftManagement_Load(object sender, EventArgs e)
        {
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

            while (current<=circle.end)
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
        }

        private void cb_dayRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shift_Class.DayRange range = (Shift_Class.DayRange) cb_dayRange.SelectedValue;
            fillGrid(range.start, range.end);
        }
    }
}
