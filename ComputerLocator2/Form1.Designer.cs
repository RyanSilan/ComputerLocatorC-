namespace ComputerLocator2
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.computerSNTextBox = new System.Windows.Forms.TextBox();
            this.computerModelTextBox = new System.Windows.Forms.TextBox();
            this.computerNameTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.retrieveInformationButton = new System.Windows.Forms.Button();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.computerServiceTagLabel = new System.Windows.Forms.Label();
            this.computerModelLabel = new System.Windows.Forms.Label();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.computerTable = new System.Windows.Forms.DataGridView();
            this.IPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextFileLookup = new System.Windows.Forms.Button();
            this.ipComputerLookup = new System.Windows.Forms.Button();
            this.massLookupPanel = new System.Windows.Forms.Panel();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.massLookupProgressBar = new System.Windows.Forms.ProgressBar();
            this.MassLookupButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filePathLab = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.massLookupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.computerSNTextBox);
            this.panel1.Controls.Add(this.computerModelTextBox);
            this.panel1.Controls.Add(this.computerNameTextBox);
            this.panel1.Controls.Add(this.ipAddressTextBox);
            this.panel1.Controls.Add(this.retrieveInformationButton);
            this.panel1.Controls.Add(this.computerNameLabel);
            this.panel1.Controls.Add(this.computerServiceTagLabel);
            this.panel1.Controls.Add(this.computerModelLabel);
            this.panel1.Controls.Add(this.ipAddressLabel);
            this.panel1.Location = new System.Drawing.Point(472, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 262);
            this.panel1.TabIndex = 0;
            // 
            // computerSNTextBox
            // 
            this.computerSNTextBox.Location = new System.Drawing.Point(235, 194);
            this.computerSNTextBox.Name = "computerSNTextBox";
            this.computerSNTextBox.ReadOnly = true;
            this.computerSNTextBox.Size = new System.Drawing.Size(183, 26);
            this.computerSNTextBox.TabIndex = 4;
            // 
            // computerModelTextBox
            // 
            this.computerModelTextBox.Location = new System.Drawing.Point(235, 162);
            this.computerModelTextBox.Name = "computerModelTextBox";
            this.computerModelTextBox.ReadOnly = true;
            this.computerModelTextBox.Size = new System.Drawing.Size(183, 26);
            this.computerModelTextBox.TabIndex = 4;
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.Location = new System.Drawing.Point(235, 131);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.ReadOnly = true;
            this.computerNameTextBox.Size = new System.Drawing.Size(183, 26);
            this.computerNameTextBox.TabIndex = 4;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(235, 36);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(183, 26);
            this.ipAddressTextBox.TabIndex = 4;
            this.ipAddressTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(235, 78);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(183, 35);
            this.retrieveInformationButton.TabIndex = 3;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.retrieveInformation_Click);
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(82, 134);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(129, 20);
            this.computerNameLabel.TabIndex = 1;
            this.computerNameLabel.Text = "Computer Name:";
            // 
            // computerServiceTagLabel
            // 
            this.computerServiceTagLabel.AutoSize = true;
            this.computerServiceTagLabel.Location = new System.Drawing.Point(41, 197);
            this.computerServiceTagLabel.Name = "computerServiceTagLabel";
            this.computerServiceTagLabel.Size = new System.Drawing.Size(170, 20);
            this.computerServiceTagLabel.TabIndex = 1;
            this.computerServiceTagLabel.Text = "Computer Service Tag:";
            // 
            // computerModelLabel
            // 
            this.computerModelLabel.AutoSize = true;
            this.computerModelLabel.Location = new System.Drawing.Point(81, 165);
            this.computerModelLabel.Name = "computerModelLabel";
            this.computerModelLabel.Size = new System.Drawing.Size(130, 20);
            this.computerModelLabel.TabIndex = 1;
            this.computerModelLabel.Text = "Computer Model:";
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(120, 39);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(91, 20);
            this.ipAddressLabel.TabIndex = 1;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // computerTable
            // 
            this.computerTable.AllowUserToOrderColumns = true;
            this.computerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.computerTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.computerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPAddress,
            this.ComputerName,
            this.Model,
            this.SerialNumber});
            this.computerTable.Location = new System.Drawing.Point(151, 503);
            this.computerTable.Margin = new System.Windows.Forms.Padding(2);
            this.computerTable.Name = "computerTable";
            this.computerTable.RowTemplate.Height = 33;
            this.computerTable.Size = new System.Drawing.Size(1077, 242);
            this.computerTable.TabIndex = 3;
            // 
            // IPAddress
            // 
            this.IPAddress.HeaderText = "IP";
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.ReadOnly = true;
            // 
            // ComputerName
            // 
            this.ComputerName.HeaderText = "Name";
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "SN";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.TextFileLookup);
            this.panel2.Controls.Add(this.ipComputerLookup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 745);
            this.panel2.TabIndex = 4;
            // 
            // TextFileLookup
            // 
            this.TextFileLookup.Location = new System.Drawing.Point(9, 206);
            this.TextFileLookup.Margin = new System.Windows.Forms.Padding(2);
            this.TextFileLookup.Name = "TextFileLookup";
            this.TextFileLookup.Size = new System.Drawing.Size(128, 61);
            this.TextFileLookup.TabIndex = 5;
            this.TextFileLookup.Text = "Lookup by Text File";
            this.TextFileLookup.UseVisualStyleBackColor = true;
            this.TextFileLookup.Click += new System.EventHandler(this.TextFileLookup_Click);
            // 
            // ipComputerLookup
            // 
            this.ipComputerLookup.Location = new System.Drawing.Point(9, 121);
            this.ipComputerLookup.Margin = new System.Windows.Forms.Padding(2);
            this.ipComputerLookup.Name = "ipComputerLookup";
            this.ipComputerLookup.Size = new System.Drawing.Size(128, 60);
            this.ipComputerLookup.TabIndex = 5;
            this.ipComputerLookup.Text = "Lookup by IP";
            this.ipComputerLookup.UseVisualStyleBackColor = true;
            this.ipComputerLookup.Click += new System.EventHandler(this.ipComputerLookup_Click);
            // 
            // massLookupPanel
            // 
            this.massLookupPanel.Controls.Add(this.filePath);
            this.massLookupPanel.Controls.Add(this.filePathLab);
            this.massLookupPanel.Controls.Add(this.filePathLabel);
            this.massLookupPanel.Controls.Add(this.openFileButton);
            this.massLookupPanel.Controls.Add(this.massLookupProgressBar);
            this.massLookupPanel.Controls.Add(this.MassLookupButton);
            this.massLookupPanel.Location = new System.Drawing.Point(151, 0);
            this.massLookupPanel.Margin = new System.Windows.Forms.Padding(2);
            this.massLookupPanel.Name = "massLookupPanel";
            this.massLookupPanel.Size = new System.Drawing.Size(1077, 505);
            this.massLookupPanel.TabIndex = 5;
            this.massLookupPanel.Visible = false;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(235, 400);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(0, 20);
            this.filePathLabel.TabIndex = 3;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(475, 439);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(162, 36);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // massLookupProgressBar
            // 
            this.massLookupProgressBar.Location = new System.Drawing.Point(323, 237);
            this.massLookupProgressBar.Name = "massLookupProgressBar";
            this.massLookupProgressBar.Size = new System.Drawing.Size(466, 23);
            this.massLookupProgressBar.TabIndex = 1;
            // 
            // MassLookupButton
            // 
            this.MassLookupButton.Location = new System.Drawing.Point(475, 141);
            this.MassLookupButton.Margin = new System.Windows.Forms.Padding(2);
            this.MassLookupButton.Name = "MassLookupButton";
            this.MassLookupButton.Size = new System.Drawing.Size(162, 55);
            this.MassLookupButton.TabIndex = 0;
            this.MassLookupButton.Text = "Mass Lookup";
            this.MassLookupButton.UseVisualStyleBackColor = true;
            this.MassLookupButton.Click += new System.EventHandler(this.MassLookupButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filePathLab
            // 
            this.filePathLab.AutoSize = true;
            this.filePathLab.Location = new System.Drawing.Point(154, 392);
            this.filePathLab.Name = "filePathLab";
            this.filePathLab.Size = new System.Drawing.Size(75, 20);
            this.filePathLab.TabIndex = 4;
            this.filePathLab.Text = "File Path:";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(235, 384);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(642, 36);
            this.filePath.TabIndex = 5;
            this.filePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 745);
            this.Controls.Add(this.massLookupPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.computerTable);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrame";
            this.Text = "Computer Locator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.massLookupPanel.ResumeLayout(false);
            this.massLookupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button retrieveInformationButton;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Label computerServiceTagLabel;
        private System.Windows.Forms.Label computerModelLabel;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox computerSNTextBox;
        private System.Windows.Forms.TextBox computerModelTextBox;
        private System.Windows.Forms.TextBox computerNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        public System.Windows.Forms.DataGridView computerTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ipComputerLookup;
        private System.Windows.Forms.Button TextFileLookup;
        private System.Windows.Forms.Panel massLookupPanel;
        private System.Windows.Forms.Button MassLookupButton;
        public System.Windows.Forms.ProgressBar massLookupProgressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label filePathLab;
    }
}

