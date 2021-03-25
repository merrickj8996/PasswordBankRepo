using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstPass;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace PasswordBankTests {
    /// <summary>
    /// Tests the methods in the Crypto class.
    /// </summary>
    [TestClass()]
    public class CryptoTests {
        private const string ActualTestFile = "TestFile.csv";
        private const string ExpectedDecryptTestFile = @"..\..\..\TestResources\CryptoTestResources\ExpectedDecryptTestFile.csv";
        private const string OriginalEncryptedFile = @"..\..\..\TestResources\CryptoTestResources\OriginalEncryptedFile.csv";
        private const string OriginalUnencryptedFile = @"..\..\..\TestResources\CryptoTestResources\OriginalUnencryptedFile.csv";
        private const string Password = "password";

        /// <summary>
        /// Tests that salt is generated.
        /// </summary>
        [TestMethod()]
        public void SaltGenTest() {
            // Act
            byte[] actual = Crypto.SaltGen();

            // Assert
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Tests that an encrypted file is not equivalent to the unencrypted version.
        /// </summary>
        [TestMethod()]
        public void EncryptFileTest() {
            // Arrange
            EncryptTestReset();

            // Act
            Crypto.EncryptFile(ActualTestFile, Password);

            // Assert
            Assert.IsFalse(CompareCSVs(ActualTestFile, OriginalUnencryptedFile));
        }
        
        /// <summary>
        /// Tests that a file gets decrypted and the contents are as they should be.
        /// </summary>
        [TestMethod()]
        public void DecryptFileTest() {
            // Arrange
            DecryptTestReset();
            
            // Act
            Crypto.DecryptFile(ActualTestFile, Password);

            // Assert
            Assert.IsTrue(CompareCSVs(ActualTestFile, ExpectedDecryptTestFile));
        }
        

        /// <summary>
        /// Removes any files from previous tests and then creates a file to be encrypted.
        /// </summary>
        private void EncryptTestReset() {
            // Make sure that an encrypted file does not already exist.
            if (File.Exists(ActualTestFile)) {
                File.Delete(ActualTestFile);
            }

            // Creates a file to be encrypted.
            DirectoryInfo baseEncryptTestFile = new DirectoryInfo(OriginalUnencryptedFile);
            File.Copy(baseEncryptTestFile.FullName, ActualTestFile);

            return;
        }

        /// <summary>
        /// Removes any files from previous tests and then creates an encrypted file to be decrypted.
        /// </summary>
        private void DecryptTestReset() {
            // Make sure that a decrypted file does not already exist
            if (File.Exists(ActualTestFile)) {
                File.Delete(ActualTestFile);
            }

            // Creates a file to be decrypted
            DirectoryInfo baseEncryptedFile = new DirectoryInfo(OriginalEncryptedFile);
            File.Copy(baseEncryptedFile.FullName, ActualTestFile);

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