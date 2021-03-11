﻿namespace FirstPass {
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
            this.OkButton.Location = new System.Drawing.Point(185, 197);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter in the password for the file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(79, 43);
            this.passwordEntry.MaxLength = 20;
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(100, 20);
            this.passwordEntry.TabIndex = 3;
            // 
            // KeyfileLocation
            // 
            this.KeyfileLocation.Location = new System.Drawing.Point(79, 150);
            this.KeyfileLocation.MaxLength = 20;
            this.KeyfileLocation.Name = "KeyfileLocation";
            this.KeyfileLocation.ReadOnly = true;
            this.KeyfileLocation.Size = new System.Drawing.Size(100, 20);
            this.KeyfileLocation.TabIndex = 5;
            // 
            // Keyfile
            // 
            this.Keyfile.AutoSize = true;
            this.Keyfile.Location = new System.Drawing.Point(17, 153);
            this.Keyfile.Name = "Keyfile";
            this.Keyfile.Size = new System.Drawing.Size(41, 13);
            this.Keyfile.TabIndex = 4;
            this.Keyfile.Text = "Keyfile:";
            // 
            // FindKeyFile
            // 
            this.FindKeyFile.Location = new System.Drawing.Point(185, 148);
            this.FindKeyFile.Name = "FindKeyFile";
            this.FindKeyFile.Size = new System.Drawing.Size(75, 23);
            this.FindKeyFile.TabIndex = 6;
            this.FindKeyFile.Text = "Search";
            this.FindKeyFile.UseVisualStyleBackColor = true;
            this.FindKeyFile.Click += new System.EventHandler(this.FindKeyFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please enter the Keyfile location:";
            // 
            // EnterPasswordForFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FindKeyFile);
            this.Controls.Add(this.KeyfileLocation);
            this.Controls.Add(this.Keyfile);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EnterPasswordForFile";
            this.Text = "EnterPasswordForFile";
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