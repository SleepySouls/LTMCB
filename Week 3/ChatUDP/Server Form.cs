using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUDP
{
    public partial class server_chat : Form
    {
        string LocalPort = "10";
        string RemotePort = "1000";
        UdpClient applications = new UdpClient();
        Thread thread;
        bool exit = false;
        delegate void ClearCacheReceivedData(string Data, string RemoteHost);
        public server_chat()
        {
            InitializeComponent();
        }

        private void ReceivedData(string Data, string RemoteHost)
        {
            if (lstReceived.InvokeRequired)
            {
                ClearCacheReceivedData clearCacheReceivedData = new ClearCacheReceivedData(ReceivedData);
                lstReceived.Invoke(clearCacheReceivedData, new object[] { Data, RemoteHost });
                return;
            }
            string msg = "";
            msg = RemoteHost + "(Client): " + Data;
            lstReceived.Items.Insert(0, msg);
        }

        private void Explore()
        {
            IPAddress ip;
            byte[] msg;
            string str = "";
            ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, Convert.ToInt16(RemotePort));
            while (exit == false)
            {
                Application.DoEvents();
                if (applications.Available > 0)
                {
                    msg = applications.Receive(ref ep);
                    str = System.Text.Encoding.UTF8.GetString(msg);
                    ReceivedData(str, ep.Address.ToString());
                }
            }
        }
        private void bt_connect_Click(object sender, EventArgs e)
        {
            LocalPort = this.tb_ServerPort.Text;
            RemotePort = this.tb_ClientPort.Text;
            applications = new UdpClient(int.Parse(LocalPort));
            thread = new Thread(Explore);
            thread.Start();
            this.bt_connect.Enabled = false;
            tb_ClientIpAddress.ReadOnly = tb_ServerPort.ReadOnly = tb_ClientPort.ReadOnly = true;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
