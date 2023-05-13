using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    class Shift_Class
    {
        DB_Class db = new DB_Class();
        public struct DayRange
        {
            public DateTime start;
            public DateTime end;
            public DayRange(DateTime start, DateTime end)
            {
                this.start = start;
                this.end = end;
            }
        }
        public DataTable getEmployeeScheduled(DateTime start, DateTime end)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT s.Date, s.Shift, e.Name FROM Employee e, WorkSchedule ws, Shifts s WHERE e.EmployeeID=ws.EmployeeID AND ws.ShiftID=s.ShiftID AND s.Date>=@start AND s.Date<=@end ORDER BY s.Date", db.getConnection);
            cmd.Parameters.Add("@start", System.Data.SqlDbType.Date).Value = start.ToShortDateString();
            cmd.Parameters.Add("@end", System.Data.SqlDbType.Date).Value = end.ToShortDateString();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            DataTable tb = new DataTable();
            for (int i = 0; i < 7; i++)
                tb.Columns.Add(new DataColumn());
            for (int i = 0; i < 3; i++)
                tb.Rows.Add(tb.NewRow());
            string[] shift = { "6:00AM - 10:00AM", "11:00AM - 3:00PM", "6:00PM - 10:00PM" };
            for (int i=0;i<3;i++)
            {
                DateTime current = start;
                for (int j = 0; j < 7; j++)
                {
                    string emp = "";
                    foreach (DataRow row in table.Rows)
                    {
                        if (((DateTime)row[0]) == current && shift[i] == row[1].ToString())
                            emp += "- " + row[2].ToString() +"\n";
                    }
                    tb.Rows[i][j] = emp;
                    current = current.AddDays(1);
                }
            }
            return tb;
        }
        public DateTime getFirstDayinCircle()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT s.Date FROM Shifts s ORDER BY s.Date", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return (DateTime)table.Rows[0][0];
        }
        public DateTime getLastDayinCircle()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT s.Date FROM Shifts s ORDER BY s.Date DESC", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return (DateTime)table.Rows[0][0];
        }
    }
}
