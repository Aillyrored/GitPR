using System;
using System.Collections.Generic;
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
        private Socket server;
        private int _listenPort = 50000;
        private Label _labelConnectedTo;
        private Form1 WorkForm;

        public CommunicationClient(Form1 WorkForm, Label _labelConnectedTo)
        {
            this._labelConnectedTo = _labelConnectedTo;
            this.WorkForm = WorkForm;
        }
        public Socket ConnectSocket(IPEndPoint _ipEndPoint)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (server.Connected)
                server.Disconnect(true);
            server.Connect(_ipEndPoint);
            WorkForm.BeginInvoke(new MethodInvoker(delegate 
            {
                _labelConnectedTo.Visible = true;
                _labelConnectedTo.Text += server.RemoteEndPoint;
            }));
            RecieveCommand();
            return server;
        }
        public void Send(CommandModel _command, string IpAddress)
        {
            //create server
            if (server?.Connected != true)
                server = ConnectSocket(new IPEndPoint(IPAddress.Parse(IpAddress), _listenPort));

            //send
            var _serializedCommand = Newtonsoft.Json.JsonConvert.SerializeObject(_command);
            Byte[] buffer = Encoding.ASCII.GetBytes(_serializedCommand);
            server.Send(buffer);
        }
        private void RecieveCommand()
        {
            CommandModel _command = new CommandModel();
            string _serializedCommand = string.Empty;
            byte[] buffer = new byte[4096];

            while (true)
            {
                try
                {
                    _serializedCommand = Encoding.ASCII.GetString(buffer, 0, server.Receive(buffer));
                }
                catch
                {
                    return;
                }
                if (!string.IsNullOrEmpty(_serializedCommand))
                    _command = Newtonsoft.Json.JsonConvert.DeserializeObject<CommandModel>(_serializedCommand.Split('}').FirstOrDefault() + "}");
                if (_command != null)
                {
                    switch (_command.Command)
                    {
                        case Command.Quit:
                            {
                                Console.WriteLine("\n<--Stopped Listenning-->");
                                return;
                            };
                        case Command.Connect:
                            {
                                Send(new CommandModel { Command = Command.Connect, Data = string.Empty }, "127.0.0.1");
                                WorkForm.BeginInvoke(new MethodInvoker(delegate { WorkForm.labelConversation.Text += "<--Connected-->"; }));
                            }
                            break;
                        case Command.Message:
                            {
                                WorkForm.BeginInvoke(new MethodInvoker(delegate { WorkForm.labelConversation.Text += "\nServer - >  " + _command.Data;}));
                            }
                            break;
                    }
                }
            }
        }
    }
}
