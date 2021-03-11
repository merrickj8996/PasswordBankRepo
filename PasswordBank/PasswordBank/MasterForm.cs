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
            if(FileOP.GetFile() != "") {
                dataGridView1.DataSource = FileOP.ReadFile();
            } else {
                dataGridView1.DataSource = null;
            }
            
        }

        public void selectedRowsButton_Click(object sender, System.EventArgs e) {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(selectedRowCount > 0) {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for(int i = 0; i < selectedRowCount; i++) {
                    sb.Append("Row: ");
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                EntryVariablesTitleTextBox.Text = (sb.ToString());
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
                        //!!TODO!! Write current information in the datastructure to the current working file in FileOP.getFile().
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
                }
                LockFile();
            }
            if (FileOP.SelectFile()) {
                EnterPasswordForFile frm = new EnterPasswordForFile {
                    TheParent = this
                };
                frm.Show();
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
                }
                LockFile();
            }
            if (FileOP.SelectFile()) {
                EnterPasswordForFile frm = new EnterPasswordForFile {
                    TheParent = this
                };
                frm.Show();
            }
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

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e) {

        }

        private void MasterForm_FormClosing(Object sender, FormClosingEventArgs e) {
            if (FileOP.GetFile() != "") {
                if (MessageBox.Show("Would you like to save the current working file?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    //!!TODO!! Write current information in the datastructure to the current working file in FileOP.getFile().
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
                //add an empty row under each respective field

                foreach (DataGridViewRow rw in this.dataGridView1.Rows) {
                    if(rw.Cells[0].Value != null)
                    id = rw.Cells[0].Value.ToString();
                }

                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataRow drToAdd = dataTable.NewRow();

                drToAdd["id"] = Int32.Parse(id) + 1;
                drToAdd["group"] = "";
                drToAdd["title"] = "";
                drToAdd["user name"] = "";
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
            
        }
    }
}
