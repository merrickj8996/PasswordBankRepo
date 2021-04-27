using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FirstPass {
    public partial class MasterForm : Form {
        /// <summary>
        /// Initializes the form.
        /// </summary>
        public MasterForm() {
            InitializeComponent();
            InitializeControlList();
        }

        
        // Initializing lists for textBoxes and Labels.
        public List<Control> textBoxes;
        public List<Control> labels;
        public List<Control> buttons;
        public List<ToolStripMenuItem> toolStrips;
        public List<ToolStripButton> toolStripButtons;
        public List<Form> forms;
        public bool darkThemeEnabled = false;
        public bool smallTextSizeEnabled = false;
        public bool defaultTextSizeEnabled = false;
        public bool largeTextSizeEnabled = false;

        // Creating thread delegates
        private delegate void ChangeThemeDelegate();

        /// <summary>
        /// Takes all the components and groups them together in a List<Control>. This is done so themes can be added using loops instead of each component at a time.
        /// </summary>
        private void InitializeControlList() {
            textBoxes = new List<Control>();
            labels = new List<Control>();
            buttons = new List<Control>();
            toolStrips = new List<ToolStripMenuItem>();
            toolStripButtons = new List<ToolStripButton>();
            forms = new List<Form>();

            // Stores all texboxes
            textBoxes.Add(EntryVariablesExpirationTextBox);
            textBoxes.Add(EntryVariablesTitleTextBox);
            textBoxes.Add(EntryVariablesUsernameTextBox);
            textBoxes.Add(EntryVariablesPasswordTextBox);
            textBoxes.Add(EntryVariablesUrlTextBox);
            textBoxes.Add(entryNotes);
            textBoxes.Add(SearchBox);

            // Stores all labels
            labels.Add(EntryVariablesHeaderLabel);
            labels.Add(EntryVariablesExpirationLabel);
            labels.Add(EntryVariablesTitleLabel);
            labels.Add(EntryVariablesUsernameLabel);
            labels.Add(EntryVariablesPasswordLabel);
            labels.Add(EntryVariablesUrlLabel);
            labels.Add(SearchbyLabel);

            // Stores all buttons
            buttons.Add(AddNewEntry);
            buttons.Add(EntryVariablesConfirmButton);

            // Stores all tool strips
            toolStrips.Add(FileDropDown);
            toolStrips.Add(helpToolStripMenuItem);
            toolStrips.Add(settingsToolStripMenuItem);
        }

        /// <summary>
        /// Changes the font size of all the objects in the MasterForm to the desired font size.
        /// </summary>
        /// <param name="fontSize"></param>
        public void ChangeFontSize(float fontSize) {

            // Creating a font that represents a new font and the same font with a Bold FontStyle.
            Font newFont = new Font("Microsoft Sans Serif", fontSize);
            Font newFontBold = new Font("Microsoft Sans Serif", fontSize, FontStyle.Bold);

            // Applying the new font to all of the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row != null) {
                    row.DefaultCellStyle.Font = newFont;
                }
            }

            // Applying the new font to all of the column headers in the DataGridView
            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                if (column != null) {
                    column.HeaderCell.Style.Font = newFont;
                }
            }

            // Applying the new font to all of the ToolStripMenuItems
            foreach (ToolStripMenuItem toolStrip in toolStrips) {
                toolStrip.Font = newFont;
            }

            // Applying the new font to all of the textBoxes
            foreach (Control item in textBoxes) {
                if (item.Font.Bold) {
                    item.Font = newFontBold;
                    item.AutoSize = true;
                }
                else {
                    item.Font = newFont;
                    item.AutoSize = true;
                }
            }

            // Applying the new font to all of the labels.
            foreach (Control item in labels) {
                if (item.Font.Bold) {
                    item.Font = newFontBold;
                    if (!item.Text.Equals("Entry Variables")) {
                        item.AutoSize = true;
                    }
                }
                else {
                    item.Font = newFont;
                    if (!item.Text.Equals("Entry Variables")) {
                        item.AutoSize = true;
                    }
                }
            }

            // Applying the new font to all of the buttons.
            foreach (Control item in buttons) {
                if (item.Font.Bold) {
                    item.Font = newFontBold;
                    if (!item.Text.Equals("Entry Variables")) {
                        item.AutoSize = true;
                    }
                }
                else {
                    item.Font = newFont;
                    if (!item.Text.Equals("Entry Variables")) {
                        item.AutoSize = true;
                    }
                }
            }

            // Applying the snew font to the SearchByComboBox.
            SearchByComboBox.Font = newFont;
        }

        /// <summary>
        /// Changes the theme of all forms.
        /// </summary>
        /// <param name="textColor">Color of the text</param>
        /// <param name="backgroundColor">Color of the backgrounds</param>
        /// <param name="panelColor">Color of the panels</param>
        public void ChangeTheme(Color textColor, Color backgroundColor, Color panelColor) {

            // Applying the new theme to all of the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row != null) {
                    row.DefaultCellStyle.BackColor = backgroundColor;
                    row.DefaultCellStyle.ForeColor = textColor;
                }
            }

            // Applying the new theme to all of the column headers in the DataGridView
            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                if (column != null) {
                    column.HeaderCell.Style.BackColor = backgroundColor;
                    column.HeaderCell.Style.ForeColor = textColor;
                }
            }

            // Applying the new theme to all of the ToolStripMenuItems
            foreach (ToolStripMenuItem toolStrip in toolStrips) {
                toolStrip.BackColor = panelColor;
                toolStrip.ForeColor = textColor;
            }

            // Applying the new theme to all of the textBoxes
            foreach (Control item in textBoxes) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }

            // Applying the new theme to all of the labels.
            foreach (Control item in labels) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }

            // Applying the new theme to all of the buttons.
            foreach (Control item in buttons) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }

            // Applying the new theme to all of the forms
            foreach (Form form in forms) {
                form.BackColor = panelColor;
            }

            // Applying the new theme to the SearchByComboBox.
            SearchByComboBox.BackColor = backgroundColor;
            SearchByComboBox.ForeColor = textColor;

            // Applying the new theme to the menu strip
            menuStrip1.BackColor = panelColor;

            // Applying the new theme to the tool strip
            toolStrip1.BackColor = panelColor;

            // Applying the new theme to the entryVariablesPanel
            EntryVariablesPanel.BackColor = panelColor;

            // Applying the new theme to dataGridView
            dataGridView1.BackColor = panelColor;

            // Applying the new theme to the splitContainer2.Panel1
            splitContainer2.Panel1.BackColor = panelColor;

            // Applying the new theme to the toolStripButtons
            foreach(ToolStripButton buttons in toolStripButtons) {
                buttons.BackColor = panelColor;
            }

            // Applying the new theme to the notes background
            entryNotes.BackColor = backgroundColor;

            // Applying the new theme to the search box
            SearchBox.BackColor = backgroundColor;
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
            EntryVariablesExpirationTextBox.Text = "";
            EntryVariablesExpirationTextBox.ForeColor = System.Drawing.Color.Black;
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
                    if (dataGridView1.SelectedRows[0].Cells[1].Value != null) {
                        EntryVariablesExpirationTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EntryVariablesTitleTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EntryVariablesUsernameTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EntryVariablesPasswordTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EntryVariablesUrlTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        entryNotes.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
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

                // Varaibles to store whether any entry variables has commas and the amount of entry variables that do.
                bool containsComma = false;
                int numberEntriesComma = 0;

                // Checks for comma in the expiration date.
                if (EntryVariablesExpirationTextBox.Text.Contains(",")) {
                    containsComma = true;
                    numberEntriesComma++;
                    EntryVariablesExpirationTextBox.Clear();
                }
                else {
                    dataGridView1.SelectedRows[0].Cells[0].Value = EntryVariablesExpirationTextBox.Text;
                }

                // Checks for comma in the title.
                if (EntryVariablesTitleTextBox.Text.Contains(",")) {
                    containsComma = true;
                    numberEntriesComma++;
                    EntryVariablesTitleTextBox.Clear();
                }
                else {
                    dataGridView1.SelectedRows[0].Cells[1].Value = EntryVariablesTitleTextBox.Text;
                }

                // Checks for comma in the username.
                if (EntryVariablesUsernameTextBox.Text.Contains(",")) {
                    containsComma = true;
                    numberEntriesComma++;
                    EntryVariablesUsernameTextBox.Clear();
                }
                else {
                    dataGridView1.SelectedRows[0].Cells[2].Value = EntryVariablesUsernameTextBox.Text;
                }

                // Checks for comma in the password.
                if (EntryVariablesPasswordTextBox.Text.Contains(",")) {
                    containsComma = true;
                    numberEntriesComma++;
                    EntryVariablesPasswordTextBox.Clear();
                }
                else {
                    dataGridView1.SelectedRows[0].Cells[3].Value = EntryVariablesPasswordTextBox.Text;
                }

                // Checks for comma in the url.
                if (EntryVariablesUrlTextBox.Text.Contains(",")) {
                    containsComma = true;
                    numberEntriesComma++;
                    EntryVariablesUrlTextBox.Clear();
                }
                else {
                    dataGridView1.SelectedRows[0].Cells[4].Value = EntryVariablesUrlTextBox.Text;
                }

                // Checks for comma in the notes.
                if (entryNotes.Text.Contains(",")) {
                    containsComma = true;
                    numberEntriesComma++;
                    entryNotes.Clear();
                }
                else {
                    dataGridView1.SelectedRows[0].Cells[5].Value = entryNotes.Text;
                }

                // Checks to make sure no entry variable's text contains commas. This is so the comma diliminated file doesn't have errors.
                if (containsComma) {
                    string message = "You have " + numberEntriesComma + " entrie(s) that have commas. They have been cleared to show which ones. Please enter that entry data again.";
                    MessageBox.Show(message, "Entry Variables Warning", MessageBoxButtons.OK);
                }
            }

        }

        /// <summary>
        /// Checks the number of days betweeen the current date and the day of expiration.
        /// </summary>
        /// <param name="expirationDate"></param> 
        /// This parameter is for the date that the entry expires on.
        /// <returns></returns>
        public void CheckExpirationDate() {
            
            double daysTillExpiration = 100;
            
            try {
                DateTime expirationDate = Convert.ToDateTime(EntryVariablesExpirationTextBox.Text.ToString());
                DateTime currentDate = DateTime.Now;
                daysTillExpiration = (expirationDate - currentDate ).TotalDays;
            }
            catch (System.FormatException) {

            }
            if (daysTillExpiration <= 3) {
                MessageBox.Show("Your password for this entry expires in " + Math.Ceiling(daysTillExpiration) + " day(s). Please update your password or remove the expiration date.", "Password Expiration Warning", MessageBoxButtons.OK);
                EntryVariablesExpirationTextBox.ForeColor = System.Drawing.Color.Red;
            }
            else {
                if (darkThemeEnabled) {
                    EntryVariablesExpirationTextBox.ForeColor = System.Drawing.Color.White;
                }
                else {
                    EntryVariablesExpirationTextBox.ForeColor = System.Drawing.Color.Black;
                }
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
                    PasswordOptions passwordOptionsForm;

                    // Creates a passwordOptions form with the correct theme
                    if(darkThemeEnabled) {
                        passwordOptionsForm = new PasswordOptions(Color.White, Color.DarkGray, Color.DarkSlateGray, darkThemeEnabled) { TheParent = this };
                    }
                    else {
                        passwordOptionsForm = new PasswordOptions(SystemColors.ControlText, SystemColors.Window, SystemColors.Control, darkThemeEnabled) { TheParent = this };
                    }
                    
                    // Adding all the password options components to the list of components in the master from.
                    // This is done to apply the same theme and text size to all of the forms
                    textBoxes.AddRange(passwordOptionsForm.passwordOptionsTextBoxes);
                    labels.AddRange(passwordOptionsForm.passwordOptionsLabels);
                    this.buttons.AddRange(passwordOptionsForm.passwordOptionsButtons);
                    forms.Add(passwordOptionsForm);

                    // Changing text size of passwordOptions
                    if (defaultTextSizeEnabled) {
                        ChangeFontSize(8.0f);
                        passwordOptionsForm.passwordOptionsDefaultTextSizeEnabled = true;
                        passwordOptionsForm.passwordOptionsSmallTextSizeEnabled = false;
                        passwordOptionsForm.passwordOptionsLargeTextSizeEnabled = false;
                    }

                    else if (smallTextSizeEnabled) {
                        ChangeFontSize(6.0f);
                        passwordOptionsForm.passwordOptionsDefaultTextSizeEnabled = false;
                        passwordOptionsForm.passwordOptionsSmallTextSizeEnabled = true;
                        passwordOptionsForm.passwordOptionsLargeTextSizeEnabled = false;
                    }

                    else if (largeTextSizeEnabled) {
                        ChangeFontSize(10.0f);
                        passwordOptionsForm.passwordOptionsDefaultTextSizeEnabled = false;
                        passwordOptionsForm.passwordOptionsSmallTextSizeEnabled = false;
                        passwordOptionsForm.passwordOptionsLargeTextSizeEnabled = true;
                    }

                    passwordOptionsForm.ShowDialog();
                    passwordOptionsForm.Activate();
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
            // if there is currently a file open
            if (FileOP.GetFile() != "") {
                // open a dialog asking if the consumer would like to save
                DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                if (savePrompt == DialogResult.Yes) {
                    // save the file contents
                    DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                    UnlockFile();
                    FileOP.WriteToFile(dataTable);
                    LockFile();
                }
                // clear any references to file paths in the memory
                ClearMem();
            }
            // if the dialog from fileOP returns true
            if (FileOP.SelectFile()) {
                // inflate the next form
                EnterPasswordForFile frm = new EnterPasswordForFile {
                    TheParent = this
                };

                // Adding all the enterPasswordForFile components to the list of components in the master from.
                // This is done to apply the same theme and text size to all of the forms
                textBoxes.AddRange(frm.enterPasswordForFileTextBoxes);
                labels.AddRange(frm.enterPasswordForFileLabels);
                this.buttons.AddRange(frm.enterPasswordForFileButtons);
                forms.Add(frm);

                // Changing theme of enterPasswordForFile
                if (darkThemeEnabled) {
                    ChangeTheme(System.Drawing.Color.White, System.Drawing.Color.DarkGray, System.Drawing.Color.DarkSlateGray);
                    frm.enterPasswordForFileDarkThemeEnabled = true;
                }
                else {
                    ChangeTheme(System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.Control);
                    frm.enterPasswordForFileDarkThemeEnabled = false;
                }

                // Changing text size of enterPasswordForFile
                if (defaultTextSizeEnabled) {
                    ChangeFontSize(8.0f);
                    frm.enterPasswordForFileDefaultTextSizeEnabled = true;
                    frm.enterPasswordForFileSmallTextSizeEnabled = false;
                    frm.enterPasswordForFileLargeTextSizeEnabled = false;
                }

                else if (smallTextSizeEnabled) {
                    ChangeFontSize(6.0f);
                    frm.enterPasswordForFileDefaultTextSizeEnabled = false;
                    frm.enterPasswordForFileSmallTextSizeEnabled = true;
                    frm.enterPasswordForFileLargeTextSizeEnabled = false;
                }

                else if (largeTextSizeEnabled) {
                    ChangeFontSize(10.0f);
                    frm.enterPasswordForFileDefaultTextSizeEnabled = false;
                    frm.enterPasswordForFileSmallTextSizeEnabled = false;
                    frm.enterPasswordForFileLargeTextSizeEnabled = true;
                }

                frm.ShowDialog();
            }

        }
        /// <summary>
        /// Calls the select file method and shows the next form when the open button is clicked from the file dropdown menu.
        /// </summary>
        private void OpenFileDropDown_Click(object sender, EventArgs e) {
            // if there is currently a file open
            if (FileOP.GetFile() != "") {
                //open a dialog asking if the consumer would like to save
                DialogResult savePrompt = MessageBox.Show("Would you like to save the current working file?", "Lock Current File", MessageBoxButtons.YesNo);
                // save the file contents
                if (savePrompt == DialogResult.Yes) {
                    DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                    UnlockFile();
                    FileOP.WriteToFile(dataTable);
                    LockFile();
                }
                // clear any references to file paths in the memory
                ClearMem();
            }
            // if the dialog from fileOP returns true
            if (FileOP.SelectFile()) {
                // inflate the next form
                EnterPasswordForFile frm = new EnterPasswordForFile {
                    TheParent = this
                };

                // Adding all the enterPasswordForFile components to the list of components in the master from.
                // This is done to apply the same theme and text size to all of the forms
                textBoxes.AddRange(frm.enterPasswordForFileTextBoxes);
                labels.AddRange(frm.enterPasswordForFileLabels);
                this.buttons.AddRange(frm.enterPasswordForFileButtons);
                forms.Add(frm);

                // Changing theme of enterPasswordForFile
                if (darkThemeEnabled) {
                    ChangeTheme(System.Drawing.Color.White, System.Drawing.Color.DarkGray, System.Drawing.Color.DarkSlateGray);
                    frm.enterPasswordForFileDarkThemeEnabled = true;
                }
                else {
                    ChangeTheme(System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.Control);
                    frm.enterPasswordForFileDarkThemeEnabled = false;
                }

                // Changing text size of enterPasswordForFile
                if (defaultTextSizeEnabled) {
                    ChangeFontSize(8.0f);
                    frm.enterPasswordForFileDefaultTextSizeEnabled = true;
                    frm.enterPasswordForFileSmallTextSizeEnabled = false;
                    frm.enterPasswordForFileLargeTextSizeEnabled = false;
                }

                else if (smallTextSizeEnabled) {
                    ChangeFontSize(6.0f);
                    frm.enterPasswordForFileDefaultTextSizeEnabled = false;
                    frm.enterPasswordForFileSmallTextSizeEnabled = true;
                    frm.enterPasswordForFileLargeTextSizeEnabled = false;
                }

                else if (largeTextSizeEnabled) {
                    ChangeFontSize(10.0f);
                    frm.enterPasswordForFileDefaultTextSizeEnabled = false;
                    frm.enterPasswordForFileSmallTextSizeEnabled = false;
                    frm.enterPasswordForFileLargeTextSizeEnabled = true;
                }

                frm.ShowDialog();
            }
        }
        /// <summary>
        /// Calls the save function when the user clicks the save file button.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e) {
            if (FileOP.GetFile() != "") {
                DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
                UnlockFile();
                FileOP.WriteToFile(dataTable);
                LockFile();
            }
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
                CryptoProgBar.Value = 16;
            }
            
            Crypto.DecryptFile(FileOP.GetFile(), Crypto.mPassTemp);
            CryptoProgBar.Value = 33;
            
            Compressor.Decompress(FileOP.GetFile());
            CryptoProgBar.Value = 50;
        }

        /// <summary>
        /// Locks the file when called
        /// </summary>
        private void LockFile() {
            //Compresses File
            Compressor.Compress(FileOP.GetFile());
            CryptoProgBar.Value = 66;
            //Encrypt the file with stored password
            Crypto.EncryptFile(FileOP.GetFile(), Crypto.mPassTemp);
            CryptoProgBar.Value = 83;
            //If a Keyfile was used to open the file, use it to encrypt the file when locking
            if (FileOP.GetKeyFile().Length > 0) {

                //Encrypt the file with the KeyFile
                Crypto.EncryptFile(FileOP.GetFile(), FileOP.KeyFileToBits(FileOP.GetKeyFile()));
                CryptoProgBar.Value = 100;
            }
            CryptoProgBar.Value = 0;
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
            //if the datagrid view doesnt have a datasource AKA no file is open
            if (dataGridView1.DataSource == null) {
                //pop open a dialog box explaining why a new row cant be added
                DialogResult res = MessageBox.Show("Please open a file before adding a new row.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                //make a new datatable
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                //Make a new row
                DataRow drToAdd = dataTable.NewRow();
                //add values to each of the rows
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
            if (dataTable != null) {
                dataTable.AcceptChanges();
            }
            else {
                MessageBox.Show("Please open a file before confirming entry data", "No Data Table Warning", MessageBoxButtons.OK);
                ClearEntryData();
            }
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
            else if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[2].Value != null) {
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
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
            else if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[3].Value != null) {
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
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
            else if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[4].Value != null) {
                // set the URL to be on the clipboard of the user
                Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                // make sure the url is a valid url
                try {
                    // open the url
                    System.Diagnostics.Process.Start(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
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
            CheckExpirationDate();
        }

        /// <summary>
        /// Opens up the password entry options when the user clicks on the password box
        /// </summary>
        private void EntryVariablesPasswordTextBox_Enter_1(object sender, EventArgs e) {
            EntryPassword form = new EntryPassword(this);

            // Adding all the Entry Password components to the list of components in the master from.
            // This is done to apply the same theme and text size to all of the forms
            textBoxes.AddRange(form.entryPasswordTextBoxes);
            labels.AddRange(form.entryPasswordLabels);
            this.buttons.AddRange(form.entryPasswordButtons);
            forms.Add(form);

            // Changing theme of EntryPassword
            if (darkThemeEnabled) {
                ChangeTheme(System.Drawing.Color.White, System.Drawing.Color.DarkGray, System.Drawing.Color.DarkSlateGray);
                form.entryPasswordDarkThemeEnabled = true;
            }
            else {
                ChangeTheme(System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.Control);
                form.entryPasswordDarkThemeEnabled = false;
            }

            // Changing text size of EntryPassword
            if (defaultTextSizeEnabled) {
                ChangeFontSize(8.0f);
                form.entryPasswordDefaultTextSizeEnabled = true;
                form.entryPasswordSmallTextSizeEnabled = false;
                form.entryPasswordLargeTextSizeEnabled = false;
            }

            else if (smallTextSizeEnabled) {
                ChangeFontSize(6.0f);
                form.entryPasswordDefaultTextSizeEnabled = false;
                form.entryPasswordSmallTextSizeEnabled = true;
                form.entryPasswordLargeTextSizeEnabled = false;
            }

            else if (largeTextSizeEnabled) {
                ChangeFontSize(10.0f);
                form.entryPasswordDefaultTextSizeEnabled = false;
                form.entryPasswordSmallTextSizeEnabled = false;
                form.entryPasswordLargeTextSizeEnabled = true;
            }

            form.ShowDialog();
        }
        
        /// <summary>
        /// Sets text size to the Master From to a smaller size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smallTextSizeOption_Click(object sender, EventArgs e) {
            ChangeFontSize(6.0f);
            defaultTextSizeEnabled = false;
            smallTextSizeEnabled = true;
            largeTextSizeEnabled = false;
        }

        /// <summary>

        /// Sets text size to the Master From to a larger size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void largeTextSizeOption_Click(object sender, EventArgs e) {
            ChangeFontSize(10.0f);
            defaultTextSizeEnabled = false;
            smallTextSizeEnabled = false;
            largeTextSizeEnabled = true;
        }

        /// <summary>
        /// Sets text size to the Master From to the default size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultTextSizeOption_Click(object sender, EventArgs e) {
            ChangeFontSize(8.0f);
            defaultTextSizeEnabled = true;
            smallTextSizeEnabled = false;
            largeTextSizeEnabled = false;
        }

        private void darkThemeOption_Click(object sender, EventArgs e) {
            ChangeTheme(System.Drawing.Color.White, System.Drawing.Color.DarkGray, System.Drawing.Color.DarkSlateGray);
            darkThemeEnabled = true;
        }

        private void defaultThemeOption_Click(object sender, EventArgs e) {
            ChangeTheme(System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.Control);
            darkThemeEnabled = false;
        }

        /// Function that tracks the key inputs on the master form. It's used to add shortcuts to the buttons
        /// </summary>
        /*private void MasterForm_KeyDown(object sender, KeyEventArgs e) {
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
        }*/

        /// <summary>
        /// Function to save when the file dropdown menu is clicked
        /// </summary>
        /*private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            DataTable dataTable = FileOP.DataGridViewToDataTable(dataGridView1);
            UnlockFile();
            FileOP.WriteToFile(dataTable);
            LockFile();
        }*/

        /// <summary>
        /// Deletes the row the consumer has selected by rickclicking and using the context strip
        /// </summary>
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows) {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void StegImport_Click(object sender, EventArgs e) {
            StegImport frm = new StegImport();
            frm.ShowDialog();
        }

        private void StegExport_Click(object sender, EventArgs e) {
            if (FileOP.GetFile() != "") {
                StegExport frm = new StegExport();
                frm.ShowDialog();
            }
            
        }

        /// <summary>
        /// Makes the datagridview password column display password chars rather than being visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (dataGridView1.Columns[e.ColumnIndex].Index == 3 && e.Value != null) {
                dataGridView1.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
