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
            this.MassLookupButton = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(630, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 328);
            this.panel1.TabIndex = 0;
            // 
            // computerSNTextBox
            // 
            this.computerSNTextBox.Location = new System.Drawing.Point(313, 242);
            this.computerSNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.computerSNTextBox.Name = "computerSNTextBox";
            this.computerSNTextBox.ReadOnly = true;
            this.computerSNTextBox.Size = new System.Drawing.Size(243, 31);
            this.computerSNTextBox.TabIndex = 4;
            // 
            // computerModelTextBox
            // 
            this.computerModelTextBox.Location = new System.Drawing.Point(313, 202);
            this.computerModelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.computerModelTextBox.Name = "computerModelTextBox";
            this.computerModelTextBox.ReadOnly = true;
            this.computerModelTextBox.Size = new System.Drawing.Size(243, 31);
            this.computerModelTextBox.TabIndex = 4;
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.Location = new System.Drawing.Point(313, 164);
            this.computerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.ReadOnly = true;
            this.computerNameTextBox.Size = new System.Drawing.Size(243, 31);
            this.computerNameTextBox.TabIndex = 4;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox.Location = new System.Drawing.Point(313, 45);
            this.ipAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(243, 31);
            this.ipAddressTextBox.TabIndex = 4;
            this.ipAddressTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // retrieveInformationButton
            // 
            this.retrieveInformationButton.Location = new System.Drawing.Point(313, 98);
            this.retrieveInformationButton.Margin = new System.Windows.Forms.Padding(4);
            this.retrieveInformationButton.Name = "retrieveInformationButton";
            this.retrieveInformationButton.Size = new System.Drawing.Size(244, 44);
            this.retrieveInformationButton.TabIndex = 3;
            this.retrieveInformationButton.Text = "Retrieve Information";
            this.retrieveInformationButton.UseVisualStyleBackColor = true;
            this.retrieveInformationButton.Click += new System.EventHandler(this.retrieveInformation_Click);
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(109, 168);
            this.computerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(179, 26);
            this.computerNameLabel.TabIndex = 1;
            this.computerNameLabel.Text = "Computer Name:";
            // 
            // computerServiceTagLabel
            // 
            this.computerServiceTagLabel.AutoSize = true;
            this.computerServiceTagLabel.Location = new System.Drawing.Point(55, 246);
            this.computerServiceTagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.computerServiceTagLabel.Name = "computerServiceTagLabel";
            this.computerServiceTagLabel.Size = new System.Drawing.Size(235, 26);
            this.computerServiceTagLabel.TabIndex = 1;
            this.computerServiceTagLabel.Text = "Computer Service Tag:";
            // 
            // computerModelLabel
            // 
            this.computerModelLabel.AutoSize = true;
            this.computerModelLabel.Location = new System.Drawing.Point(108, 206);
            this.computerModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.computerModelLabel.Name = "computerModelLabel";
            this.computerModelLabel.Size = new System.Drawing.Size(179, 26);
            this.computerModelLabel.TabIndex = 1;
            this.computerModelLabel.Text = "Computer Model:";
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(160, 49);
            this.ipAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(125, 26);
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
            this.computerTable.Location = new System.Drawing.Point(201, 629);
            this.computerTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.computerTable.Name = "computerTable";
            this.computerTable.RowTemplate.Height = 33;
            this.computerTable.Size = new System.Drawing.Size(1436, 302);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 931);
            this.panel2.TabIndex = 4;
            // 
            // TextFileLookup
            // 
            this.TextFileLookup.Location = new System.Drawing.Point(12, 257);
            this.TextFileLookup.Name = "TextFileLookup";
            this.TextFileLookup.Size = new System.Drawing.Size(170, 76);
            this.TextFileLookup.TabIndex = 5;
            this.TextFileLookup.Text = "Lookup by Text File";
            this.TextFileLookup.UseVisualStyleBackColor = true;
            this.TextFileLookup.Click += new System.EventHandler(this.TextFileLookup_Click);
            // 
            // ipComputerLookup
            // 
            this.ipComputerLookup.Location = new System.Drawing.Point(12, 151);
            this.ipComputerLookup.Name = "ipComputerLookup";
            this.ipComputerLookup.Size = new System.Drawing.Size(170, 75);
            this.ipComputerLookup.TabIndex = 5;
            this.ipComputerLookup.Text = "Lookup by IP";
            this.ipComputerLookup.UseVisualStyleBackColor = true;
            this.ipComputerLookup.Click += new System.EventHandler(this.ipComputerLookup_Click);
            // 
            // massLookupPanel
            // 
            this.massLookupPanel.Controls.Add(this.MassLookupButton);
            this.massLookupPanel.Location = new System.Drawing.Point(201, 0);
            this.massLookupPanel.Name = "massLookupPanel";
            this.massLookupPanel.Size = new System.Drawing.Size(1436, 631);
            this.massLookupPanel.TabIndex = 5;
            this.massLookupPanel.Visible = false;
            // 
            // MassLookupButton
            // 
            this.MassLookupButton.Location = new System.Drawing.Point(638, 420);
            this.MassLookupButton.Name = "MassLookupButton";
            this.MassLookupButton.Size = new System.Drawing.Size(216, 69);
            this.MassLookupButton.TabIndex = 0;
            this.MassLookupButton.Text = "Mass Lookup";
            this.MassLookupButton.UseVisualStyleBackColor = true;
            this.MassLookupButton.Click += new System.EventHandler(this.MassLookupButton_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 931);
            this.Controls.Add(this.massLookupPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.computerTable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrame";
            this.Text = "Computer Locator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.massLookupPanel.ResumeLayout(false);
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
    }
}

