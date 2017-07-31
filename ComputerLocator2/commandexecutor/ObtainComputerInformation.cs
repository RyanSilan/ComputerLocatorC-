using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLocator2.commandexecutor
{
    class ObtainComputerInformation
    {
        string cmd = "/c %windir%\\System32\\wbem\\WMIC.exe /node:";
        string serialNumberCommand = " bios get serialnumber";

        public void getComputerInfo(string name)
        {
            

        }

        private string getSerialNumber(string name)
        {
            var commandExecutor = new CommandExecutor();
            string command = cmd + name + serialNumberCommand;

            return commandExecutor.executeCommand(command);
        }
    }
}
