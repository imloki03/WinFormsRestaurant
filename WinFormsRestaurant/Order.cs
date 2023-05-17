using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_order_Click(object sender, EventArgs e)
        {

            WorkStation.guest = int.Parse(tb_amountOfDiner.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
