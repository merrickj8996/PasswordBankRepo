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
        private const string ReadFileTestFile = @"..\..\..\TestResources\FileOPTestResources\ReadFileTestFile.csv";

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
            Assert.IsTrue(AreCSVsEqual(TestFile, WriteToFileExpected));
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
            Assert.IsTrue(AreCSVsEqual(TestFile, WriteToFileExpected));
        }

        /// <summary>
        /// Tests that a file gets read correctly.
        /// </summary>
        [TestMethod()]
        public void ReadFileTest() {
            // Arrange
            FileOP.LoadFile(ReadFileTestFile);
            DataTable expected = CreateDataTable();

            // Act
            DataTable actual = FileOP.ReadFile();

            // Assert
            Assert.IsTrue(AreDataTablesEqual(actual, expected));
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
        public static bool AreCSVsEqual(string path1, string path2) {
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2 = new FileInfo(path2);

            return file1.Length == file2.Length && (file1.Length == 0 || File.ReadAllBytes(file1.FullName).SequenceEqual(File.ReadAllBytes(file2.FullName)));
        }

        /// <summary>
        /// Checks that two DataTables are equivalent.
        /// </summary>
        /// <param name="dataTable1">First DataTable</param>
        /// <param name="dataTable2">Second DataTable</param>
        /// <returns>Boolean indicating if the DataTables were equivalent</returns>
        public static bool AreDataTablesEqual(DataTable dataTable1, DataTable dataTable2) {
            // Check that the number of rows and columns are equivalent
            if (dataTable1.Rows.Count != dataTable2.Rows.Count || dataTable1.Columns.Count != dataTable2.Columns.Count) {
                return false;
            }
            // Go through each row and check that they are equivalent
            else {
                foreach (DataRow dataTable1Row in dataTable1.Rows) {
                    foreach (DataRow dataTable2Row in dataTable2.Rows) {
                        var array1 = dataTable1Row.ItemArray;
                        var array2 = dataTable2Row.ItemArray;

                        if (!array1.SequenceEqual(array2)) {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}