using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLocator2.commandexecutor
{
    class CommandExecutor
    {
        public System.IO.StreamReader ExecuteCommand(String cmdString)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            //Hides CMD window. 
            process.StartInfo.CreateNoWindow = true; 
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = cmdString;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            

            process.Start();

                      
            
            //process.StandardOutput.ReadLine();
            //process.StandardOutput.ReadLine(); 
            
            //string strOutput = process.StandardOutput.ReadLine();
            //System.Diagnostics.Debug.WriteLine(strOutput);
                        
            return process.StandardOutput;

             
        }
        
    }
}
