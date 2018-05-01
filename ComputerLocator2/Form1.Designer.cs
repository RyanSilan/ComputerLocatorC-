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
            this.individualComputerLookupDataPanel = new System.Windows.Forms.Panel();
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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.programsButton = new System.Windows.Forms.Button();
            this.printerLookupButton = new System.Windows.Forms.Button();
            this.TextFileLookup = new System.Windows.Forms.Button();
            this.ipComputerLookup = new System.Windows.Forms.Button();
            this.massLookupPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filePathLab = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.massLookupProgressBar = new System.Windows.Forms.ProgressBar();
            this.MassLookupButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.massSaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.individualComputerLookupPanel = new System.Windows.Forms.Panel();
            this.processGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new ComputerLocator2.SettingsPanel();
            this.programsPanel = new ComputerLocator2.ProgramsPanel();
            this.printerPanel = new ComputerLocator2.PrinterPanel();
            this.currentStatusLabel = new System.Windows.Forms.Label();
            this.individualComputerLookupDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerTable)).BeginInit();
            this.sideBarPanel.SuspendLayout();
            this.massLookupPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.individualComputerLookupPanel.SuspendLayout();
            this.processGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // individualComputerLookupDataPanel
            // 
            this.individualComputerLookupDataPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.individualComputerLookupDataPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.individualComputerLookupDataPanel.Controls.Add(this.computerSNTextBox);
            this.individualComputerLookupDataPanel.Controls.Add(this.computerModelTextBox);
            this.individualComputerLookupDataPanel.Controls.Add(this.computerNameTextBox);
            this.individualComputerLookupDataPanel.Controls.Add(this.ipAddressTextBox);
            this.individualComputerLookupDataPanel.Controls.Add(this.retrieveInformationButton);
            this.individualComputerLookupDataPanel.Controls.Add(this.computerNameLabel);
            this.individualComputerLookupDataPanel.Controls.Add(this.computerServiceTagLabel);
            this.individualComputerLookupDataPanel.Controls.Add(this.computerModelLabel);
            this.individualComputerLookupDataPanel.Controls.Add(this.ipAddressLabel);
            this.individualComputerLookupDataPanel.Location = new System.Drawing.Point(203, 49);
            this.individualComputerLookupDataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.individualComputerLookupDataPanel.Name = "individualComputerLookupDataPanel";
            this.individualComputerLookupDataPanel.Size = new System.Drawing.Size(311, 170);
            this.individualComputerLookupDataPanel.TabIndex = 0;
            // 
            // computerSNTextBox
            // 
            this.computerSNTextBox.Location = new System.Drawing.Point(157, 126);
            this.computerSNTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.computerSNTextBox.Name = "computerSNTextBox";
            this.computerSNTextBox.ReadOnly = true;
            this.computerSNTextBox.Size = new System.Drawing.Size(123, 20);
            this.computerSNTextBox.TabIndex = 4;
            // 
            // computerModelTextBox
            // 
            this.computerModelTextBox.Location = new System.Drawing.Point(157, 105);
            this.computerModelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.computerModelTextBox.Name = "computerModelTextBox";
            this.computerModelTextBox.ReadOnly = true;
            this.computerModelTextBox.Size = new System.Drawing.Size(123, 20);
            this.computerModelTextBox.TabIndex = 4;
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.Location = new System.Drawing.Point(157, 85);
            this.computerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.ReadOnly = true;
            this.computerNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.computerNameTextBox.TabIndex = 4;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(157, 23);
            this.ipAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(123, 20);
            this.ipAddressTextBox.TabIndex = 4;
            this.ipAddressTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(157, 51);
            this.retrieveInformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(122, 23);
            this.retrieveInformationButton.TabIndex = 3;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.RetrieveInformation_Click);
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(55, 87);
            this.computerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(86, 13);
            this.computerNameLabel.TabIndex = 1;
            this.computerNameLabel.Text = "Computer Name:";
            // 
            // computerServiceTagLabel
            // 
            this.computerServiceTagLabel.AutoSize = true;
            this.computerServiceTagLabel.Location = new System.Drawing.Point(27, 128);
            this.computerServiceTagLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computerServiceTagLabel.Name = "computerServiceTagLabel";
            this.computerServiceTagLabel.Size = new System.Drawing.Size(116, 13);
            this.computerServiceTagLabel.TabIndex = 1;
            this.computerServiceTagLabel.Text = "Computer Service Tag:";
            // 
            // computerModelLabel
            // 
            this.computerModelLabel.AutoSize = true;
            this.computerModelLabel.Location = new System.Drawing.Point(54, 107);
            this.computerModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computerModelLabel.Name = "computerModelLabel";
            this.computerModelLabel.Size = new System.Drawing.Size(87, 13);
            this.computerModelLabel.TabIndex = 1;
            this.computerModelLabel.Text = "Computer Model:";
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(80, 25);
            this.ipAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAddressLabel.TabIndex = 1;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // computerTable
            // 
            this.computerTable.AllowUserToAddRows = false;
            this.computerTable.AllowUserToDeleteRows = false;
            this.computerTable.AllowUserToOrderColumns = true;
            this.computerTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.computerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.computerTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.computerTable.BackgroundColor = System.Drawing.Color.White;
            this.computerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.computerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPAddress,
            this.ComputerName,
            this.Model,
            this.SerialNumber});
            this.computerTable.GridColor = System.Drawing.Color.LightGray;
            this.computerTable.Location = new System.Drawing.Point(101, 327);
            this.computerTable.Margin = new System.Windows.Forms.Padding(1);
            this.computerTable.Name = "computerTable";
            this.computerTable.RowHeadersVisible = false;
            this.computerTable.RowTemplate.Height = 33;
            this.computerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.computerTable.Size = new System.Drawing.Size(718, 157);
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
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sideBarPanel.Controls.Add(this.settingsButton);
            this.sideBarPanel.Controls.Add(this.programsButton);
            this.sideBarPanel.Controls.Add(this.printerLookupButton);
            this.sideBarPanel.Controls.Add(this.TextFileLookup);
            this.sideBarPanel.Controls.Add(this.ipComputerLookup);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(1);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(100, 484);
            this.sideBarPanel.TabIndex = 4;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(6, 432);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(85, 40);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // programsButton
            // 
            this.programsButton.Location = new System.Drawing.Point(6, 246);
            this.programsButton.Margin = new System.Windows.Forms.Padding(2);
            this.programsButton.Name = "programsButton";
            this.programsButton.Size = new System.Drawing.Size(85, 40);
            this.programsButton.TabIndex = 7;
            this.programsButton.Text = "Lookup Programs";
            this.programsButton.UseVisualStyleBackColor = true;
            this.programsButton.Click += new System.EventHandler(this.ProgramsButton_Click);
            // 
            // printerLookupButton
            // 
            this.printerLookupButton.Location = new System.Drawing.Point(6, 190);
            this.printerLookupButton.Margin = new System.Windows.Forms.Padding(2);
            this.printerLookupButton.Name = "printerLookupButton";
            this.printerLookupButton.Size = new System.Drawing.Size(85, 40);
            this.printerLookupButton.TabIndex = 6;
            this.printerLookupButton.Text = "Lookup Printers";
            this.printerLookupButton.UseVisualStyleBackColor = true;
            this.printerLookupButton.Click += new System.EventHandler(this.PrinterLookupButton_Click);
            // 
            // TextFileLookup
            // 
            this.TextFileLookup.Location = new System.Drawing.Point(6, 134);
            this.TextFileLookup.Margin = new System.Windows.Forms.Padding(1);
            this.TextFileLookup.Name = "TextFileLookup";
            this.TextFileLookup.Size = new System.Drawing.Size(85, 40);
            this.TextFileLookup.TabIndex = 5;
            this.TextFileLookup.Text = "Lookup by Text File";
            this.TextFileLookup.UseVisualStyleBackColor = true;
            this.TextFileLookup.Click += new System.EventHandler(this.TextFileLookup_Click);
            // 
            // ipComputerLookup
            // 
            this.ipComputerLookup.Location = new System.Drawing.Point(6, 79);
            this.ipComputerLookup.Margin = new System.Windows.Forms.Padding(1);
            this.ipComputerLookup.Name = "ipComputerLookup";
            this.ipComputerLookup.Size = new System.Drawing.Size(85, 40);
            this.ipComputerLookup.TabIndex = 5;
            this.ipComputerLookup.Text = "Lookup by IP";
            this.ipComputerLookup.UseVisualStyleBackColor = true;
            this.ipComputerLookup.Click += new System.EventHandler(this.IpComputerLookup_Click);
            // 
            // massLookupPanel
            // 
            this.massLookupPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.massLookupPanel.AutoSize = true;
            this.massLookupPanel.Controls.Add(this.groupBox1);
            this.massLookupPanel.Controls.Add(this.filePathLabel);
            this.massLookupPanel.Controls.Add(this.massLookupProgressBar);
            this.massLookupPanel.Controls.Add(this.MassLookupButton);
            this.massLookupPanel.Controls.Add(this.panel3);
            this.massLookupPanel.Location = new System.Drawing.Point(101, 0);
            this.massLookupPanel.Margin = new System.Windows.Forms.Padding(1);
            this.massLookupPanel.Name = "massLookupPanel";
            this.massLookupPanel.Size = new System.Drawing.Size(718, 328);
            this.massLookupPanel.TabIndex = 5;
            this.massLookupPanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filePathLab);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.openFileButton);
            this.groupBox1.Location = new System.Drawing.Point(171, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // filePathLab
            // 
            this.filePathLab.AutoSize = true;
            this.filePathLab.Location = new System.Drawing.Point(38, 29);
            this.filePathLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filePathLab.Name = "filePathLab";
            this.filePathLab.Size = new System.Drawing.Size(51, 13);
            this.filePathLab.TabIndex = 4;
            this.filePathLab.Text = "File Path:";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(93, 24);
            this.filePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(278, 23);
            this.filePath.TabIndex = 5;
            this.filePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(142, 52);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(108, 23);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(157, 260);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(0, 13);
            this.filePathLabel.TabIndex = 3;
            // 
            // massLookupProgressBar
            // 
            this.massLookupProgressBar.Location = new System.Drawing.Point(212, 181);
            this.massLookupProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.massLookupProgressBar.Name = "massLookupProgressBar";
            this.massLookupProgressBar.Size = new System.Drawing.Size(311, 15);
            this.massLookupProgressBar.TabIndex = 1;
            // 
            // MassLookupButton
            // 
            this.MassLookupButton.Location = new System.Drawing.Point(313, 92);
            this.MassLookupButton.Margin = new System.Windows.Forms.Padding(1);
            this.MassLookupButton.Name = "MassLookupButton";
            this.MassLookupButton.Size = new System.Drawing.Size(108, 36);
            this.MassLookupButton.TabIndex = 0;
            this.MassLookupButton.Text = "Mass Lookup";
            this.MassLookupButton.UseVisualStyleBackColor = true;
            this.MassLookupButton.Click += new System.EventHandler(this.MassLookupButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.massSaveButton);
            this.panel3.Location = new System.Drawing.Point(171, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 166);
            this.panel3.TabIndex = 6;
            // 
            // massSaveButton
            // 
            this.massSaveButton.Location = new System.Drawing.Point(142, 92);
            this.massSaveButton.Name = "massSaveButton";
            this.massSaveButton.Size = new System.Drawing.Size(108, 26);
            this.massSaveButton.TabIndex = 0;
            this.massSaveButton.Text = "Save Results";
            this.massSaveButton.UseVisualStyleBackColor = true;
            this.massSaveButton.Click += new System.EventHandler(this.massSaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // individualComputerLookupPanel
            // 
            this.individualComputerLookupPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.individualComputerLookupPanel.Controls.Add(this.processGroupBox);
            this.individualComputerLookupPanel.Controls.Add(this.individualComputerLookupDataPanel);
            this.individualComputerLookupPanel.Location = new System.Drawing.Point(103, 0);
            this.individualComputerLookupPanel.Name = "individualComputerLookupPanel";
            this.individualComputerLookupPanel.Size = new System.Drawing.Size(718, 328);
            this.individualComputerLookupPanel.TabIndex = 8;
            // 
            // processGroupBox
            // 
            this.processGroupBox.Controls.Add(this.currentStatusLabel);
            this.processGroupBox.Controls.Add(this.statusLabel);
            this.processGroupBox.Location = new System.Drawing.Point(203, 231);
            this.processGroupBox.Name = "processGroupBox";
            this.processGroupBox.Size = new System.Drawing.Size(311, 66);
            this.processGroupBox.TabIndex = 9;
            this.processGroupBox.TabStop = false;
            this.processGroupBox.Text = "Progress";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(80, 29);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status: ";
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoSize = true;
            this.settingsPanel.Location = new System.Drawing.Point(101, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(718, 486);
            this.settingsPanel.TabIndex = 7;
            this.settingsPanel.Visible = false;
            // 
            // programsPanel
            // 
            this.programsPanel.AutoSize = true;
            this.programsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programsPanel.Location = new System.Drawing.Point(100, 0);
            this.programsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.programsPanel.Name = "programsPanel";
            this.programsPanel.Size = new System.Drawing.Size(719, 484);
            this.programsPanel.TabIndex = 7;
            this.programsPanel.Visible = false;
            // 
            // printerPanel
            // 
            this.printerPanel.AutoSize = true;
            this.printerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerPanel.Location = new System.Drawing.Point(100, 0);
            this.printerPanel.Margin = new System.Windows.Forms.Padding(1);
            this.printerPanel.Name = "printerPanel";
            this.printerPanel.Size = new System.Drawing.Size(719, 484);
            this.printerPanel.TabIndex = 6;
            this.printerPanel.Visible = false;
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.Location = new System.Drawing.Point(149, 29);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(67, 13);
            this.currentStatusLabel.TabIndex = 1;
            this.currentStatusLabel.Text = "Not Running";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 484);
            this.Controls.Add(this.individualComputerLookupPanel);
            this.Controls.Add(this.computerTable);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.printerPanel);
            this.Controls.Add(this.massLookupPanel);
            this.Controls.Add(this.programsPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(835, 523);
            this.Name = "MainFrame";
            this.Text = "Computer Locator";
            this.individualComputerLookupDataPanel.ResumeLayout(false);
            this.individualComputerLookupDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerTable)).EndInit();
            this.sideBarPanel.ResumeLayout(false);
            this.massLookupPanel.ResumeLayout(false);
            this.massLookupPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.individualComputerLookupPanel.ResumeLayout(false);
            this.processGroupBox.ResumeLayout(false);
            this.processGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel individualComputerLookupDataPanel;
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
        private System.Windows.Forms.Panel sideBarPanel;
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
        private System.Windows.Forms.Button printerLookupButton;
        private PrinterPanel printerPanel;
        private ProgramsPanel programsPanel;
        private System.Windows.Forms.Button programsButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button settingsButton;
        private SettingsPanel settingsPanel;
        private System.Windows.Forms.Button massSaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel individualComputerLookupPanel;
        private System.Windows.Forms.GroupBox processGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label currentStatusLabel;
    }
}

