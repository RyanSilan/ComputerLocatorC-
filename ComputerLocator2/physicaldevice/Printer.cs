using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLocator2.physicaldevice
{
    class Printer
    {
        string name;
        string ipAddress;
        //string manu;
        //string model; 

        public Printer(string ipAddress, string name)
        {
            this.name = name;
            this.ipAddress = ipAddress; 
        }
    }
}
