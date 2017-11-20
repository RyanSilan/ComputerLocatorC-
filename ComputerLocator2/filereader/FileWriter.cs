using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace ComputerLocator2.filereader
{
    class FileWriter
    {
        string filePath = null;
        string fileName = null;
        StreamWriter writer = null;
        
        public FileWriter(string filePath, string fileName)
        {
            this.filePath = filePath;
            this.fileName = fileName;

            writer = File.CreateText(filePath + fileName + ".txt"); 
        }

        public void WriteLine(string lineToWrite)
        {
            writer.WriteLine(lineToWrite); 
        }

        public void CloseWriter()
        {
            writer.Close(); 
        }
    }
}
