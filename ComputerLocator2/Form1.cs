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
        
        private void retrieveInformation_Click(object sender, EventArgs e)
        {
            //Not currenlty working. 
            //clearTextBoxes();


            ObtainComputerInformation oci;
             
            List<Computer> computerList = ComputerList.GetComputerList();
            
        
            if (ipAddressTextBox.Text.Equals(""))
            {
                ipAddressTextBox.Text = "127.0.0.1"; 
                oci = new ObtainComputerInformation(ipAddressTextBox.Text);
            }
            else
            {
                oci = new ObtainComputerInformation(ipAddressTextBox.Text);
            }

            

            Console.WriteLine("Capacity: " + computerList.Count);

            try
            {
                computerNameTextBox.Text = computerList[computerList.Count - 1].GetName();
                computerModelTextBox.Text = computerList[computerList.Count - 1].GetModel();
                computerSNTextBox.Text = computerList[computerList.Count - 1].GetSerialNumber();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Cannot retrieve information");    
            }
            
            
        }

        //Not working, need to investigate.  
        private void ClearTextBoxes()
        {
            computerNameTextBox.Text = null;
            computerModelTextBox.Text = "test";
            computerSNTextBox.Text = " ";
        }

        private void ipComputerLookup_Click(object sender, EventArgs e)
        {
            massLookupPanel.Hide();
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
                fileReader = new FileReader(massLookupProgressBar, fileName);
            }

            

        }

        private void TextFileLookup_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            printerPanel.Hide(); 
            massLookupPanel.Show();
            computerTable.Show(); 
        }

        public void SetProgress(int progress)
        {
            massLookupProgressBar.Value = progress; 
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                //MessageBox.Show(openFileDialog1.FileName);
                fileName = openFileDialog1.FileName;
                filePath.Text = fileName; 
            }
        }

        private void printerLookupButton_Click(object sender, EventArgs e)
        {
            massLookupPanel.Hide();
            panel1.Hide();
            computerTable.Hide(); 
            printerPanel.Show(); 
        }
    }
}
