using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server_Multi
{
    public partial class Form1 : Form
    {
        Thread t1;
        int flag = 0;
        string receivedPath = "";
        string host_ = "";
        int port_ = 0;
        int t_check = 0;
        public delegate void MyDelegate();
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        public class StateObject
        {
            // Client socket.
            public Socket workSocket = null;

            public const int BufferSize = 8096;
            // Receive buffer.
            public byte[] buffer = new byte[BufferSize];
        }

        public static ManualResetEvent allDone = new ManualResetEvent(true);

        public void StartListening()
        {
            byte[] bytes = new Byte[8096];
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(host_), port_);
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(ipEnd);
                listener.Listen(100);
                logyaz("Listening For Connection");
                while (true)
                {
                    allDone.Reset();
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                    allDone.WaitOne();

                }
            }
            catch (Exception ex)
            {
            }

        }

        public void AcceptCallback(IAsyncResult ar)
        {
            allDone.Set();

            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
            flag = 0;

        }

        public void ReadCallback(IAsyncResult ar)
        {
            int fileNameLen = 1;
            String content = String.Empty;
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;
            int bytesRead = handler.EndReceive(ar);
            if (bytesRead > 0)
            {
                if (flag == 0)
                {
                    fileNameLen = BitConverter.ToInt32(state.buffer, 0);
                    fileName = Encoding.UTF8.GetString(state.buffer, 4, fileNameLen);
                    receivedPath = @"D:\" + fileName;
                    flag++;
                }

                if (flag >= 1)
                {
                    BinaryWriter writer = new BinaryWriter(File.Open(receivedPath, FileMode.Append));
                    if (flag == 1)
                    {
                        writer.Write(state.buffer, 4 + fileNameLen, bytesRead - (4 + fileNameLen));
                        flag++;
                    }
                    else
                        writer.Write(state.buffer, 0, bytesRead);
                    writer.Close();
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                }
            }
            else
            {
                Invoke(new MyDelegate(LabelWriter));
            }

        }

        public void LabelWriter()
        {
            label1.Text = "Data has been received " + fileName;
        }

        private void logyaz(string mesaj)
        {

            textBox_log.Text = Environment.NewLine + DateTime.Now.ToString() + "..." + mesaj.TrimEnd().ToString() + "......" + textBox_log.Text.TrimEnd().ToString();

            if (textBox_log.Text.TrimEnd().ToString().Length >= 32767) textBox_log.Clear();
            textBox_log.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get host name
            String strHostName = Dns.GetHostName();
            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            comboBox_Host.Items.Add("127.0.0.1");
            foreach(IPAddress ipaddress in iphostentry.AddressList)
            {
                comboBox_Host.Items.Add(ipaddress.ToString());
            }
            receivedPath = label_Folder.Text;
            comboBox_Host.SelectedIndex = 0;
        }

        private void button_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                label_Folder.Text = fd.SelectedPath;
                receivedPath = label_Folder.Text;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TcpClient tcpCheckClient = new TcpClient();
            //tcpCheckClient.Connect(host_, port_);
            if (t1.IsAlive){
                
                label_Status.Text = "ONLINE";
                button_Start.Enabled = false;
                button_Stop.Enabled = true;
                if (t_check == 0)
                {
                    logyaz(host_ + ":" + textBox_port.Text + "OPEN");
                }
                t_check++;
            } else {
                label_Status.Text = "OFFLINE";
                button_Start.Enabled = true;
                button_Stop.Enabled = false;
                logyaz(host_ + ":" + textBox_port.Text + "CLOSED");
                timer1.Enabled = false;
            }
        }
//START
        private void button_Start_Click(object sender, EventArgs e)
        {
            host_ = comboBox_Host.Text;
            port_ = Convert.ToInt32(textBox_port.Text);
            label_Status.Text = "ONLINE";
            button_Start.Enabled = false;
            button_Stop.Enabled = true;
            t1 = new Thread(new ThreadStart(StartListening));
            t1.Start();
            logyaz(host_ + ":" + textBox_port.Text + "OPEN");
            //timer1.Enabled = true;
        }
//STOP
        private void button_Stop_Click(object sender, EventArgs e)
        {
            t1.Abort();
            label_Status.Text = "OFFLINE";
            button_Start.Enabled = true;
            button_Stop.Enabled = false;
            logyaz(host_ + ":" + textBox_port.Text + "CLOSED");
        }

    }
}
