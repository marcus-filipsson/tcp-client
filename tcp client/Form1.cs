using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace tcp_client
{
    public partial class Form1 : Form
    {
        TcpClient klient;
        int port = 12345;
        public KlientForm()...
        private void btnSägHej_Click( object sender, EventArgs e)
        
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAdress.Parse(tbxIPAdress.Text);
            klient = new TcpClient();
            klient.NoDelay = true;
            klient.Connect(adress, port);

            if (klient.Connected)
            { 
        }
        byte[] utData = Encoding.Unicode.GetBytes("Hej!");
        Klient.GetStream().Write(utData, 0, utData.Lenght);
        Klient.Close();
            }
    }
}
