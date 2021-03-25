using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class EnterPasswordForFile : Form {
        bool success = false;
        public MasterForm TheParent;
        public EnterPasswordForFile() {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e) {

            if (KeyfileLocation.TextLength > 0) {
                if (!Crypto.DecryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(KeyfileLocation.Text))) {
                    MessageBox.Show("Inncorrect Credentials. Please Try Again.", "Access Denied", MessageBoxButtons.OK);
                    KeyfileLocation.ResetText();
                }
                else if (!Crypto.DecryptFile(FileOP.GetFile(), passwordEntry.Text)) {
                    Crypto.EncryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(KeyfileLocation.Text));
                    MessageBox.Show("Inncorrect Credentials. Please Try Again.", "Access Denied", MessageBoxButtons.OK);
                    KeyfileLocation.ResetText();
                }
                else {
                    FileOP.LoadKeyFile(KeyfileLocation.Text);
                    Crypto.mPassTemp = passwordEntry.Text;
                    Compressor.Decompress(FileOP.GetFile());
                    TheParent.PerformRefresh(true);
                    success = true;
                    this.Close();
                }

            }
            else if (!Crypto.DecryptFile(FileOP.GetFile(), passwordEntry.Text)) {
                MessageBox.Show("Inncorrect Credentials. Please Try Again.", "Access Denied", MessageBoxButtons.OK);
                KeyfileLocation.ResetText();
            }
            else {
                Crypto.mPassTemp = passwordEntry.Text;
                Compressor.Decompress(FileOP.GetFile());
                TheParent.PerformRefresh(true);
                success = true;
                this.Close();
            }

        }

        private void FindKeyFile_Click(object sender, EventArgs e) {
            if (FileOP.SelectKeyFile()) {
                KeyfileLocation.Text = FileOP.GetKeyFile();
            }
        }

        private void EnterPasswordForFile_FormClosing(object sender, FormClosingEventArgs e) {
            if (!success) {
                FileOP.ClearFile();
                FileOP.ClearKeyFile();
            } else {
                success = false;
            }
        }
    }
}
