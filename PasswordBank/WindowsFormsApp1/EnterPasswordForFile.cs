using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class EnterPasswordForFile : Form {
        public EnterPasswordForFile() {
            InitializeComponent();
        }
        public string DatabaseFileName { get; set; }

        private void button1_Click(object sender, EventArgs e) {
            Crypto.DecryptFile(FileOP.GetFile(), passwordEntry.Text);
            Crypto.mPassTemp = passwordEntry.Text;
            //passwordEntry.Text.ToCharArray().ToList().ForEach(i => Crypto.mPassTemp.AppendChar(i));
        }
    }
}
