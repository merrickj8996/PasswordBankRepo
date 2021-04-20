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
    public partial class EntryPassword : Form {

        private MasterForm currentMasterform;
        public EntryPassword(MasterForm form) {
            InitializeComponent();
            InitializeControlList();
            currentMasterform = form;
        }

        public List<Control> entryPasswordTextBoxes;
        public List<Control> entryPasswordLabels;
        public List<Control> entryPasswordButtons;
        public bool entryPasswordDarkThemeEnabled;
        public bool entryPasswordDefaultTextSizeEnabled;
        public bool entryPasswordSmallTextSizeEnabled;
        public bool entryPasswordLargeTextSizeEnabled;

        /// <summary>
        /// Takes all the components and groups them together in a List<Control>. This is done so themes can be added using loops instead of each component at a time.
        /// </summary>
        private void InitializeControlList() {
            entryPasswordTextBoxes = new List<Control>();
            entryPasswordLabels = new List<Control>();
            entryPasswordButtons = new List<Control>();

            // Stores all texboxes
            entryPasswordTextBoxes.Add(entryPasswordTextBox);
            entryPasswordTextBoxes.Add(confirmEntryPasswordTextBox);

            // Stores all labels
            entryPasswordLabels.Add(EntryPasswordLabel);
            entryPasswordLabels.Add(confirmEntryPasswordLabel);
            entryPasswordLabels.Add(entryPasswordStrengthLabel);

            // Stores all buttons
            entryPasswordButtons.Add(entryPasswordRandomizeButton);
            entryPasswordButtons.Add(entryPasswordOkButton);
            entryPasswordButtons.Add(entryPasswordCancelButton);
        }

        private void entryPasswordTextBox_TextChanged(object sender, EventArgs e) {

            double passwordStrength = Password.CheckStrength(entryPasswordTextBox.Text);

            if (passwordStrength <= 4) {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Red;
                entryPasswordStrengthLabel.Text = "Password Strength: Very Weak";
                entryPasswordStrengthBar.Value = 0;
            }

            // If the password strength is more than 4, but no greater than 8 it is weak.
            else if (passwordStrength <= 8) {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Orange;
                entryPasswordStrengthLabel.Text = "Password Strength: Weak";
                entryPasswordStrengthBar.Value = 33;
            }

            // If the password strength is more than 8, but no greater than 12 it is average.
            else if (passwordStrength <= 12) {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Green;
                entryPasswordStrengthLabel.Text = "Password Strength: Average";
                entryPasswordStrengthBar.Value = 66;
            }

            // If the password strength is more than 12 it is strong.
            else {
                entryPasswordStrengthLabel.ForeColor = System.Drawing.Color.Blue;
                entryPasswordStrengthLabel.Text = "Password Strength: Strong";
                entryPasswordStrengthBar.Value = 100;
            }
        }

        private void entryPasswordOkButton_Click(object sender, EventArgs e) {
            if ((entryPasswordTextBox.Text == confirmEntryPasswordTextBox.Text) && String.IsNullOrEmpty(entryPasswordTextBox.Text) == false && String.IsNullOrEmpty(confirmEntryPasswordTextBox.Text) == false) {
                currentMasterform.EntryVariablesPasswordTextBox.Text = entryPasswordTextBox.Text;
                try {
                    DateTime expirationDate = Convert.ToDateTime(currentMasterform.EntryVariablesExpirationTextBox.Text);
                    expirationDate = expirationDate.AddMonths(1);
                    currentMasterform.EntryVariablesExpirationTextBox.Text = expirationDate.ToShortDateString();
                }
                catch (System.FormatException) {

                }
                this.Close();
            }
            else {
                MessageBox.Show("The passwords do match or one of the text boxes is empty, please enter your password again.", "Password Error", MessageBoxButtons.OK);
            }
        }

        private void entryPasswordCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void entryPasswordRandomizeButton_Click(object sender, EventArgs e) {
            MasterPasswordGenForm randomPasswordForm = new MasterPasswordGenForm(this);

            MasterForm controlForm = new MasterForm();

            // Adding all the enterPasswordForFile components to the list of components in the master from.
            // This is done to apply the same theme and text size to all of the forms
            controlForm.labels.AddRange(randomPasswordForm.passwordGenLabels);
            controlForm.buttons.AddRange(randomPasswordForm.passwordGenButtons);
            controlForm.forms.Add(randomPasswordForm);

            // Changing theme of MasterPasswordGenForm
            if (entryPasswordDarkThemeEnabled) {
                controlForm.ChangeTheme(System.Drawing.Color.White, System.Drawing.Color.DarkGray, System.Drawing.Color.DarkSlateGray);
                randomPasswordForm.passwordGenDarkThemeEnabled = true;
            }
            else {
                controlForm.ChangeTheme(System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.Control);
                randomPasswordForm.passwordGenDarkThemeEnabled = false;
            }

            // Changing text size of MasterPasswordGenForm
            if (entryPasswordDefaultTextSizeEnabled) {
                controlForm.ChangeFontSize(8.0f);
                randomPasswordForm.passwordGenDefaultTextSizeEnabled = true;
                randomPasswordForm.passwordGenSmallTextSizeEnabled = false;
                randomPasswordForm.passwordGenLargeTextSizeEnabled = false;
            }

            else if (entryPasswordSmallTextSizeEnabled) {
                controlForm.ChangeFontSize(6.0f);
                randomPasswordForm.passwordGenDefaultTextSizeEnabled = false;
                randomPasswordForm.passwordGenSmallTextSizeEnabled = true;
                randomPasswordForm.passwordGenLargeTextSizeEnabled = false;
            }

            else if (entryPasswordLargeTextSizeEnabled) {
                controlForm.ChangeFontSize(10.0f);
                randomPasswordForm.passwordGenDefaultTextSizeEnabled = false;
                randomPasswordForm.passwordGenSmallTextSizeEnabled = false;
                randomPasswordForm.passwordGenLargeTextSizeEnabled = true;
            }

            randomPasswordForm.ShowDialog();
        }
    }
}
