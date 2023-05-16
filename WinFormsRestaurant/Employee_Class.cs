using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using System.IO;

namespace WinFormsRestaurant
{
    internal class Employee_Class
    {
        DB_Class dB = new DB_Class();
        public DataTable getEmployee(SqlCommand cmd)
        {
            cmd.Connection = dB.getConnection;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public int amountOfEmloyees()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Employee where JobTitle <> 'Manager' or JobTitle is null", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public int scheduledToday(string shift)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from WorkSchedule w, Shifts s where w.ShiftID=s.ShiftID and s.Date=@date and s.Shift=@shift", dB.getConnection);
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
            cmd.Parameters.Add("@shift", System.Data.SqlDbType.NVarChar).Value = shift;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public int checkedIN(string shift)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from WorkSchedule w, Shifts s where w.ShiftID=s.ShiftID and s.Date=@date and s.Shift=@shift and w.Checkin is not null", dB.getConnection);
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
            cmd.Parameters.Add("@shift", System.Data.SqlDbType.NVarChar).Value = shift;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public int working(string shift)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from WorkSchedule w, Shifts s where w.ShiftID=s.ShiftID and s.Date=@date and s.Shift=@shift and w.Checkin is not null and w.Checkout is null", dB.getConnection);
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
            cmd.Parameters.Add("@shift", System.Data.SqlDbType.NVarChar).Value = shift;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows.Count;
        }

        public string getEmID(int num)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE JobTitle <> 'Manager' OR JobTitle IS NULL ORDER BY EmployeeID OFFSET @num ROWS FETCH NEXT 1 ROWS ONLY", dB.getConnection);
            cmd.Parameters.Add("@num", System.Data.SqlDbType.Int).Value = num;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }
        public void addEmployee(string name, bool gender, string phone, string address, string birthday, string jobtitle, string account, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into Employee values ([dbo].[AUTO_IDEmployee](), @name, @gender, @phone, @address, @birth, @job, null, @picture)", dB.getConnection);

        }
        public void updateEmployee()
        {

        }
        public void deleteEmployee()
        {

        }

        public string whatEmIDByAcc(string username)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Account = @user", dB.getConnection);
            cmd.Parameters.Add("@user", System.Data.SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }
    }
}
