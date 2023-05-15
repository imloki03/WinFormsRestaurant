using Emgu.CV.ML;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Province
{
    public int code { get; set; }
    public string Name { get; set; }
}

public class District
{
    public int code { get; set; }
    public string Name { get; set; }
    public int ProvinceId { get; set; }
}
public class ProvinceResponse
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("districts")]
    public List<District> Districts { get; set; }
}
public class Ward
{
    public int code { get; set; }
    public string Name { get; set; }
    public int DistrictId { get; set; }
}
public class DistrictResponse
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("wards")]
    public List<Ward> Wards { get; set; }
}
namespace WinFormsRestaurant
{
    public class Methods
    {
        private static string RemoveVietnameseSigns(string text)
        {
            // Thay thế các ký tự có dấu thành các ký tự không dấu
            string[] fromChars = new string[] { "à", "á", "ạ", "ả", "ã", "â", "ầ", "ấ", "ậ", "ẩ", "ẫ", "ă", "ằ", "ắ", "ặ", "ẳ", "ẵ", "è", "é", "ẹ", "ẻ", "ẽ", "ê", "ề", "ế", "ệ", "ể", "ễ", "ì", "í", "ị", "ỉ", "ĩ", "ò", "ó", "ọ", "ỏ", "õ", "ô", "ồ", "ố", "ộ", "ổ", "ỗ", "ơ", "ờ", "ớ", "ợ", "ở", "ỡ", "ù", "ú", "ụ", "ủ", "ũ", "ư", "ừ", "ứ", "ự", "ử", "ữ", "ỳ", "ý", "ỵ", "ỷ", "ỹ", "đ" };
            string[] toChars = new string[]   { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y", "d" };
            for (int i = 0; i < fromChars.Length; i++)
            {
                text = Regex.Replace(text, fromChars[i], toChars[i], RegexOptions.IgnoreCase);
            }
            for (int i = 1; i < text.Length; i++)
                if (text[i - 1] == ' ')
                    text = text.Substring(0, i) + Char.ToUpper(text[i]) + text.Substring(i + 1);
            return text;
        }
        static HttpClient client = new HttpClient();
        public static async Task<List<Province>> GetProvincesAsync()
        {
            List<Province> provinces = new List<Province>();
            HttpResponseMessage response = await client.GetAsync("https://provinces.open-api.vn/api/p/");

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                provinces = JsonConvert.DeserializeObject<List<Province>>(content);
            }
            foreach (Province province in provinces)
            {
                province.Name = RemoveVietnameseSigns(province.Name);
            }
            return provinces;
        }

        public static async Task<List<District>> GetDistrictsAsync(int provinceId)
        {
            List<District> districts = new List<District>();
            HttpResponseMessage response = await client.GetAsync($"https://provinces.open-api.vn/api/p/{provinceId}/?depth=2");

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                ProvinceResponse provinceResponse = JsonConvert.DeserializeObject<ProvinceResponse>(content);
                districts = provinceResponse.Districts;
            }
            foreach (District district in districts)
            {
                district.Name = RemoveVietnameseSigns(district.Name);
            }
            return districts;
        }

