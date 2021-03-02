﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class MasterForm : Form {
        public MasterForm() {
            InitializeComponent();
        }
        public void PerformRefresh() {
            dataGridView1.DataSource = FileOP.ReadFile();
        }
        private void CreateNewButton_Click(object sender, EventArgs e) {
            DisplayNewFileWarning();

        }

        private void DisplayNewFileWarning() {
            string message = "Are you sure you wish to create a new password File?";
            string title = "Pass Keeper";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                FileOP.CreateFile();
                passwordOptions form = new passwordOptions();
                this.Hide();
                form.Show();
            }
        }


        private void CreateNewFileDropDown_Click(object sender, EventArgs e) {
            DisplayNewFileWarning();

        }

        private void OpenFileButton_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            FileOP.SelectFile();
            EnterPasswordForFile frm = new EnterPasswordForFile();
            frm.Show();
        }

        private void OpenFileDropDown_Click(object sender, EventArgs e) {
            FileOP.SelectFile();
            EnterPasswordForFile frm = new EnterPasswordForFile();
            frm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            FileOP.SaveFile();
        }

        //Lock button to Encrypt and close the currently opened file.
        private void LockButton_Click(object sender, EventArgs e) {
            //Encrypt the file with stored password
            Crypto.EncryptFile(FileOP.GetFile(), Crypto.mPassTemp);

            //If a Keyfile was used to open the file, use it to encrypt the file when locking
            if (FileOP.GetKeyFile().Length > 0) {

                //Encrypt the file with the KeyFile
                Crypto.EncryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(FileOP.GetKeyFile()));

                //Clear the keyFile from memory
                FileOP.ClearKeyFile();
            }

            //Clear the file from memory
            FileOP.ClearFile();
            this.Close();
        }


        private void MasterForm_Load(object sender, EventArgs e) {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e) {

        }


    }
}