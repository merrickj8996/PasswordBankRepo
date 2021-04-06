
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
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageFileLabel
            // 
            this.ImageFileLabel.AutoSize = true;
            this.ImageFileLabel.Location = new System.Drawing.Point(12, 9);
            this.ImageFileLabel.Name = "ImageFileLabel";
            this.ImageFileLabel.Size = new System.Drawing.Size(58, 13);
            this.ImageFileLabel.TabIndex = 7;
            this.ImageFileLabel.Text = "Image File:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(279, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ExportFileTB
            // 
            this.ExportFileTB.Location = new System.Drawing.Point(91, 6);
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
            this.ImportFile.Click += new System.EventHandler(this.ImportFile_Click_1);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::FirstPass.Properties.Resources.NoImage;
            this.pictureBox8.Location = new System.Drawing.Point(15, 33);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(339, 282);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // StegImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 356);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ImportFile);
            this.Controls.Add(this.ImageFileLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ExportFileTB);
            this.Name = "StegImport";
            this.Text = "StegImport";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImageFileLabel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox ExportFileTB;
        private System.Windows.Forms.Button ImportFile;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}