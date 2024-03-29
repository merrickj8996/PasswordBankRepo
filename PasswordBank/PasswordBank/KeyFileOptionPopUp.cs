﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class KeyFileOptionPopUp : Form {
        public KeyFileOptionPopUp() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void KeyFileYesRadioButton_CheckedChanged(object sender, EventArgs e) {

        }

        private void KeyFileNoRadioButton_CheckedChanged(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            FileOP.SelectKeyFile();
            Crypto.EncryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(FileOP.GetKeyFile()));
            FileOP.ClearKeyFile();
            MasterForm frm = new MasterForm();
            frm.Show();
            frm.PerformRefresh();
            this.Close();
        }

        private void KeyFileNoButton_Click(object sender, EventArgs e) {
            MasterForm frm = new MasterForm();
            frm.Show();
            frm.PerformRefresh();
            this.Close();
        }
    }
}
