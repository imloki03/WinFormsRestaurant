using Pango;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Libs.ZXing;

namespace WinFormsRestaurant
{
    public partial class QRDiscount : Form
    {
        public QRDiscount()
        {
            InitializeComponent();
        }
        private BinaryReader reader;
        private Process process;
        private TcpClient client;
        private void QRDiscount_Load(object sender, EventArgs e)
        {
            var listener = new TcpListener(IPAddress.Loopback, 12345);
            listener.Start();
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = "QRscan.py",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                }
            };
            process.Start();


            client = listener.AcceptTcpClient();
            reader = new BinaryReader(client.GetStream());
            var t = new System.Threading.Thread(ReceiveImages);
            t.IsBackground = true;
            t.Start();
        }

        private void ReceiveImages()
        {
            bool isClientClosed = false; // Initialize the flag to false
            while (!isClientClosed)
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
                        pb_scan.Invoke(new Action(() =>
                        {
                            pb_scan.Image = bmp;
                        }));
                    }
                }
                catch (IOException)
                {
                    // Client disconnected, set the flag to true
                    isClientClosed = true;
                    string discode = process.StandardOutput.ReadToEnd().Trim();
                    this.Invoke(new Action(() =>
                    {
                        Reciept r = Application.OpenForms.OfType<Reciept>().FirstOrDefault();
                        DB_Class dB = new DB_Class();
                        SqlCommand cmd = new SqlCommand("SELECT Value FROM Discount WHERE DiscID = '"+discode+"'", dB.getConnection);
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                        int m = Int32.Parse(r.lb_money.Text);
                        m = m - (m * Int32.Parse(table.Rows[0][0].ToString()))/100;
                        r.lb_money.Text = m.ToString();
                        this.Close();
                    }));
                }
            }
        }
    }
}
