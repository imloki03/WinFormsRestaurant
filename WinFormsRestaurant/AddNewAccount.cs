using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.MediaFramework.FFMPEGCore.Enums;
using VisioForge.MediaFramework.Helpers;

namespace WinFormsRestaurant
{
    public partial class AddNewAccount : Form
    {

        public AddNewAccount()
        {
            InitializeComponent();
        }

        VideoCaptureDevice device = new VideoCaptureDevice();
        private VideoCapture video_capture;
        private Bitmap image;

        Methods methods = new Methods();
        Exception_Class exc = new Exception_Class();
        Employee_Class emp = new Employee_Class();

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
            pg_scan.Minimum = 0;
            pg_scan.Maximum = 100;
            VideoCaptureDeviceForm deviceForm = new VideoCaptureDeviceForm();
            if (deviceForm.ShowDialog() == DialogResult.OK)
                device = deviceForm.VideoDevice;
            device = deviceForm.VideoDevice;
            device.NewFrame += new NewFrameEventHandler(video_NewFrame);
            device.Start();
            bt_add.Enabled = false;
            getProvince();
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            img = methods.antimirror(img);
            pb_camera.Image = img;
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


        private void bt_scan_Click(object sender, EventArgs e)
        {
            if (exc.BlankBox(this))
            {
                while (pg_scan.Value != 100)
                {
                    if (pg_scan.Value + 100 / 8 < 100)
                    {
                        pg_scan.Value += 100 / 8;
                    }
                    else
                    {
                        pg_scan.Value = 100;
                        bt_scan.Enabled = false;
                        bt_add.Enabled = true;
                    }

                    int duplicateCount = 0;
                    string fileName = emp.getNextEmID();
                    string fileExtension = ".png";
                    string newFileName = fileName;
         
                    string cDirectory = Directory.GetCurrentDirectory();
                    // Combine the current directory path with the folder name
                    string fPath = Path.Combine(cDirectory, "Faces");
                    // Check if the folder already exists
                    if (Directory.Exists(fPath))
                    {
                        // Get the current directory path
                        string currentDirectory = Directory.GetCurrentDirectory();
                        // Combine the current directory path with the folder name
                        string folderPath = Path.Combine(currentDirectory + "\\Faces", fileName);
                        // Check if the folder already exists
                        if (Directory.Exists(folderPath))
                        {
                            Bitmap varBmp = new Bitmap(pb_camera.Image);
                            Bitmap newBitmap = new Bitmap(varBmp);
                            while (File.Exists(folderPath + "\\" + newFileName + fileExtension))
                            {
                                duplicateCount++;
                                newFileName = fileName + " (" + duplicateCount.ToString() + ")";
                            }
                            varBmp.Save(folderPath + "\\" + newFileName + fileExtension, ImageFormat.Png);
                            varBmp.Save(picture, ImageFormat.Png);
                            //Now Dispose to free the memory
                            varBmp.Dispose();
                            varBmp = null;
                        }
                        // Create the folder
                        Directory.CreateDirectory(folderPath);
                    }
                    // Create the folder
                    Directory.CreateDirectory(fPath);           
                    Thread.Sleep(1000);
                }
            }
            else
                MessageBox.Show("Missing Fields");
        }

        int i = 0;

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            device.Stop();
        }
        MemoryStream picture = new MemoryStream();
        private void bt_add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            bool gender;
            if (rb_male.Checked)
                gender = true;
            else
                gender = false;
            string phone = tb_phone.Text;
            string address = tb_street.Text+" "+cb_ward.Text+" "+cb_district.Text+cb_province.Text;
            string birthday = dt_birthday.Value.Date.ToString();
      
            emp.addEmployee(name, gender, phone, address, birthday, picture);
        }
    }
}
    
