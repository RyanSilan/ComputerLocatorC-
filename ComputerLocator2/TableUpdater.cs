using System;
using System.Windows.Forms;
using ComputerLocator2.physicaldevice;
using ComputerLocator2.list; 

namespace ComputerLocator2
{
    class TableUpdater
    {
        public static DataGridView computerTable { get; set; }
        public static DataGridView printerTable { get; set; }

        delegate void SetCallBackText(string ipAddress, string name, string model, string sn);
        delegate void PrinterCallBackSetTableText(string printerIPAddress, string name, string driver); 

        public static void PopulateTable(String ipAddress, String name, String model, String sn)
        {
            if (computerTable.InvokeRequired)
            {
                SetCallBackText d = new SetCallBackText(PopulateTable);
                computerTable.Invoke(d, new object[] { ipAddress, name, model, sn });
            }
            else
            {
                computerTable.Rows.Add(ipAddress, name, model, sn);
            }
        }

        public static void PopulateTableFromComputerList()
        {
            foreach (Computer computerObj in ComputerList.GetComputerList())
            {
                if (computerObj.GetSerialNumber() != null)
                {
                    computerTable.Rows.Add(computerObj.GetIpAddress(), computerObj.GetName(), computerObj.GetModel(), computerObj.GetSerialNumber());
                }
            }
        }

        public static void PopulatePrinterTable(string printerIPAddress, string name, string driver)
        {
            if (printerTable.InvokeRequired)
            {
                PrinterCallBackSetTableText update = new PrinterCallBackSetTableText(PopulatePrinterTable); 
                computerTable.Invoke(update, new object[] { printerIPAddress, name, driver });
            }
            else
            {
                printerTable.Rows.Add(printerIPAddress, name, driver);
            }

        }
    }
}
