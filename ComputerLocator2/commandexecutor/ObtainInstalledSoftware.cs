using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.ComponentModel;
using System.Windows.Forms;

namespace ComputerLocator2.commandexecutor
{
    class ObtainInstalledSoftware
    {
        CommandExecutor commandExecutor = new CommandExecutor(); 
        ProgressBar oisProgressBar = null; 
        BackgroundWorker bw = new BackgroundWorker(); 
        ServiceController sc = new ServiceController("Remote Registry"); 
        string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        string computerName = null;

        string firstPartOfCMD = @"/c %windir%\system32\sc \\";
        string secondPartOfCMDToStart = " config remoteregistry start=demand";
        string secondPartOfCMDToStop = " config remoteregistry start=disabled"; 
        
        public ObtainInstalledSoftware(ProgressBar progressBar, string computer)
        {
            computerName = computer;
            oisProgressBar = progressBar;

            bw.DoWork += GetInstalledSoftware;
            bw.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
            bw.WorkerReportsProgress = true;

            
           bw.RunWorkerAsync();
            
            

        }

        private void GetInstalledSoftware(object sender, DoWorkEventArgs e)
        {
            int totalNumberOfKeys = 0;
            int countedKeys = 0;

            try
            {
            

                Console.WriteLine("About to start the service.");
                StartService(computerName);

                using (RegistryKey key =
                RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, computerName).OpenSubKey(registryKey))
            {
                totalNumberOfKeys = key.GetSubKeyNames().Length; 

                foreach (string keyName in key.GetSubKeyNames())
                {
                    using (RegistryKey subKey = key.OpenSubKey(keyName))
                    {
                        if (subKey.GetValue("DisplayName") != null &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Security Update")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Adobe Flash")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Dell")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Java")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Google Update")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Apple")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Computrace")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Microsoft redistributable")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Cisco AnyConnect")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Update for")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("IBM i Access")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Service Pack")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("System Requirement")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Absolute Software")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Adobe Refresh")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Intel(R)")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Proof")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("O2Micro")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("Realtek")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("ST Microelectronics")) &&
                            !(subKey.GetValue("DisplayName").ToString().Contains("MSXML")))
                        {
                            TableUpdater.PopulateProgramsTable(subKey.GetValue("DisplayName").ToString());

                            ++countedKeys;
                            int progress = (countedKeys * 100) / totalNumberOfKeys;
                            bw.ReportProgress(progress);

                        }
                        else
                        {
                            ++countedKeys;
                            int progress = (countedKeys * 100) / totalNumberOfKeys;
                            bw.ReportProgress(progress);
                        }

                    }
                }
            }
                
            }
        
            catch (Exception ex)
            {
                
                    Console.WriteLine("Failed to start the service, caught exception");
                    MessageBox.Show("Failed to start the service! \n\n\n" + ex, "Error");
                
            }
            

            StopService(); 
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Progress: " + e.ProgressPercentage.ToString());
            oisProgressBar.Value = e.ProgressPercentage;

        }

        //Used to start the RemoteRegistry service that is 
        //required to be running in order to query registry
        private void StartService(string computerName)
        {
            string cmdToStart = firstPartOfCMD + computerName + secondPartOfCMDToStart;
            sc.MachineName = computerName;

            try
            {
                Console.WriteLine("Status of the service when attempting to start: " + sc.Status.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to the machine to get the service status", "Error");
            }
            
            if(sc.Status == ServiceControllerStatus.Stopped)
            {
                //Attempts to start the service via ServiceController.  
                //This sometimes failes with Windows 10 machines if the service 
                //is disabled instead of stopped. 
                try
                {
                    sc.Start();
                }
                //If it fails, it will attempt to use the SC.exe built into Windows
                //via CMD to set the service to "Manual" and then use ServiceController
                //to start the service. 
                catch (Exception)
                {
                    try
                    {
                        Console.WriteLine("Failed to start it the first time, trying again");
                        commandExecutor.ExecuteCommand(cmdToStart);
                        sc.Start();
                        sc.WaitForStatus(ServiceControllerStatus.Running);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Tried to start the service twice and failed. \n\n" + ex, "Error");
                    }
                    
                }
                 
            }

                       
        }
        
        //Stops the RemoteRegistry service and then sets it to Disabled
        private void StopService()
        {
            string cmdToStop = firstPartOfCMD + computerName + secondPartOfCMDToStop;

            Console.WriteLine("Status of the service when attempting to stop: " + sc.Status.ToString());

            sc.Stop();
            sc.Refresh(); 
            sc.WaitForStatus(ServiceControllerStatus.Stopped);

            commandExecutor.ExecuteCommand(cmdToStop); 

            Console.WriteLine("Status of the service after attempting to stop: " + sc.Status.ToString());
        }
    }
}
