﻿using System;
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

        public ObtainComputerInformation(String ipAddress){
            this.ipAddress = ipAddress;
            serialNumber = getSerialNumber(); 
        }

       
        private string getSerialNumber()
        {
            var commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + serialNumberCommand;

            return commandExecutor.executeCommand(command);
        }

        private string getModel()
        {
            var commandExecutor = new CommandExecutor();

            string command = cmd + ipAddress + modelNumberCommand;
            string commandOutput = commandExecutor.executeCommand(command);


            return "test"; 

        }

        private string getName()
        {
			var commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + nameCommand;

			return commandExecutor.executeCommand(command);
		}
    }
}
