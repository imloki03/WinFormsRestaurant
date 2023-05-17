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
    public partial class _0_Temp_addDish : Form
    {
        public _0_Temp_addDish()
        {
            InitializeComponent();
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_picture.SizeMode = PictureBoxSizeMode.Zoom;
                pic_picture.Image = Image.FromFile(opf.FileName);
            }
        }
        DB_Class db = new DB_Class();   
        private void bt_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Dishes SET picture=@pic", db.getConnection);
            MemoryStream pic = new MemoryStream();
            pic_picture.Image.Save(pic, pic_picture.Image.RawFormat);
            cmd.Parameters.Add("@pic", System.Data.SqlDbType.Image).Value = pic.ToArray();
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
