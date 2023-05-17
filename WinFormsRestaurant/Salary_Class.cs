using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    class Salary_Class
    {
        DB_Class db = new DB_Class();
        public DataTable getSalarySummary(SqlCommand command) // nho select cot 0 la id, cot 1 la ten
        {
            DataTable table = new DataTable();
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            DataTable tb= new DataTable();
            for (int i = 0; i < 8; i++)
                tb.Columns.Add(new DataColumn());
            for (int i = 0; i < table.Rows.Count; i++)
                tb.Rows.Add(tb.NewRow());
            DateTime now = DateTime.Now;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                tb.Rows[i][0] = table.Rows[i][0];
                tb.Rows[i][1] = table.Rows[i][1];
                tb.Rows[i][2] = getTimeWorking(table.Rows[i][0].ToString());
                tb.Rows[i][3] = getTotalTimeWorking(table.Rows[i][0].ToString(), now);
                tb.Rows[i][4] = salaryByTimeWorking(getTotalTimeWorking(table.Rows[i][0].ToString(), now));
                tb.Rows[i][5] = fine(table.Rows[i][0].ToString(), now);
                tb.Rows[i][6] = temporarySalary(table.Rows[i][0].ToString(), now);
                if (actuallyReceivedSalary(table.Rows[i][0].ToString(), now) != 0)
                    tb.Rows[i][7] = actuallyReceivedSalary(table.Rows[i][0].ToString(), now);
            }
            return tb;
        }
        public string getTimeWorking(string id)
        {
            string time = "";
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ws.EmployeeID, ws.Checkin, ws.Checkout FROM WorkSchedule ws, Shifts s WHERE ws.ShiftID=s.ShiftID AND ws.EmployeeID = @id AND s.Date = @date AND ws.Checkin IS NOT NULL ORDER BY ws.ShiftID", db.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                DateTime checking = (DateTime)row[1];
                DateTime checkout = DateTime.Now;
                if (row[2].ToString()!="")
                    checkout = (DateTime)row[2];
                time += checking.ToShortTimeString() + " - " + checkout.ToShortTimeString() + "\n";
            }
            return time;
        }
        public int getTotalTimeWorking(string id, DateTime date)
        {
            int total=0;
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ws.EmployeeID, ws.Checkin, ws.Checkout FROM WorkSchedule ws, Shifts s WHERE ws.ShiftID=s.ShiftID AND ws.EmployeeID = @id AND s.Date = @date AND ws.Checkin IS NOT NULL ORDER BY ws.ShiftID", db.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = date.ToShortDateString();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                DateTime checking = (DateTime)row[1];
                DateTime checkout = DateTime.Now;
                if (row[2].ToString() != "")
                    checkout = (DateTime)row[2];
                double time = (checkout.ToOADate() - checking.ToOADate()) * 24;
                if (time - (int)time >= 0.75)
                    time = (int)time + 1;
                else
                    time = (int)time;
                if (time>=4)
                    total += 4;
                else
                    total += (int) time;
            }
            return total;
        }
        public int salaryByTimeWorking(int time)
        {
            return 50000 * time;
        }
        public int fine(string id, DateTime date)
        {
            int total = 0;
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ws.EmployeeID, ws.Checkin, ws.Checkout FROM WorkSchedule ws, Shifts s WHERE ws.ShiftID=s.ShiftID AND ws.EmployeeID = @id AND s.Date = @date AND ws.Checkin IS NOT NULL AND ws.Checkout IS NOT NULL ORDER BY ws.ShiftID", db.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = date.ToShortDateString();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                DateTime checking = (DateTime)row[1];
                DateTime checkout = (DateTime)row[2];
                double time = (checkout.ToOADate() - checking.ToOADate()) * 24;
                if (time - (int)time >= 0.75)
                    time = (int)time + 1;
                else
                    time = (int)time;
                if (time <4)
                    total += (4-(int)time);
            }
            return 100000*total;
        }
        public int temporarySalary(string id, DateTime date)
        {
            return salaryByTimeWorking(getTotalTimeWorking(id, date)) - fine(id, date);
        }
        public int actuallyReceivedSalary(string id, DateTime date)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ws.EmployeeID, ws.Checkin, ws.Checkout FROM WorkSchedule ws, Shifts s WHERE ws.ShiftID=s.ShiftID AND ws.EmployeeID = @id AND s.Date = @date AND ws.Checkout IS NULL ORDER BY ws.ShiftID", db.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return 0;
            else
                return temporarySalary(id, date);
        }
    }
}
