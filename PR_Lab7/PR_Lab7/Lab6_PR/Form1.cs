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
            _communication_SERVER = new CommunicationServer(textBoxServer, buttonSendServer);
            _communication_CLIENT = new CommunicationClient(labelConversation,this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _clientThread = new Thread(() => Client());
            _serverThread = new Thread(() => Server());

            _clientThread.IsBackground = true;
            _serverThread.IsBackground = true;

            _clientThread.Start();
            _serverThread.Start();
        }
        private void Server()
        {
            _communication_SERVER.Server();
        }
        private void Client()
        {
            _communication_CLIENT.Client();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("////////*******" + _serverThread.Name + " : "+ _serverThread.ThreadState);
            Console.WriteLine("////////*******"+_clientThread.ThreadState);
        }
    }
}
