using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstPass;
using System;
using System.Data;
using System.IO;
using System.Linq;

namespace PasswordBankTests {

    /// <summary>
    /// Tests the methods in the FileOP class.
    /// </summary>
    [TestClass()]
    public class FileOPTests {
        private const string TestFile = @"TestFile.csv";
        private const string WriteToFileBase = @"..\..\..\TestResources\FileOPTestResources\WriteToFileBase.csv";
        private const string WriteToFileExpected = @"..\..\..\TestResources\FileOPTestResources\WriteToFileExpected.csv";
        private const string WriteLessLinesToFileBase = @"..\..\..\TestResources\FileOPTestResources\WriteLessLinesToFileBase.csv";

        /// <summary>
        /// Tests that data is written to a file.
        /// </summary>
        [TestMethod()]
        public void WriteToFileTest() {
            // Arrange
            WriteToFileTestReset();
            DataTable dataTable = CreateDataTable();

            // Act
            FileOP.WriteToFile(dataTable);

            // Assert
            Assert.IsTrue(CompareCSVs(TestFile, WriteToFileExpected));
        }

        /// <summary>
        /// Tests that data is properly written to a file after the user deletes a password entry.
        /// </summary>
        [TestMethod()]
        public void WriteLessLinesToFileTest() {
            // Arrange
            WriteLessLinesToFileTestReset();
            DataTable dataTable = CreateDataTable();

            // Act
            FileOP.WriteToFile(dataTable);

            // Assert
            Assert.IsTrue(CompareCSVs(TestFile, WriteToFileExpected));
        }

        /// <summary>
        /// Deletes files left over from previous tests and creates a fresh file for testing.
        /// </summary>
        private void WriteToFileTestReset() {
            if (File.Exists(TestFile)) {
                File.Delete(TestFile);
            }

            DirectoryInfo TestCSVInfo = new DirectoryInfo(WriteToFileBase);
            File.Copy(TestCSVInfo.FullName, TestFile);

            FileOP.LoadFile(TestFile);

            return;
        }

        /// <summary>
        /// Deletes files left over from previous tests and creates a fresh file for testing.
        /// </summary>
        private void WriteLessLinesToFileTestReset() {
            if (File.Exists(TestFile)) {
                File.Delete(TestFile);
            }

            DirectoryInfo TestCSVInfo = new DirectoryInfo(WriteLessLinesToFileBase);
            File.Copy(TestCSVInfo.FullName, TestFile);

            FileOP.LoadFile(TestFile);

            return;
        }

        /// <summary>
        /// Creates a datatable for testing.
        /// </summary>
        /// <returns>Data table containing test data</returns>
        private DataTable CreateDataTable() {
            DataTable dataTable = new DataTable();

            // Add the columns to the test DataTable
            dataTable.Columns.Add("id", typeof(String));
            dataTable.Columns.Add("expiration date", typeof(String));
            dataTable.Columns.Add("title", typeof(String));
            dataTable.Columns.Add("username", typeof(String));
            dataTable.Columns.Add("password", typeof(String));
            dataTable.Columns.Add("url", typeof(String));
            dataTable.Columns.Add("notes", typeof(String));

            // Add the first row to the test DataTable
            DataRow newRow = dataTable.NewRow();
            newRow["id"] = "id1";
            newRow["expiration date"] = "expiration date1";
            newRow["title"] = "title1";
            newRow["username"] = "username1";
            newRow["password"] = "password1";
            newRow["url"] = "url1";
            newRow["notes"] = "notes1";
            dataTable.Rows.Add(newRow);

            return dataTable;
        }

        /// <summary>
        /// Compares two CSVs and return false if they don't match.
        /// </summary>
        /// <param name="path1">First filepath</param>
        /// <param name="path2">Second filepath</param>
        /// <returns>Whether or not the files match</returns>
        public static bool CompareCSVs(string path1, string path2) {
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2 = new FileInfo(path2);

            return file1.Length == file2.Length && (file1.Length == 0 || File.ReadAllBytes(file1.FullName).SequenceEqual(File.ReadAllBytes(file2.FullName)));
        }
    }
}