using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_PR
{
    public partial class Form1 : Form
    {
        private const string _ip = "127.0.0.1";

        private CommunicationClient _communication_CLIENT;
        private CommunicationServer _communication_SERVER;

        private Thread _serverThread; 
        private Thread _clientThread;
        public Form1()
        {
            InitializeComponent();
            buttonConnectClient.Enabled = false;
            buttonSClient.Enabled = false;

            _communication_SERVER = new CommunicationServer(this, labelConnectedTo_Server);
            _communication_CLIENT = new CommunicationClient(this, labelConnectedTo_Client);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _clientThread = new Thread(() => Client());
            _serverThread = new Thread(() => Server());

            buttonConnectClient.Click+= (ee,w)=> _clientThread.Start();
            buttonListen.Click += (ee, w) => _serverThread.Start();

            labelConnectedTo_Client.Visible = false;
            labelConnectedTo_Server.Visible = false;
        }
        private void Server()
        {
            _communication_SERVER.Listen();

            BeginInvoke(new MethodInvoker(delegate
            {
                buttonConnectClient.Enabled = false;
                buttonSClient.Enabled = true;
            }));

            buttonSendServer.Click += (o, e) => 
            {
                _communication_SERVER.SendComand(new CommandModel { Command = Command.Message, Data = textBoxServer.Text });
            };

            _communication_SERVER.RecieveCommand();
        }
        private void Client()
        {
            buttonSClient.Click += (o, e) =>
            {
                _communication_CLIENT.Send(new CommandModel { Command = Command.Message, Data = textBoxClient.Text }, _ip);
            };

            _communication_CLIENT.Send(new CommandModel {Command = Command.Connect , Data = string.Empty }, _ip);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("////////*******" + _serverThread.ThreadState);
            Console.WriteLine("////////*******"+_clientThread.ThreadState);
        }
    }
}
