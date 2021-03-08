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
    public partial class MasterPasswordGenForm : Form {
        public MasterPasswordGenForm() {
            InitializeComponent();
            LowerCase.Enabled = false;
        }

        private void CloseButton_Click(object sender, EventArgs e) {

            int count = Convert.ToInt32(Math.Round(passSize.Value, 0));
            string pass = Password.randomizePassword(count, UpperCase.Checked, Digits.Checked, Special.Checked, Brackets.Checked);
            Console.WriteLine(pass);
            PasswordOptions frm = new PasswordOptions();
            frm.Show();
            frm.UpdateTextBox(pass);
            this.Hide();
        }

    }
}
