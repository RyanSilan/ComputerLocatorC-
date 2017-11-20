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
            this.programsProgressBar = new System.Windows.Forms.ProgressBar();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.retrieveInformationButton = new System.Windows.Forms.Button();
            this.programsTable = new System.Windows.Forms.DataGridView();
            this.softwareDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLabel = new System.Windows.Forms.Label();
            this.currentStatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.currentStatusLabel);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.programsProgressBar);
            this.panel1.Controls.Add(this.ipAddressTextBox);
            this.panel1.Controls.Add(this.ipAddressLabel);
            this.panel1.Controls.Add(this.retrieveInformationButton);
            this.panel1.Location = new System.Drawing.Point(217, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 170);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(99, 81);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Results";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // programsProgressBar
            // 
            this.programsProgressBar.Location = new System.Drawing.Point(50, 141);
            this.programsProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.programsProgressBar.Name = "programsProgressBar";
            this.programsProgressBar.Size = new System.Drawing.Size(225, 15);
            this.programsProgressBar.TabIndex = 17;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(99, 20);
            this.ipAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(122, 20);
            this.ipAddressTextBox.TabIndex = 16;
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(35, 22);
            this.ipAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAddressLabel.TabIndex = 14;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(99, 53);
            this.retrieveInformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(122, 23);
            this.retrieveInformationButton.TabIndex = 15;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.RetrieveInformationButton_Click);
            // 
            // programsTable
            // 
            this.programsTable.AllowUserToAddRows = false;
            this.programsTable.AllowUserToDeleteRows = false;
            this.programsTable.AllowUserToResizeRows = false;
            this.programsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.programsTable.BackgroundColor = System.Drawing.Color.White;
            this.programsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.programsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareDisplayName});
            this.programsTable.GridColor = System.Drawing.Color.LightGray;
            this.programsTable.Location = new System.Drawing.Point(0, 327);
            this.programsTable.Margin = new System.Windows.Forms.Padding(2);
            this.programsTable.Name = "programsTable";
            this.programsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.programsTable.RowHeadersVisible = false;
            this.programsTable.RowTemplate.Height = 28;
            this.programsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.programsTable.Size = new System.Drawing.Size(718, 157);
            this.programsTable.TabIndex = 1;
            // 
            // softwareDisplayName
            // 
            this.softwareDisplayName.HeaderText = "Software Display Name";
            this.softwareDisplayName.Name = "softwareDisplayName";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(105, 116);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status: ";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.Location = new System.Drawing.Point(145, 116);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(67, 13);
            this.currentStatusLabel.TabIndex = 3;
            this.currentStatusLabel.Text = "Not Running";
            // 
            // ProgramsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.programsTable);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(151, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProgramsPanel";
            this.Size = new System.Drawing.Size(718, 486);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsTable)).EndInit();
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
    }
}
