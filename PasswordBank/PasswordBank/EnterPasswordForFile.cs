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
            InitializeControlList();
        }

        public List<Control> enterPasswordForFileTextBoxes;
        public List<Control> enterPasswordForFileLabels;
        public List<Control> enterPasswordForFileButtons;
        public bool enterPasswordForFileDarkThemeEnabled = false;
        public bool enterPasswordForFileSmallTextSizeEnabled = false;
        public bool enterPasswordForFileDefaultTextSizeEnabled = false;
        public bool enterPasswordForFileLargeTextSizeEnabled = false;

        /// <summary>
        /// Takes all the components and groups them together in a List<Control>. This is done so themes can be added using loops instead of each component at a time.
        /// </summary>
        private void InitializeControlList() {
            enterPasswordForFileTextBoxes = new List<Control>();
            enterPasswordForFileLabels = new List<Control>();
            enterPasswordForFileButtons = new List<Control>();

            // Stores all texboxes
            enterPasswordForFileTextBoxes.Add(passwordEntry);
            enterPasswordForFileTextBoxes.Add(KeyfileLocation);

            // Stores all labels
            enterPasswordForFileLabels.Add(label1);
            enterPasswordForFileLabels.Add(label2);
            enterPasswordForFileLabels.Add(label3);
            enterPasswordForFileLabels.Add(Keyfile);

            // Stores all buttons
            enterPasswordForFileButtons.Add(FindKeyFile);
            enterPasswordForFileButtons.Add(OkButton);
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

        private void KeyfileLocation_DragOver(object sender, DragEventArgs e) {

            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0) {
                KeyfileLocation.Text = files[0];
                FileOP.LoadKeyFile(KeyfileLocation.Text);
            }
        }
    }
}
