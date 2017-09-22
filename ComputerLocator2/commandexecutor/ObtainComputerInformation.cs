﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComputerLocator2.physicaldevice;
using ComputerLocator2.list;
using ComputerLocator2.commandexecutor; 

namespace ComputerLocator2.commandexecutor
{
    class ObtainComputerInformation
    {
        private readonly string cmd = "/c %windir%\\System32\\wbem\\WMIC.exe /node:";
        private readonly string serialNumberCommand = " bios get serialnumber";
        private readonly string modelNumberCommand = " computersystem get model";
        private readonly string nameCommand = " computersystem get name";
        string name = null;
        string ipAddress = null;
        string model = null;
        string serialNumber = null;
        

        public ObtainComputerInformation(String ipAddress){

            this.ipAddress = ipAddress; 
            GetAllComputerInfo(ipAddress);            
                        
        }

        public void GetAllComputerInfo(String ipAddress)
        {
            this.ipAddress = ipAddress;
            Console.WriteLine("This is the IP: " + ipAddress); 
            List<Task> tasks = new List<Task>(); 

            Task task = Task.Factory.StartNew(() => serialNumber = GetSerialNumber());
            tasks.Add(task);
            //task.Wait(2000);
            task.Wait(); 

            if (serialNumber.Equals("") == false)
            {
                Task taskTwo = Task.Factory.StartNew(() => name = GetName());
                Task taskThree = Task.Factory.StartNew(() => model = GetModel());
                tasks.Add(taskTwo);
                tasks.Add(taskThree);


                Task.WaitAll(tasks.ToArray());

                TableUpdater.PopulateTable(ipAddress, name, model, serialNumber); 

                Computer computer = new Computer(ipAddress, name, serialNumber, model);
                ComputerList.AddToList(computer);
                
               
            }
        }

       
        private string GetSerialNumber()
        {
            CommandExecutor commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + serialNumberCommand;
            System.IO.StreamReader commandOutput = commandExecutor.ExecuteCommand(command);
            

            //The data needed is on the third line in the StreamReader. 
            commandOutput.ReadLine();
            commandOutput.ReadLine();
            return commandOutput.ReadLine();

        }

        private string GetModel()
        {
            CommandExecutor commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + modelNumberCommand;
            System.IO.StreamReader commandOutput = commandExecutor.ExecuteCommand(command);

            //The data needed is on the third line in the StreamReader. 
            commandOutput.ReadLine();
            commandOutput.ReadLine();
            return commandOutput.ReadLine();
        }

        private string GetName()
        {
			CommandExecutor commandExecutor = new CommandExecutor();
            string command = cmd + ipAddress + nameCommand;
            System.IO.StreamReader commandOutput = commandExecutor.ExecuteCommand(command);

            //The data needed is on the third line in the StreamReader. 
            commandOutput.ReadLine();
            commandOutput.ReadLine();
            return commandOutput.ReadLine();
        }
    }
}
