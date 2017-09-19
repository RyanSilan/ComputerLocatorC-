using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerLocator2.physicaldevice;
using ComputerLocator2.list; 

namespace ComputerLocator2
{
    class TableUpdater
    {
        public static DataGridView computerTable { get; set; }

        delegate void SetCallBackText(String ipAddress, String name, String model, String sn); 

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
    }
}
