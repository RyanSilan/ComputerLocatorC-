using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerLocator2.commandexecutor;
using ComputerLocator2.list;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO; 

namespace ComputerLocator2.filereader
{
    class FileReader
    {
        //public delegate void ProgressDelegate(int progress);
        ProgressBar massLookupProgressBar;


        StreamReader file; 
        List<string> ipAddressList = new List<string>();
        String line;
        BackgroundWorker bw; 
   
        public FileReader(ProgressBar progressBar, string filePath)
        {
            massLookupProgressBar = progressBar;
            file = new StreamReader(filePath); 

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
            //TableUpdater.PopulateTableFromComputerList();
        }

        
        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Progress: " + e.ProgressPercentage.ToString());
            massLookupProgressBar.Value = e.ProgressPercentage; 
            
        }
        
        
        

        private void ReadFile(object sender, DoWorkEventArgs e)
        {
            //const int maxThreads = 100;
            int computerCount = 0;
            int computersCounted = 0; 
            
            

            while ((line = file.ReadLine()) != null)
            {
                ipAddressList.Add(line); 
            }

            file.Close();
            computerCount = ipAddressList.Count();

           
            Parallel.ForEach(ipAddressList, ipAddress =>
            {
                
                ObtainComputerInformation oci = new ObtainComputerInformation(ipAddress);

                ++computersCounted;
                int precentProgress = (computersCounted * 100) / computerCount;
                bw.ReportProgress(precentProgress, computersCounted); 
            });
         
            
            //ComputerList.PrintList();
            Console.WriteLine("All operations have completed.");
            
        }
               
    }
}
