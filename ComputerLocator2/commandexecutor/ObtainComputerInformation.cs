﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerLocator2.physicaldevice;
using ComputerLocator2.list;
using System.Collections;
using System.Threading; 

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
            getAllComputerInfo(ipAddress);            
                        
        }

        public void getAllComputerInfo(String ipAddress)
        {
            this.ipAddress = ipAddress;
            Console.WriteLine("This is the IP: " + ipAddress); 
            List<Task> tasks = new List<Task>(); 

            Task task = Task.Factory.StartNew(() => serialNumber = getSerialNumber());
            tasks.Add(task);
            //task.Wait(2000);
            task.Wait(); 

            if (serialNumber.Equals("") == false)
            {
                Task taskTwo = Task.Factory.StartNew(() => name = getName());
                Task taskThree = Task.Factory.StartNew(() => model = getModel());
                tasks.Add(taskTwo);
                tasks.Add(taskThree);


                Task.WaitAll(tasks.ToArray());

                Computer computer = new Computer(ipAddress, name, serialNumber, model);
                ComputerList.AddToList(computer);
            }
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
