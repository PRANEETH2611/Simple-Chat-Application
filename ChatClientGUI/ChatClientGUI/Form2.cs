using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatClientGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        UdpClient client;
        IPEndPoint remoteIP;
        int remotePort = 44444;

        private void Form2_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Bind client to any available port
                client = new UdpClient(0); // Automatically chooses a local port
                remoteIP = new IPEndPoint(IPAddress.Parse(txtRemoteIp.Text), remotePort);

                // Start receiving asynchronously
                client.BeginReceive(new AsyncCallback(onReceive), null);
                button1.Enabled = false; // Disable the connect button after connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void onReceive(IAsyncResult AR)
        {
            try
            {
                IPEndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] buff = client.EndReceive(AR, ref senderEndPoint);

                string message = Encoding.ASCII.GetString(buff);
                ControlInvoke(txtInMSG, () => txtInMSG.AppendText($"{senderEndPoint.Address}:>> {message}{Environment.NewLine}"));

                // Continue receiving messages
                client.BeginReceive(new AsyncCallback(onReceive), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Receive Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (client != null && remoteIP != null)
            {
                try
                {
                    string msg = txtMSG.Text;
                    byte[] data = Encoding.ASCII.GetBytes(msg);

                    // Send message to the server
                    client.Send(data, data.Length, remoteIP); // Send message to the server
                    txtMSG.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Send Error: " + ex.Message);
                }
            }
        }

        // Method to safely invoke UI updates
        delegate void UniversalVoidDelegate();
        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;
            if (control.InvokeRequired)
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
            else
                function();
        }
    }
}
