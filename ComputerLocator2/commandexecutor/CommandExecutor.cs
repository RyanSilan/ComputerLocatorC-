using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLocator2.commandexecutor
{
    class CommandExecutor
    {
        public void executeCommand(String cmdString)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.FileName = "cmd.exe";

            process.StartInfo.Arguments = cmdString; 

            process.StartInfo.UseShellExecute = false; 

            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            string strOutput = process.StandardOutput.ReadToEnd();

            System.Diagnostics.Debug.WriteLine(strOutput);

             
        }
        
    }
}
