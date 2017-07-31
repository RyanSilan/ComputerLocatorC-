using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerLocator2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            var commandExecutor = new commandexecutor.CommandExecutor();
            commandExecutor.executeCommand("/c %windir%\\System32\\wbem\\WMIC.exe /node:127.0.0.1 bios get serialnumber");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }
}
