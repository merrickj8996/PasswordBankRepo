
namespace FirstPass
{
    partial class StegExport
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
            this.ExportFileTB = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordConfirmTB = new System.Windows.Forms.TextBox();
            this.ImageFileLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmLabel = new System.Windows.Forms.Label();
            this.ExportFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExportFileTB
            // 
            this.ExportFileTB.Location = new System.Drawing.Point(92, 93);
            this.ExportFileTB.Name = "ExportFileTB";
            this.ExportFileTB.Size = new System.Drawing.Size(165, 20);
            this.ExportFileTB.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(279, 91);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(92, 199);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(165, 20);
            this.PasswordTB.TabIndex = 2;
            // 
            // PasswordConfirmTB
            // 
            this.PasswordConfirmTB.Location = new System.Drawing.Point(92, 235);
            this.PasswordConfirmTB.Name = "PasswordConfirmTB";
            this.PasswordConfirmTB.PasswordChar = '*';
            this.PasswordConfirmTB.Size = new System.Drawing.Size(165, 20);
            this.PasswordConfirmTB.TabIndex = 3;
            // 
            // ImageFileLabel
            // 
            this.ImageFileLabel.AutoSize = true;
            this.ImageFileLabel.Location = new System.Drawing.Point(12, 96);
            this.ImageFileLabel.Name = "ImageFileLabel";
            this.ImageFileLabel.Size = new System.Drawing.Size(58, 13);
            this.ImageFileLabel.TabIndex = 4;
            this.ImageFileLabel.Text = "Image File:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 202);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordConfirmLabel
            // 
            this.PasswordConfirmLabel.AutoSize = true;
            this.PasswordConfirmLabel.Location = new System.Drawing.Point(12, 238);
            this.PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            this.PasswordConfirmLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordConfirmLabel.TabIndex = 6;
            this.PasswordConfirmLabel.Text = "Confirm:";
            // 
            // ExportFile
            // 
            this.ExportFile.Location = new System.Drawing.Point(279, 322);
            this.ExportFile.Name = "ExportFile";
            this.ExportFile.Size = new System.Drawing.Size(75, 23);
            this.ExportFile.TabIndex = 7;
            this.ExportFile.Text = "Export";
            this.ExportFile.UseVisualStyleBackColor = true;
            // 
            // StegExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 357);
            this.Controls.Add(this.ExportFile);
            this.Controls.Add(this.PasswordConfirmLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ImageFileLabel);
            this.Controls.Add(this.PasswordConfirmTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ExportFileTB);
            this.Name = "StegExport";
            this.Text = "StegExport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExportFileTB;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox PasswordConfirmTB;
        private System.Windows.Forms.Label ImageFileLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PasswordConfirmLabel;
        private System.Windows.Forms.Button ExportFile;
    }
}