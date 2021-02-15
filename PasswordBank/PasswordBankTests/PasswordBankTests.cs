using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.IO;

namespace PasswordBankTests {
    [TestClass]
    public class PasswordBankTests {

        [TestMethod]
        public void compressTest() {
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
    }
}
