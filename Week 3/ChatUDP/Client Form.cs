using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUDP
{
    public partial class client_chat : Form
    {
        string LocalPort = "10";
        string RemotePort = "1000";
        UdpClient applications = new UdpClient();
        Thread thread;
        bool exit = false;
        private server_chat serverchat;
        delegate void ClearCacheReceivedData(string Data, string RemoteHost);

        public client_chat()
        {
            InitializeComponent();
            serverchat = new server_chat();
            serverchat.Show(this);
        }
        private void SentData()
        {
            byte[] msg;
            msg = System.Text.Encoding.UTF8.GetBytes(tb_chatbox.Text);
            applications.Send(msg, msg.Length, tb_ServerIpAddress.Text, int.Parse(RemotePort));
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
                }
            }
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            LocalPort = this.tb_ClientPort.Text;
            RemotePort = this.tb_ServerPort.Text;
            applications = new UdpClient(int.Parse(LocalPort));
            thread = new Thread(Explore);
            thread.Start();
            this.bt_send.Enabled = true;
            this.bt_connect.Enabled = false;
            tb_ServerIpAddress.ReadOnly = tb_ClientPort.ReadOnly = tb_ServerPort.ReadOnly = true;
        }
        private void bt_send_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(tb_ServerIpAddress.Text, out ip))
                MessageBox.Show("Please provide IP address of receiver", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SentData();
                lstSent.Items.Insert(0, tb_chatbox.Text);
                tb_chatbox.Clear();
            }
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
