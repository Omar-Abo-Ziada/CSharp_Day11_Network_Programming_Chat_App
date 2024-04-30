using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        StreamReader streamReader;

        StreamWriter streamWriter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Connect()
        {
            TcpClient tcpClient = new TcpClient();

            await tcpClient.ConnectAsync("127.0.0.1", 5500);

            //MessageBox.Show("Connected");

            NetworkStream networkStream = tcpClient.GetStream();

            streamReader = new StreamReader(networkStream);

            streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;

            while (true)
            {
                string msg = await streamReader.ReadLineAsync();

                //MessageBox.Show(msg);
                textBoxRecievedMessages.Text += Environment.NewLine;
                textBoxRecievedMessages.Text += msg;
            }
        }

        private void buttonSendMessages_Click(object sender, EventArgs e)
        {
            streamWriter.WriteLineAsync(textBoxSentMessages.Text);
            //streamWriter.Flush(); // senfing the written on streamWriter or just use make the autoFlush = true in the streamWriter props
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}
