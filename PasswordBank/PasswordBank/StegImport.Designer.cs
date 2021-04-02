
namespace FirstPass
{
    partial class StegImport
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
            this.ImageFileLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.ExportFileTB = new System.Windows.Forms.TextBox();
            this.ImportFile = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ImageFileLabel
            // 
            this.ImageFileLabel.AutoSize = true;
            this.ImageFileLabel.Location = new System.Drawing.Point(12, 80);
            this.ImageFileLabel.Name = "ImageFileLabel";
            this.ImageFileLabel.Size = new System.Drawing.Size(58, 13);
            this.ImageFileLabel.TabIndex = 7;
            this.ImageFileLabel.Text = "Image File:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(279, 75);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // ExportFileTB
            // 
            this.ExportFileTB.Location = new System.Drawing.Point(91, 77);
            this.ExportFileTB.Name = "ExportFileTB";
            this.ExportFileTB.Size = new System.Drawing.Size(165, 20);
            this.ExportFileTB.TabIndex = 5;
            // 
            // ImportFile
            // 
            this.ImportFile.Location = new System.Drawing.Point(279, 321);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(75, 23);
            this.ImportFile.TabIndex = 8;
            this.ImportFile.Text = "Import";
            this.ImportFile.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 223);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(91, 220);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(165, 20);
            this.PasswordTB.TabIndex = 9;
            // 
            // StegImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 356);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.ImportFile);
            this.Controls.Add(this.ImageFileLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ExportFileTB);
            this.Name = "StegImport";
            this.Text = "StegImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImageFileLabel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox ExportFileTB;
        private System.Windows.Forms.Button ImportFile;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTB;
    }
}