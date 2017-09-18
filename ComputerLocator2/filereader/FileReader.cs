using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ComputerLocator2.commandexecutor;
using ComputerLocator2.list;
using System.ComponentModel; 

namespace ComputerLocator2.filereader
{
    class FileReader
    {
        System.IO.StreamReader file = new System.IO.StreamReader("c:\\printerlist.txt");
        List<string> ipAddressList = new List<string>();
        String line;
        BackgroundWorker bw; 
   
        public FileReader()
        {
            this.bw = new BackgroundWorker();
            this.bw.DoWork += new DoWorkEventHandler(ReadFile);
            this.bw.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
            this.bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Completed);
            this.bw.WorkerReportsProgress = true;

            bw.RunWorkerAsync(); 
        }

        private void Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Done");
            TableUpdater.PopulateTableFromComputerList();
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Progress: " + e.ProgressPercentage.ToString());
        }

        private void ReadFile(object sender, DoWorkEventArgs e)
        {
            //const int maxThreads = 100;
            int computerCount = 0; 
            
            

            while ((line = file.ReadLine()) != null)
            {
                ipAddressList.Add(line); 
            }

            file.Close();
            computerCount = ipAddressList.Count();

            /*
            foreach (String ipAddressObj in ipAddressList)
            {
                Parallel.For(0, 50, new ParallelOptions { MaxDegreeOfParallelism = maxThreads },
                     i =>
                    {
                        ObtainComputerInformation oci = new ObtainComputerInformation(ipAddressObj); 
                    });
            }
            */

            Parallel.ForEach(ipAddressList, ipAddress =>
            {
                ObtainComputerInformation oci = new ObtainComputerInformation(ipAddress);
            });
         
            
            ComputerList.PrintList();
            Console.WriteLine("All operations have completed.");




        }

       
    }
}
