﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;

namespace FirstPass {
    /// <summary>
    /// Contains all the methods for file operations such as opening a file, creating a new file and saving a file.
    /// </summary>
    public class FileOP {
        #region memberVariables
        public static String mFileName = "";
        public static String mKeyFileName = "";
        #endregion

        /// <summary>
        /// Clears the file path of the current file
        /// </summary>
        public static void ClearFile() {
            mFileName = "";
        }

        /// <summary>
        /// Returns the file path of the current file
        /// </summary>
        public static string GetFile() {
            return mFileName;
        }

        /// <summary>
        /// Sets the file path to a given filename
        /// </summary>
        /// <param name="keyFile">Filepath to the password file</param>
        public static void LoadFile(string fileName) {
            mFileName = fileName;
        }

        /// <summary>
        /// clears the path of the key file
        /// </summary>
        public static void ClearKeyFile() {
            mKeyFileName = "";
        }

        /// <summary>
        /// Returns the keyfiles path
        /// </summary>
        public static string GetKeyFile() {
            return mKeyFileName;
        }

        /// <summary>
        /// Sets the keyfile path to a given keyfile path
        /// </summary>
        /// <param name="keyFile">filepath to the keyfile</param>
        public static void LoadKeyFile(string keyFileName) {
            mKeyFileName = keyFileName;
        }

        /// <summary>
        /// used to save a file DOES NOT COMPLETELY WORK AS OF NOW
        /// </summary>
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

        /// <summary>
        /// Opens up the dialog for creating a new password file
        /// </summary>
        public static void CreateFile() {
            Stream myStream;
            //default to creating a .csv file
            SaveFileDialog save = new SaveFileDialog {
                Filter = "CSV |*.csv",
                Title = "Save password DB"
            };
            //opens up the file explorer dialog menu and determines if the result is the ok button
            if (save.ShowDialog() == DialogResult.OK) {
                //as long as the stream is not null load the file name and optionally print it for testing purposes
                if ((myStream = save.OpenFile()) != null) {
                    FileOP.LoadFile(save.FileName);
                    //FileOP.PrintFileName();
                    myStream.Close();
                }
                //Write the first line of the file to the file.
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(save.FileName, true)) {
                    file.WriteLine("ID,Group,Title,User Name,Password,URL,Notes");
                    file.Close();
                }
            }
        }

        /// <summary>
        /// Opens the dialog for opening a file allows opening of .gz files
        /// </summary>
        public static bool SelectFile() {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "gz file (*.gz)|*.gz";
                openFileDialog.RestoreDirectory = true;
                //if the result is ok load the file
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //set the path of the file that is selected
                    FileOP.LoadFile(openFileDialog.FileName);
                    return true;
                } else {
                    return false;
                }
            }
        }

        /// <summary>
        /// Opens the dialog for opening a file allows opening of all files to allow any file to be a key file
        /// </summary>
        public static bool SelectKeyFile() {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                //if the result is ok load the file
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    FileOP.LoadKeyFile(openFileDialog.FileName);
                    return true;
                } else {
                    return false;
                }
            }
        }

        /// <summary>
        /// Turns the keyfile's path to bits
        /// </summary>
        /// <param name="keyFile">Filepath of the key file to conver to bits</param>
        public static string KeyFileToBits(string keyFile) {
            return Convert.ToBase64String(File.ReadAllBytes(keyFile));
        }

        /// <summary>
        /// Reads the CSV file that the consumer has read.
        /// </summary>
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

        /// <summary>
        /// Writes all the password entries to the file.
        /// </summary>
        public static void WriteToFile(DataTable dataTable) {
            string origFilePath = GetFile();
            string tempFile = "temp_file.csv";
            using (FileStream fs = File.Create(tempFile)) { }

            // Create stream to write to file with
            using (StreamWriter writer = new StreamWriter(tempFile)) {
                // Create csvwriter to write to the file as a csv
                using (CsvWriter csvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture)) {
                    // Setting the map so that entries get written into the correct columns
                    csvWrite.Context.RegisterClassMap<PasswordEntryMap>();

                    // Creating a list for the password entries
                    List<PasswordEntry> passwordEntries = new List<PasswordEntry>() { };

                    // Adding all the passwords to a list
                    foreach (DataRow row in dataTable.Rows) {
                        PasswordEntry passwordEntry = new PasswordEntry(row["id"].ToString(), row["group"].ToString(), row["title"].ToString(), row["user name"].ToString(),
                                                                                    row["password"].ToString(), row["url"].ToString(), row["notes"].ToString());
                        passwordEntries.Add(passwordEntry);
                    }

                    // Casting the password list to an IEnumerable
                    IEnumerable<PasswordEntry> enumData = passwordEntries;

                    csvWrite.WriteRecords(enumData);
                }
            }

            File.Delete(origFilePath);
            File.Move(tempFile, origFilePath);
            FileOP.LoadFile(origFilePath);
        }

        /// <summary>
        /// Logs the filepath to the console. Use for testing purposes.
        /// </summary>
        public static void PrintFileName() {
            Console.WriteLine(FileOP.GetFile());
        }
    }

    /// <summary>
    /// Maps the CSV file.
    /// </summary>
    public class PasswordEntryMap : ClassMap<PasswordEntry> {
        public PasswordEntryMap() {
            Map(m => m.Id).Index(0).Name("id");
            Map(m => m.Group).Index(1).Name("group");
            Map(m => m.Title).Index(2).Name("title");
            Map(m => m.Username).Index(3).Name("username");
            Map(m => m.Password).Index(4).Name("password");
            Map(m => m.Url).Index(5).Name("url");
            Map(m => m.Notes).Index(6).Name("notes");
        }
    }
}

