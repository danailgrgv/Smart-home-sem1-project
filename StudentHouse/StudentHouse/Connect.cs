using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websocket;

namespace StudentHouse
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        readonly Reception receptionForm;

        public Connect(Reception receptionForm)
        {
            InitializeComponent();
            this.receptionForm = receptionForm;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (receptionForm != null)
            {
                receptionForm.ws.ConnectTo(tbLocalIP.Text, tbLocalPort.Text, tbRemoteIP.Text, tbRemotePort.Text);
                receptionForm.isConnected = true;
                MessageBox.Show("Connection established.");
            }
            this.Close();
        }

        private void Connect_Load(object sender, EventArgs e)
        {
            WebSocket ws = new WebSocket();
            // For local connection, get local user IP. Otherwise, find your public IP and type that instead.
            tbLocalIP.Text = "192.168.178.221"; //ws.GetLocalIP();
            // For local testing with one PC, use preset configuration
            tbRemoteIP.Text = "192.168.178.220"; //ws.GetLocalIP();
            if (receptionForm != null)
            {
                tbLocalPort.Text = "81";
                tbRemotePort.Text = "81";
            }
        }
    }
}
