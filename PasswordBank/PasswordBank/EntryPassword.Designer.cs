
namespace FirstPass {
    partial class EntryPassword {
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
            this.entryPasswordStrengthBar = new System.Windows.Forms.ProgressBar();
            this.entryPasswordStrengthLabel = new System.Windows.Forms.Label();
            this.entryPasswordRandomizeButton = new System.Windows.Forms.Button();
            this.confirmEntryPasswordLabel = new System.Windows.Forms.Label();
            this.confirmEntryPasswordTextBox = new System.Windows.Forms.TextBox();
            this.entryPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EntryPasswordLabel = new System.Windows.Forms.Label();
            this.entryPasswordCancelButton = new System.Windows.Forms.Button();
            this.entryPasswordOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryPasswordStrengthBar
            // 
            this.entryPasswordStrengthBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryPasswordStrengthBar.Location = new System.Drawing.Point(283, 74);
            this.entryPasswordStrengthBar.Margin = new System.Windows.Forms.Padding(2);
            this.entryPasswordStrengthBar.Name = "entryPasswordStrengthBar";
            this.entryPasswordStrengthBar.Size = new System.Drawing.Size(89, 15);
            this.entryPasswordStrengthBar.TabIndex = 20;
            // 
            // entryPasswordStrengthLabel
            // 
            this.entryPasswordStrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryPasswordStrengthLabel.Location = new System.Drawing.Point(33, 74);
            this.entryPasswordStrengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entryPasswordStrengthLabel.Name = "entryPasswordStrengthLabel";
            this.entryPasswordStrengthLabel.Size = new System.Drawing.Size(245, 13);
            this.entryPasswordStrengthLabel.TabIndex = 19;
            this.entryPasswordStrengthLabel.Text = "Password Strength: ";
            this.entryPasswordStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // entryPasswordRandomizeButton
            // 
            this.entryPasswordRandomizeButton.AccessibleName = "EntryPasswordRandomizeButton";
            this.entryPasswordRandomizeButton.Location = new System.Drawing.Point(395, 36);
            this.entryPasswordRandomizeButton.Name = "entryPasswordRandomizeButton";
            this.entryPasswordRandomizeButton.Size = new System.Drawing.Size(75, 23);
            this.entryPasswordRandomizeButton.TabIndex = 18;
            this.entryPasswordRandomizeButton.Text = "Randomize";
            this.entryPasswordRandomizeButton.UseVisualStyleBackColor = true;
            this.entryPasswordRandomizeButton.Click += new System.EventHandler(this.entryPasswordRandomizeButton_Click);
            // 
            // confirmEntryPasswordLabel
            // 
            this.confirmEntryPasswordLabel.AutoSize = true;
            this.confirmEntryPasswordLabel.Location = new System.Drawing.Point(27, 50);
            this.confirmEntryPasswordLabel.Name = "confirmEntryPasswordLabel";
            this.confirmEntryPasswordLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmEntryPasswordLabel.TabIndex = 17;
            this.confirmEntryPasswordLabel.Text = "Confirm Password:";
            // 
            // confirmEntryPasswordTextBox
            // 
            this.confirmEntryPasswordTextBox.AccessibleName = "confirmEntryPasswordTextBox";
            this.confirmEntryPasswordTextBox.Location = new System.Drawing.Point(127, 47);
            this.confirmEntryPasswordTextBox.MaxLength = 20;
            this.confirmEntryPasswordTextBox.Name = "confirmEntryPasswordTextBox";
            this.confirmEntryPasswordTextBox.PasswordChar = '*';
            this.confirmEntryPasswordTextBox.Size = new System.Drawing.Size(247, 20);
            this.confirmEntryPasswordTextBox.TabIndex = 16;
            // 
            // entryPasswordTextBox
            // 
            this.entryPasswordTextBox.AccessibleName = "entryPasswordTextBox";
            this.entryPasswordTextBox.Location = new System.Drawing.Point(127, 21);
            this.entryPasswordTextBox.MaxLength = 20;
            this.entryPasswordTextBox.Name = "entryPasswordTextBox";
            this.entryPasswordTextBox.PasswordChar = '*';
            this.entryPasswordTextBox.Size = new System.Drawing.Size(247, 20);
            this.entryPasswordTextBox.TabIndex = 15;
            this.entryPasswordTextBox.TextChanged += new System.EventHandler(this.entryPasswordTextBox_TextChanged);
            // 
            // EntryPasswordLabel
            // 
            this.EntryPasswordLabel.AutoSize = true;
            this.EntryPasswordLabel.Location = new System.Drawing.Point(33, 24);
            this.EntryPasswordLabel.Name = "EntryPasswordLabel";
            this.EntryPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.EntryPasswordLabel.TabIndex = 14;
            this.EntryPasswordLabel.Text = "Password:";
            // 
            // entryPasswordCancelButton
            // 
            this.entryPasswordCancelButton.Location = new System.Drawing.Point(46, 100);
            this.entryPasswordCancelButton.Name = "entryPasswordCancelButton";
            this.entryPasswordCancelButton.Size = new System.Drawing.Size(75, 23);
            this.entryPasswordCancelButton.TabIndex = 22;
            this.entryPasswordCancelButton.Text = "Cancel";
            this.entryPasswordCancelButton.UseVisualStyleBackColor = true;
            this.entryPasswordCancelButton.Click += new System.EventHandler(this.entryPasswordCancelButton_Click);
            // 
            // entryPasswordOkButton
            // 
            this.entryPasswordOkButton.AccessibleName = "entryPasswordOkButton";
            this.entryPasswordOkButton.Location = new System.Drawing.Point(415, 100);
            this.entryPasswordOkButton.Name = "entryPasswordOkButton";
            this.entryPasswordOkButton.Size = new System.Drawing.Size(75, 23);
            this.entryPasswordOkButton.TabIndex = 21;
            this.entryPasswordOkButton.Text = "Ok";
            this.entryPasswordOkButton.UseVisualStyleBackColor = true;
            this.entryPasswordOkButton.Click += new System.EventHandler(this.entryPasswordOkButton_Click);
            // 
            // EntryPassword
            // 
            this.AccessibleName = "EntryPassword";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 132);
            this.Controls.Add(this.entryPasswordCancelButton);
            this.Controls.Add(this.entryPasswordOkButton);
            this.Controls.Add(this.entryPasswordStrengthBar);
            this.Controls.Add(this.entryPasswordStrengthLabel);
            this.Controls.Add(this.entryPasswordRandomizeButton);
            this.Controls.Add(this.confirmEntryPasswordLabel);
            this.Controls.Add(this.confirmEntryPasswordTextBox);
            this.Controls.Add(this.entryPasswordTextBox);
            this.Controls.Add(this.EntryPasswordLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EntryPassword";
            this.Text = "EntryPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar entryPasswordStrengthBar;
        private System.Windows.Forms.Label entryPasswordStrengthLabel;
        private System.Windows.Forms.Button entryPasswordRandomizeButton;
        private System.Windows.Forms.Label confirmEntryPasswordLabel;
        private System.Windows.Forms.Label EntryPasswordLabel;
        private System.Windows.Forms.Button entryPasswordCancelButton;
        private System.Windows.Forms.Button entryPasswordOkButton;
        public System.Windows.Forms.TextBox confirmEntryPasswordTextBox;
        public System.Windows.Forms.TextBox entryPasswordTextBox;
    }
}