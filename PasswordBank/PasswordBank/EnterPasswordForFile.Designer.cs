namespace FirstPass {
    partial class EnterPasswordForFile {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.KeyfileLocation = new System.Windows.Forms.TextBox();
            this.Keyfile = new System.Windows.Forms.Label();
            this.FindKeyFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.AccessibleName = "Ok";
            this.OkButton.Location = new System.Drawing.Point(278, 303);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(112, 35);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter in the password for the file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // passwordEntry
            // 
            this.passwordEntry.AccessibleName = "PasswordEntry";
            this.passwordEntry.Location = new System.Drawing.Point(118, 66);
            this.passwordEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordEntry.MaxLength = 20;
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(148, 26);
            this.passwordEntry.TabIndex = 3;
            // 
            // KeyfileLocation
            // 
            this.KeyfileLocation.AllowDrop = true;
            this.KeyfileLocation.Location = new System.Drawing.Point(118, 231);
            this.KeyfileLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KeyfileLocation.MaxLength = 20;
            this.KeyfileLocation.Name = "KeyfileLocation";
            this.KeyfileLocation.ReadOnly = true;
            this.KeyfileLocation.Size = new System.Drawing.Size(148, 26);
            this.KeyfileLocation.TabIndex = 5;
            this.KeyfileLocation.DragOver += new System.Windows.Forms.DragEventHandler(this.KeyfileLocation_DragOver);
            // 
            // Keyfile
            // 
            this.Keyfile.AutoSize = true;
            this.Keyfile.Location = new System.Drawing.Point(26, 235);
            this.Keyfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Keyfile.Name = "Keyfile";
            this.Keyfile.Size = new System.Drawing.Size(59, 20);
            this.Keyfile.TabIndex = 4;
            this.Keyfile.Text = "Keyfile:";
            // 
            // FindKeyFile
            // 
            this.FindKeyFile.AccessibleName = "FindKeyFile";
            this.FindKeyFile.Location = new System.Drawing.Point(278, 228);
            this.FindKeyFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FindKeyFile.Name = "FindKeyFile";
            this.FindKeyFile.Size = new System.Drawing.Size(112, 35);
            this.FindKeyFile.TabIndex = 6;
            this.FindKeyFile.Text = "Search";
            this.FindKeyFile.UseVisualStyleBackColor = true;
            this.FindKeyFile.Click += new System.EventHandler(this.FindKeyFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please enter the Keyfile location:";
            // 
            // EnterPasswordForFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FindKeyFile);
            this.Controls.Add(this.KeyfileLocation);
            this.Controls.Add(this.Keyfile);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnterPasswordForFile";
            this.Text = "EnterPasswordForFile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterPasswordForFile_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.TextBox KeyfileLocation;
        private System.Windows.Forms.Label Keyfile;
        private System.Windows.Forms.Button FindKeyFile;
        private System.Windows.Forms.Label label3;
    }
}