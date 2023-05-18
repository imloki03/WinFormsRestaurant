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
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();
        }
        public string oderid;
        public int table;
        public int qguest;
        Order_Class order = new Order_Class();
        Employee_Class employee = new Employee_Class();
        Bill_Class bill = new Bill_Class();
        private void Reciept_Load(object sender, EventArgs e)
        {
            dv_bill.DataSource = order.getOder(new System.Data.SqlClient.SqlCommand("SELECT name as Dishes, cost as UnitPrice, quantity As Quantity FROM [ORDER] o, Dishes d WHERE d.dishID = o.dishID AND o.orderID = '" + oderid + "'"));
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Ammount";
            dv_bill.Columns.Add(column);
            int t = 0;
            foreach(DataGridViewRow row in dv_bill.Rows)
            {
                int cell1Value;
                int cell2Value;
                Int32.TryParse(row.Cells[1].Value?.ToString(), out cell1Value);
                Int32.TryParse(row.Cells[2].Value?.ToString(), out cell2Value);
                int result = cell1Value * cell2Value;
                row.Cells[3].Value = result.ToString();
                t += Int32.Parse(row.Cells[3].Value.ToString());

            }
            lb_date.Text = "Date: " + DateTime.Now.ToString("dd//MM/yy");
            lb_time.Text = "Print Time: " +  DateTime.Now.ToString("hh:mm");
            //lb_cashier.Text = "Cashier: " + employee.getEmName(StaticVars_Class.emID);
            lb_bilnumber.Text = "Bill Num: " + bill.getNextBillID();
            lb_table.Text = "Table " + table;
            lb_money.Text = t.ToString() ;
            
            string tableid;
            if (table < 10)
                tableid = "Table0" + table.ToString();
            else
                tableid = "Table" + table.ToString();

            bill.addBill(qguest, t, tableid, oderid, DateTime.Now);
        }

        private void bt_qrpay_Click(object sender, EventArgs e)
        {
            QRpay payQR = new QRpay();
            payQR.lb_billnumber.Text = this.lb_bilnumber.Text;
            payQR.lb_money.Text = this.lb_money.Text;
            payQR.lb_printtime.Text = DateTime.Now.ToString("hh:mm") +" "+ DateTime.Now.ToString("dd//MM/yy");
            payQR.Show(this);
        }

        private void bt_scanqr_Click(object sender, EventArgs e)
        {
            QRDiscount qrDiscount = new QRDiscount();
            qrDiscount.Show(this);
        }
    }
}
