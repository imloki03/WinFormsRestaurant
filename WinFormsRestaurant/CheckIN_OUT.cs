using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    public partial class CheckIN_OUT : Form
    {
        Methods methods = new Methods();
        WorkSchedule_Class workSchedule = new WorkSchedule_Class();
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private Process process;

        public CheckIN_OUT()
        {
            InitializeComponent();
        }

        private void CheckIN_OUT_Load(object sender, EventArgs e)
        {
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = "recognition.py",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                }
            };
            process.Start();

            listener = new TcpListener(IPAddress.Any, 8000);
            listener.Start();

            // Accept client connection
            client = listener.AcceptTcpClient();
            stream = client.GetStream();
            reader = new BinaryReader(stream);

            // Start receiving images in a separate thread
            var t = new System.Threading.Thread(ReceiveImages);
            t.IsBackground = true;
            t.Start();
        }
        private void ReceiveImages()
        {
            while (true)
            {
                try
                {
                    // Read the image size
                    var size = reader.ReadInt32();

                    // Read the image data
                    var data = reader.ReadBytes(size);

                    // Decode the image into a Bitmap object
                    using (var ms = new MemoryStream(data))
                    {
                        var bmp = new Bitmap(ms);
                        bmp = methods.antimirror(bmp);
                        // Update the PictureBox control in the UI thread
                        pb_camera.Invoke(new Action(() =>
                        {
                            pb_camera.Image = bmp;
                        }));
                    }
                }
                catch (IOException)
                {
                    string output = process.StandardOutput.ReadToEnd().Trim();
                    if (output == StaticVars_Class.emID)
                    {
                        if (StaticVars_Class.state == StaticVars_Class.loginstate[0])
                        {
                            workSchedule.checkIn();
                            MessageBox.Show("Check-In Succesfully");
                        }
                        if (StaticVars_Class.state == StaticVars_Class.loginstate[1])
                        {
                            workSchedule.checkOut();
                            MessageBox.Show("Check-Out Succesfully");
                            Salary salary = new Salary();
                            salary.Show(this);
                        }
                    }
                    else
                        MessageBox.Show("Check-In Unsuccesfully!!!!");
                    this.Close(); 
                    break;
                }
            }
        }

        private void CheckIN_OUT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
