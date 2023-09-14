using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visokoe
{
    public class MyServer : IObservable
    {
        private List<IObserver> observers;
        private TcpListener _server;
        private NetworkStream _stream;
        private bool _serverStatus;
        private bool _clientStatus;

        private string data;
        private string respons;

        private MySetting _setting;

        public MyServer(MySetting setting)
        {
            _setting = setting; 
            observers = new List<IObserver>();
            StartServer(_server);
            
        }

        public string Data
        {
            get => data;
            set
            {
                data = value;
                NotifyObserbers();
            }
        }
         public string Response
        {
            get => respons;
            set
            {
                respons = value;
                NotifyObserbers();
            }

        }

        public bool ClientStatus {
            get => _clientStatus;

            set
            { _clientStatus = value;
                NotifyObserbers();
            } 
        
        }

     

        public bool getServerStatus()
        {
            return _serverStatus;
           
        }

    

        public void NotifyObserbers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update();
            }
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        private async void StartServer(TcpListener server)
        {
            while (true) {
            if (_setting.Port == 0)
            {
                    break;
            }
            try
            {
                
                IPAddress localAdr = IPAddress.Parse("127.0.0.1");
                
                _server = new TcpListener(localAdr, _setting.Port);
               
                _server.Start();
                _serverStatus = true;

                byte[] receivedBuffer = new byte[1024];
                
                data = "";
                respons = "";
                
                while (true)
                {
                    using TcpClient client = await _server.AcceptTcpClientAsync();
                    ClientStatus = true;
                 
                    _stream = client.GetStream();

                   
                    
                    int i;
                    while ((i = _stream.Read(receivedBuffer, 0, receivedBuffer.Length)) != 0)  // (i = _stream.Read(receivedBuffer, 0, receivedBuffer.Length)) != 0
                    {
                        
                        Data = Encoding.UTF8.GetString(receivedBuffer, 0, i);
                        //Data = Data.ToUpper();
                        NotifyObserbers();
                        string end_bute = "\n"; // Роберто в конце должен отпрвить <LF>
                        string answer = "OK";
                        byte[] end_buff = Encoding.Default.GetBytes(end_bute);
                        byte[] answer_buff = Encoding.Default.GetBytes(answer);

                        if (data.EndsWith("\n")) {
                            
                         _stream.Write(answer_buff, 0, answer_buff.Length);
                           //break;
                                } 
                    }
                    ClientStatus= false;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                server.Stop();
                _serverStatus &= false;
            }
            }
        }

        public void SwitchPort(int port)
        {
            if (port == 0)
                return;
            _server.Stop();
            _setting.Port = port;
            StartServer(_server);

        }

        public void SendMessage(string Response)
        {
        if  (Response != null) {
               
                string response = Response + "\n";
               byte[] resposeData = Encoding.Default.GetBytes(response);          
                _stream.Write(resposeData, 0, resposeData.Length);
            }
        }
    }
}

