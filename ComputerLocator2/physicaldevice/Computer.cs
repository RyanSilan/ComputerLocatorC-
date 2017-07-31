using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLocator2.physicaldevice
{
    class Computer
    {
        string serialNumber;
        string name;
        string ipAddress;
        string model; 

        public Computer(string ipAddress, string name, string serialNumber, string model)
        {
            this.ipAddress = ipAddress;
            this.name = name;
            this.serialNumber = serialNumber;
            this.model = model; 
        }

        public string getIpAddress()
        {
            return ipAddress; 
        }

        public string getName()
        {
            return name; 
        }

        public string getModel()
        {
            return model; 
        }

        public string getSerialNumber()
        {
            return serialNumber; 
        }        

    }
}
