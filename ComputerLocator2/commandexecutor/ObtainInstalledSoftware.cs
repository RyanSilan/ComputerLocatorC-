﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using ComputerLocator2.list; 

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

        public delegate void UpdateLabel(string value);
        public event UpdateLabel OnLabelUpdate; 

        /*
        public ObtainInstalledSoftware(ProgressBar progressBar, string computer)
        {
            computerName = computer;
            oisProgressBar = progressBar;
            progressBar.Value = 0; 
            
            bw.DoWork += GetInstalledSoftware;
            bw.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
            bw.WorkerReportsProgress = true;
            bw.RunWorkerCompleted += WorkCompleted;

            bw.RunWorkerAsync();
            
        }
        */ 

        public void GetInstalledSoftware(ProgressBar progressBar, string computer)
        {
            computerName = computer;
            oisProgressBar = progressBar;
            progressBar.Value = 0;

            bw.DoWork += GetInstalledSoftware;
            bw.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
            bw.WorkerReportsProgress = true;
            bw.RunWorkerCompleted += WorkCompleted;

            OnLabelUpdate("Running");

            bw.RunWorkerAsync();
        }

        private void WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnLabelUpdate("Not Running"); 
            MessageBox.Show("Finished pulling software list");
        }

        /*
        private void GetInstalledSoftware(object sender, DoWorkEventArgs e)
        {
            
            int totalNumberOfKeys = 0;
            int countedKeys = 0;
            
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


            StopService();
            
        }

    */

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Progress: " + e.ProgressPercentage.ToString());
            oisProgressBar.Value = e.ProgressPercentage;

        }

        //Used to start the RemoteRegistry service that is 
        //required to be running in order to query registry
        public void StartService(string computerName)
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
                    Console.WriteLine("Failed to start it the first time, trying again");
                    commandExecutor.ExecuteCommand(cmdToStart);
                    Thread.Sleep(2000);
                    sc.Start();
                    sc.Refresh();
                    sc.WaitForStatus(ServiceControllerStatus.Running);
                }
            }

            sc.Refresh(); 
            if(sc.Status == ServiceControllerStatus.Stopped)
                MessageBox.Show("Tried to start the service twice and failed.");

        }
        
        //Stops the RemoteRegistry service and then sets it to Disabled
        public void StopService(string computerName)
        {
            string cmdToStop = firstPartOfCMD + computerName + secondPartOfCMDToStop;
            sc.MachineName = computerName;

            Console.WriteLine("Status of the service when attempting to stop: " + sc.Status.ToString());

            sc.Stop();
            sc.Refresh(); 
            sc.WaitForStatus(ServiceControllerStatus.Stopped);

            commandExecutor.ExecuteCommand(cmdToStop); 

            Console.WriteLine("Status of the service after attempting to stop: " + sc.Status.ToString());
        }

        private void GetInstalledSoftware(object sender, DoWorkEventArgs e)
        {

            List<string> programList = new List<string>(); 
             
            int totalNumberOfKeys = 0;
            int countedKeys = 0;

            StartService(computerName);

            using (RegistryKey key =
            RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, computerName).OpenSubKey(registryKey))
            {
                totalNumberOfKeys = key.GetSubKeyNames().Length;

                foreach (string keyName in key.GetSubKeyNames())
                {
                    using (RegistryKey subKey = key.OpenSubKey(keyName))
                    {
                        if (subKey.GetValue("DisplayName") != null)
                        {
                            //TableUpdater.PopulateProgramsTable(subKey.GetValue("DisplayName").ToString());
                            programList.Add(subKey.GetValue("DisplayName").ToString()); 
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

            foreach (string value in programList)
            {
                if (!(value.Contains("Security Update")) &&
                            !(value.Contains("Adobe Flash")) &&
                            !(value.Contains("Dell")) &&
                            !(value.Contains("Java")) &&
                            !(value.Contains("Google Update")) &&
                            !(value.Contains("Apple")) &&
                            !(value.Contains("Computrace")) &&
                            !(value.Contains("Microsoft redistributable")) &&
                            !(value.Contains("Cisco AnyConnect")) &&
                            !(value.Contains("Update for")) &&
                            !(value.Contains("IBM i Access")) &&
                            !(value.Contains("Service Pack")) &&
                            !(value.Contains("System Requirement")) &&
                            !(value.Contains("Absolute Software")) &&
                            !(value.Contains("Adobe Refresh")) &&
                            !(value.Contains("Intel(R)")) &&
                            !(value.Contains("Proof")) &&
                            !(value.Contains("O2Micro")) &&
                            !(value.Contains("Realtek")) &&
                            !(value.Contains("ST Microelectronics")) &&
                            !(value.Contains("MSXML")))
                {
                    TableUpdater.PopulateProgramsTable(value);                  
                }
            }
            StopService(computerName);
        }
    }
}
