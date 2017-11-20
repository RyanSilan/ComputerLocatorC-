using System;
using System.Windows.Forms;
using ComputerLocator2.physicaldevice;
using ComputerLocator2.list;
using System.ComponentModel;

namespace ComputerLocator2
{
    class TableUpdater
    {
        public static DataGridView computerTable { get; set; }
        public static DataGridView printerTable { get; set; }
        public static DataGridView programsTable { get; set; }

        delegate void ComputerCallBackSetTableTest(string ipAddress, string name, string model, string sn);
        delegate void PrinterCallBackSetTableText(string printerIPAddress, string name, string driver);
        delegate void ProgramsCallBackSetTableText(string programName); 

        public static void PopulateComputerTable(String ipAddress, String name, String model, String sn)
        {
            if (computerTable.InvokeRequired)
            {
                ComputerCallBackSetTableTest d = new ComputerCallBackSetTableTest(PopulateComputerTable);
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
                printerTable.Invoke(update, new object[] { printerIPAddress, name, driver });
            }
            else
            {
                printerTable.Rows.Add(printerIPAddress, name, driver);
            }

        }

        public static void PopulateProgramsTable(string programName)
        {
            if (programsTable.InvokeRequired)
            {
                ProgramsCallBackSetTableText update = new ProgramsCallBackSetTableText(PopulateProgramsTable);
                programsTable.Invoke(update, new object[] { programName });
            }
            else
            {
                programsTable.Rows.Add(programName);
                programsTable.Sort(programsTable.Columns[0], ListSortDirection.Ascending);
            }

        }

    }
}
