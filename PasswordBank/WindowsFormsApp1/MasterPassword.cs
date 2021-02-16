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
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class passwordOptions : Form {
        public passwordOptions() {
            InitializeComponent();
        }
        public string databasefileName { get; set; }
        private void OkButton_Click (object sender, EventArgs e) {
            //format the database name to be a text file
            Console.WriteLine(databasefileName + ".txt");
            if ((PassEntry1.Text == PassEntry2.Text) && String.IsNullOrEmpty(PassEntry1.Text) == false && String.IsNullOrEmpty(PassEntry2.Text) == false) {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(@"..\..\..\PasswordBankTests\TestResources\Sha256TestSources\", databasefileName + ".txt"), true)) {
                    file.WriteLine(Password.HashSHA256(PassEntry1.Text));
                }
                MasterForm frm = new MasterForm();
                this.Close();
                frm.Show();
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

        private void CancelButton_Click(object sender, EventArgs e) {
            MasterForm form = new MasterForm();
            this.Hide();
            form.Show();
        }
    }
}
