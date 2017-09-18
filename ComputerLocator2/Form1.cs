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
        private BackgroundWorker bw; 
        
        public mainFrame()
        {
            InitializeComponent();
            ComputerLocator2.TableUpdater.computerTable = this.computerTable;

            FileReader fileReader = new FileReader(); 
            /*
            this.bw = new BackgroundWorker();
            this.bw.DoWork += new DoWorkEventHandler(bwReadFile);
            this.bw.ProgressChanged += new ProgressChangedEventHandler(bwProgressChanged);
            this.bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwCompleted);
            this.bw.WorkerReportsProgress = true;

            bw.RunWorkerAsync();
            */
            
            
            
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
            
            computerNameTextBox.Text = computerList[computerList.Count-1].GetName();
            computerModelTextBox.Text = computerList[computerList.Count-1].GetModel();
            computerSNTextBox.Text = computerList[computerList.Count-1].GetSerialNumber();


            TableUpdater.PopulateTable(ipAddressTextBox.Text, computerList[computerList.Count - 1].GetName(), computerList[computerList.Count - 1].GetModel(), computerList[computerList.Count - 1].GetSerialNumber()); 
        }

        //Not working, need to investigate.  
        private void clearTextBoxes()
        {
            computerNameTextBox.Text = null;
            computerModelTextBox.Text = "test";
            computerSNTextBox.Text = " ";
        }

        /*
        public static void populateTable(String ipAddress, String name, String model, String sn)
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
        */
        
            /*
        private void bwReadFile(object sender, DoWorkEventArgs e)
        {
            FileReader fileReader = new FileReader();

            fileReader.readFile();

        }

        private void bwProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Progress: " + e.ProgressPercentage.ToString()); 
        }

        private void bwCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Console.WriteLine("BackgroundWorker completed: " + e.Result.ToString());
            //populateTableFromComputerList(); 
            Console.WriteLine("Done");
            TableUpdater.populateTableFromComputerList(); 
        }
        */
    }
}
