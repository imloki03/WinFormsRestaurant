using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    internal class WorkSchedule_Class
    {
        DB_Class dB = new DB_Class();
        public DataTable getWorkSchedule(SqlCommand cmd)
        {
            cmd.Connection = dB.getConnection;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public bool checkhaveWorkSchedule()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM WorkSchedule w, Shifts s, Employee e WHERE w.ShiftID = s.ShiftID AND w.EmployeeID = e.EmployeeID  AND w.EmployeeID = @eid AND s.Date = @today AND s.Shift = '" + StaticVars_Class.shifttime + "'", dB.getConnection);
            cmd.Parameters.Add("@eid", SqlDbType.NVarChar).Value = StaticVars_Class.emID;
            cmd.Parameters.Add("@today", SqlDbType.Date).Value = DateTime.Now.Date;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if(table.Rows.Count >= 1)
                return true;
            else 
                return false;
        }

        public void checkstate()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM WorkSchedule w, Shifts s, Employee e WHERE w.ShiftID = s.ShiftID AND w.EmployeeID = e.EmployeeID  AND w.EmployeeID = @eid AND s.Date = @today AND s.Shift = '"+StaticVars_Class.shifttime+"'", dB.getConnection);
            cmd.Parameters.Add("@eid", SqlDbType.NVarChar).Value = StaticVars_Class.emID;
            cmd.Parameters.Add("@today", SqlDbType.Date).Value = DateTime.Now.Date;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            if (table.Rows[0][2] == DBNull.Value && table.Rows[0][3] == DBNull.Value)
                StaticVars_Class.state = StaticVars_Class.loginstate[0];
            if (table.Rows[0][2] != DBNull.Value && table.Rows[0][3] == DBNull.Value)
                StaticVars_Class.state = StaticVars_Class.loginstate[1];
            if (table.Rows[0][2] != DBNull.Value && table.Rows[0][3] != DBNull.Value)
                StaticVars_Class.state = StaticVars_Class.loginstate[2];
        }

        public void checkIn()
        {
            SqlCommand cmd = new SqlCommand("UPDATE w SET w.Checkin = @now FROM WorkSchedule AS w JOIN Shifts AS s ON w.ShiftID = s.ShiftID JOIN Employee AS e ON w.EmployeeID = e.EmployeeID WHERE w.EmployeeID = @eid AND s.Date = @today AND s.Shift = '"+StaticVars_Class.shifttime+"'", dB.getConnection);
            cmd.Parameters.Add("@eid", SqlDbType.NVarChar).Value = StaticVars_Class.emID;
            cmd.Parameters.Add("@today", SqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@now", SqlDbType.DateTime).Value = DateTime.Now;
            if (cmd.ExecuteNonQuery()==1)
             MessageBox.Show("Check-in Succesfully");
            else
            {
                MessageBox.Show("Check-in Failed");
            }
        }

        public void checkOut()
        {
            SqlCommand cmd = new SqlCommand("UPDATE w SET w.Checkout = @now FROM WorkSchedule AS w JOIN Shifts AS s ON w.ShiftID = s.ShiftID JOIN Employee AS e ON w.EmployeeID = e.EmployeeID WHERE w.EmployeeID = @eid AND s.Date = @today AND s.Shift = '" + StaticVars_Class.shifttime + "'", dB.getConnection);
            cmd.Parameters.Add("@eid", SqlDbType.NVarChar).Value = StaticVars_Class.emID;
            cmd.Parameters.Add("@today", SqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@now", SqlDbType.DateTime).Value = DateTime.Now;
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Check-out Succesfully");
            else
            {
                MessageBox.Show("Check-out Failed");
            }
        }

    }
}
