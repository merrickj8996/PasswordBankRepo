using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class PasswordOptions : Form {

        public MasterForm TheParent;

        public PasswordOptions() {
            InitializeComponent();
        }
        public void UpdateTextBox(string pass) {

            PassEntry1.BeginInvoke((MethodInvoker)delegate {
                this.PassEntry1.Text = pass;
                this.PassEntry2.Text = pass;
            });
            //this.Refresh();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            if ((PassEntry1.Text == PassEntry2.Text) && String.IsNullOrEmpty(PassEntry1.Text) == false && String.IsNullOrEmpty(PassEntry2.Text) == false) {
                if (KeyFileCheckBox.Checked) {
                    if (FileOP.GetKeyFile() != "" && FileOP.GetKeyFile() != null && File.Exists(FileOP.GetKeyFile())) {
                        KeyFileLocationText.Text = FileOP.GetKeyFile();
                        Crypto.mPassTemp = PassEntry1.Text;
                        MasterPasswordPrintPopUp printPopUp = new MasterPasswordPrintPopUp(PassEntry1.Text);
                        printPopUp.ShowDialog();
                        TheParent.PerformRefresh(true);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Your key file is invalid. Please reselect your keyfile.", "File Error", MessageBoxButtons.OK);
                    }
                }
                else {
                    Crypto.mPassTemp = PassEntry1.Text;
                    MasterPasswordPrintPopUp printPopUp = new MasterPasswordPrintPopUp(PassEntry1.Text);
                    printPopUp.ShowDialog();
                    TheParent.PerformRefresh(true);
                    this.Close();
                }
            }
            else {
                string message = "Your passwords do not match or the boxes are blank. Please try entering them again";
                string title = "Pass Keeper";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                _ = MessageBox.Show(message, title, buttons);
            }
        }

        private void RandomGen_Click(object sender, EventArgs e) {
            MasterPasswordGenForm generatePasswordOptions = new MasterPasswordGenForm();
            generatePasswordOptions.Show();
            this.Hide();
        }

        private void PasswordStrengthLabel_Click(object sender, EventArgs e) {

        }

        private void PassEntry1_TextChanged(object sender, EventArgs e) {

            // This code will run everytime the text changes in the password box.

            // creates passwordStrength variable to hold the current strenght of the password.
            double passwordStrength = Password.CheckStrength(PassEntry1.Text);

            // If the password strength is 4 or less it is very weak.
            if (passwordStrength <= 4) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Red;
                passwordStrengthLabel.Text = "Password Strength: Very Weak";
                PasswordStrengthBar.Value = 0;
            }

            // If the password strength is more than 4, but no greater than 8 it is weak.
            else if (passwordStrength <= 8) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Orange;
                passwordStrengthLabel.Text = "Password Strength: Weak";
                PasswordStrengthBar.Value = 33;
            }

            // If the password strength is more than 8, but no greater than 12 it is average.
            else if (passwordStrength <= 12) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Green;
                passwordStrengthLabel.Text = "Password Strength: Average";
                PasswordStrengthBar.Value = 66;
            }

            // If the password strength is more than 12 it is strong.
            else {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Blue;
                passwordStrengthLabel.Text = "Password Strength: Strong";
                PasswordStrengthBar.Value = 100;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {

            this.Hide();

        }

        private void FindKeyFile_Click(object sender, EventArgs e) {
            FileOP.SelectKeyFile();
            KeyFileLocationText.Text = FileOP.GetKeyFile();
        }
    }
}
