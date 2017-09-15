using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ComputerLocator2.commandexecutor;
using ComputerLocator2.list; 

namespace ComputerLocator2.filereader
{
    class FileReader
    {
        System.IO.StreamReader file = new System.IO.StreamReader("c:\\printerlist.txt");
        List<string> ipAddressList = new List<string>();
        String line;
   

        public void readFile()
        {
            const int maxThreads = 100;
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
         
            
            ComputerList.printList();
            Console.WriteLine("All operations have completed.");




        }

       
    }
}
