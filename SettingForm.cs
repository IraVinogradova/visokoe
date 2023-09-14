using System;
using System.Windows.Forms;

namespace visokoe
{
    public partial class SettingForm : Form
    {
        private MyServer _myServer;

        public SettingForm(MyServer server)
        {

            _myServer = server;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _myServer.SwitchPort(Int32.Parse(portinput.Text));
        }
    }
}