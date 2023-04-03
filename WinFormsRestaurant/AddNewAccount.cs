using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    public partial class AddNewAccount : Form
    {
        public AddNewAccount()
        {
            InitializeComponent();
        }
        static HttpClient client = new HttpClient();
        static List<Province> provinces = new List<Province>();
        static List<District> districts = new List<District>();
        static List<Ward> wards = new List<Ward>();
        static async Task getProvince()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            provinces = await Methods.GetProvincesAsync();
        }
        static async Task getDistrict(int provinceID)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            districts = await Methods.GetDistrictsAsync(provinceID);
        }
        static async Task getWard(int districtID)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            wards = await Methods.GetWardsAsync(districtID);
        }
        private void AddNewAccount_Load(object sender, EventArgs e)
        {
            getProvince();
        }

        private async void cb_province_Click(object sender, EventArgs e)
        {
            List<string> provinceNames = new List<string>();
            if (provinces.Count()!=0)
                provinceNames = provinces.Select(p => p.Name).ToList();
            // else // show error Internet connection do khong request dc API
            cb_province.Items.Clear();
            cb_province.Items.AddRange(provinceNames.ToArray());
        }

        private async void cb_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_district.SelectedIndex = -1;
            if (cb_province.SelectedIndex == -1)
                return;   // show label error chua chon Province
            await getDistrict(provinces[cb_province.SelectedIndex].code);
            List<string> districtNames = districts.Select(p => p.Name).ToList();
            cb_district.Items.Clear();
            cb_district.Items.AddRange(districtNames.ToArray());
        }

        private async void cb_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ward.SelectedIndex = -1;
            if (cb_district.SelectedIndex == -1)
                return;   //show label error chua chon District
            await getWard(districts[cb_district.SelectedIndex].code);
            List<string> wardNames = wards.Select(p => p.Name).ToList();
            cb_ward.Items.Clear();
            cb_ward.Items.AddRange(wardNames.ToArray());
        }
    }
}
