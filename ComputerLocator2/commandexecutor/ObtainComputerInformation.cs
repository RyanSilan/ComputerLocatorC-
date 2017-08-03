﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerLocator2.physicaldevice;
using ComputerLocator2.list; 

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
            name = getName();
            model = getModel();

            Computer computer = new Computer(ipAddress, name, serialNumber, model);
            ComputerList.AddToList(computer);

            /*
            System.Diagnostics.Debug.WriteLine(serialNumber);
            System.Diagnostics.Debug.WriteLine(name);
            System.Diagnostics.Debug.WriteLine(model);
            System.Diagnostics.Debug.WriteLine(ipAddress);
            */
            
        }

       
        private string getSerialNumber()
        {
            CommandExecutor commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + serialNumberCommand;
            System.IO.StreamReader commandOutput = commandExecutor.executeCommand(command);

            //The data needed is on the third line in the StreamReader. 
            commandOutput.ReadLine();
            commandOutput.ReadLine();
            return commandOutput.ReadLine();


        }

        private string getModel()
        {
            CommandExecutor commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + modelNumberCommand;
            System.IO.StreamReader commandOutput = commandExecutor.executeCommand(command);

            //The data needed is on the third line in the StreamReader. 
            commandOutput.ReadLine();
            commandOutput.ReadLine();
            return commandOutput.ReadLine();
        }

        private string getName()
        {
			CommandExecutor commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + nameCommand;
            System.IO.StreamReader commandOutput = commandExecutor.executeCommand(command);

            //The data needed is on the third line in the StreamReader. 
            commandOutput.ReadLine();
            commandOutput.ReadLine();
            return commandOutput.ReadLine();
        }
    }
}
