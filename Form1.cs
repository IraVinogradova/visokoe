using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Http;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace visokoe
{  
    public partial class Panel : Form
    {
       
        public async  void Panel1()
        {
            
            InitializeComponent();
            // Запускаем сервер на адресе 127.0.0.1 и порту 8888
            IPAddress localAdr = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(localAdr, 8888);

            IPEndPoint ipLocalEndPoint = new IPEndPoint(localAdr, 8888);
            try
            {
                server.Start(); ser_cl.Visible = false;
                ser_on.Visible = true;
           
            ;
            // Запуск сервера
            server.Start();
            TcpClient client = await server.AcceptTcpClientAsync();
            byte[] receivedBuffer = new byte[1024];
            string msg = "";
            // if (msg.Length !=0) { 
            // msg.Remove(msg.Length - 1);
            // }
            NetworkStream stream = client.GetStream();
            string end_bute = "\n";
            byte[] end_buff = System.Text.Encoding.Default.GetBytes(end_bute);
            if (client.Connected ) { serverison.Visible = true; };

                // читаем данные
                do
                {

                    // if (receivedBuffer.Take(3).Equals(end_buff))
                    //{
                    //    fromPLC.Clear(); break;
                    // }

                    //stream.Read(receivedBuffer, 0, receivedBuffer.Length);
                    var bytesread = await stream.ReadAsync(receivedBuffer, 0, receivedBuffer.Length);
                    msg = Encoding.UTF8.GetString(receivedBuffer, 0, bytesread);
                    fromPLC.Text = msg;
                    text_test.Text = msg;

                }
                while (client.Connected);

            }
            catch (Exception ex)
            {
                server.Stop();
                MessageBox.Show(ex.Message);
            }
        }
        
 

        private async void PLCcon_Click(object sender, EventArgs e)
        {
               /* do
                {

                    // if (receivedBuffer.Take(3).Equals(end_buff))
                    //{
                    //    fromPLC.Clear(); break;
                    // }

                    //stream.Read(receivedBuffer, 0, receivedBuffer.Length);
                    var bytesread = await stream.ReadAsync(receivedBuffer, 0, receivedBuffer.Length);
                    msg = Encoding.UTF8.GetString(receivedBuffer, 0, bytesread);
                    fromPLC.Text = msg;
                    text_test.Text = msg;

                }
                while (client.Connected);

            }
                catch (Exception ex)
                {
                    server.Stop();
                    MessageBox.Show(ex.Message);
                }
    //TcpClient client = await server.AcceptTcpClientAsync(); */
}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
            
}
