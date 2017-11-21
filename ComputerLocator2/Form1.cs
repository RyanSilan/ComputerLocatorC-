using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComputerLocator2.commandexecutor;
using ComputerLocator2.list;
using ComputerLocator2.physicaldevice; 
using ComputerLocator2.filereader; 

namespace ComputerLocator2
{
    public partial class MainFrame : Form
    {

        private string fileName = null; 
        private string pathToSaveFiles = Environment.ExpandEnvironmentVariables(@"%userprofile%\Documents\");

        public MainFrame()
        {
            InitializeComponent();
            TableUpdater.computerTable = computerTable;
            
        }
        
        private void Test_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void RetrieveInformation_Click(object sender, EventArgs e)
        {

            ClearTextBoxes();

            ObtainComputerInformation oci;             
            List<Computer> computerList = ComputerList.GetComputerList();
            int currentCount = computerList.Count; 

            if (ipAddressTextBox.Text.Equals(""))
            {
                ipAddressTextBox.Text = "127.0.0.1";
            }

            oci = new ObtainComputerInformation(ipAddressTextBox.Text);
            oci.GetAllComputerInfoWithErrorChecking();
            
            Console.WriteLine("Capacity: " + computerList.Count);

            try
            {
                if (computerList.Count > currentCount)
                {
                    computerNameTextBox.Text = computerList[computerList.Count - 1].GetName();
                    computerModelTextBox.Text = computerList[computerList.Count - 1].GetModel();
                    computerSNTextBox.Text = computerList[computerList.Count - 1].GetSerialNumber();

                    /*
                    FileWriter fileWriter = new FileWriter(pathToSaveFiles, computerNameTextBox.Text);
                    fileWriter.WriteLine(computerSNTextBox.Text);
                    fileWriter.CloseWriter(); 
                    */
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in RetrieveInformation_Click class. \n\n" + ex);
            }
            
        }

        private void ClearTextBoxes()
        {
            computerNameTextBox.Text = "";
            computerModelTextBox.Text = "";
            computerSNTextBox.Text = "";            
        }

        private void IpComputerLookup_Click(object sender, EventArgs e)
        {
            massLookupPanel.Hide();
            programsPanel.Hide();
            settingsPanel.Hide();
            printerPanel.Hide();
            panel1.Show();
            computerTable.Show(); 
        }

        private void MassLookupButton_Click(object sender, EventArgs e)
        {
            FileReader fileReader; 
            try
            {
                fileReader = new FileReader(massLookupProgressBar, fileName);
            }
            catch (ArgumentNullException)
            {
                openFileDialog1.ShowDialog();
                fileName = openFileDialog1.FileName;
                filePath.Text = fileName;
                if(!fileName.Equals("openFileDialog1"))
                {
                    fileReader = new FileReader(massLookupProgressBar, fileName);
                }
                
            }
        }

        private void TextFileLookup_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            printerPanel.Hide();
            programsPanel.Hide();
            settingsPanel.Hide();
            massLookupPanel.Show();
            computerTable.Show(); 
        }

        public void SetProgress(int progress)
        {
            massLookupProgressBar.Value = progress; 
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                fileName = openFileDialog1.FileName;
                filePath.Text = fileName;
                
            }
        }

        private void PrinterLookupButton_Click(object sender, EventArgs e)
        {
            massLookupPanel.Hide();
            panel1.Hide();
            computerTable.Hide();
            programsPanel.Hide();
            settingsPanel.Hide();
            printerPanel.Show(); 
        }

        private void ProgramsButton_Click(object sender, EventArgs e)
        {
            massLookupPanel.Hide();
            printerPanel.Hide();
            panel1.Hide();
            computerTable.Hide();
            settingsPanel.Hide();
            programsPanel.Show();
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            massLookupPanel.Hide();
            printerPanel.Hide();
            panel1.Hide();
            computerTable.Hide();
            programsPanel.Hide();
            settingsPanel.Show();
        }
    }
}
