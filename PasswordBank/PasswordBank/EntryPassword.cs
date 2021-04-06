using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class EntryPassword : Form {

        private MasterForm currentMasterform;
        public EntryPassword(MasterForm form) {
            InitializeComponent();
            currentMasterform = form;
        }

        private void entryPasswordTextBox_TextChanged(object sender, EventArgs e) {

            double passwordStrength = Password.CheckStrength(entryPasswordTextBox.Text);

            if (passwordStrength <= 4) {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Red;
                entryPasswordStrengthLabel.Text = "Password Strength: Very Weak";
                entryPasswordStrengthBar.Value = 0;
            }

            // If the password strength is more than 4, but no greater than 8 it is weak.
            else if (passwordStrength <= 8) {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Orange;
                entryPasswordStrengthLabel.Text = "Password Strength: Weak";
                entryPasswordStrengthBar.Value = 33;
            }

            // If the password strength is more than 8, but no greater than 12 it is average.
            else if (passwordStrength <= 12) {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Green;
                entryPasswordStrengthLabel.Text = "Password Strength: Average";
                entryPasswordStrengthBar.Value = 66;
            }

            // If the password strength is more than 12 it is strong.
            else {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Blue;
                entryPasswordStrengthLabel.Text = "Password Strength: Strong";
                entryPasswordStrengthBar.Value = 100;
            }
        }

        private void entryPasswordOkButton_Click(object sender, EventArgs e) {
            if ((entryPasswordTextBox.Text == confirmEntryPasswordTextBox.Text) && String.IsNullOrEmpty(entryPasswordTextBox.Text) == false && String.IsNullOrEmpty(confirmEntryPasswordTextBox.Text) == false) {
                currentMasterform.EntryVariablesPasswordTextBox.Text = entryPasswordTextBox.Text;
                try {
                    DateTime expirationDate = Convert.ToDateTime(currentMasterform.EntryVariablesExpirationTextBox.Text);
                    expirationDate = expirationDate.AddMonths(1);
                    currentMasterform.EntryVariablesExpirationTextBox.Text = expirationDate.ToShortDateString();
                }
                catch (System.FormatException) {

                }
                this.Close();
            }
            else {
                MessageBox.Show("The passwords do match or one of the text boxes is empty, please enter your password again.", "Password Error", MessageBoxButtons.OK);
            }
        }

        private void entryPasswordCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void entryPasswordRandomizeButton_Click(object sender, EventArgs e) {
            MasterPasswordGenForm randomPasswordFrom = new MasterPasswordGenForm(this);
            randomPasswordFrom.ShowDialog();
        }
    }
}
