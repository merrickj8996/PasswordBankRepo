using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstPass;
using System.Data;
using System.IO;
using System.Linq;
using System;

namespace PasswordBankTests {
    [TestClass]
    public class PasswordBankTests {

        [TestMethod]
        public void CompressTest() {
            // Tests that a .txt file gets compressed

            // Arrange
            string toCompressPath = @"..\..\..\TestResources\CompressTestResources\Test.txt";
            if (!File.Exists(toCompressPath)) {
                using (StreamWriter sw = File.CreateText(toCompressPath)) {
                    sw.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
                }
            }
            string compressedPath = @"..\..\..\TestResources\CompressTestResources\Test.txt.gz";

            // Act
            Compressor.Compress(toCompressPath);

            // Assert
            Assert.IsTrue(File.Exists(compressedPath));

            // Clean-up
            File.Delete(compressedPath);
        }

        [TestMethod]
        public void DeleteAfterCompressTest() {
            // Tests that the .txt file is deleted after compression

            // Arrange
            string toCompressPath = @"..\..\..\TestResources\CompressTestResources\Test.txt";
            if (!File.Exists(toCompressPath)) {
                using (StreamWriter sw = File.CreateText(toCompressPath)) {
                    sw.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
                }
            }
            string compressedPath = @"..\..\..\TestResources\CompressTestResources\Test.txt.gz";

            // Act
            Compressor.Compress(toCompressPath);

            // Assert
            Assert.IsFalse(File.Exists(toCompressPath));

            // Clean-up
            File.Delete(compressedPath);
        }

        
        [TestMethod]
        public void DecompressTest() {
            // Tests that a compressed .gz file gets decompressed into a .txt file

            // Arrange
            
            // Ensuring there is a .gz file to be decompressed
            string decompressedPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt";
            if (!File.Exists(decompressedPath)) {
                using (StreamWriter sw = File.CreateText(decompressedPath)) {
                    sw.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
                }
            }
            Compressor.Compress(decompressedPath);

            string toDecompressPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt.gz";

            // Act
            Compressor.Decompress(toDecompressPath);

            // Assert
            Assert.IsTrue(File.Exists(decompressedPath));

            // Clean-up
            File.Delete(decompressedPath);
        }

        [TestMethod]
        public void DecompressCorrectlyTest() {
            // Tests that a compressed .gz file gets decompressed into a .txt file

            // Arrange

            // Ensuring there is a .gz file to be decompressed
            string decompressedPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt";
            if (!File.Exists(decompressedPath)) {
                using (StreamWriter sw = File.CreateText(decompressedPath)) {
                    sw.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
                }
            }
            Compressor.Compress(decompressedPath);

            string toDecompressPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt.gz";
            string comparatorPath = @"..\..\..\TestResources\DecompressTestResources\comparator.txt";

            // Act
            Compressor.Decompress(toDecompressPath);

            // Assert
            Assert.IsTrue(File.ReadLines(comparatorPath).SequenceEqual(File.ReadLines(decompressedPath)));

            // Clean-up
            File.Delete(decompressedPath);
        }

        [TestMethod]
        public void DeletionAfterDecompressTest() {
            // Tests that a compressed .gz file gets decompressed into a .txt file

            // Arrange

            // Ensuring there is a .gz file to be decompressed
            string decompressedPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt";
            if (!File.Exists(decompressedPath)) {
                using (StreamWriter sw = File.CreateText(decompressedPath)) {
                    sw.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
                }
            }
            Compressor.Compress(decompressedPath);

            string toDecompressPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt.gz";

            // Act
            Compressor.Decompress(toDecompressPath);

            // Assert
            Assert.IsFalse(File.Exists(toDecompressPath));

            // Clean-up
            File.Delete(decompressedPath);
        }

        [TestMethod]
        public void Sha256Test() {

            string testPassword = "password";
            string hashedPassword;

            //act
            hashedPassword = Password.HashSHA256(testPassword);

            //assert
            Assert.IsFalse(hashedPassword.Equals(testPassword));
        }

        [TestMethod]
        public void PasswordIsAlwaysSameSha256Test() {
            //this test verifies that the hashing algorithm will always gnereate the same string based on the same input
            string testPassword = "password";
            string hashedPassword;
            string hashedPassword2;

            //Act
            hashedPassword = Password.HashSHA256(testPassword);
            hashedPassword2 = Password.HashSHA256(testPassword);

            //Assert
            Assert.IsTrue(hashedPassword.Equals(hashedPassword2));
        }

