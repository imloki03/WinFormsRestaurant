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
    public partial class WorkStation : Form
    {
        public WorkStation()
        {
            InitializeComponent();
        }
        DB_Class db = new DB_Class();
        Employee_Class employee = new Employee_Class();
        bool leftMouse = true;
        public static int guest;
        public DataTable[] orderList = new DataTable[20];
        public string[] orderID = new string[20];
        private void WorkStation_Load(object sender, EventArgs e)
        {
            list_log.Columns.Add("log",232);
            SqlCommand cmd = new SqlCommand("select * from [Table]", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i=1;i<=15;i++)
            {
                Panel panel = (Panel)this.Controls["pn_"+i];
                for (int j = 1; j <= 4; j++)
                {
                    PictureBox pictureBox = (PictureBox)panel.Controls["cus" + i + "_" + j];
                    pictureBox.Visible = false;
                }
                if (table.Rows[i - 1][1].ToString() == "False")
                {
                    if (i < 10)
                        hideTable(panel, "Table0" + i);
                    else
                        hideTable(panel, "Table" + i);
                }
            }
        }
        public void hideTable(Control control, string tableName)
        {
            foreach (Control c in control.Controls)
            {
                c.Visible = false;
            }
            control.BackgroundImage = Properties.Resources.addTable;
            SqlCommand cmd = new SqlCommand("update [Table] set visible=0 where tableID='" + tableName + "'", db.getConnection);
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }
        public void showTable(Control control, string tableName)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Label)
                    c.Visible = true;
            }
            control.BackgroundImage = Properties.Resources.table;
            SqlCommand cmd = new SqlCommand("update [Table] set visible=1 where tableID='"+tableName+"'", db.getConnection);
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }

        private void pn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from [Table]", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Panel panel = (Panel)(sender);
            int num = int.Parse(panel.Name.Substring(3));

            if (table.Rows[num - 1][1].ToString() == "False")
            {
                if (MessageBox.Show("Confirm ADD new Table?", "Add Table", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (num<10)
                        showTable(panel, "Table0" + num);
                    else
                        showTable(panel, "Table" + num);
                }
            }
            else
            {
                if (leftMouse)
                {
                    PictureBox pictureBox = (PictureBox)panel.Controls["cus" + num + "_" + 1];
                    if (pictureBox.Visible == false)
                    {
                        Order order = new Order();   /// mo form order
                        order.lb_table.Text=num.ToString();
                        if (order.ShowDialog() == DialogResult.OK)
                        {
                            orderList[num] = Order.order;
                            orderID[num] = Order.static_orderID;
                            for (int i=1;i<=guest;i++)
                            {
                                PictureBox pic = (PictureBox)panel.Controls["cus" + num + "_" + i];
                                pic.Visible = true;
                            }
                            list_log.Items.Insert(0,new ListViewItem(">> "+guest+" diners to Table "+ num));
                        }
                    }
                    else
                    {
                        Reciept reciept = new Reciept();
                        reciept.oderid = orderID[num];
                        reciept.table = num;
                        reciept.qguest = guest;
                        if (reciept.ShowDialog() == DialogResult.OK)
                        {
                            Panel panel1 = (Panel)this.Controls["pn_" + num];
                            for (int j = 1; j <= 4; j++)
                            {
                                PictureBox pictureBox1 = (PictureBox)panel1.Controls["cus" + num + "_" + j];
                                pictureBox1.Visible = false;
                            }
                            list_log.Items.Insert(0, new ListViewItem("<< " + guest + " diners out of Table " + num));
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("right click");
                    PictureBox pictureBox = (PictureBox)panel.Controls["cus" + num + "_" + 1];
                    if (pictureBox.Visible == false)
                    {
                        option.Items[0].Visible = true;
                        option.Items[1].Visible = false;
                        option.Items[2].Visible = true;
                    }
                    else
                    {
                        option.Items[0].Visible = false;
                        option.Items[1].Visible = true;
                        option.Items[2].Visible = false;
                    }
                    option.Show(panel, mouse);
                }
            }
        }
        Point mouse = new Point();
        Panel selectedPanel = new Panel();
        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                leftMouse = true;
            else
                leftMouse = false;
            mouse = e.Location;
            selectedPanel = (Panel)sender;
        }

        private void option_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            option.Close();
            if (e.ClickedItem == newOrder)
            {
                Panel panel = selectedPanel;
                int num = int.Parse(panel.Name.Substring(3));
                Order order = new Order();   /// mo form order
                orderID[num] = Order.static_orderID;
                order.lb_table.Text = num.ToString();
                if (order.ShowDialog() == DialogResult.OK)
                {
                    orderList[num] = Order.order;
                    for (int i = 1; i <= guest; i++)
                    {
                        PictureBox pic = (PictureBox)panel.Controls["cus" + num + "_" + i];
                        pic.Visible = true;
                    }
                }
                list_log.Items.Insert(0, new ListViewItem(">> " + guest + " diners to Table " + num));
            }
            else
            {
                if (e.ClickedItem == exportReceipt)
                {
                    int num = int.Parse(selectedPanel.Name.Substring(3));
                    Reciept reciept = new Reciept();
                    reciept.oderid = orderID[num];
                    reciept.table = num;
                    reciept.qguest = guest;
                    if (reciept.ShowDialog()==DialogResult.OK)
                    {
                        Panel panel = (Panel)this.Controls["pn_" + num];
                        for (int j = 1; j <= 4; j++)
                        {
                            PictureBox pictureBox = (PictureBox)panel.Controls["cus" + num + "_" + j];
                            pictureBox.Visible = false;
                        }
                        list_log.Items.Insert(0, new ListViewItem("<< " + guest + " diners out of Table " + num));
                    }
                }
                else
                {
                    if (e.ClickedItem == removeTable)
                    {
                        int num = int.Parse(selectedPanel.Name.Substring(3));
                        if (MessageBox.Show("Remove this Table?", "Remove Table", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                        {
                            if (num < 10)
                                hideTable(selectedPanel, "Table0" + num);
                            else
                                hideTable(selectedPanel, "Table" + num);
                        }
                    }
                }
            }
        }

  
        private void bt_checkOUT_Click(object sender, EventArgs e)
        {
            CheckIN_OUT checkIN_OUT = new CheckIN_OUT();
            checkIN_OUT.Show();
        }
    }
}
