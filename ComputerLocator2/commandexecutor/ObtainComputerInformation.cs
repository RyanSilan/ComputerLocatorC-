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
        string modelNumberCommand = " computersystem get model";
        string nameCommand = " computersystem get name";
        string name = null;
        string ipAddress = null;
        string model = null;
        string serialNumber = null; 

        public void getComputerInfo(string ipAddress)
        {
            this.ipAddress = ipAddress;
            System.Diagnostics.Debug.WriteLine(getSerialNumber(ipAddress)); 

        }

        private string getSerialNumber(string ipAddress)
        {
            var commandExecutor = new CommandExecutor();
            string command = cmd + name + serialNumberCommand;

            return commandExecutor.executeCommand(command);
        }
    }
}
