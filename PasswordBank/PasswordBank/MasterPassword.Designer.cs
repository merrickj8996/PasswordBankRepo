
namespace FirstPass {
    partial class PasswordOptions {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassEntry1 = new System.Windows.Forms.TextBox();
            this.PassEntry2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.passwordStrengthLabel = new System.Windows.Forms.Label();
            this.KeyFileCheckBox = new System.Windows.Forms.CheckBox();
            this.KeyFileLocationText = new System.Windows.Forms.TextBox();
            this.PasswordStrengthBar = new System.Windows.Forms.ProgressBar();
            this.FindKeyFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter in a password for this file.\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password for file:";
            // 
            // PassEntry1
            // 
            this.PassEntry1.AccessibleName = "PassEntry1";
            this.PassEntry1.Location = new System.Drawing.Point(113, 60);
            this.PassEntry1.MaxLength = 20;
            this.PassEntry1.Name = "PassEntry1";
            this.PassEntry1.PasswordChar = '*';
            this.PassEntry1.Size = new System.Drawing.Size(247, 20);
            this.PassEntry1.TabIndex = 2;
            this.PassEntry1.TextChanged += new System.EventHandler(this.PassEntry1_TextChanged);
            // 
            // PassEntry2
            // 
            this.PassEntry2.AccessibleName = "PassEntry2";
            this.PassEntry2.Location = new System.Drawing.Point(113, 86);
            this.PassEntry2.MaxLength = 20;
            this.PassEntry2.Name = "PassEntry2";
            this.PassEntry2.PasswordChar = '*';
            this.PassEntry2.Size = new System.Drawing.Size(247, 20);
            this.PassEntry2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "If you forget the name of this password you will not be able to get into the file" +
    ".";
            // 
            // OkButton
            // 
            this.OkButton.AccessibleName = "Ok";
            this.OkButton.Location = new System.Drawing.Point(381, 316);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 316);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordStrengthLabel.Location = new System.Drawing.Point(20, 113);
            this.passwordStrengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(245, 13);
            this.passwordStrengthLabel.TabIndex = 10;
            this.passwordStrengthLabel.Text = "Password Strength: ";
            this.passwordStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordStrengthLabel.Click += new System.EventHandler(this.PasswordStrengthLabel_Click);
            // 
            // KeyFileCheckBox
            // 
            this.KeyFileCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyFileCheckBox.AutoSize = true;
            this.KeyFileCheckBox.Location = new System.Drawing.Point(136, 176);
            this.KeyFileCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.KeyFileCheckBox.Name = "KeyFileCheckBox";
            this.KeyFileCheckBox.Size = new System.Drawing.Size(63, 17);
            this.KeyFileCheckBox.TabIndex = 11;
            this.KeyFileCheckBox.Text = "Key File";
            this.KeyFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // KeyFileLocationText
            // 
            this.KeyFileLocationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyFileLocationText.Location = new System.Drawing.Point(203, 174);
            this.KeyFileLocationText.Margin = new System.Windows.Forms.Padding(2);
            this.KeyFileLocationText.Name = "KeyFileLocationText";
            this.KeyFileLocationText.ReadOnly = true;
            this.KeyFileLocationText.Size = new System.Drawing.Size(157, 20);
            this.KeyFileLocationText.TabIndex = 12;
            // 
            // PasswordStrengthBar
            // 
            this.PasswordStrengthBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordStrengthBar.Location = new System.Drawing.Point(269, 113);
            this.PasswordStrengthBar.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordStrengthBar.Name = "PasswordStrengthBar";
            this.PasswordStrengthBar.Size = new System.Drawing.Size(89, 15);
            this.PasswordStrengthBar.TabIndex = 13;
            // 
            // FindKeyFile
            // 
            this.FindKeyFile.Location = new System.Drawing.Point(381, 172);
            this.FindKeyFile.Name = "FindKeyFile";
            this.FindKeyFile.Size = new System.Drawing.Size(75, 23);
            this.FindKeyFile.TabIndex = 14;
            this.FindKeyFile.Text = "Search";
            this.FindKeyFile.UseVisualStyleBackColor = true;
            this.FindKeyFile.Click += new System.EventHandler(this.FindKeyFile_Click);
            // 
            // PasswordOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 351);
            this.Controls.Add(this.FindKeyFile);
            this.Controls.Add(this.PasswordStrengthBar);
            this.Controls.Add(this.KeyFileLocationText);
            this.Controls.Add(this.KeyFileCheckBox);
            this.Controls.Add(this.passwordStrengthLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassEntry2);
            this.Controls.Add(this.PassEntry1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PasswordOptions";
            this.Text = "passwordOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassEntry1;
        private System.Windows.Forms.TextBox PassEntry2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label passwordStrengthLabel;
        private System.Windows.Forms.CheckBox KeyFileCheckBox;
        private System.Windows.Forms.TextBox KeyFileLocationText;
        private System.Windows.Forms.ProgressBar PasswordStrengthBar;
        private System.Windows.Forms.Button FindKeyFile;
    }
}