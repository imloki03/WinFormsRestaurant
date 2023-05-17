using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRestaurant
{
    class Dashboard_Class
    {
        DB_Class db = new DB_Class();
        public int numberOfOrders(DateTime start, DateTime end)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Bill where time>=@start and time<=@end", db.getConnection);
            cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = end;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public int numberOfDiners(DateTime start, DateTime end)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Bill where time>=@start and time<=@end", db.getConnection);
            cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = end;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            int guest = 0;
            foreach(DataRow row in table.Rows)
            {
                guest += (int)row[2];
            }
            return guest;
        }
        public int totalOfRevenue(DateTime start, DateTime end)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Bill where time>=@start and time<=@end", db.getConnection);
            cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = end;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            int revenue = 0;
            foreach (DataRow row in table.Rows)
            {
                revenue += (int)row[3];
            }
            return revenue;
        }
    }
}
