using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLib;

namespace WinFormsRestaurant
{
    class Dashboard_Class
    {
        DB_Class db = new DB_Class();
        public int numberOfOrders(System.DateTime start, System.DateTime end)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Bill where time>=@start and time<=@end", db.getConnection);
            cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = end;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public int numberOfDiners(System.DateTime start, System.DateTime end)
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
        public int totalOfRevenue(System.DateTime start, System.DateTime end)
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
        public DataTable getIngredient()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT name, (CAST(quantity as NVARCHAR)+' '+unit) as quantity FROM Ingredient", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public DataTable getBestSeller(System.DateTime start, System.DateTime end)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT d.dishID, d.name, P.total FROM (SELECT TOP 5 Q.dishID, sum(Q.quantity) as total from (select o.dishID, o.quantity from Bill b, [Order] o where b.orderID = o.orderID and time>=@start and time<=@end) Q GROUP BY Q.dishID ORDER BY total) P, Dishes d where P.dishID = d.dishID", db.getConnection);
            cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = end;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public DataTable getOrdersperHour(System.DateTime start, System.DateTime end)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add(new DataColumn("hour", typeof(int)));
            tb.Columns.Add(new DataColumn("order", typeof(int)));
            for (int i=0;i<4;i++)
            {
                DataTable table = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Bill where time>=@start and time<@end", db.getConnection);
                cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
                cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = start.AddHours(1);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                tb.Rows[i][0] = start.Hour;
                tb.Rows[i][1] = table.Rows.Count;
                start = start.AddHours(1);
            }
            return tb;
        }
    }
}
