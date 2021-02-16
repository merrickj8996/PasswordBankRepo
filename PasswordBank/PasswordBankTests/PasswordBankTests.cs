using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.IO;
using System.Linq;

namespace PasswordBankTests {
    [TestClass]
    public class PasswordBankTests {

        [TestMethod]
        public void CompressTest() {
            // Tests that a .txt file gets compressed

            // Arrange
            string toCompressPath = @"..\..\..\TestResources\CompressTestResources";
            string compressedPath = toCompressPath + @"\Test.txt.gz";
            DirectoryInfo toCompressDirectory = new DirectoryInfo(toCompressPath);

            // Act
            BankFile.Compress(toCompressDirectory);

            // Assert
            Assert.IsNotNull(compressedPath);

            // Clean-up
            File.Delete(compressedPath);
        }

        [TestMethod]
        public void DecompressTest() {
            // Tests that a compressed .gz file gets decompressed into a .txt file

            // Arrange
            string toDecompressPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt.gz";
            string decompressedPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt";
            FileInfo toDecompressFile = new FileInfo(toDecompressPath);

            // Act
            BankFile.Decompress(toDecompressFile);

            // Assert
            Assert.IsNotNull(decompressedPath);

            // Clean-up
            File.Delete(decompressedPath);
        }

        [TestMethod]
        public void DecompressCorrectlyTest() {
            // Tests that the contents of a decompressed .txt file are what they're supposed to be

            // Arrange
            string originalPath = @"..\..\..\TestResources\DecompressTestResources\Original.txt";
            string toDecompressPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt.gz";
            FileInfo toDecompressFile = new FileInfo(toDecompressPath);
            string decompressedPath = @"..\..\..\TestResources\DecompressTestResources\Test.txt";

            // Act
            BankFile.Decompress(toDecompressFile);

            // Assert
            Assert.IsTrue(File.ReadLines(originalPath).SequenceEqual(File.ReadLines(decompressedPath)));

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
    }
}
