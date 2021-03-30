using System;
using System.ComponentModel;
using System.Data;
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
        /// Sets the datagridviews datasource to be the datatable constructed by the readfile method.
        /// </summary>
        public void PerformRefresh(bool opened) {
            if (FileOP.GetFile() != "") {
                if (!opened) {
                    UnlockFile();
                }
                dataGridView1.DataSource = FileOP.ReadFile();
                LockFile();
            }
            else {
                dataGridView1.DataSource = null;
            }

        }

        /// <summary>
        /// Clears all the data for the entry variables.
        /// </summary>
        public void ClearEntryData() {
            EntryVariablesTitleTextBox.Text = "";
            EntryVariablesUsernameTextBox.Text = "";
            EntryVariablesPasswordTextBox.Text = "";
            EntryVariablesUrlTextBox.Text = "";
            entryNotes.Text = "";
        }

        /// <summary>
        /// Added method to grab data from the above data table and display it in the cooresponding text boxes.
        /// </summary>
        public void GetSelectedEntryData() {

            if (dataGridView1.Rows.Count > 0) {
                try {
                    // Checks to make sure that cells in row are not null.
                    if (dataGridView1.SelectedRows[0].Cells[2].Value != null) {
                        EntryVariablesTitleTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EntryVariablesUsernameTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EntryVariablesPasswordTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EntryVariablesUrlTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        entryNotes.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    }
                }
                // When adding a first row to the dataGridView1 an exception is thrown due to know rows existing. So instead it only initalizing the text in the entry variables.
                catch(ArgumentOutOfRangeException) {
                    ClearEntryData();
                }
            }

        }

        /// <summary>
        /// Added method to set the data in the data table to the values in the corresponding text boxes.
        /// </summary>
        public void SetSelectedEntryData() {

            if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[0].Cells.Count > 0) {

                dataGridView1.SelectedRows[0].Cells[2].Value = EntryVariablesTitleTextBox.Text;
                dataGridView1.SelectedRows[0].Cells[3].Value = EntryVariablesUsernameTextBox.Text;
                dataGridView1.SelectedRows[0].Cells[4].Value = EntryVariablesPasswordTextBox.Text;
                dataGridView1.SelectedRows[0].Cells[5].Value = EntryVariablesUrlTextBox.Text;
                dataGridView1.SelectedRows[0].Cells[6].Value = entryNotes.Text;
            }

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
                        DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                        FileOP.WriteToFile(dataTable);
                    }
                    ClearMem();
                }
                //call the create file method and inflate the next form
                if (FileOP.CreateFile()) {
                    PasswordOptions form = new PasswordOptions() {
                        TheParent = this
                    };
                    form.ShowDialog();
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
                    DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                    UnlockFile();
                    FileOP.WriteToFile(dataTable);
                    LockFile();
                }
                ClearMem();
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
                    DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                    UnlockFile();
                    FileOP.WriteToFile(dataTable);
                    LockFile();
                }
                ClearMem();
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
            DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
            UnlockFile();
            FileOP.WriteToFile(dataTable);
            LockFile();
        }

        /// <summary>
        /// Lock and encrypt the currently open file.
        /// </summary>
        private void LockButton_Click(object sender, EventArgs e) {
            if (FileOP.GetFile() != "") {
                DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                if (savePrompt == DialogResult.Yes) {
                    DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                    UnlockFile();
                    FileOP.WriteToFile(dataTable);
                    LockFile();
                }
                ClearMem();
            }
        }

        /// <summary>
        /// Function for when the form closes. Asks the consumer if they would like to save the file they currently have open
        /// </summary>
        private void MasterForm_FormClosing(Object sender, FormClosingEventArgs e) {
            if (FileOP.GetFile() != "") {
                if (MessageBox.Show("Would you like to save the current working file?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                    UnlockFile();
                    FileOP.WriteToFile(dataTable);
                    LockFile();
                }
                ClearMem();
            }
        }

        /// <summary>
        /// Unlocks the current file
        /// </summary>
        private void UnlockFile() {
            if (FileOP.GetKeyFile().Length > 0) {
                Crypto.DecryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(FileOP.GetKeyFile()));
            }
            Crypto.DecryptFile(FileOP.GetFile(), Crypto.mPassTemp);
            Compressor.Decompress(FileOP.GetFile());

        }

        /// <summary>
        /// Locks the file when called
        /// </summary>
        private void LockFile() {
            //Compresses File
            Compressor.Compress(FileOP.GetFile());

            //Encrypt the file with stored password
            Crypto.EncryptFile(FileOP.GetFile(), Crypto.mPassTemp);

            //If a Keyfile was used to open the file, use it to encrypt the file when locking
            if (FileOP.GetKeyFile().Length > 0) {

                //Encrypt the file with the KeyFile
                Crypto.EncryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(FileOP.GetKeyFile()));
            }
        }

        /// <summary>
        /// Clears the local memory by clearing any bariables used in fileOP and crypto
        /// </summary>
        private void ClearMem() {
            FileOP.ClearKeyFile();
            FileOP.ClearFile();
            Crypto.mPassTemp = "";
            this.PerformRefresh(false);
        }

        //add a new empty row
        private void AddNewEntry_Click(object sender, EventArgs e) {
            AddANewEntry();
        }

        /// <summary>
        /// Adds a new entry to the datagrid view when a file is currently open
        /// </summary>
        private void AddANewEntry() {
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
                drToAdd["expiration date"] = "";
                drToAdd["title"] = "";
                drToAdd["username"] = "";
                drToAdd["password"] = "";
                drToAdd["url"] = "";
                drToAdd["notes"] = "";

                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();

                // Stores the number of rows in dataGridView1 to int numberOfRows
                int numberOfRows = dataGridView1.Rows.Count;
                // Makes sure there is at least 1 row in dataGridView1
                if (numberOfRows > 0) {
                    // When a new row is added it will automatically select the row to be editable.
                    dataGridView1.Rows[numberOfRows - 1].Selected = true;
                    ClearEntryData();
                }
            }
        }

        /// <summary>
        /// Opens up the file creation help menu
        /// </summary>
        private void quickGuideToolStripMenuItem_Click_1(object sender, EventArgs e) {
            UserGuide guide = new UserGuide();
            guide.Show();
        }

        /// <summary>
        /// Updates the datagridview with the data entered in the entry variables panel
        /// </summary>
        private void EntryVariablesConfirmButton_Click(object sender, EventArgs e) {
            SetSelectedEntryData();
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            dataTable.AcceptChanges();
        }

        /// <summary>
        /// opens the help menu form for opening a file
        /// </summary>
        private void openingAFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpeningAFileHelpMenu guide = new OpeningAFileHelpMenu();
            guide.Show();
        }

        /// <summary>
        /// Opens the help menu for editing the contents of a file
        /// </summary>
        private void addingEntriesToTheFielToolStripMenuItem_Click(object sender, EventArgs e) {
            EditingAFileHelpMenu guide = new EditingAFileHelpMenu();
            guide.Show();
        }

        /// <summary>
        /// Searches the datagrid view as the user enters text and filters the results depending on what they wish to search by
        /// </summary>
        private void SearchBox_TextChanged(object sender, EventArgs e) {
            // if the datagrid view doesn't have a source do nothing
            if (dataGridView1.DataSource != null) {
                // if the consumer has 'Title' selected
                if (SearchByComboBox.SelectedIndex == 0) {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("title like '%" + SearchBox.Text + "%'");
                }
                // Otherwise if the consumer has 'Username' selected
                else if (SearchByComboBox.SelectedIndex == 1) {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("username like '%" + SearchBox.Text + "%'");
                }
                // Otherwise if the consumer has 'URL' selected
                else if (SearchByComboBox.SelectedIndex == 2) {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("url like '%" + SearchBox.Text + "%'");
                }
            }
        }

        /// <summary>
        /// Sets the default value of the search by combo box to be by entry title
        /// </summary>
        private void MasterForm_Load(object sender, EventArgs e) {
            SearchByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Event for when the mouse is hovered over the cell. for the purpose of our program it's used for opening a context menu strip on right click
        /// </summary>
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) {
            // if the right click button is clicked
            if(e.Button == MouseButtons.Right) {
                try {
                    // make sure that the selected item is actually a row.
                    if(e.RowIndex > -1) {
                        this.dataGridView1.Rows[e.RowIndex].Selected = true;
                        this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                        this.CopyAndDeleteCMS.Show(this.dataGridView1, e.Location);
                        CopyAndDeleteCMS.Show(Cursor.Position);
                    }
                }
                catch (ArgumentOutOfRangeException outOfRange) {
                    Console.WriteLine("Out of range exception", outOfRange.Message);
                }
            }
        }

        /// <summary>
        /// Function for a click on the context menu strip for copying a username
        /// </summary>
        private void copyUserNameToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dataGridView1.DataSource == null) {
                // pop open a dialog box explaining why the username can't be copied
                DialogResult res = MessageBox.Show("Please open a file before trying to copy a username.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridView1.SelectedRows.Count > 0) {
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        /// <summary>
        /// Function for a click on the context menu strip for copying a password
        /// </summary>
        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dataGridView1.DataSource == null) {
                // pop open a dialog box explaining why a password cant be copied
                DialogResult res = MessageBox.Show("Please open a file before trying to copy a password.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridView1.SelectedRows.Count > 0) {
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        /// <summary>
        /// Function for a click on the context menu strip for copying a URL
        /// </summary>
        private void copyURLToolStripMenuItem_Click(object sender, EventArgs e) {
            // make sure the datagrid view has a source
            if (dataGridView1.DataSource == null) {
                // pop open a dialog box explaining why a new cant be copied
                DialogResult res = MessageBox.Show("Please open a file before trying to open a url.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // datagrid view has a source and make sure that the count of selectd rows is > 0
            else if (dataGridView1.SelectedRows.Count > 0) {
                // set the URL to be on the clipboard of the user
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                // make sure the url is a valid url
                try {
                    // open the url
                    System.Diagnostics.Process.Start(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                }
                // catch any invalid urls
                catch (Win32Exception w) {
                    Console.WriteLine("invalid URL selected", w.Message);
                    MessageBox.Show("The URL is not a valid URL");
                }
            }

            // stores the number of rows in dataGridView1 to int numberOfRows
            int numberOfRows = dataGridView1.Rows.Count;
            // checks to make sure there at least 1 row in dataGridView1
            if (numberOfRows > 0) {
                // When row is deleted it will select to bottom most row. 
                dataGridView1.Rows[numberOfRows - 1].Selected = true;
                // After bottom most row is selected it gets the data from the row.
                GetSelectedEntryData();
            }
            else {
                // If last row is deleted, clear the entry data.
                ClearEntryData();
            }

        }

        /// <summary>
        /// Gets the selected rows data when a row is clicked
        /// </summary>
        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e) {
            GetSelectedEntryData();
        }

        /// <summary>
        /// Opens up the password entry options when the user clicks on the password box
        /// </summary>
        private void EntryVariablesPasswordTextBox_Enter_1(object sender, EventArgs e) {
            EntryPassword form = new EntryPassword(this);
            form.Show();
        }

        /// <summary>
        /// Function that tracks the key inputs on the master form. It's used to add shortcuts to the buttons
        /// </summary>
        private void MasterForm_KeyDown(object sender, KeyEventArgs e) {
            // Shortcut for locking (ctrl + L)
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.L && dataGridView1.DataSource != null) {
                DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                if (savePrompt == DialogResult.Yes) {
                    DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                    UnlockFile();
                    FileOP.WriteToFile(dataTable);
                    LockFile();
                   }
                ClearMem();
            }
            // Shortcut for adding a new line to the gridview (shift + N)
            else if(e.Modifiers == Keys.Shift && e.KeyCode == Keys.N && dataGridView1.DataSource != null) {
                AddANewEntry();
            }
        }

        /// <summary>
        /// Function to save when the file dropdown menu is clicked
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
            UnlockFile();
            FileOP.WriteToFile(dataTable);
            LockFile();
        }

        /// <summary>
        /// Deletes the row the consumer has selected by rickclicking and using the context strip
        /// </summary>
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows) {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
}
