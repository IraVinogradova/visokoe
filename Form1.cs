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

    public partial class Panel : Form, IObserver
    {
        private MyServer _myServer;
        private MySetting _mysetting;

        public Panel(MyServer server)
        {
           int  servPort = _mysetting.SetPort;
            _myServer.Port = servPort;

            _myServer = server;
            _myServer.Add(this);
            InitializeComponent();
            if (server.getServerStatus())
            {
                ser_cl.Visible = false;
                ser_on.Visible = true;
            }
           
        }

        void IObserver.Update()
      {
            Invoke(new Action(() => text_test.Text = _myServer.Data));
            Invoke(new Action(() => clientconected.Visible = _myServer.ClientStatus));
            //Invoke(new Action(() => toPLC.Text = _myServer.Response));
            //   MessageBox.Show("UPDATED!");
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            _myServer.SendMessage(toPLC.Text);

        }

        private void text_test_Click(object sender, EventArgs e)
        {
            // if (!_myServer.getServerStatus())
            // { text_test.Text = _myServer.Data;  }
            text_test.Text = _myServer.Data;

        }

        private void setting_Click(object sender, EventArgs e)
        {
            setting form_setting = new setting(_mysetting);
            form_setting.Show();
        }
    }
            
}
