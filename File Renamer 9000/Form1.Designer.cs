namespace File_Renamer_9000
{
    partial class fileRenamer9000
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
            this.folderPickerTextBox = new System.Windows.Forms.TextBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.startNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.namingFormatTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.instructiosLlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // folderPickerTextBox
            // 
            this.folderPickerTextBox.Location = new System.Drawing.Point(30, 52);
            this.folderPickerTextBox.Name = "folderPickerTextBox";
            this.folderPickerTextBox.Size = new System.Drawing.Size(800, 31);
            this.folderPickerTextBox.TabIndex = 0;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(947, 38);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(171, 59);
            this.selectFolderButton.TabIndex = 3;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(85, 304);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(138, 25);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "Start Number";
            // 
            // startNumericUpDown
            // 
            this.startNumericUpDown.Location = new System.Drawing.Point(306, 304);
            this.startNumericUpDown.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.startNumericUpDown.Name = "startNumericUpDown";
            this.startNumericUpDown.Size = new System.Drawing.Size(200, 31);
            this.startNumericUpDown.TabIndex = 6;
            // 
            // namingFormatTextBox
            // 
            this.namingFormatTextBox.Location = new System.Drawing.Point(30, 234);
            this.namingFormatTextBox.Name = "namingFormatTextBox";
            this.namingFormatTextBox.Size = new System.Drawing.Size(800, 31);
            this.namingFormatTextBox.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(947, 220);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(171, 59);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start Rename";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // instructiosLlabel
            // 
            this.instructiosLlabel.Location = new System.Drawing.Point(78, 136);
            this.instructiosLlabel.Name = "instructiosLlabel";
            this.instructiosLlabel.Size = new System.Drawing.Size(508, 63);
            this.instructiosLlabel.TabIndex = 10;
            this.instructiosLlabel.Text = "Write your desired rename format here.  Use # for where you\'d like numbers, but o" +
    "nly in one place";
            // 
            // fileRenamer9000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 390);
            this.Controls.Add(this.instructiosLlabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.namingFormatTextBox);
            this.Controls.Add(this.startNumericUpDown);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.folderPickerTextBox);
            this.Name = "fileRenamer9000";
            this.Text = "Form Renamer 9000";
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPickerTextBox;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.NumericUpDown startNumericUpDown;
        private System.Windows.Forms.TextBox namingFormatTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label instructiosLlabel;
    }
}

