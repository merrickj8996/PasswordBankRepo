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

namespace WindowsFormsApp1 {
    public partial class MasterForm : Form {
        public MasterForm() {
            InitializeComponent();
        }

        private void CreateNewButton_Click(object sender, EventArgs e) {
            DisplayNewFileWarning();
        }

        private void ReadCSV(string filePath) {
            //Read the CSV file that as just opened.
            //set the columns to be equal to the first line of the CSV seperated by commas
            string[] lines = File.ReadAllLines(filePath);
            string[] fields;
            fields = lines[0].Split(new char[] { ',' });
            int Cols = fields.GetLength(0);
            DataTable dt = new DataTable();
            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(fields[i].ToLower(), typeof(string));
            DataRow Row;
            for (int i = 1; i < lines.GetLength(0); i++) {
                fields = lines[i].Split(new char[] { ',' });
                Row = dt.NewRow();
                for (int f = 0; f < Cols; f++)
                    Row[f] = fields[f];
                dt.Rows.Add(Row);
            }
            dataGridView1.DataSource = dt;
        }

        /**
         * Windows prompt for opening a file
         */
        private String OpenFile(string filePath, string fileContent) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            return filePath;
        }
        /**
         * Method for creating a file
         */
        private void CreateFile() {
            Stream myStream;
            string fileName;
            SaveFileDialog save = new SaveFileDialog {
                Filter = "CSV |*.csv",
                Title = "Save password DB"
            };
            if (save.ShowDialog() == DialogResult.OK) {
                if ((myStream = save.OpenFile()) != null) {
                    myStream.Close();
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(save.FileName, true)) {
                    file.WriteLine("Group,Title,User Name,Password,URL,Notes");
                }
                ReadCSV(save.FileName);
                this.Hide();

                //get the name of the file and trim off the .csv
                fileName = Path.GetFileName(save.FileName).Substring(0, Path.GetFileName(save.FileName).Length - 4);
                passwordOptions masterPass = new passwordOptions();
                masterPass.databasefileName = fileName;
                masterPass.ShowDialog();
            }
        }

        private void SaveFile() {
            SaveFileDialog save = new SaveFileDialog {
                Filter = "CSV |*.csv",
                Title = "Save file"
            };
            if (save.ShowDialog() == DialogResult.OK) {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(dataGridView1);
                write.Dispose();
            }
        }

        private void DisplayNewFileWarning() {
            string message = "Are you sure you wish to create a new password File?";
            string title = "Pass Keeper";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                FileOP.CreateFile();
            }
        }


        private void CreateNewFileDropDown_Click(object sender, EventArgs e) {
            DisplayNewFileWarning();
        }

        private void OpenFileButton_Click(object sender, EventArgs e) {
            //decryption should go here I think.
            var fileContent = string.Empty;
            var filePath = string.Empty;
            FileOP.SelectFile();
            EnterPasswordForFile frm = new EnterPasswordForFile();
            //frm.DatabaseFileName = filePath;
            frm.Show();
        }

        private void OpenFileDropDown_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            filePath = OpenFile(filePath, fileContent);
            EnterPasswordForFile frm = new EnterPasswordForFile();
            frm.DatabaseFileName = filePath;
            frm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            FileOP.SaveFile();
        }

        //Lock button to Encrypt the currently opened file.
        private void LockButton_Click(object sender, EventArgs e) {
            Crypto.EncryptFile(FileOP.GetFile(), Crypto.mPassTemp.ToString());
            FileOP.ClearFile();
        }
    }
}
