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

namespace TCP_Client_Multi
{
    public partial class Form1 : Form
    {
        string splitter = "'\\'";
        string fName;
        string[] split = null;
        byte[] clientData;

        public Form1()
        {
            InitializeComponent();
            button_Send.Enabled = false;
        }

        private void button_Dlg_Click(object sender, EventArgs e)
        {
            char[] delimiter = splitter.ToCharArray();
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_File.Text = openFileDialog1.FileName;
                textBox_log.AppendText("Selected file " + textBox_File.Text);
                button_Send.Enabled = true;
            }
            else
            {
                textBox_log.AppendText("Please Select any one file to send");
                button_Send.Enabled= false;
            }

            split = textBox_File.Text.Split(delimiter);
            int limit = split.Length;
            fName = split[limit - 1].ToString();
            if (textBox_File.Text != null)
                button_Dlg.Enabled = true;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ip = new IPAddress;


            byte[] fileName = Encoding.UTF8.GetBytes(fName); //file name
            byte[] fileData = File.ReadAllBytes(textBox_File.Text); //file
            byte[] fileNameLen = BitConverter.GetBytes(fileName.Length); //lenght of file name
            clientData = new byte[4 + fileName.Length + fileData.Length];

            fileNameLen.CopyTo(clientData, 0);
            fileName.CopyTo(clientData, 4);
            fileData.CopyTo(clientData, 4 + fileName.Length);

            textBox_log.AppendText("Preparing File To Send");
            clientSock.Connect(textBox_Host.Text, Convert.ToInt32(textBox_Port.Text)); //target machine's ip address and the port number
            clientSock.Send(clientData);
            //clientSock.
            clientSock.Close();
        }
    }
}
