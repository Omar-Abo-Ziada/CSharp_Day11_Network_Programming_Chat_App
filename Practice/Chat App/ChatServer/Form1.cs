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
        //StreamReader streamReader;

        //StreamWriter streamWriter;

        List<Client> clients = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private async void Start()
        {
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");

            TcpListener tcpListener = new TcpListener(iPAddress, 5500);

            tcpListener.Start();

            while (true)
            {
                //Task.Run(()=> tcpListener.AcceptTcpClient());  // another thread
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();  // or use the Asyc version

                Client client = new Client(tcpClient);
                client.MsgRecieved += Client_MsgRecieved;

                clients.Add(client);
            }
        }

        private void Client_MsgRecieved(Client client, string msg)
        {
            textBoxRecievedMessages.Text += Environment.NewLine + msg;
        }

        private async void buttonSendMessages_Click(object sender, EventArgs e)
        {
            //streamWriter.WriteLineAsync(textBoxSentMessages.Text);

            foreach (Client client in clients)
            {
                await client.Send(textBoxSentMessages.Text);
            }
        }
    }
}
