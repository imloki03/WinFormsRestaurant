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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public string getNextEmID()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[AUTO_IDEmployee]()", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }
        public string getEmjob(string eid)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE EmployeeID = @eid", dB.getConnection);
            cmd.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows[0]["JobTitle"].ToString();
        }
        public void addEmployee(string name, bool gender, string phone, string address, string birthday, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into Employee values ([dbo].[AUTO_IDEmployee](), @name, @gender, @phone, @address, @birth, @job, null, @picture)", dB.getConnection);
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", System.Data.SqlDbType.Bit).Value = gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@birth", System.Data.SqlDbType.NVarChar).Value = birthday;
            command.Parameters.Add("@job", System.Data.SqlDbType.NVarChar).Value = "Employee";
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Add Employee Successfully");
            else
                MessageBox.Show("Add Employee Unsuccessfully!!!");
            dB.closeConnection();
        }
        public void updateEmployee(string eid ,string name, bool gender, string phone, string address, string birthday, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET Name = @name, Gender = @gender, Phone = @phone, Address = @address, BirthDate = @birth , Picture = @picture WHERE EmployeeID = @eid", dB.getConnection);
            command.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", System.Data.SqlDbType.Bit).Value = gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@birth", System.Data.SqlDbType.NVarChar).Value = birthday;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Update Employee Successfully");
            else
                MessageBox.Show("Update Employee Unsuccessfully!!!");
            dB.closeConnection();
        }
        public void deleteEmployee(string eid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @eid", dB.getConnection);
            command.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Delete Employee Successfully");
            else
                MessageBox.Show("Delete Employee Unsuccessfully!!!");
            dB.closeConnection();
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