        [TestMethod]
        public void TwoDifferentPasswordsSha256Test() {
            //this test verifies that two different passwords hash to different values.
            string testPassword = "password";
            string testPassword2 = "PassWord";
            string hashedPassword;
            string hashedPassword2;

            //Act
            hashedPassword = Password.HashSHA256(testPassword);
            hashedPassword2 = Password.HashSHA256(testPassword2);

            //Assert
            Assert.IsFalse(hashedPassword.Equals(hashedPassword2));
        }

        [TestMethod]
        public void WriteToFileTest() {
            // Tests that a single new entry gets to an empty CSV correctly

            // Arrange
            string testFilePath = @"..\..\..\TestResources\WriteToFileTestFile.csv";
            string comparatorFilePath = @"..\..\..\TestResources\WriteToFileTestComparator.csv";
            FileOP.LoadFile(testFilePath);

            DataTable testTable = new DataTable();
            testTable.Clear();
            testTable.Columns.Add("id");
            testTable.Columns.Add("group");
            testTable.Columns.Add("title");
            testTable.Columns.Add("user name");
            testTable.Columns.Add("password");
            testTable.Columns.Add("url");
            testTable.Columns.Add("notes");

            testTable.Rows.Add("0", "test group", "test title", "test username", "test password", "test url", "test notes");
            testTable.AcceptChanges();

            // Act
            FileOP.WriteToFile(testTable);

            // Assert
            bool equals = File.ReadAllBytes(testFilePath).SequenceEqual(File.ReadAllBytes(comparatorFilePath));
            Assert.IsTrue(equals);
        }

        [TestMethod]
        public void WriteMultipleLinesTest() {
            // Tests that a multiple entries to a new file

            // Arrange
            string testFilePath = @"..\..\..\TestResources\WriteMultipleLinesTestFile.csv";
            string comparatorFilePath = @"..\..\..\TestResources\WriteMultipleLinesTestComparator.csv";
            FileOP.LoadFile(testFilePath);

            DataTable multiLineTestTable = new DataTable();
            multiLineTestTable.Clear();
            multiLineTestTable.Columns.Add("id");
            multiLineTestTable.Columns.Add("group");
            multiLineTestTable.Columns.Add("title");
            multiLineTestTable.Columns.Add("user name");
            multiLineTestTable.Columns.Add("password");
            multiLineTestTable.Columns.Add("url");
            multiLineTestTable.Columns.Add("notes");

            multiLineTestTable.Rows.Add("0", "test group", "test title", "test username", "test password", "test url", "test notes");
            multiLineTestTable.Rows.Add("0", "test group2", "test title2", "test username2", "test password2", "test url2", "test notes2");
            multiLineTestTable.Rows.Add("0", "test group3", "test title3", "test username3", "test password3", "test url3", "test notes3");
            multiLineTestTable.Rows.Add("0", "test group4", "test title4", "test username4", "test password4", "test url4", "test notes4");
            multiLineTestTable.Rows.Add("0", "test group5", "test title5", "test username5", "test password5", "test url5", "test notes5");
            multiLineTestTable.AcceptChanges();

            // Act
            FileOP.WriteToFile(multiLineTestTable);

            // Assert
            bool equals = File.ReadAllBytes(testFilePath).SequenceEqual(File.ReadAllBytes(comparatorFilePath));
            Assert.IsTrue(equals);
        }

        [TestMethod]
        public void WriteLessLinesTest() {
            // Tests that a multiple entries to a new file

            // Arrange
            string testFilePath = @"..\..\..\TestResources\WriteLessLinesTestFile.csv";
            string comparatorFilePath = @"..\..\..\TestResources\WriteLessLinesTestComparator.csv";
            FileOP.LoadFile(testFilePath);

            DataTable lessLinesTestTable = new DataTable();
            lessLinesTestTable.Clear();
            lessLinesTestTable.Columns.Add("id");
            lessLinesTestTable.Columns.Add("group");
            lessLinesTestTable.Columns.Add("title");
            lessLinesTestTable.Columns.Add("user name");
            lessLinesTestTable.Columns.Add("password");
            lessLinesTestTable.Columns.Add("url");
            lessLinesTestTable.Columns.Add("notes");

            lessLinesTestTable.Rows.Add("0", "test group", "test title", "test username", "test password", "test url", "test notes");
            lessLinesTestTable.Rows.Add("0", "test group2", "test title2", "test username2", "test password2", "test url2", "test notes2");
            lessLinesTestTable.Rows.Add("0", "test group3", "test title3", "test username3", "test password3", "test url3", "test notes3");
            lessLinesTestTable.AcceptChanges();

            // Act
            FileOP.WriteToFile(lessLinesTestTable);

            // Assert
            bool equals = File.ReadAllBytes(testFilePath).SequenceEqual(File.ReadAllBytes(comparatorFilePath));
            Assert.IsTrue(equals);
        }
    }
}