
namespace WindowsFormsApp1 {
    partial class KeyFileOptionPopUp {
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
            this.KeyPassOptionLabel = new System.Windows.Forms.Label();
            this.KeyFileYesButton = new System.Windows.Forms.Button();
            this.KeyFileNoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyPassOptionLabel
            // 
            this.KeyPassOptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPassOptionLabel.AutoSize = true;
            this.KeyPassOptionLabel.Location = new System.Drawing.Point(8, 6);
            this.KeyPassOptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KeyPassOptionLabel.Name = "KeyPassOptionLabel";
            this.KeyPassOptionLabel.Size = new System.Drawing.Size(241, 13);
            this.KeyPassOptionLabel.TabIndex = 0;
            this.KeyPassOptionLabel.Text = "Would you like to add a key file for more security?";
            this.KeyPassOptionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // KeyFileYesButton
            // 
            this.KeyFileYesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyFileYesButton.AutoSize = true;
            this.KeyFileYesButton.Location = new System.Drawing.Point(49, 66);
            this.KeyFileYesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KeyFileYesButton.Name = "KeyFileYesButton";
            this.KeyFileYesButton.Size = new System.Drawing.Size(50, 23);
            this.KeyFileYesButton.TabIndex = 3;
            this.KeyFileYesButton.Text = "Yes";
            this.KeyFileYesButton.UseVisualStyleBackColor = true;
            this.KeyFileYesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyFileNoButton
            // 
            this.KeyFileNoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.KeyFileNoRadioButton.AutoSize = true;
            this.KeyFileNoRadioButton.Location = new System.Drawing.Point(232, 51);
            this.KeyFileNoRadioButton.Name = "KeyFileNoRadioButton";
            this.KeyFileNoRadioButton.Size = new System.Drawing.Size(54, 24);
            this.KeyFileNoRadioButton.TabIndex = 2;
            this.KeyFileNoRadioButton.TabStop = true;
            this.KeyFileNoRadioButton.Text = "No";
            this.KeyFileNoRadioButton.UseVisualStyleBackColor = true;
            this.KeyFileNoRadioButton.CheckedChanged += new System.EventHandler(this.KeyFileNoRadioButton_CheckedChanged);
            // 
            // KeyFileOkButton
            // 
            this.KeyFileOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyFileOkButton.AutoSize = true;
            this.KeyFileOkButton.Location = new System.Drawing.Point(148, 90);
            this.KeyFileOkButton.Name = "KeyFileOkButton";
            this.KeyFileOkButton.Size = new System.Drawing.Size(75, 30);
            this.KeyFileOkButton.TabIndex = 3;
            this.KeyFileOkButton.Text = "Ok";
            this.KeyFileOkButton.UseVisualStyleBackColor = true;
            this.KeyFileOkButton.Click += new System.EventHandler(this.button1_Click);
=======
            this.KeyFileNoButton.AutoSize = true;
            this.KeyFileNoButton.Location = new System.Drawing.Point(161, 66);
            this.KeyFileNoButton.Margin = new System.Windows.Forms.Padding(2);
            this.KeyFileNoButton.Name = "KeyFileNoButton";
            this.KeyFileNoButton.Size = new System.Drawing.Size(50, 23);
            this.KeyFileNoButton.TabIndex = 4;
            this.KeyFileNoButton.Text = "No";
            this.KeyFileNoButton.UseVisualStyleBackColor = true;
            this.KeyFileNoButton.Click += new System.EventHandler(this.KeyFileNoButton_Click);
>>>>>>> 09595ada9247cb9620267842edff28eae17eec13
            // 
            // KeyFileOptionPopUp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 105);
            this.Controls.Add(this.KeyFileNoButton);
            this.Controls.Add(this.KeyFileYesButton);
            this.Controls.Add(this.KeyPassOptionLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(272, 144);
            this.MinimumSize = new System.Drawing.Size(272, 144);
            this.Name = "KeyFileOptionPopUp";
            this.Text = "Key File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyPassOptionLabel;
        private System.Windows.Forms.Button KeyFileYesButton;
        private System.Windows.Forms.Button KeyFileNoButton;
    }
}