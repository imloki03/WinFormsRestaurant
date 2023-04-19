﻿using System;
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
        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private Process process;
        public CheckIN_OUT()
        {
            InitializeComponent();
        }
        //string python = "C:\\Users\\21110\\AppData\\Local\\Programs\\Python\\Python311\\python.exe";
        string script = "E:\\Python\\FaceRecog\\recognition.py";
        private void CheckIN_OUT_Load(object sender, EventArgs e)
        {
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = script,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                }
            };
            process.Start();
    

            // Wait for process to exit

            client = new TcpClient("localhost", 8000);
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

                        // Update the PictureBox control in the UI thread
                        pb_camera.Invoke(new Action(() =>
                        {
                            pb_camera.Image = bmp;
                        }));
                    }
                }
                catch
                {
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
