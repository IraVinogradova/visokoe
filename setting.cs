using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visokoe
{
    public partial class setting : Form
    {
        private MySetting _mysetting;
        
        public setting(MySetting setting)
        {

            _mysetting = setting;
            

            _mysetting.InitialSetting(8888);
            InitializeComponent();
        }

       
        private void set_port_box_ValueChanged(object sender, EventArgs e)
        {
            _mysetting.InitialSetting(Convert.ToInt32(set_port_box.Value));

        }
    }
}
