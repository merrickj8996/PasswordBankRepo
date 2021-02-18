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
        public string databasefileName { get; set; }

        private void button1_Click(object sender, EventArgs e) {
            Console.WriteLine(databasefileName);
        }
    }
}
