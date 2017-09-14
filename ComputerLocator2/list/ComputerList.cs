using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 
using ComputerLocator2.physicaldevice; 


namespace ComputerLocator2.list
{
    public static class ComputerList
    {
        public static List<Computer> computerArrayList = new List<Computer>(); 

        //Old way
        //public static ArrayList computerArrayList = new ArrayList(); 

        public static void AddToList(Computer computer)
        {
            computerArrayList.Add(computer); 
        }

        public static List<Computer> GetComputerList()
        {
            return computerArrayList;
        }
    }
}
