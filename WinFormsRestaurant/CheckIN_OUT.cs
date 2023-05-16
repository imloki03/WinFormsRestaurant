﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private Process process;
        public CheckIN_OUT()
        {
            InitializeComponent();
        }
        string script = "E:\\Python\\FaceRecog\\recognition.py";
        private void CheckIN_OUT_Load(object sender, EventArgs e)
        {
            //process = new Process
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = "python",
            //        Arguments = script,
            //        UseShellExecute = false,
            //        RedirectStandardOutput = true,
            //        RedirectStandardError = true,
            //        CreateNoWindow = true,
            //    }
            //};
            //process.Start();


            //// Wait for process to exit

            //client = new TcpClient("localhost", 8000);
            //stream = client.GetStream();
            //reader = new BinaryReader(stream);

            //// Start receiving images in a separate thread
            //var t = new System.Threading.Thread(ReceiveImages);
            //t.IsBackground = true;
            //t.Start();
            if (StaticVars_Class.state == StaticVars_Class.loginstate[0])
                workSchedule.checkIn();
            if (StaticVars_Class.state == StaticVars_Class.loginstate[1])
                workSchedule.checkOut();

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
                    MessageBox.Show(output);
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
