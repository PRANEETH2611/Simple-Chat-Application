using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatServerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient server;
        IPEndPoint remoteIP; // This will be dynamically updated with the client's IP
        int listenPort = 44444; // Listening port
        int remotePort = 55555; // Remote port to send data to

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the server to listen on listenPort
                server = new UdpClient(listenPort);
                server.BeginReceive(new AsyncCallback(onReceive), null);
                button1.Enabled = false; // Disable connect button after server starts listening
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
                byte[] buff = server.EndReceive(AR, ref senderEndPoint);

                string message = Encoding.ASCII.GetString(buff);
                ControlInvoke(txtInMSG, () => txtInMSG.AppendText($"{senderEndPoint.Address}:>> {message}{Environment.NewLine}"));

                // Dynamically update remoteIP to respond to the client who sent the message
                remoteIP = senderEndPoint;

                // Continue receiving messages
                server.BeginReceive(new AsyncCallback(onReceive), server);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Receive Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (server != null && remoteIP != null)
            {
                try
                {
                    string msg = txtMSG.Text;
                    byte[] data = Encoding.ASCII.GetBytes(msg);

                    // Send the message to the dynamically updated remoteIP
                    server.Send(data, data.Length, remoteIP); // Sending message back to the last known remoteIP

                    txtMSG.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Send Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No client connected. Please wait for a client to send a message.");
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
