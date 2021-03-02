using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FirstPass {
    class FileOP {
        #region memberVariables
        public static String mFileName = "";
        public static String mKeyFileName = "";
        #endregion

        public static void ClearFile() {
            mFileName = "";
        }

        public static string GetFile() {
            return mFileName;
        }

        public static void LoadFile(string fileName) {
            mFileName = fileName;
        }

        public static void ClearKeyFile() {
            mKeyFileName = "";
        }

        public static string GetKeyFile() {
            return mKeyFileName;
        }

        public static void LoadKeyFile(string keyFileName) {
            mKeyFileName = keyFileName;
        }

        public static void SaveFile() {
            //TODO: Implement/move saveFile from MasterForm.cs
            SaveFileDialog save = new SaveFileDialog {
                Filter = "CSV |*.csv",
                Title = "Save file"
            };
            //if (save.ShowDialog() == DialogResult.OK) {
            //    StreamWriter write = new StreamWriter(File.Create(save.FileName));
            //    write.Write(dataGridView1);
            //    write.Dispose();
            //}
        }

        public static void CreateFile() {
            //TODO: Import/move CreateFile from MasterForm.cs
            Stream myStream;
            SaveFileDialog save = new SaveFileDialog {
                Filter = "CSV |*.csv",
                Title = "Save password DB"
            };
            if (save.ShowDialog() == DialogResult.OK) {
                if ((myStream = save.OpenFile()) != null) {
                    FileOP.LoadFile(save.FileName);
                    FileOP.PrintFileName();
                    myStream.Close();
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(save.FileName, true)) {
                    file.WriteLine("Group,Title,User Name,Password,URL,Notes");
                    file.Close();
                }
                //ReadFile();
            }
        }

        public static void SelectFile() {
            //TODO: Import/move OpenFile from MasterForm.cs
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    FileOP.LoadFile(openFileDialog.FileName);
                }
            }
        }

        public static void SelectKeyFile() {
            //TODO: Import/move OpenFile from MasterForm.cs
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    FileOP.LoadKeyFile(openFileDialog.FileName);
                }
            }
        }

        public static string KeyFileToBits(string keyFile) {
            return Convert.ToBase64String(File.ReadAllBytes(keyFile));
        }

        public static DataTable ReadFile() {
            //TODO: Import/move ReadCSV from MasterForm.cs

            //Read the CSV file that as just opened.
            //set the columns to be equal to the first line of the CSV seperated by commas
            string[] lines = File.ReadAllLines(GetFile());
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
            return dt;
            //dataGridView1.DataSource = dt;

        }
        public static void PrintFileName() {
            Console.WriteLine(FileOP.GetFile());
        }
    }
}

