using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    public partial class SelectDishes : Form
    {
        public SelectDishes()
        {
            InitializeComponent();
        }
        public Button currentButton;
        DB_Class db = new DB_Class();
        //public int[] food = new int[100];
        //public int[] drink = new int[100];
        public DataTable food = new DataTable();
        public DataTable drink = new DataTable();
        private void SelectDishes_Load(object sender, EventArgs e)
        {
            currentButton = bt_food;
            ShiftButtonClickUI(currentButton);

            SqlCommand cmd = new SqlCommand("select dishID, name from Dishes where dishID like '%Food%'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(food);
            food.Columns.Add(new DataColumn("num", typeof(int)));
            food.Columns.Add(new DataColumn("max", typeof(int)));
            foreach (DataRow row in food.Rows)
            {
                row[3] = getMaxDish(row[0].ToString());
            }

            cmd = new SqlCommand("select dishID, name from Dishes where dishID like '%Drink%'", db.getConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(drink);
            drink.Columns.Add(new DataColumn("num", typeof(int)));
            drink.Columns.Add(new DataColumn("max", typeof(int)));
            foreach (DataRow row in drink.Rows)
            {
                row[3] = getMaxDish(row[0].ToString());
            }

            bt_food.Invoke(new MethodInvoker(()=>bt_food_Click(bt_food, new EventArgs())));

        }
        public int getMaxDish(string id)
        {
            SqlCommand cmd = new SqlCommand("select min(Q.num) from (SELECT (i.quantity/r.quantity) as num FROM Dishes d, Recipe r, Ingredient i WHERE d.recipeID= r.recipeID AND r.ingredientID=i.ingredientID AND d.dishID = @id) Q", db.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }
        public Panel createPanel(string PanelName, string dishName, MemoryStream pic)
        {
            int num = int.Parse(PanelName.Substring(3));

            Panel panel = new Panel();
            panel.Name = PanelName;
            panel.Size = new Size(180, 170);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "pic_" + num;
            pictureBox.Size = new Size(180, 110);
            panel.Controls.Add(pictureBox);
            pictureBox.Location = new Point(0,0);
            pictureBox.BackColor = Color.Pink;
            pictureBox.Image = Image.FromStream(pic);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            Label label = new Label();
            label.Name = "lb_name_" + num;
            label.Text = dishName;
            label.Size = new Size(180, 20);
            label.Location = new Point(0, 110);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BackColor = Color.Orange;
            panel.Controls.Add(label);

            Button bt_subtract = new Button();
            bt_subtract.Name = "bt_s_" + num;
            bt_subtract.Size = new Size(35, 35);
            panel.Controls.Add(bt_subtract);
            bt_subtract.Location = new Point(30, 131);
            bt_subtract.Text = "-";
            bt_subtract.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            bt_subtract.TextAlign = ContentAlignment.MiddleCenter;
            bt_subtract.Enabled = false;
            bt_subtract.Click += subtract_Click;

            Button bt_add = new Button();
            bt_add.Name = "bt_a_" + num;
            bt_add.Size = new Size(35, 35);
            panel.Controls.Add(bt_add);
            bt_add.Location = new Point(115, 131);
            bt_add.Text = "+";
            bt_add.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            bt_add.TextAlign = ContentAlignment.MiddleCenter;
            bt_add.Click += add_Click;

            Label lb_number = new Label();
            lb_number.Name = "lb_num_" + num;
            panel.Controls.Add(lb_number);
            if (currentButton == bt_food)
                lb_number.Text = food.Rows[num - 1][2].ToString();
            else
                lb_number.Text = drink.Rows[num - 1][2].ToString();
            if (lb_number.Text == "")
                lb_number.Text = "0";
            lb_number.Size = new Size(180, 40);
            lb_number.Location = new Point(0, 128);
            lb_number.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            lb_number.TextAlign = ContentAlignment.MiddleCenter;

            return panel;
        }
        private void subtract_Click(object sender, EventArgs e)
        {
            int num = int.Parse(((Button)sender).Name.Substring(5));
            Panel panel = this.Controls.Find("pn_" + num, true).FirstOrDefault() as Panel;
            Label label = (Label)panel.Controls["lb_num_" + num];
            int n=int.Parse(label.Text);
            if (n > 0)
                n--;
            label.Text = n + "";
            if (currentButton == bt_food)
                food.Rows[num - 1][2] = n;
            else
                drink.Rows[num - 1][2] = n;
            if (n <=0)
                ((Button)sender).Enabled = false;
            else
                ((Button)sender).Enabled = true;
            Button button = (Button)panel.Controls["bt_a_" + num];
            button.Enabled = true;
        }
        private void add_Click(object sender, EventArgs e)
        {
            int num = int.Parse(((Button)sender).Name.Substring(5));
            Panel panel = this.Controls.Find("pn_"+num, true).FirstOrDefault() as Panel;
            Label label= new Label();
            if (panel != null)
                label = (Label)panel.Controls["lb_num_" + num];
            int n = int.Parse(label.Text);
            n++;
            label.Text = n + "";
            int max;
            if (currentButton == bt_food)
            {
                food.Rows[num - 1][2] = n;
                max = (int)food.Rows[num - 1][3];
            }
            else
            {
                drink.Rows[num - 1][2] = n;
                max = (int)drink.Rows[num - 1][3];
            }

            if (n >= max)
                ((Button)sender).Enabled = false;
            else
                ((Button)sender).Enabled = true;
            Button button = (Button)panel.Controls["bt_s_" + num];
            button.Enabled = true;
        }
        private void panel_Click(object sender, EventArgs e)
        {
            Panel x= (Panel)sender;
            MessageBox.Show(x.Name);
        }
        public void ShiftButtonClickUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = bt_food.FlatAppearance.BorderColor;
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = Color.FromArgb(219, 250, 255);
            }
            currentButton = btn;
        }

        private void bt_food_Click(object sender, EventArgs e)
        {
            ShiftButtonClickUI(sender);
            pn_dish.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select * from Dishes where dishID like '%Food%'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i=0;i<table.Rows.Count;i++)
            {
                byte[] pic = (byte[])table.Rows[i][3];
                MemoryStream picture = new MemoryStream(pic);
                pn_dish.Controls.Add(createPanel("pn_"+(i+1), table.Rows[i][1].ToString(), picture));
            }
        }

        private void bt_drink_Click(object sender, EventArgs e)
        {
            ShiftButtonClickUI(sender);
            pn_dish.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select * from Dishes where dishID like '%Drink%'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                byte[] pic = (byte[])table.Rows[i][3];
                MemoryStream picture = new MemoryStream(pic);
                pn_dish.Controls.Add(createPanel("pn_" + (i + 1), table.Rows[i][1].ToString(), picture));
            }
        }

        private void bt_order_Click(object sender, EventArgs e)
        {
            food.Columns.RemoveAt(3);
            drink.Columns.RemoveAt(3);
            Order.food_Order = food;
            Order.drink_Order = drink;
            this.DialogResult = DialogResult.OK;
        }
    }
}
