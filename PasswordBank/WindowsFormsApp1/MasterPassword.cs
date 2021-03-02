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

namespace WindowsFormsApp1 {
    public partial class passwordOptions : Form {
        public passwordOptions() {
            InitializeComponent();
        }
        public void UpdateTextBox(string pass) {

            PassEntry1.BeginInvoke((MethodInvoker)delegate {
                this.PassEntry1.Text = pass;
                this.PassEntry2.Text = pass;
            });
            //this.Refresh();
        }

        public string randomPass { get; set; }
        private void OkButton_Click (object sender, EventArgs e) {
            if ((PassEntry1.Text == PassEntry2.Text) && String.IsNullOrEmpty(PassEntry1.Text) == false && String.IsNullOrEmpty(PassEntry2.Text) == false) {

                //File is compressed before Encryption
                BankFile.Compress(FileOP.GetFile());
                
                //Encrypt the File with the entered password
                Crypto.EncryptFile(FileOP.GetFile(), PassEntry1.Text);

                // Creates a new print pop-up
                MasterPasswordPrintPopUp printPopUp = new MasterPasswordPrintPopUp(PassEntry1.Text);
                printPopUp.ShowDialog();

                this.Close();
                // Creates a new KeyFileOptionPopUp object to open the Key File Popup.
                /*KeyFileOptionPopUp keyFileOptionPopUp = new KeyFileOptionPopUp();
                keyFileOptionPopUp.Show();*/
            }
            else {
                string message = "Your passwords do not match or the boxes are blank. Please try entering them again";
                string title = "Pass Keeper";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                _ = MessageBox.Show(message, title, buttons);
            }



        }

        private void button3_Click(object sender, EventArgs e) {
            //this.Close();
            MasterForm frm = new MasterForm();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            MasterPasswordGenForm generatePasswordOptions = new MasterPasswordGenForm();
            generatePasswordOptions.Show();
            this.Hide();
        }

        private void passwordStrengthLabel_Click(object sender, EventArgs e) {
            
        }

        private void PassEntry1_TextChanged(object sender, EventArgs e) {
            
            // This code will run everytime the text changes in the password box.

            // creates passwordStrength variable to hold the current strenght of the password.
            double passwordStrength = Password.checkStrength(PassEntry1.Text);

            // If the password strength is 4 or less it is very weak.
            if(passwordStrength <= 4) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Red;
                passwordStrengthLabel.Text = "Password Strength: Very Weak";
            }

            // If the password strength is more than 4, but no greater than 8 it is weak.
            else if (passwordStrength <= 8) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Orange;
                passwordStrengthLabel.Text = "Password Strength: Weak";
            }

            // If the password strength is more than 8, but no greater than 12 it is average.
            else if (passwordStrength <= 12) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Green;
                passwordStrengthLabel.Text = "Password Strength: Average";
            }

            // If the password strength is more than 12 it is strong.
            else {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Blue;
                passwordStrengthLabel.Text = "Password Strength: Strong";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            MasterForm form = new MasterForm();
            this.Hide();
            form.Show();
        }

        private void PassEntry2_TextChanged(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void KeyFileCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (KeyFileCheckBox.Checked) {
                FileOP.SelectKeyFile();
                Crypto.EncryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(FileOP.GetKeyFile()));
                KeyFileLocationText.Text = FileOP.GetKeyFile();
                FileOP.ClearKeyFile();
            }
            else {
                FileOP.ClearKeyFile();
                KeyFileLocationText.Text = FileOP.GetKeyFile();
            }
        }
    }
}
