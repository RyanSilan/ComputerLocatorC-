using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerLocator2.physicaldevice; 

namespace ComputerLocator2.list
{
    public static class PrinterList
    {
        static List<Printer> printerList = new List<Printer>();
              
        public static void AddToList(Printer printer)
        {
            printerList.Add(printer);
        }

        public static List<Printer> GetPrinterList()
        {
            return printerList; 
        }

        public static void PrintList()
        {
            foreach (Printer printerObj in printerList)
            {
                Console.WriteLine("IP Address: " + printerObj.ipAddress);
                Console.WriteLine("Name: " + printerObj.name);
                Console.WriteLine("Driver: " + printerObj.driver); 
                Console.WriteLine("----------------");
            }
        }

        public static int Size()
        {
           return printerList.Capacity; 
        }

        public static void ClearList()
        {
            printerList.Clear();
            printerList.Capacity = 0; 
        }
    }
}
