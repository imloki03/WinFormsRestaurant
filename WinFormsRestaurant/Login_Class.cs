using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    internal class Login_Class
    {
        DB_Class db = new DB_Class();
        public bool checklogin(string username,string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table_lg = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table_lg);
            if ((table_lg.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool changepassword(string password,string username,string newpass,string confirmpass)
        {
            if (checklogin(username, password))
            {
                if (newpass != confirmpass)
                    return false;
                else
                {
                    db.openConnection();
                    SqlCommand command = new SqlCommand("UPDATE Login SET password = @new", db.getConnection);
                    command.Parameters.Add("@new", SqlDbType.NChar).Value = newpass;
                    try
                    {
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        return true;
                    }
                    catch
                    {
                        db.closeConnection();
                        return false;
                    }
                }
            }
            else
                return false;
        }
    }
}
