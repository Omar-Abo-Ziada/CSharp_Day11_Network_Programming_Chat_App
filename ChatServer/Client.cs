using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    internal class Client
    {
        TcpClient tcpClient;
        StreamReader streamReader;
        StreamWriter streamWriter;

        public event Action<Client, string> MsgReceived;

        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;

            NetworkStream stream = tcpClient.GetStream();

            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            streamWriter.AutoFlush = true;

            RecieveMessages();

        }

        private async void RecieveMessages()
        {
            while (true)
            {
                string msg = await streamReader.ReadLineAsync();

                if(MsgReceived != null) 
                {
                    MsgReceived(this, msg);
                }
            }
        }

        public async Task Send(string message) 
        {
            await streamWriter.WriteLineAsync(message);
        }
    }
}
