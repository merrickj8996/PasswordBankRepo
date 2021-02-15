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
    }
}
