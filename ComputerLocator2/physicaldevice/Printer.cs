using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLocator2.physicaldevice
{
    public class Printer
    {
        public string name { get; set; }
        public string ipAddress { get; set; }
        public string driver { get; set; }

        public Printer(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }
        
    }
}
