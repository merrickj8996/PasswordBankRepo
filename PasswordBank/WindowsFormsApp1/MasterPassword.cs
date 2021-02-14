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

        private static string computeSha256Hash(String data) {
            using (SHA256 sha256Hash = SHA256.Create()) {
                //compute the hash. store in byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if ((PassEntry1.Text == PassEntry2.Text) && PassEntry1 != null && PassEntry2 != null) {
                Stream myStream;
                SaveFileDialog save = new SaveFileDialog {
                    Filter = "Text File (.txt) |*.txt",
                    Title = "Save password for DB"
                };
                if (save.ShowDialog() == DialogResult.OK) {
                    if ((myStream = save.OpenFile()) != null) {
                        myStream.Close();
                    }
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(save.FileName, true)) {
                        file.WriteLine(computeSha256Hash(PassEntry1.Text));
                    }
                    this.Close();
                }
            }
            else {
                string message = "Your passwords do not match. Please try entering them again";
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
    }
}
