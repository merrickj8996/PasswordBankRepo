
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
            this.KeyFileYesRadioButton = new System.Windows.Forms.RadioButton();
            this.KeyFileNoRadioButton = new System.Windows.Forms.RadioButton();
            this.KeyFileOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyPassOptionLabel
            // 
            this.KeyPassOptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPassOptionLabel.AutoSize = true;
            this.KeyPassOptionLabel.Location = new System.Drawing.Point(12, 9);
            this.KeyPassOptionLabel.Name = "KeyPassOptionLabel";
            this.KeyPassOptionLabel.Size = new System.Drawing.Size(354, 20);
            this.KeyPassOptionLabel.TabIndex = 0;
            this.KeyPassOptionLabel.Text = "Would you like to add a key file for more security?";
            this.KeyPassOptionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // KeyFileYesRadioButton
            // 
            this.KeyFileYesRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyFileYesRadioButton.AutoSize = true;
            this.KeyFileYesRadioButton.Location = new System.Drawing.Point(84, 51);
            this.KeyFileYesRadioButton.Name = "KeyFileYesRadioButton";
            this.KeyFileYesRadioButton.Size = new System.Drawing.Size(62, 24);
            this.KeyFileYesRadioButton.TabIndex = 1;
            this.KeyFileYesRadioButton.TabStop = true;
            this.KeyFileYesRadioButton.Text = "Yes";
            this.KeyFileYesRadioButton.UseVisualStyleBackColor = true;
            this.KeyFileYesRadioButton.CheckedChanged += new System.EventHandler(this.KeyFileYesRadioButton_CheckedChanged);
            // 
            // KeyFileNoRadioButton
            // 
            this.KeyFileNoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // 
            // KeyFileOptionPopUp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 144);
            this.Controls.Add(this.KeyFileOkButton);
            this.Controls.Add(this.KeyFileNoRadioButton);
            this.Controls.Add(this.KeyFileYesRadioButton);
            this.Controls.Add(this.KeyPassOptionLabel);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "KeyFileOptionPopUp";
            this.Text = "Key File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyPassOptionLabel;
        private System.Windows.Forms.RadioButton KeyFileYesRadioButton;
        private System.Windows.Forms.RadioButton KeyFileNoRadioButton;
        private System.Windows.Forms.Button KeyFileOkButton;
    }
}