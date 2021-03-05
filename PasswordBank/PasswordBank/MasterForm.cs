using System;
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
        /// <summary>
        /// Initializes the form.
        /// </summary>
        public MasterForm() {
            InitializeComponent();
        }
        /// <summary>
        /// Sets the datagridviews datasource to be the datatable consturcted by the readfile method.
        /// </summary>
        public void PerformRefresh() {
            dataGridView1.DataSource = FileOP.ReadFile();
        }
        /// <summary>
        /// Calls the createfilewarning method when the user clicks on the save button.
        /// </summary>
        private void CreateNewButton_Click(object sender, EventArgs e) {
            DisplayNewFileWarning();

        }
        /// <summary>
        /// Displays a warning to the user that they are about to create a new file.
        /// </summary>
        private void DisplayNewFileWarning() {
            string message = "Are you sure you wish to create a new password File?";
            string title = "Pass Keeper";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //creates a dialog box with the message, title and button options
            DialogResult confirm = MessageBox.Show(message, title, buttons);

            //if they want to make a new file
            if (confirm == DialogResult.Yes) {
                if (FileOP.GetFile() != "") {
                    DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                    if (savePrompt == DialogResult.Yes) {
                        //!!TODO!! Write current information in the datastructure to the current working file in FileOP.getFile().
                    }
                    LockFile();
                }
                //call the create file method and inflate the next form
                FileOP.CreateFile();
                passwordOptions form = new passwordOptions();
                form.Show();
            }
        }

        /// <summary>
        /// Called when the user clicks the new button from the file drop down menu. Calls the warning function.
        /// </summary>
        private void CreateNewFileDropDown_Click(object sender, EventArgs e) {
            DisplayNewFileWarning();
        }
        /// <summary>
        /// Calls the select file method and shows the next form when the open button is clicked.
        /// </summary>
        private void OpenFileButton_Click(object sender, EventArgs e) {
           
            if (FileOP.GetFile() != "") {
                DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                if (savePrompt == DialogResult.Yes) {
                    //!!TODO!! Write current information in the datastructure to the current working file in FileOP.getFile().
                }
                LockFile();
            }
            if (FileOP.SelectFile()) {
                EnterPasswordForFile frm = new EnterPasswordForFile();
                frm.TheParent = this;
                frm.Show();
            }
            
        }
        /// <summary>
        /// Calls the select file method and shows the next form when the open button is clicked from the file dropdown menu.
        /// </summary>
        private void OpenFileDropDown_Click(object sender, EventArgs e) {
            FileOP.SelectFile();
            EnterPasswordForFile frm = new EnterPasswordForFile();
            frm.Show();
        }
        /// <summary>
        /// Calls the save function when the user clicks the save file button.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e) {
            FileOP.SaveFile();
        }

        //Lock button to Encrypt and close the currently opened file.
        private void LockButton_Click(object sender, EventArgs e) {
            LockFile();
        }


        private void MasterForm_Load(object sender, EventArgs e) {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e) {

        }

        private void LockFile() {
            //Compresses File
            Compressor.Compress(FileOP.GetFile());

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
        }

    }
}
