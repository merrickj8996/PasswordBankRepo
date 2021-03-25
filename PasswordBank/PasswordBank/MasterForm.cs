using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
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
            if (FileOP.GetFile() != "") {
                dataGridView1.DataSource = FileOP.ReadFile();
            }
            else {
                dataGridView1.DataSource = null;
            }

        }

        public void GetSelectedEntryData() {

            EntryVariablesTitleTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            EntryVariablesUsernameTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            EntryVariablesPasswordTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            EntryVariablesUrlTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            entryNotes.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        public void SetSelectedEntryData() {

            dataGridView1.SelectedRows[0].Cells[2].Value = EntryVariablesTitleTextBox.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = EntryVariablesUsernameTextBox.Text;
            dataGridView1.SelectedRows[0].Cells[4].Value = EntryVariablesPasswordTextBox.Text;
            dataGridView1.SelectedRows[0].Cells[5].Value = EntryVariablesUrlTextBox.Text;
            dataGridView1.SelectedRows[0].Cells[6].Value = entryNotes.Text;

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
                        FileOP.SaveFile(dataGridView1);
                    }
                    LockFile();
                }
                //call the create file method and inflate the next form
                if (FileOP.CreateFile()) {
                    PasswordOptions form = new PasswordOptions();
                    form.Show();
                };
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
                    FileOP.SaveFile(dataGridView1);
                }
                LockFile();
            }
            if (FileOP.SelectFile()) {
                EnterPasswordForFile frm = new EnterPasswordForFile {
                    TheParent = this
                };
                frm.ShowDialog();
            }

        }
        /// <summary>
        /// Calls the select file method and shows the next form when the open button is clicked from the file dropdown menu.
        /// </summary>
        private void OpenFileDropDown_Click(object sender, EventArgs e) {
            if (FileOP.GetFile() != "") {
                DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                if (savePrompt == DialogResult.Yes) {
                    //!!TODO!! Write current information in the datastructure to the current working file in FileOP.getFile().
                    FileOP.SaveFile(dataGridView1);
                }
                LockFile();
            }
            if (FileOP.SelectFile()) {
                EnterPasswordForFile frm = new EnterPasswordForFile {
                    TheParent = this
                };
                frm.ShowDialog();
            }
        }
        /// <summary>
        /// Calls the save function when the user clicks the save file button.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e) {
            FileOP.SaveFile(dataGridView1);
        }

        //Lock button to Encrypt and close the currently opened file.
        private void LockButton_Click(object sender, EventArgs e) {
            if (FileOP.GetFile() != "") {
                DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                if (savePrompt == DialogResult.Yes) {
                    //!!TODO!! Write current information in the datastructure to the current working file in FileOP.getFile().
                    FileOP.SaveFile(dataGridView1);
                }
                LockFile();
            }
        }

        private void MasterForm_FormClosing(Object sender, FormClosingEventArgs e) {
            if (FileOP.GetFile() != "") {
                if (MessageBox.Show("Would you like to save the current working file?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    //!!TODO!! Write current information in the datastructure to the current working file in FileOP.getFile().
                    FileOP.SaveFile(dataGridView1);
                }
                LockFile();
            }
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
            this.PerformRefresh();
        }


        //click event for the help option to teach you how to use the program
        private void quickGuideToolStripMenuItem_Click(object sender, EventArgs e) {
            //open the new form
            UserGuide frm = new UserGuide();
            frm.Show();
        }

        //add a new empty row
        private void AddNewEntry_Click(object sender, EventArgs e) {
            String id = "0";
            //if the datagrid view doesnt have a datasource AKA no file is open
            if (dataGridView1.DataSource == null) {
                //pop open a dialog box explaining why a new row cant be added
                DialogResult res = MessageBox.Show("Please open a file before adding a new row.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                //Read in the id's in the datagridview
                foreach (DataGridViewRow rw in this.dataGridView1.Rows) {
                    if (rw.Cells[0].Value != null)
                        id = rw.Cells[0].Value.ToString();
                }


                //make a new datatable
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                //Make a new row
                DataRow drToAdd = dataTable.NewRow();
                //add values to each of the rows
                drToAdd["id"] = Int32.Parse(id) + 1;
                drToAdd["group"] = "";
                drToAdd["title"] = "";
                drToAdd["username"] = "";
                drToAdd["password"] = "";
                drToAdd["url"] = "";
                drToAdd["notes"] = "";


                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
            }
        }

        private void quickGuideToolStripMenuItem_Click_1(object sender, EventArgs e) {
            UserGuide guide = new UserGuide();
            guide.Show();
        }


        private void EntryVariablesConfirmButton_Click(object sender, EventArgs e) {
            SetSelectedEntryData();
        }
        //button press to edit a row that the consumer has selected
        private void EditRowButton_Click(object sender, EventArgs e) {
            //if the datagrid view doesnt have a datasource AKA no file is open
            if (dataGridView1.DataSource == null) {
                //pop open a dialog box explaining why a new row cant be added
                DialogResult res = MessageBox.Show("Please open a file before trying to edit a row.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                GetSelectedEntryData();
            }
        }
        //button press to copy the username of the row selected
        private void CopyUsernameButton_Click(object sender, EventArgs e) {
            if (dataGridView1.DataSource == null) {
                //pop open a dialog box explaining why a new cant be copied
                DialogResult res = MessageBox.Show("Please open a file before trying to copy a username.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridView1.SelectedRows.Count > 0) {
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            }
        }
        //button press to copy the passwrod of the row selected
        private void CopyPassword_Click(object sender, EventArgs e) {
            if (dataGridView1.DataSource == null) {
                //pop open a dialog box explaining why a new cant be copied
                DialogResult res = MessageBox.Show("Please open a file before trying to copy a password.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridView1.SelectedRows.Count > 0) {
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            }
        }
        //button to copy and open the link of the row selected.
        private void CopyButton_Click(object sender, EventArgs e) {
            if (dataGridView1.DataSource == null) {
                //pop open a dialog box explaining why a new cant be copied
                DialogResult res = MessageBox.Show("Please open a file before trying to open a url.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridView1.SelectedRows.Count > 0) {
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                System.Diagnostics.Process.Start(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            }
        }

        private void openingAFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpeningAFileHelpMenu guide = new OpeningAFileHelpMenu();
            guide.Show();
        }

        private void addingEntriesToTheFielToolStripMenuItem_Click(object sender, EventArgs e) {
            EditingAFileHelpMenu guide = new EditingAFileHelpMenu();
            guide.Show();
        }
    }
}
