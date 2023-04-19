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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsRestaurant
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            Employee_Class employee = new Employee_Class();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE account = @acc");
            command.Parameters.Add("@acc", SqlDbType.NVarChar).Value = StaticVars_Class.username;
            DataTable table_emp = employee.getEmployee(command);
            lb_fullname.Text = table_emp.Rows[0]["Name"].ToString();
            DateTime dateOnly = (DateTime)table_emp.Rows[0]["BirthDate"];
            lb_birth.Text = dateOnly.Date.ToString("dd/MM/yyyy");
            lb_phone.Text = table_emp.Rows[0]["Phone"].ToString();
            lb_jobtitle.Text = table_emp.Rows[0]["JobTitle"].ToString();
            //byte[] imageData = (byte[])table_emp.Rows[0]["Picture"];
            //Bitmap imageBitmap = new Bitmap(new MemoryStream(imageData));
            //overView.pb_avatar.Image = imageBitmap;
            bool gender = Convert.ToBoolean(table_emp.Rows[0]["Gender"]);

            if (gender)
                rb_male.Checked = true;
            else
                rb_female.Checked = true;

            
        }
    }
}
