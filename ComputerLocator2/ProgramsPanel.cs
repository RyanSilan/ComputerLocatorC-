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
using ComputerLocator2.table;
using System.Linq.Expressions;
using System.Reflection;

namespace ComputerLocator2
{
    public partial class ProgramsPanel : UserControl
    {
        private string pathToSaveFiles = Environment.ExpandEnvironmentVariables(@"%userprofile%\Documents\");

        public ProgramsPanel()
        {
            InitializeComponent();
            TableUpdater.programsTable = programsTable; 
        }

        private void RetrieveInformationButton_Click(object sender, EventArgs e)
        {
            programsTable.Rows.Clear();
            programsTable.Refresh();
            
            if(ipAddressTextBox.Text.Equals(""))
            {
                //ipAddressTextBox.Text = "127.0.0.1";
                MessageBox.Show("Please supply IP Address");
            }
            else
            {

                ObtainInstalledSoftware ois = new ObtainInstalledSoftware();  
                ois.onLabelUpdate += new ObtainInstalledSoftware.UpdateLabel(UpdateCurrentStatusLabel);
                ois.GetInstalledSoftware(programsProgressBar, ipAddressTextBox.Text); 
            }

            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TableWriter tableWriter = new TableWriter();
            //tableWriter.WriteTableToFile(pathToSaveFiles, ipAddressTextBox.Text + " - Programs", programsTable);
            tableWriter.WriteTableToFile(Environment.ExpandEnvironmentVariables(Properties.Settings.Default.FileSaveLocation), "\\" + ipAddressTextBox.Text + " - Programs", programsTable);
        }



        void UpdateCurrentStatusLabel(string value)
        {
            currentStatusLabel.Text = value; 
        }

    }
}
