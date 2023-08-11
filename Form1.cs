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

namespace visokoe
{
    public partial class Form1 : Form
        



    {
        

        public Form1()
        {

            InitializeComponent();

        }

        private void serverison_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Настраиваем обмен
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);  // Сервер запущен на 127.0.0.1 порт 8888 !
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipPoint);
            // включаем метод listen
            socket.Listen(1000);
           
            
           

            while (true)
            {

                // получаем подключение клиента
                Socket client = await socket.AcceptAsync();
                serverison.Visible = true;  // Есть подключение - видна надпись, что можно есть коннект 
                if (client.Connected)
                    serverison.Enabled = false; // чтобы не нажать кнопку еще раз
                byte[] responseData = new byte[512];
                // bytes = 0;
                int bytes = 0;

                var response = new StringBuilder(); // для склеивания данных 

                //SocketAsyncEventArgs readArg = SocketAsyncEventArgs();
                /*do
                {
                    bytes = await socket.ReceiveAsync(SocketAsyncEventArgs); 
                    response.Append(Encoding.UTF8.GetString(responseData, 0, bytes));
                }
                while (bytes > 0); */
            }


            ///
           

            ///
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Запускаем сервер на адресе 127.0.0.1 и порту 8888
            IPAddress localAdr = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(localAdr, 8888);

            IPEndPoint ipLocalEndPoint = new IPEndPoint(localAdr, 8888);
            // Запуск сервера
            server.Start();


        }
    }
        
    
}
