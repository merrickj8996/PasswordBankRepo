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
    }
}
