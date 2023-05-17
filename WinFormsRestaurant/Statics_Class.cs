using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VisioForge.MediaFramework.FFMPEGEXE;

namespace WinFormsRestaurant
{
    
    class Statics_Class
    {
        DB_Class db = new DB_Class();
        Shift_Class shift = new Shift_Class();
        Salary_Class salary = new Salary_Class();
        public struct Status
        {
            public int worked;
            public int absent;
            public int scheduled;
        }
        public DataTable getSalaryStatics()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select EmployeeID, Name from Employee", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            table.Columns.Add(new DataColumn());
            foreach (DataRow row in table.Rows)
            {
                DateTime start = shift.getFirstDayinCircle();
                DateTime end = shift.getLastDayinCircle();
                int total = 0;
                while (start<=end)
                {
                    total += salary.actuallyReceivedSalary(row[0].ToString(), start);
                    start = start.AddDays(1);
                }
                row[2] = total;
            }
            return table;
        }
        public Status getShiftStatus(string id)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ws.EmployeeID, ws.Checkin, ws.Checkout, s.Date FROM WorkSchedule ws, Shifts s WHERE ws.ShiftID=s.ShiftID AND ws.EmployeeID = @id ORDER BY ws.ShiftID", db.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            Status status = new Status();
            status.worked = 0;
            status.absent = 0;
            status.scheduled = 0;
            foreach (DataRow row in table.Rows)
            {
                string checkin = row[1].ToString();
                string checkout = row[2].ToString();
                DateTime time = (DateTime)row[3];
                if (checkin != "" && checkout != "")
                    status.worked++;
                else
                    if (checkin=="" && checkout=="" && DateTime.Now>time)
                    status.absent++;
                else
                    status.scheduled++;
            }
            return status;
        }
        public DataTable getShiftStatics()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select EmployeeID, Name from Employee", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            for (int i=0;i<3;i++)
                table.Columns.Add(new DataColumn());
            foreach (DataRow row in table.Rows)
            {
                Status status = getShiftStatus(row[0].ToString());
                row[2]=status.scheduled; 
                row[3]=status.worked;
                row[4]=status.absent;
            }
            return table;
        }
        public DataTable getTimeWorkingStatics()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select EmployeeID, Name from Employee", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            table.Columns.Add(new DataColumn());
            foreach (DataRow row in table.Rows)
            {
                DateTime start = shift.getFirstDayinCircle();
                DateTime end = shift.getLastDayinCircle();
                int total = 0;
                while (start <= end)
                {
                    total += salary.getTotalTimeWorking(row[0].ToString(), start);
                    start = start.AddDays(1);
                }
                row[2] = total;
            }
            return table;
        }
    }
}
