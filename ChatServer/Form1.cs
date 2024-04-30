using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Start()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

            TcpListener tcpListener = new TcpListener(ipAddress, 5500);
            tcpListener.Start();

            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                Client client = new Client(tcpClient);
                client.MsgReceived += Client_MsgReceived;

                clients.Add(client);
            }
        }

        private void Client_MsgReceived(Client client, string message)
        {
            txtReceivedMessages.Text += Environment.NewLine;
            txtReceivedMessages.Text += message;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Client client in clients) 
            {
                await client.Send(txtMsg.Text);
            }
        }
    }
}
