using Chat.Admin_panel;
using Chat.Entities;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.un(new SignIn());*/
            /*Application.Run(new ControlsFromForms());*/
            Application.Run(new InitializingEnviroment());
            /*Application.Run(new MainPanel());*/
        }
    }
}
