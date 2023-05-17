using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        public static DataTable food_Order;
        public static DataTable drink_Order;
        public static DataTable order;
        public static string static_orderID;
        private void bt_select_Click(object sender, EventArgs e)
        {
            SelectDishes selectDishes = new SelectDishes();
            if (selectDishes.ShowDialog() == DialogResult.OK)
            {
                order = food_Order;
                order.Merge(drink_Order);
                for (int i = 0; i < order.Rows.Count; i++)
                {
                    if (order.Rows[i][2].ToString()=="")
                    {
                        order.Rows[i].Delete();
                    }
                }
                order.AcceptChanges();

                list_dishes.DataSource = order;
                list_dishes.Columns[0].Visible = false;
                list_dishes.Columns[1].HeaderText = "Dish";
                list_dishes.Columns[2].HeaderText = "Quantity";
                list_dishes.Columns[1].Width = 180;
                bt_select.Enabled = false;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DB_Class db = new DB_Class();
        private void bt_order_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[AUTO_IDOrder]()", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string orderID = table.Rows[0][0].ToString();
            foreach (DataRow row in order.Rows)
            {
                cmd = new SqlCommand("INSERT [Order] VALUES (@id, @dish, @quantity)", db.getConnection);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = orderID;
                cmd.Parameters.Add("@dish", System.Data.SqlDbType.NVarChar).Value = row[0].ToString();
                cmd.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = row[2].ToString();
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            WorkStation.guest = int.Parse(tb_amountOfDiner.Text);
            static_orderID = orderID;
            this.DialogResult = DialogResult.OK;
        }

        private void Order_Load(object sender, EventArgs e)
        {
        }
    }
}
