﻿using System;
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
        bool leftMouse = true;
        private void WorkStation_Load(object sender, EventArgs e)
        {
            timer_Clock.Start();
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
                        MessageBox.Show("order");   /// mo form order
                    }
                    else
                    {
                        MessageBox.Show("payment");  // mo form payment
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
                        option.Items[2].Enabled = false;
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
                MessageBox.Show("order");   /// mo form order
            }
            else
            {
                if (e.ClickedItem == exportReceipt)
                {
                    MessageBox.Show("payment");  // mo form payment
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

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            lb_clock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
