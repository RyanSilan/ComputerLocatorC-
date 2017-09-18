using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLocator2.physicaldevice
{
    public class Computer
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

        public string GetIpAddress()
        {
            return ipAddress; 
        }

        public string GetName()
        {
            return name; 
        }

        public string GetModel()
        {
            return model; 
        }

        public string GetSerialNumber()
        {
            return serialNumber; 
        }        

    }
}
