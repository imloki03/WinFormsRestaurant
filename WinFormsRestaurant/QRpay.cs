using System;
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
    public partial class QRpay : Form
    {
        public QRpay()
        {
            InitializeComponent();
        }
        private Process process;
        private void QRpay_Load(object sender, EventArgs e)
        {
            var listener = new TcpListener(IPAddress.Loopback, 12345);
            listener.Start();

            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = "Qrbank.py",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                }
            };
            process.Start();

            var client = listener.AcceptTcpClient();


            using (var stream = client.GetStream())
            {
                byte[] buffer = Encoding.ASCII.GetBytes(lb_money.Text);
                stream.Write(buffer, 0, buffer.Length);

                byte[] imgBytes = new byte[client.ReceiveBufferSize];
                int bytesRead = client.GetStream().Read(imgBytes, 0, client.ReceiveBufferSize);

                // Convert the bytes back into an image and display it in the picture box
                using (MemoryStream ms = new MemoryStream(imgBytes, 0, bytesRead))
                {
                    ms.Write(imgBytes, 0, bytesRead);
                    Image img = Image.FromStream(ms);
                    pb_qr.Image = img;
                }
            }
            listener.Stop();
        }
    }
}
