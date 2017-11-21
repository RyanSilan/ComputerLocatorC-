namespace ComputerLocator2
{
    partial class SettingsPanel
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
            this.currentLabel = new System.Windows.Forms.Label();
            this.currentFileLocationLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(179, 228);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(119, 13);
            this.currentLabel.TabIndex = 0;
            this.currentLabel.Text = "Current Save Location: ";
            // 
            // currentFileLocationLabel
            // 
            this.currentFileLocationLabel.AutoSize = true;
            this.currentFileLocationLabel.Location = new System.Drawing.Point(305, 228);
            this.currentFileLocationLabel.Name = "currentFileLocationLabel";
            this.currentFileLocationLabel.Size = new System.Drawing.Size(0, 13);
            this.currentFileLocationLabel.TabIndex = 1;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(182, 273);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(121, 34);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "Select File Location";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.currentFileLocationLabel);
            this.Controls.Add(this.currentLabel);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(718, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label currentFileLocationLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
