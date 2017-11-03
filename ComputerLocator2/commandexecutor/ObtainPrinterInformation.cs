using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerLocator2.list;
using ComputerLocator2.physicaldevice;
using System.IO;
using System.Threading;
using System.ComponentModel; 

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
        private BackgroundWorker bw; 
         


        
        public ObtainPrinterInformation(string ipAddress)
        {
            computerIPAddress = ipAddress;
            PrinterList.ClearList();

            /*
            List<Task> tasks = new List<Task>();

            
            Task taskOne = Task.Factory.StartNew(() => GetPrinterIP());
            taskOne.Wait(); 
            Task taskTwo = Task.Factory.StartNew(() => GetPrinterName());
            Task taskThree = Task.Factory.StartNew(() => GetPrinterDriver());
            taskTwo.Wait(); 
            taskThree.Wait(); 

            */

            this.bw = new BackgroundWorker();
            this.bw.DoWork += new DoWorkEventHandler(GetAllPrinterInfo);


            this.bw.RunWorkerAsync(); 

        }

        public void GetPrinterName()
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
            
        }

        public void GetPrinterIP()
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
            
        }

        public void GetPrinterDriver()
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
            
        }

        private void GetAllPrinterInfo(object sender, DoWorkEventArgs e)
        {
            List<Task> tasks = new List<Task>();


            Task taskOne = Task.Factory.StartNew(() => GetPrinterIP());
            taskOne.Wait();
            Task taskTwo = Task.Factory.StartNew(() => GetPrinterName());
            Task taskThree = Task.Factory.StartNew(() => GetPrinterDriver());
            taskTwo.Wait();
            taskThree.Wait();

            foreach (Printer printer in PrinterList.GetPrinterList())
            {
                TableUpdater.PopulatePrinterTable(printer.ipAddress, printer.name, printer.driver);
            }

            PrinterList.PrintList();
        }
    }
}
