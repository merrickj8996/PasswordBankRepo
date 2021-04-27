using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class PasswordOptions : Form {

        public MasterForm TheParent;
        public bool success = false;
        public List<Control> passwordOptionsTextBoxes = new List<Control>();
        public List<Control> passwordOptionsLabels = new List<Control>();
        public List<Control> passwordOptionsButtons = new List<Control>();
        public bool passwordOptionsDarkThemeEnabled = false;
        public bool passwordOptionsDefaultTextSizeEnabled = false;
        public bool passwordOptionsSmallTextSizeEnabled = false;
        public bool passwordOptionsLargeTextSizeEnabled = false;

        public PasswordOptions(Color textColor, Color backgroundColor, Color panelColor, bool darkThemeEnabled) {
            passwordOptionsDarkThemeEnabled = darkThemeEnabled;

            InitializeComponent();
            InitializeControlList();
            SetTheme(textColor, backgroundColor, panelColor);
        }

        /// <summary>
        /// Takes all the components and groups them together in a List<Control>. This is done so themes can be added using loops instead of each component at a time.
        /// </summary>
        private void InitializeControlList() {
            // Stores all text boxes
            passwordOptionsTextBoxes.Add(PassEntry1);
            passwordOptionsTextBoxes.Add(PassEntry2);
            passwordOptionsTextBoxes.Add(KeyFileLocationText);

            // Stores all labels
            passwordOptionsLabels.Add(label1);
            passwordOptionsLabels.Add(label2);
            passwordOptionsLabels.Add(label3);
            passwordOptionsLabels.Add(label4);
            passwordOptionsLabels.Add(passwordStrengthLabel);

            // Stores all buttons
            passwordOptionsButtons.Add(KeyFileCheckBox);
            passwordOptionsButtons.Add(KeyFileHelpButton);
            passwordOptionsButtons.Add(FindKeyFile);
            passwordOptionsButtons.Add(ExitButton);
            passwordOptionsButtons.Add(OkButton);
        }

        /// <summary>
        /// Sets theme of the passwordOptions form.
        /// </summary>
        /// <param name="textColor">Color of the text</param>
        /// <param name="backgroundColor">Color of the background</param>
        /// <param name="panelColor">Color of the panels</param>
        private void SetTheme(Color textColor, Color backgroundColor, Color panelColor) {
            // Apply theme to the form
            this.BackColor = panelColor;

            // Apply the theme to all of the text boxes
            foreach (Control item in passwordOptionsTextBoxes) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }

            // Apply the new theme to all of the labels.
            foreach (Control item in passwordOptionsLabels) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }

            // Applying the new theme to all of the buttons.
            foreach (Control item in passwordOptionsButtons) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }
        }

        public void UpdateTextBox(string pass) {

            PassEntry1.BeginInvoke((MethodInvoker)delegate {
                this.PassEntry1.Text = pass;
                this.PassEntry2.Text = pass;
            });
            //this.Refresh();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            if ((PassEntry1.Text == PassEntry2.Text) && String.IsNullOrEmpty(PassEntry1.Text) == false && String.IsNullOrEmpty(PassEntry2.Text) == false) {
                if (KeyFileCheckBox.Checked) {
                    if (FileOP.GetKeyFile() != "" && FileOP.GetKeyFile() != null && File.Exists(FileOP.GetKeyFile())) {
                        KeyFileLocationText.Text = FileOP.GetKeyFile();
                        Crypto.mPassTemp = PassEntry1.Text;
                        CreatePrintPopUp();
                    }
                    else {
                        MessageBox.Show("Your key file is invalid. Please reselect your keyfile.", "File Error", MessageBoxButtons.OK);
                    }
                }
                else {
                    Crypto.mPassTemp = PassEntry1.Text;
                    CreatePrintPopUp();
                }
            }
            else {
                string message = "Your passwords do not match or the boxes are blank. Please try entering them again";
                string title = "Pass Keeper";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                _ = MessageBox.Show(message, title, buttons);
            }
        }
        
        /// <summary>
        /// Creates the master password print pop-up.
        /// </summary>
        private void CreatePrintPopUp() {
            MasterPasswordPrintPopUp printPopUp;

            if (passwordOptionsDarkThemeEnabled) {
                printPopUp = new MasterPasswordPrintPopUp(PassEntry1.Text, Color.White, Color.DarkGray, Color.DarkSlateGray, passwordOptionsDarkThemeEnabled);
            }
            else {
                printPopUp = new MasterPasswordPrintPopUp(PassEntry1.Text, SystemColors.ControlText, SystemColors.Window, SystemColors.Control, passwordOptionsDarkThemeEnabled);
            }

            // Adding all the printPopUp components to the list of components in the master from.
            // This is done to apply the same theme and text size to all of the forms
            MasterForm controlForm = new MasterForm();

            controlForm.labels.AddRange(printPopUp.printPopUpLabels);
            controlForm.buttons.AddRange(printPopUp.printPopUpButtons);
            controlForm.forms.Add(printPopUp);

            // Changing text size of printPopUp
            if (passwordOptionsDefaultTextSizeEnabled) {
                controlForm.ChangeFontSize(8.0f);
                printPopUp.printPopUpDefaultTextSizeEnabled = true;
                printPopUp.printPopUpSmallTextSizeEnabled = false;
                printPopUp.printPopUpLargeTextSizeEnabled = false;
            }

            else if (passwordOptionsSmallTextSizeEnabled) {
                controlForm.ChangeFontSize(6.0f);
                printPopUp.printPopUpDefaultTextSizeEnabled = false;
                printPopUp.printPopUpSmallTextSizeEnabled = true;
                printPopUp.printPopUpLargeTextSizeEnabled = false;
            }

            else if (passwordOptionsLargeTextSizeEnabled) {
                controlForm.ChangeFontSize(10.0f);
                printPopUp.printPopUpDefaultTextSizeEnabled = false;
                printPopUp.printPopUpSmallTextSizeEnabled = false;
                printPopUp.printPopUpLargeTextSizeEnabled = true;
            }

            printPopUp.ShowDialog();
            TheParent.PerformRefresh(true);
            success = true;
            this.Close();
        }

        private void RandomGen_Click(object sender, EventArgs e) {
            MasterPasswordGenForm generatePasswordOptions = new MasterPasswordGenForm();
            generatePasswordOptions.Show();
            this.Hide();
        }

        private void PasswordStrengthLabel_Click(object sender, EventArgs e) {

        }

        private void PassEntry1_TextChanged(object sender, EventArgs e) {

            // This code will run everytime the text changes in the password box.

            // creates passwordStrength variable to hold the current strenght of the password.
            double passwordStrength = Password.CheckStrength(PassEntry1.Text);

            // If the password strength is 4 or less it is very weak.
            if (passwordStrength <= 4) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Red;
                passwordStrengthLabel.Text = "Password Strength: Very Weak";
                PasswordStrengthBar.Value = 0;
            }

            // If the password strength is more than 4, but no greater than 8 it is weak.
            else if (passwordStrength <= 8) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Orange;
                passwordStrengthLabel.Text = "Password Strength: Weak";
                PasswordStrengthBar.Value = 33;
            }

            // If the password strength is more than 8, but no greater than 12 it is average.
            else if (passwordStrength <= 12) {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Green;
                passwordStrengthLabel.Text = "Password Strength: Average";
                PasswordStrengthBar.Value = 66;
            }

            // If the password strength is more than 12 it is strong.
            else {
                passwordStrengthLabel.ForeColor = System.Drawing.Color.Blue;
                passwordStrengthLabel.Text = "Password Strength: Strong";
                PasswordStrengthBar.Value = 100;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {

            this.Hide();

        }

        private void FindKeyFile_Click(object sender, EventArgs e) {
            FileOP.SelectKeyFile();
            KeyFileLocationText.Text = FileOP.GetKeyFile();
        }

        private void KeyFileHelpButton_Click(object sender, EventArgs e) {
            MessageBox.Show("A key file is any file that contains lots of data, is non-replecatible, and does not change. Pictures work well as key files as they contain many bits", "Key File Help", MessageBoxButtons.OK);
        }

        private void PasswordOptions_FormClosing(object sender, FormClosingEventArgs e) {
            if (!success) {
                File.Delete(FileOP.GetFile());
                FileOP.ClearFile();
                FileOP.ClearKeyFile();
            }
            else {
                success = false;
            }
        }

        private void KeyFileLocationText_DragOver(object sender, DragEventArgs e) {

            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0) {
                KeyFileLocationText.Text = files[0];
                FileOP.LoadKeyFile(KeyFileLocationText.Text);
            }

        }
    }
}
