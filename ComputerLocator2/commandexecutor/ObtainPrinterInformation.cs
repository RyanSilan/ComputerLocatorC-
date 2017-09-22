using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerLocator2.list;
using ComputerLocator2.physicaldevice;
using System.IO; 

namespace ComputerLocator2.commandexecutor
{
    class ObtainPrinterInformation
    {
        private string computerIPAddress = null;
        //private List<Printer> printerList = new List<Printer>; 
        private readonly string cmd = "/c %windir%\\System32\\wbem\\WMIC.exe /node:";
        private readonly string printerNameCMD = " printer get name";
        private readonly string printerDriverCMD = " printer get drivername";
        private readonly string portNameCMD = " printer get portname"; 


        
        public ObtainPrinterInformation(string ipAddress)
        {
            computerIPAddress = ipAddress;
            PrinterList.ClearList(); 
            GetPrinterIP(); 
            GetPrinterName();
            GetPrinterDriver(); 
            PrinterList.PrintList(); 

        }

        public string GetPrinterName()
        {
            int i = 0; 
            string tempCmd = cmd + computerIPAddress + printerNameCMD;
            string tempOutput = null; 
            CommandExecutor cmdExecutor = new CommandExecutor();
            StreamReader commandOutput = cmdExecutor.ExecuteCommand(tempCmd);
            List<Printer> tempPrinterList = PrinterList.GetPrinterList();

            Console.WriteLine("Command String: " + tempCmd);

            while(!commandOutput.EndOfStream)
            {
                tempOutput = commandOutput.ReadLine();


                //checks to see if the output line is empty, or if it's the header. Which does not need to be included. 
                if (tempOutput != "" && !tempOutput.Contains("Name"))
                {
                    tempPrinterList.ElementAt(i).name = tempOutput;
                    i++;
                }
                
                 
            }
            
            return "test"; 
        }

        public string GetPrinterIP()
        {
            string tempCmd = cmd + computerIPAddress + portNameCMD;
            string tempOutput = null;
            CommandExecutor commandExecutor = new CommandExecutor();
            StreamReader commandOutput = commandExecutor.ExecuteCommand(tempCmd); 
            
             

            while (!commandOutput.EndOfStream)
            {
                tempOutput = commandOutput.ReadLine();
                                
                if (tempOutput != "" && !tempOutput.Contains("PortName"))
                {
                    Printer printer = new Printer(tempOutput);
                    PrinterList.AddToList(printer);
                }

            }

           return "test"; 
        }

        public string GetPrinterDriver()
        {
            int i = 0;
            string tempCmd = cmd + computerIPAddress + printerDriverCMD;
            string tempOutput = null;
            CommandExecutor cmdExecutor = new CommandExecutor();
            StreamReader commandOutput = cmdExecutor.ExecuteCommand(tempCmd);
            List<Printer> tempPrinterList = PrinterList.GetPrinterList();

            
            while (!commandOutput.EndOfStream)
            {
                tempOutput = commandOutput.ReadLine();
                Console.WriteLine(tempOutput); 

                //checks to see if the output line is empty, or if it's the header. Which does not need to be included. 
                if (tempOutput != "" && !tempOutput.Contains("DriverName"))
                {
                    tempPrinterList.ElementAt(i).driver = tempOutput;
                    i++;
                }


            }

            return "test";
        }
    }
}
