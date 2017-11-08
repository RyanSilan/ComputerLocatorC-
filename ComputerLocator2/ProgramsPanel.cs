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

namespace ComputerLocator2
{
    public partial class ProgramsPanel : UserControl
    {
        public ProgramsPanel()
        {
            InitializeComponent();
            TableUpdater.programsTable = programsTable; 
        }

        private void retrieveInformationButton_Click(object sender, EventArgs e)
        {
            
            
            if(ipAddressTextBox.Text.Equals(""))
            {
                //ipAddressTextBox.Text = "127.0.0.1";
                MessageBox.Show("Please supply IP Address");
            }
            else
            {
                ObtainInstalledSoftware ois = new ObtainInstalledSoftware(programsProgressBar, ipAddressTextBox.Text);
                
            }

            

        }
    }
}
