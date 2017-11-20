namespace ComputerLocator2
{
    partial class PrinterPanel
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
            this.printerTable = new System.Windows.Forms.DataGridView();
            this.ipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.retrieveInformationButton = new System.Windows.Forms.Button();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.saveResultsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.printerTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printerTable
            // 
            this.printerTable.AllowUserToAddRows = false;
            this.printerTable.AllowUserToDeleteRows = false;
            this.printerTable.AllowUserToResizeRows = false;
            this.printerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.printerTable.BackgroundColor = System.Drawing.Color.White;
            this.printerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.printerTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.printerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipAddress,
            this.printerName,
            this.printerDriver});
            this.printerTable.GridColor = System.Drawing.Color.LightGray;
            this.printerTable.Location = new System.Drawing.Point(0, 327);
            this.printerTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printerTable.Name = "printerTable";
            this.printerTable.RowHeadersVisible = false;
            this.printerTable.RowTemplate.Height = 28;
            this.printerTable.Size = new System.Drawing.Size(718, 157);
            this.printerTable.TabIndex = 0;
            // 
            // ipAddress
            // 
            this.ipAddress.HeaderText = "IP Address";
            this.ipAddress.Name = "ipAddress";
            // 
            // printerName
            // 
            this.printerName.HeaderText = "Name";
            this.printerName.Name = "printerName";
            // 
            // printerDriver
            // 
            this.printerDriver.HeaderText = "Driver";
            this.printerDriver.Name = "printerDriver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.saveResultsButton);
            this.panel1.Controls.Add(this.ipAddressTextBox);
            this.panel1.Controls.Add(this.retrieveInformationButton);
            this.panel1.Controls.Add(this.ipAddressLabel);
            this.panel1.Location = new System.Drawing.Point(217, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 170);
            this.panel1.TabIndex = 1;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(131, 62);
            this.ipAddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(123, 20);
            this.ipAddressTextBox.TabIndex = 13;
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(131, 90);
            this.retrieveInformationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(122, 23);
            this.retrieveInformationButton.TabIndex = 9;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.retrieveInformationButton_Click);
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(54, 64);
            this.ipAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAddressLabel.TabIndex = 8;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // saveResultsButton
            // 
            this.saveResultsButton.Location = new System.Drawing.Point(132, 127);
            this.saveResultsButton.Name = "saveResultsButton";
            this.saveResultsButton.Size = new System.Drawing.Size(122, 23);
            this.saveResultsButton.TabIndex = 2;
            this.saveResultsButton.Text = "Save Results";
            this.saveResultsButton.UseVisualStyleBackColor = true;
            this.saveResultsButton.Click += new System.EventHandler(this.saveResultsButton_Click);
            // 
            // PrinterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printerTable);
            this.Location = new System.Drawing.Point(151, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrinterPanel";
            this.Size = new System.Drawing.Size(718, 486);
            ((System.ComponentModel.ISupportInitialize)(this.printerTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView printerTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Button retrieveInformationButton;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerDriver;
        private System.Windows.Forms.Button saveResultsButton;
    }
}
