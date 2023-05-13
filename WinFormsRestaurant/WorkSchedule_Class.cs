using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
