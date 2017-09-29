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
            this.printerIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.retrieveInformationButton = new System.Windows.Forms.Button();
            this.ipAddressLabel = new System.Windows.Forms.Label();
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
            this.printerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printerIP,
            this.name,
            this.driver});
            this.printerTable.Location = new System.Drawing.Point(0, 503);
            this.printerTable.Name = "printerTable";
            this.printerTable.RowTemplate.Height = 28;
            this.printerTable.Size = new System.Drawing.Size(1077, 242);
            this.printerTable.TabIndex = 0;
            // 
            // printerIP
            // 
            this.printerIP.HeaderText = "Printer IP";
            this.printerIP.Name = "printerIP";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // driver
            // 
            this.driver.HeaderText = "Driver";
            this.driver.Name = "driver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.ipAddressTextBox);
            this.panel1.Controls.Add(this.retrieveInformationButton);
            this.panel1.Controls.Add(this.ipAddressLabel);
            this.panel1.Location = new System.Drawing.Point(326, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 262);
            this.panel1.TabIndex = 1;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(196, 96);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(183, 26);
            this.ipAddressTextBox.TabIndex = 13;
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(196, 138);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(183, 35);
            this.retrieveInformationButton.TabIndex = 9;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.retrieveInformationButton_Click);
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(81, 99);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(91, 20);
            this.ipAddressLabel.TabIndex = 8;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // PrinterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printerTable);
            this.Location = new System.Drawing.Point(151, 0);
            this.Name = "PrinterPanel";
            this.Size = new System.Drawing.Size(1077, 747);
            ((System.ComponentModel.ISupportInitialize)(this.printerTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView printerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Button retrieveInformationButton;
        private System.Windows.Forms.Label ipAddressLabel;
    }
}
