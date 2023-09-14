using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visokoe
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var settings = new MySetting();
            var server = new MyServer(settings);
            var settinForm = new SettingForm(server);
            var clientForm = new Panel(server, settinForm);
            Application.Run(clientForm);
            
        }
    }
}
