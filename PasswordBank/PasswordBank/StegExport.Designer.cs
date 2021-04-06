
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
            this.ImageFileLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ExportFile = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportFileTB
            // 
            this.ExportFileTB.Location = new System.Drawing.Point(76, 14);
            this.ExportFileTB.Name = "ExportFileTB";
            this.ExportFileTB.Size = new System.Drawing.Size(181, 20);
            this.ExportFileTB.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(279, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(49, 322);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(208, 20);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // ImageFileLabel
            // 
            this.ImageFileLabel.AutoSize = true;
            this.ImageFileLabel.Location = new System.Drawing.Point(12, 17);
            this.ImageFileLabel.Name = "ImageFileLabel";
            this.ImageFileLabel.Size = new System.Drawing.Size(58, 13);
            this.ImageFileLabel.TabIndex = 4;
            this.ImageFileLabel.Text = "Image File:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 325);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(31, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Text:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // ExportFile
            // 
            this.ExportFile.Location = new System.Drawing.Point(279, 322);
            this.ExportFile.Name = "ExportFile";
            this.ExportFile.Size = new System.Drawing.Size(75, 23);
            this.ExportFile.TabIndex = 7;
            this.ExportFile.Text = "Export";
            this.ExportFile.UseVisualStyleBackColor = true;
            this.ExportFile.Click += new System.EventHandler(this.ExportFile_Click_1);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::FirstPass.Properties.Resources.NoImage;
            this.pictureBox8.Location = new System.Drawing.Point(14, 41);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(339, 275);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // StegExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 357);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ExportFile);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ImageFileLabel);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ExportFileTB);
            this.Name = "StegExport";
            this.Text = "StegExport";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExportFileTB;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label ImageFileLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button ExportFile;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}