using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerLocator2.commandexecutor;
using ComputerLocator2.list;
using ComputerLocator2.physicaldevice; 
using System.Collections;
using ComputerLocator2.filereader; 

namespace ComputerLocator2
{
    public partial class mainFrame : Form
    {
        
        public mainFrame()
        {
            InitializeComponent();

            FileReader fileReader = new FileReader();
            fileReader.readFile();
            populateTableFromComputerList();
            
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

        
            ObtainComputerInformation oci = new ObtainComputerInformation(ipAddressTextBox.Text);
            List<Computer> computerList = ComputerList.GetComputerList();


            Console.Write("Capacity: " + computerList.Count);
            
            computerNameTextBox.Text = computerList[computerList.Count-1].getName();
            computerModelTextBox.Text = computerList[computerList.Count-1].getModel();
            computerSNTextBox.Text = computerList[computerList.Count-1].getSerialNumber();

            populateTable(ipAddressTextBox.Text, computerList[computerList.Count - 1].getName(), computerList[computerList.Count - 1].getModel(), computerList[computerList.Count - 1].getSerialNumber()); 
        }

        //Not working, need to investigate.  
        private void clearTextBoxes()
        {
            computerNameTextBox.Text = null;
            computerModelTextBox.Text = "test";
            computerSNTextBox.Text = " ";
        }

        private void populateTable(String ipAddress, String name, String model, String sn)
        {
            computerTable.Rows.Add(ipAddress, name, model, sn); 
        }

        private void populateTableFromComputerList()
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
