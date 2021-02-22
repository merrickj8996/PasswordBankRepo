
namespace WindowsFormsApp1 {
    partial class MasterPasswordPrintPopUp {
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
            this.printButton = new System.Windows.Forms.Button();
            this.masterPasswordPrintDialog = new System.Windows.Forms.PrintDialog();
            this.printText = new System.Windows.Forms.Label();
            this.noPrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(60, 53);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Yes";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // masterPasswordPrintDialog
            // 
            this.masterPasswordPrintDialog.AllowSomePages = true;
            this.masterPasswordPrintDialog.UseEXDialog = true;
            // 
            // printText
            // 
            this.printText.AutoSize = true;
            this.printText.Location = new System.Drawing.Point(12, 9);
            this.printText.Name = "printText";
            this.printText.Size = new System.Drawing.Size(318, 13);
            this.printText.TabIndex = 1;
            this.printText.Text = "Would you like to print out a document containing your password?\r\n";
            // 
            // noPrintButton
            // 
            this.noPrintButton.Location = new System.Drawing.Point(194, 53);
            this.noPrintButton.Name = "noPrintButton";
            this.noPrintButton.Size = new System.Drawing.Size(75, 23);
            this.noPrintButton.TabIndex = 2;
            this.noPrintButton.Text = "No";
            this.noPrintButton.UseVisualStyleBackColor = true;
            this.noPrintButton.Click += new System.EventHandler(this.noPrintButton_Click);
            // 
            // MasterPasswordPrintPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 111);
            this.Controls.Add(this.noPrintButton);
            this.Controls.Add(this.printText);
            this.Controls.Add(this.printButton);
            this.Name = "MasterPasswordPrintPopUp";
            this.Text = "MasterPasswordPrintPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PrintDialog masterPasswordPrintDialog;
        private System.Windows.Forms.Label printText;
        private System.Windows.Forms.Button noPrintButton;
    }
}