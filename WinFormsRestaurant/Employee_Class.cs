using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRestaurant
{
    internal class Employee_Class
    {
        DB_Class dB = new DB_Class();
        public DataTable getEmployee(SqlCommand cmd)
        {
            cmd.Connection = dB.getConnection;
            DataTable table_studentid = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table_studentid);
            return table_studentid;
        }
        public int amountOfEmloyees()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Employee", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public string getEmID(int num)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee ORDER BY EmployeeID OFFSET @num ROWS FETCH NEXT 1 ROWS ONLY", dB.getConnection);
            cmd.Parameters.Add("@num", System.Data.SqlDbType.Int).Value = num;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }
    }
}
