using A1lib;
using A1lib.AdvancedTopicsA1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Final
{
    public partial class Form1 : Form
    {
        private MessageClient myclient;
        public Form1()
        {
            InitializeComponent();


            myclient = new MessageClient();

            myclient.ClientConnected += OnConnection;

            myclient.ClientDisconnected += OnDisconnect;

            myclient.MessageSent += OnMessageSent;

            myclient.MessageReceived += OnMessageReceived;
        }

        private void OnMessageReceived(string message)
        {
            listBox1.Items.Add("Received: " + message);

        }

        private void OnMessageSent(string message)
        {

            listBox1.Items.Add("Sent: " + message);
        }

        private void OnConnection()
        {
            listBox1.Items.Add("Connected");
        }

        private void OnDisconnect()
        {
            listBox1.Items.Add("Disconnected");

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendMsgButton_Click(object sender, EventArgs e)
        {
            myclient.SendMessage(msgBox.Text);

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myclient.ClientConnect();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myclient.Disconnect();
        }

        private void Game_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
