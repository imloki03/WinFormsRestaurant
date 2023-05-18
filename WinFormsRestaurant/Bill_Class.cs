using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    internal class Bill_Class
    {
        DB_Class dB = new DB_Class();
        public string getNextBillID()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[AUTO_IDBill]()", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }

        public void addBill(int guest, int money, string tableid, string orderID,DateTime time)
        {
            SqlCommand command = new SqlCommand("insert into Bill(billID, guest, money, tableID, orderID, time) values ([dbo].[AUTO_IDBill](),@guest,@money, @tid, @oid ,@time)", dB.getConnection);
  
            command.Parameters.Add("@guest", System.Data.SqlDbType.Int).Value = guest;
            command.Parameters.Add("@money", System.Data.SqlDbType.Int).Value = money;
            command.Parameters.Add("@tid", System.Data.SqlDbType.NVarChar).Value = tableid;
            command.Parameters.Add("@oid", System.Data.SqlDbType.NVarChar).Value = orderID;
            command.Parameters.Add("@time", System.Data.SqlDbType.DateTime).Value = time;
            dB.openConnection();
            command.ExecuteNonQuery();
            dB.closeConnection();
        }
    }
}
