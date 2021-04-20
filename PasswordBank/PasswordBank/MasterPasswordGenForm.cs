using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class MasterPasswordGenForm : Form {

        private EntryPassword currentEntryPasswordform;
        public MasterPasswordGenForm(EntryPassword form) {
            InitializeComponent();
            InitializeControlList();
            LowerCase.Enabled = false;
            currentEntryPasswordform = form;
        }

        public MasterPasswordGenForm() {
            InitializeComponent();
            InitializeControlList();
            LowerCase.Enabled = false;
        }

        public List<Control> passwordGenLabels;
        public List<Control> passwordGenButtons;
        public bool passwordGenDarkThemeEnabled;
        public bool passwordGenDefaultTextSizeEnabled;
        public bool passwordGenSmallTextSizeEnabled;
        public bool passwordGenLargeTextSizeEnabled;

        /// <summary>
        /// Takes all the components and groups them together in a List<Control>. This is done so themes can be added using loops instead of each component at a time.
        /// </summary>
        private void InitializeControlList() {
            passwordGenLabels = new List<Control>();
            passwordGenButtons = new List<Control>();

            // Stores all labels
            passwordGenLabels.Add(label1);
            passwordGenLabels.Add(label2);

            // Stores all buttons
            passwordGenButtons.Add(passSize);
            passwordGenButtons.Add(LowerCase);
            passwordGenButtons.Add(UpperCase);
            passwordGenButtons.Add(Digits);
            passwordGenButtons.Add(Special);
            passwordGenButtons.Add(Brackets);
            passwordGenButtons.Add(CloseButton);
        }

        private void CloseButton_Click(object sender, EventArgs e) {

            int count = Convert.ToInt32(Math.Round(passSize.Value, 0));

            string pass = Password.randomizePassword(count, UpperCase.Checked, Digits.Checked, Special.Checked, Brackets.Checked);

            currentEntryPasswordform.entryPasswordTextBox.Text = pass;
            currentEntryPasswordform.confirmEntryPasswordTextBox.Text = pass;
            this.Close();
            currentEntryPasswordform.Show();
        }

    }
}
