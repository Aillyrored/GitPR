using System;
using System.Collections.Generic;
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

        private Socket _connectedClient;
        private Form1 WorkForm;
        private int _listenPort = 50000;
        private Label _labelConnectedTo;
        private string ipAddress_External => GetExternalIp();
        private string ipAddress_Local => GetLocalIPAddress();

        public CommunicationServer(Form1 WorkForm, Label _labelConnectedTo)
        {
            this.WorkForm = WorkForm;
            this._labelConnectedTo = _labelConnectedTo;
        }
        public void Listen()
        {
            //ip-addresa pentru a face conexiunea ->127.0.0.1 este localhost
            var _ipToListen = "127.0.0.1";
            
            //setting up socket for listening
            IPEndPoint _localEndPoint = new IPEndPoint(IPAddress.Parse(_ipToListen), _listenPort);

            //setarea serverului
            Socket _server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            _server.Bind(_localEndPoint);
            _server.Listen(1);

            //notoficarea utilizatorului despre inceputul ascultarii
            WorkForm.BeginInvoke(new MethodInvoker(delegate
            {
                WorkForm.labelConversation.Text += ("<--Listening--> on" + _ipToListen);
                WorkForm.buttonConnectClient.Enabled = true;
                WorkForm.buttonListen.Enabled = false;
            }));

            //asteptare unui client pentru a se conecta
            Socket _client = _server.Accept();

            WorkForm.BeginInvoke(new MethodInvoker(delegate
            {
                _labelConnectedTo.Visible = true;
                _labelConnectedTo.Text += _client.RemoteEndPoint;
            }));
            Console.WriteLine("<--Connected to-->" + _client.RemoteEndPoint);
            _connectedClient = _client;

            //primeste mesaje de la client
            new Thread(() => RecieveCommand()).Start();
        }
        public void RecieveCommand()
        {
            CommandModel _command = new CommandModel();
            string _serializedCommand = string.Empty;
            byte[] buffer = new byte[4096];

            while (true)
            {
                try
                {
                    _serializedCommand = Encoding.ASCII.GetString(buffer, 0, _connectedClient.Receive(buffer));
                }
                catch
                {

                    return;
                }
                if (!string.IsNullOrEmpty(_serializedCommand))
                    _command = Newtonsoft.Json.JsonConvert.DeserializeObject<CommandModel>(_serializedCommand.Split('}').FirstOrDefault() + "}");
                if (_command.Data.Contains("sum")) _command.Command = Command.Sum;
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
                                //intoarce serverului comanda de conectare
                                SendComand(new CommandModel { Command = Command.Connect, Data = string.Empty });
                            }
                            break;
                        case Command.Message:
                            {
                                //afisarea mesajului
                                WorkForm.BeginInvoke(new MethodInvoker(delegate { WorkForm.labelConversation.Text += "\nClient - >   " + _command.Data; }));
                            }break;
                        case Command.Sum:
                            {
                                var _data = _command.Data.Split('m');
                                if (_data[1].Contains(","))
                                {
                                    string[] _nums = _data[1].Split(',');
                                    int _result = 0;
                                    foreach (var element in _nums)
                                    {
                                        _result += Int32.Parse(element);
                                    }
                                    SendComand(new CommandModel { Data = _result.ToString(), Command = Command.Message });
                                }
                                else
                                    WorkForm.BeginInvoke(new MethodInvoker(delegate { WorkForm.labelConversation.Text += "/** Numerele care urmeaza sa fie adunate trebuie scrise prin virgula fara spsatiu **\\"; }));


                                //afisarea mesajului
                            }
                            break;
                    }
                }
            }
        }
        public void ReleaseSocket()
        {
            SendComand(new CommandModel { Command = Command.Quit, Data = string.Empty });
            _connectedClient.Disconnect(true);
            _connectedClient.Close();
        }
        public void SendComand(CommandModel _command)
        {
            string _serializedCommand = Newtonsoft.Json.JsonConvert.SerializeObject(_command);
            Byte[] buffer = Encoding.ASCII.GetBytes(_serializedCommand);
            _connectedClient.Send(buffer);
        }

    }
}
