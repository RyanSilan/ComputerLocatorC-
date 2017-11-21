using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerLocator2
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();
            currentFileLocationLabel.Text = Environment.ExpandEnvironmentVariables(Properties.Settings.Default.FileSaveLocation); 
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Properties.Settings.Default.FileSaveLocation = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();

                currentFileLocationLabel.Text = Environment.ExpandEnvironmentVariables(Properties.Settings.Default.FileSaveLocation);

            }
        }
    }
}
