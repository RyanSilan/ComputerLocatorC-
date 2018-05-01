namespace ComputerLocator2
{
    partial class ProgramsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.retrieveInformationButton = new System.Windows.Forms.Button();
            this.currentStatusLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.programsProgressBar = new System.Windows.Forms.ProgressBar();
            this.programsTable = new System.Windows.Forms.DataGridView();
            this.softwareDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startRemoteRegistryButton = new System.Windows.Forms.Button();
            this.stopRemoteRegistryButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.ipAddressTextBox);
            this.panel1.Controls.Add(this.ipAddressLabel);
            this.panel1.Controls.Add(this.retrieveInformationButton);
            this.panel1.Location = new System.Drawing.Point(232, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 126);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(107, 81);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Results";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(107, 20);
            this.ipAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(122, 20);
            this.ipAddressTextBox.TabIndex = 16;
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(43, 22);
            this.ipAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAddressLabel.TabIndex = 14;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(107, 53);
            this.retrieveInformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(122, 23);
            this.retrieveInformationButton.TabIndex = 15;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.RetrieveInformationButton_Click);
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.Location = new System.Drawing.Point(154, 25);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(67, 13);
            this.currentStatusLabel.TabIndex = 3;
            this.currentStatusLabel.Text = "Not Running";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(96, 25);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status: ";
            // 
            // programsProgressBar
            // 
            this.programsProgressBar.Location = new System.Drawing.Point(43, 53);
            this.programsProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.programsProgressBar.Name = "programsProgressBar";
            this.programsProgressBar.Size = new System.Drawing.Size(225, 15);
            this.programsProgressBar.TabIndex = 17;
            // 
            // programsTable
            // 
            this.programsTable.AllowUserToAddRows = false;
            this.programsTable.AllowUserToDeleteRows = false;
            this.programsTable.AllowUserToResizeRows = false;
            this.programsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.programsTable.BackgroundColor = System.Drawing.Color.White;
            this.programsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.programsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareDisplayName});
            this.programsTable.GridColor = System.Drawing.Color.LightGray;
            this.programsTable.Location = new System.Drawing.Point(0, 326);
            this.programsTable.Margin = new System.Windows.Forms.Padding(2);
            this.programsTable.Name = "programsTable";
            this.programsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.programsTable.RowHeadersVisible = false;
            this.programsTable.RowTemplate.Height = 28;
            this.programsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.programsTable.Size = new System.Drawing.Size(747, 157);
            this.programsTable.TabIndex = 1;
            // 
            // softwareDisplayName
            // 
            this.softwareDisplayName.HeaderText = "Software Display Name";
            this.softwareDisplayName.Name = "softwareDisplayName";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.currentStatusLabel);
            this.groupBox1.Controls.Add(this.programsProgressBar);
            this.groupBox1.Location = new System.Drawing.Point(232, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // startRemoteRegistryButton
            // 
            this.startRemoteRegistryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startRemoteRegistryButton.Location = new System.Drawing.Point(566, 112);
            this.startRemoteRegistryButton.Name = "startRemoteRegistryButton";
            this.startRemoteRegistryButton.Size = new System.Drawing.Size(132, 23);
            this.startRemoteRegistryButton.TabIndex = 3;
            this.startRemoteRegistryButton.Text = "Start Remote Registry";
            this.startRemoteRegistryButton.UseVisualStyleBackColor = true;
            this.startRemoteRegistryButton.Click += new System.EventHandler(this.startRemoteRegistryButton_Click);
            // 
            // stopRemoteRegistryButton
            // 
            this.stopRemoteRegistryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopRemoteRegistryButton.Location = new System.Drawing.Point(566, 141);
            this.stopRemoteRegistryButton.Name = "stopRemoteRegistryButton";
            this.stopRemoteRegistryButton.Size = new System.Drawing.Size(132, 23);
            this.stopRemoteRegistryButton.TabIndex = 4;
            this.stopRemoteRegistryButton.Text = "Stop Remote Registry";
            this.stopRemoteRegistryButton.UseVisualStyleBackColor = true;
            this.stopRemoteRegistryButton.Click += new System.EventHandler(this.stopRemoteRegistryButton_Click);
            // 
            // ProgramsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.stopRemoteRegistryButton);
            this.Controls.Add(this.startRemoteRegistryButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.programsTable);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(151, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProgramsPanel";
            this.Size = new System.Drawing.Size(749, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Button retrieveInformationButton;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.DataGridView programsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareDisplayName;
        private System.Windows.Forms.ProgressBar programsProgressBar;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label currentStatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startRemoteRegistryButton;
        private System.Windows.Forms.Button stopRemoteRegistryButton;
    }
}
