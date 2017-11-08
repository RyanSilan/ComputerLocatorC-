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
            this.programsProgressBar = new System.Windows.Forms.ProgressBar();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.retrieveInformationButton = new System.Windows.Forms.Button();
            this.programsTable = new System.Windows.Forms.DataGridView();
            this.softwareDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.programsProgressBar);
            this.panel1.Controls.Add(this.ipAddressTextBox);
            this.panel1.Controls.Add(this.ipAddressLabel);
            this.panel1.Controls.Add(this.retrieveInformationButton);
            this.panel1.Location = new System.Drawing.Point(326, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 262);
            this.panel1.TabIndex = 0;
            // 
            // programsProgressBar
            // 
            this.programsProgressBar.Location = new System.Drawing.Point(72, 176);
            this.programsProgressBar.Name = "programsProgressBar";
            this.programsProgressBar.Size = new System.Drawing.Size(337, 23);
            this.programsProgressBar.TabIndex = 17;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(182, 69);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(183, 26);
            this.ipAddressTextBox.TabIndex = 16;
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(85, 72);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(91, 20);
            this.ipAddressLabel.TabIndex = 14;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(182, 113);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(183, 35);
            this.retrieveInformationButton.TabIndex = 15;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.retrieveInformationButton_Click);
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
            this.programsTable.Location = new System.Drawing.Point(0, 503);
            this.programsTable.Name = "programsTable";
            this.programsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.programsTable.RowHeadersVisible = false;
            this.programsTable.RowTemplate.Height = 28;
            this.programsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.programsTable.Size = new System.Drawing.Size(1077, 242);
            this.programsTable.TabIndex = 1;
            // 
            // softwareDisplayName
            // 
            this.softwareDisplayName.HeaderText = "Software Display Name";
            this.softwareDisplayName.Name = "softwareDisplayName";
            // 
            // ProgramsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.programsTable);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(151, 0);
            this.Name = "ProgramsPanel";
            this.Size = new System.Drawing.Size(1077, 747);
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
    }
}
