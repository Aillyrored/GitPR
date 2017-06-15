using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_PR
{
    class CommunicationClient : InternetHelper
    {
        Label _conversation;
        Form1 WorkForm;
        public CommunicationClient(Label _conversation, Form1 WorkForm)
        {
            this._conversation = _conversation;
            this.WorkForm = WorkForm;
        }
        public void Client()
        {
            var clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            var localPoint = new IPEndPoint(IPAddress.Any, 3500);
            EndPoint endPoint = localPoint;

            var multicastIpAddress = IPAddress.Parse("224.5.6.7");
            var multicastGroupOption = new MulticastOption(multicastIpAddress);
            string Message = string.Empty;

            clientSocket.ExclusiveAddressUse = false;
            clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            clientSocket.Bind(localPoint);
            clientSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, multicastGroupOption);

            while (true)
            {
                var message = new byte[65535];

                try
                {
                    var revc = clientSocket.ReceiveFrom(message, ref endPoint);
                    var memoryStream = new MemoryStream(message, 0, revc);
                    var binaryReader = new BinaryReader(memoryStream);
                    Message = binaryReader.ReadString();
                    WorkForm.BeginInvoke(new MethodInvoker(delegate 
                    {
                        _conversation.Text +="<<Server>>: " + Message +"\n";
                    }));
                }
                catch (SocketException err)
                {
                    Console.WriteLine("SentTo Failed: {0}", err.Message);
                }

                Console.WriteLine("{0}" + Message);
            }
        }
    }
}