        public static async Task<List<Ward>> GetWardsAsync(int districtId)
        {
            List<Ward> wards = new List<Ward>();
            HttpResponseMessage response = await client.GetAsync($"https://provinces.open-api.vn/api/d/{districtId}/?depth=2");

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                DistrictResponse districtResponse = JsonConvert.DeserializeObject<DistrictResponse>(content);
                wards = districtResponse.Wards;
            }
            foreach (Ward ward in wards)
            {
                ward.Name = RemoveVietnameseSigns(ward.Name);
            }
            return wards;
        }


        public Bitmap antimirror(Bitmap bmp)
        {
            Bitmap result = new Bitmap(bmp.Width, bmp.Height);

            // Flip the original bitmap horizontally and copy it to the new bitmap
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0);
            }

            // Flip the original bitmap back to its original orientation
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

            return result;
        }
        public void fillPanel(Panel panel, Form childform, int clear)
        {
            childform.Dock = DockStyle.Fill;
            if (clear == 1)
                panel.Controls.Clear();
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.TopLevel = false;
            panel.Controls.Add(childform);
            panel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        Employee_Class emp = new Employee_Class();
        public void scheduleShift(int x)    //x: employee/shift
        {
            int n = emp.amountOfEmloyees();
            //them mot exception neu x>n thi return error
            int T = (n % x != 0 ? n : n / x);  // circle
            DateTime shift = DateTime.Now;
            DB_Class db = new DB_Class();
            SqlCommand cmd = new SqlCommand();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            db.openConnection();
            cmd = new SqlCommand("delete from WorkSchedule", db.getConnection);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from Shifts", db.getConnection);
            cmd.ExecuteNonQuery();
            for (int i = 1; i <= T; i++)
            {
                shift = shift.AddDays(1);
                cmd = new SqlCommand("insert into Shifts values ([dbo].[AUTO_IDShift](), @shift, '6:00AM - 10:00AM')", db.getConnection);
                cmd.Parameters.Add("@shift", System.Data.SqlDbType.DateTime).Value = shift;
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("insert into Shifts values ([dbo].[AUTO_IDShift](), @shift, '11:00AM - 3:00PM')", db.getConnection);
                cmd.Parameters.Add("@shift", System.Data.SqlDbType.DateTime).Value = shift;
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("insert into Shifts values ([dbo].[AUTO_IDShift](), @shift, '6:00PM - 10:00PM')", db.getConnection);
                cmd.Parameters.Add("@shift", System.Data.SqlDbType.DateTime).Value = shift;
                cmd.ExecuteNonQuery();
            }

            //phan ca sang
            for (int i=0;i<T*x;i=i+x)
            {
                table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Shifts where Shift='6:00AM - 10:00AM' ORDER BY ShiftID OFFSET @num ROWS FETCH NEXT 1 ROWS ONLY", db.getConnection);
                command.Parameters.Add("@num", System.Data.SqlDbType.Int).Value = i/x;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                string sid = table.Rows[0][0].ToString();
                for (int j=0;j<x;j++)
                {
                    string eid = emp.getEmID((i+j) % n);
                    cmd = new SqlCommand("insert into WorkSchedule(EmployeeID, ShiftID) values (@eid, @sid)", db.getConnection);
                    cmd.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
                    cmd.Parameters.Add("@sid", System.Data.SqlDbType.NVarChar).Value = sid;
                    cmd.ExecuteNonQuery();
                }
            }

            //phan ca trua
            for (int i = 0; i < T * x; i = i + x)
            {
                table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Shifts where Shift='11:00AM - 3:00PM' ORDER BY ShiftID OFFSET @num ROWS FETCH NEXT 1 ROWS ONLY", db.getConnection);
                command.Parameters.Add("@num", System.Data.SqlDbType.Int).Value = ((i / x) + (T - 1)) % T;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                string sid = table.Rows[0][0].ToString();
                for (int j = 0; j < x; j++)
                {
                    string eid = emp.getEmID((i + j) % n);
                    cmd = new SqlCommand("insert into WorkSchedule(EmployeeID, ShiftID) values (@eid, @sid)", db.getConnection);
                    cmd.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
                    cmd.Parameters.Add("@sid", System.Data.SqlDbType.NVarChar).Value = sid;
                    cmd.ExecuteNonQuery();
                }
            }

            //phan ca toi
            for (int i = 0; i < T * x; i = i + x)
            {
                table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Shifts where Shift='6:00PM - 10:00PM' ORDER BY ShiftID OFFSET @num ROWS FETCH NEXT 1 ROWS ONLY", db.getConnection);
                command.Parameters.Add("@num", System.Data.SqlDbType.Int).Value = ((i / x) + (T - 2)) % T;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                string sid = table.Rows[0][0].ToString();
                for (int j = 0; j < x; j++)
                {
                    string eid = emp.getEmID((i + j) % n);
                    cmd = new SqlCommand("insert into WorkSchedule(EmployeeID, ShiftID) values (@eid, @sid)", db.getConnection);
                    cmd.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
                    cmd.Parameters.Add("@sid", System.Data.SqlDbType.NVarChar).Value = sid;
                    cmd.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
    }
}
