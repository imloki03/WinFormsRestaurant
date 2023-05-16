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
        private void WorkStation_Load(object sender, EventArgs e)
        {
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
                    hideTable(panel);
                }
            }
        }
        public void hideTable(Control control)
        {
            foreach (Control c in control.Controls)
            {
                c.Visible = false;
            }
            control.BackgroundImage = Properties.Resources.addTable;
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
        }
    }
}
