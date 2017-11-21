using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerLocator2.commandexecutor;
using ComputerLocator2.filereader;
using ComputerLocator2.table; 

namespace ComputerLocator2
{
    public partial class PrinterPanel : UserControl
    {
        ObtainPrinterInformation opi;
        //private string pathToSaveFiles = Environment.ExpandEnvironmentVariables(@"%userprofile%\Documents\");
        

        public PrinterPanel()
        {
            InitializeComponent();
            TableUpdater.printerTable = printerTable; 
        }

        private void retrieveInformationButton_Click(object sender, EventArgs e)
        {
            printerTable.Rows.Clear();
            printerTable.Refresh(); 
            if (ipAddressTextBox.Text.Equals(""))
            {
                ipAddressTextBox.Text = "127.0.0.1";
                opi = new ObtainPrinterInformation(ipAddressTextBox.Text); 
            }
            else
            {
                opi = new ObtainPrinterInformation(ipAddressTextBox.Text);
            }
        }

        private void saveResultsButton_Click(object sender, EventArgs e)
        {
            TableWriter tableWriter = new TableWriter();
            //tableWriter.WriteTableToFile(pathToSaveFiles, ipAddressTextBox.Text + " - Printers", printerTable);
            tableWriter.WriteTableToFile(Environment.ExpandEnvironmentVariables(Properties.Settings.Default.FileSaveLocation), "\\" + ipAddressTextBox.Text + " - Printers", printerTable);
        }
    }
}
