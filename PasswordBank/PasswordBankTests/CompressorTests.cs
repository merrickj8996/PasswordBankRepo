using FirstPass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace PasswordBankTests {
    [TestClass()]
    public class CompressorTests {

        private const string CompressedTestCSV = @"..\..\..\TestResources\DataFilledFile.csv.gz";
        private const string UncompressedTestCSV = @"..\..\..\TestResources\DataFilledFile.csv";
        private const string CompressedFile = @"TestCSV.csv.gz";
        private const string UncompressedFile = @"TestCSV.csv";

        /// <summary>
        /// Tests that a file gets compressed.
        /// </summary>
        [TestMethod]
        public void CompressTest() {
            // Arrange
            CompressTestReset();

            // Act
            Compressor.Compress(UncompressedFile);

            // Assert
            Assert.IsTrue(File.Exists(CompressedFile));
        }

        /// <summary>
        /// Tests that the uncompressed file gets deleted after compression occurs.
        /// </summary>
        [TestMethod]
        public void DeleteAfterCompressTest() {
            // Arrange
            CompressTestReset();

            // Act
            Compressor.Compress(UncompressedFile);

            // Assert
            Assert.IsFalse(File.Exists(UncompressedFile));
        }

        /// <summary>
        /// Tests that a compressed file gets decompressed.
        /// </summary>
        [TestMethod]
        public void DecompressTest() {
            // Arrange
            DecompressTestReset();

            // Act
            Compressor.Decompress(CompressedFile);

            // Assert
            Assert.IsTrue(File.Exists(UncompressedFile));
        }

        /// <summary>
        /// Tests that the contents of a decompressed file are what they are supposed to be.
        /// </summary>
        [TestMethod]
        public void DecompressCorrectlyTest() {
            // Arrange
            DecompressTestReset();

            // Act
            Compressor.Decompress(CompressedFile);

            // Assert
            Assert.IsTrue(CompareCSVs(UncompressedFile, UncompressedTestCSV));
        }


        /// <summary>
        /// Tests that the compressed file gets deleted after decompression.
        /// </summary>
        [TestMethod]
        public void DeletionAfterDecompressTest() {
            // Arrange
            DecompressTestReset();

            // Act
            Compressor.Decompress(CompressedFile);

            // Assert
            Assert.IsFalse(File.Exists(CompressedFile));
        }

        /// <summary>
        /// Removes the compressed file created by previous compression tests
        /// and creates an uncompressed file to be tested with.
        /// </summary>
        private void CompressTestReset() {

            if (!File.Exists(UncompressedFile)) {
                DirectoryInfo TestCSVInfo = new DirectoryInfo(UncompressedTestCSV);
                File.Copy(TestCSVInfo.FullName, UncompressedFile);
            }

            if (File.Exists(CompressedFile)) {
                File.Delete(CompressedFile);
            }

            FileOP.LoadFile(UncompressedFile);

            return;
        }

        /// <summary>
        /// Removes the uncompressed file created by previous decompression tests
        /// and creates an compressed file to be tested with.
        /// </summary>
        private void DecompressTestReset() {

            if (!File.Exists(CompressedFile)) {
                DirectoryInfo TestCSVInfo = new DirectoryInfo(CompressedTestCSV);
                File.Copy(TestCSVInfo.FullName, CompressedFile);
            }

            if (File.Exists(UncompressedFile)) {
                File.Delete(UncompressedFile);
            }

            FileOP.LoadFile(CompressedFile);

            return;
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
