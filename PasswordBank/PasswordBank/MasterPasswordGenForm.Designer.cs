
namespace FirstPass {
    partial class MasterPasswordGenForm {
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
            this.UpperCase = new System.Windows.Forms.CheckBox();
            this.LowerCase = new System.Windows.Forms.CheckBox();
            this.Digits = new System.Windows.Forms.CheckBox();
            this.Special = new System.Windows.Forms.CheckBox();
            this.Brackets = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.passSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the password generation options you would like to include:";
            // 
            // UpperCase
            // 
            this.UpperCase.AccessibleName = "UpperCase";
            this.UpperCase.AutoSize = true;
            this.UpperCase.Location = new System.Drawing.Point(19, 123);
            this.UpperCase.Name = "UpperCase";
            this.UpperCase.Size = new System.Drawing.Size(139, 17);
            this.UpperCase.TabIndex = 1;
            this.UpperCase.Text = "Upper Case (A, B, C, ...)";
            this.UpperCase.UseVisualStyleBackColor = true;
            // 
            // LowerCase
            // 
            this.LowerCase.AutoSize = true;
            this.LowerCase.Checked = true;
            this.LowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCase.Location = new System.Drawing.Point(19, 98);
            this.LowerCase.Name = "LowerCase";
            this.LowerCase.Size = new System.Drawing.Size(136, 17);
            this.LowerCase.TabIndex = 2;
            this.LowerCase.Text = "Lower Case (a, b, c, ...)";
            this.LowerCase.UseVisualStyleBackColor = true;
            // 
            // Digits
            // 
            this.Digits.AccessibleName = "Digits";
            this.Digits.AutoSize = true;
            this.Digits.Location = new System.Drawing.Point(19, 146);
            this.Digits.Name = "Digits";
            this.Digits.Size = new System.Drawing.Size(112, 17);
            this.Digits.TabIndex = 3;
            this.Digits.Text = "Digits (0,1,2,3, ....)";
            this.Digits.UseVisualStyleBackColor = true;
            // 
            // Special
            // 
            this.Special.AccessibleName = "Special";
            this.Special.AutoSize = true;
            this.Special.Location = new System.Drawing.Point(161, 98);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(125, 17);
            this.Special.TabIndex = 7;
            this.Special.Text = "Special (!, +, ?, *, ... )";
            this.Special.UseVisualStyleBackColor = true;
            // 
            // Brackets
            // 
            this.Brackets.AccessibleName = "Brackets";
            this.Brackets.AutoSize = true;
            this.Brackets.Location = new System.Drawing.Point(164, 123);
            this.Brackets.Name = "Brackets";
            this.Brackets.Size = new System.Drawing.Size(127, 17);
            this.Brackets.TabIndex = 8;
            this.Brackets.Text = "Brackets ([, ], {, }, (, ))";
            this.Brackets.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleName = "CloseButton";
            this.CloseButton.Location = new System.Drawing.Point(247, 272);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter in the length of the password";
            // 
            // passSize
            // 
            this.passSize.Location = new System.Drawing.Point(208, 55);
            this.passSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.passSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passSize.Name = "passSize";
            this.passSize.Size = new System.Drawing.Size(68, 20);
            this.passSize.TabIndex = 12;
            this.passSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MasterPasswordGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 307);
            this.Controls.Add(this.passSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Brackets);
            this.Controls.Add(this.Special);
            this.Controls.Add(this.Digits);
            this.Controls.Add(this.LowerCase);
            this.Controls.Add(this.UpperCase);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MasterPasswordGenForm";
            this.Text = "MasterPasswordGenForm";
            ((System.ComponentModel.ISupportInitialize)(this.passSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox UpperCase;
        private System.Windows.Forms.CheckBox LowerCase;
        private System.Windows.Forms.CheckBox Digits;
        private System.Windows.Forms.CheckBox Special;
        private System.Windows.Forms.CheckBox Brackets;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown passSize;
    }
}