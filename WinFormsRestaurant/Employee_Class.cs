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
    }
}
