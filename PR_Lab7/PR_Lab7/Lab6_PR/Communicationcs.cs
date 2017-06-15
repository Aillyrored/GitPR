using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_PR
{
    class CommunicationServer : InternetHelper
    {
        TextBox _textBoxMessage;
        Button _buttonSend;
        public CommunicationServer(TextBox _textBoxMessage , Button _buttonSend)
        {
            this._textBoxMessage = _textBoxMessage;
            this._buttonSend = _buttonSend;
        }
        public void Server()
        {
            var senderSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            var multicastIpAddress = IPAddress.Parse("224.5.6.7");
            senderSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(multicastIpAddress));
            senderSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);

            var remotEndPoint = new IPEndPoint(multicastIpAddress, 3500);
            senderSocket.Connect(remotEndPoint);
            Console.WriteLine("Starting Multicast");

            _buttonSend.Click+=(e,w)=>SendMessage(senderSocket);
        }
        public void SendMessage(Socket _senderSocket)
        {
            var input = _textBoxMessage.Text;
            var memoryStream = new MemoryStream();
            var binaryReader = new BinaryWriter(memoryStream);

            string Message = input;
            if (Message != null) binaryReader.Write(Message);
            var dataBytes = memoryStream.ToArray();

            Console.WriteLine("Sending to Clients...");
            try
            {
                _senderSocket.Send(dataBytes, dataBytes.Length, SocketFlags.None);
            }
            catch (SocketException err)
            {
                Console.WriteLine("SendTo Failed: {0}", err.Message);
            }
        }
    }
}
