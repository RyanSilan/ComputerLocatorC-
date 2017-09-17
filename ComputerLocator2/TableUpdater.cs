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

        public static void populateTable(String ipAddress, String name, String model, String sn)
        {
            if (computerTable.InvokeRequired)
            {
                SetCallBackText d = new SetCallBackText(populateTable);
                computerTable.Invoke(d, new object[] { ipAddress, name, model, sn });
            }
            else
            {
                computerTable.Rows.Add(ipAddress, name, model, sn);
            }
        }

        public static void populateTableFromComputerList()
        {
            foreach (Computer computerObj in ComputerList.GetComputerList())
            {
                if (computerObj.getSerialNumber() != null)
                {
                    computerTable.Rows.Add(computerObj.getIpAddress(), computerObj.getName(), computerObj.getModel(), computerObj.getSerialNumber());
                }
            }
        }
    }
}
