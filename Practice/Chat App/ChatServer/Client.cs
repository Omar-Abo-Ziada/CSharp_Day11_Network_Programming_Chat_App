using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ChatServer
{
    internal class Client
    {
        TcpClient tcpClient;
        StreamReader streamReader;
        StreamWriter streamWriter;

        public event Action<Client,string> MsgRecieved;

        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;

            NetworkStream networkStream = tcpClient.GetStream();

            streamReader = new StreamReader(networkStream);

            streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;

            RecieveMessages();
        }

        private async void RecieveMessages()
        {
            while (true)
            {
                string msg = await streamReader.ReadLineAsync();

                if (MsgRecieved != null)
                {
                    MsgRecieved(this, msg);
                }
            }
        }

        public async Task Send(string message)
        {
            await streamWriter.WriteLineAsync(message);
        }
    }
}
