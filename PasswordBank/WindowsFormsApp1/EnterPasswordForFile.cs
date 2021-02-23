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
    public partial class EnterPasswordForFile : Form {
        public EnterPasswordForFile() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            
            if (KeyfileLocation.TextLength > 0) {
                Crypto.DecryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(KeyfileLocation.Text));
            }
            Crypto.DecryptFile(FileOP.GetFile(), passwordEntry.Text);
            Crypto.mPassTemp = passwordEntry.Text;
            BankFile.Decompress(FileOP.GetFile());
            MasterForm frm = new MasterForm();
            frm.Show();
            frm.PerformRefresh();
            this.Close();
        }

        private void FindKeyFile_Click(object sender, EventArgs e) {
            FileOP.SelectKeyFile();
            KeyfileLocation.Text = FileOP.GetKeyFile();
        }
    }
}
