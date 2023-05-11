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
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
        }
        Methods methods = new Methods();
        Employee_Class employee = new Employee_Class();
        private void bt_add_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_manageAccount, new AddNewAccount(), 0); //thi dep trai
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_manageAccount, new EditAccount(), 0);
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            list_account.DataSource = employee.getEmployee(new System.Data.SqlClient.SqlCommand("select * from Employee"));
        }
    }
}
