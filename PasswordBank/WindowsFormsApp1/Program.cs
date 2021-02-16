using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MasterForm());
        }
    }

    public static partial class Password
    {
        public static double checkStrength(string password) {
            // Initalizes double to store password strength at sets it to 0.
            double passwordStrength = 0;

            // If the password isn't more than 4 characters the password strength will be 0.
            if (password.Length <= 4) {
                return passwordStrength;
            }

            else {

                // If the password length is more than 4 it gets a score of at least 1 before multiplier.
                passwordStrength = 1;

                // If the password length is at least 8 it gets a score of at least 2 before multiplier.
                if (password.Length >= 8) {
                    passwordStrength = 2;
                }

                // If the password length is at least 12 it gets a score of at least 3 before multiplier.
                if (password.Length >= 12) {
                    passwordStrength = 3;
                }

                // If the password length is at tleast 15 it gets a score of at least 4 before multiplier.
                if (password.Length >= 15) {
                    passwordStrength = 4;
                }

                // If the password contains a space it gets an increase of 1.
                if (Regex.IsMatch(password, @" ")) {
                    passwordStrength++;
                }

                // If the password contains a number it gets an increase of 1.
                if (Regex.IsMatch(password, @"\d")) {
                    passwordStrength++;
                }

                // If the password contains a upper and lower case letter it gets an increase of 1.
                if (Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"[A-Z]")) {
                    passwordStrength++;
                }

                // If the password contains a special character it gets an increase of 1.
                if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,£,(,)]")) {
                    passwordStrength++;
                }

                // checks the number of unique characters in the password and stores it in uniqueCharacters
                int uniqueCharacters = password.Distinct().Count();

                // multiplier is intialized and set to 0.
                double mulitplier = 0;

                // If there are less than 2 unique characters the password strength is 0.
                if (uniqueCharacters >= 2) {
                    mulitplier = .5;
                }

                // If there are less than 5 unique characters, but at least 2 then the password strength
                // will be cut in half.
                if (uniqueCharacters >= 5) {
                    mulitplier = 1;
                }

                // If there are less than 8 unique characters, but at least 5 then the password strength
                // will be left the same.
                if (uniqueCharacters >= 8) {
                    mulitplier = 1.5;
                }

                // If there are less than 10 unique characters, but at least 8 then the password strength
                // will be increased by 50%.
                // If there are at least 10 unique characters the password strength is doubled.
                if (uniqueCharacters >= 10) {
                    mulitplier = 2;
                }

                // Multiplier is applied to password strength.
                passwordStrength = passwordStrength * mulitplier;

                return passwordStrength;
            }
        }
        public static string HashSHA256(string data) {
            using (SHA256 sha256Hash = SHA256.Create()) {
                //compute the hash. store in byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
    public static class BankFile {

        // Compresses all files in a folder using GZip
        public static void Compress(DirectoryInfo fileDirectory) {

            // For loop lets each file in directory get compressed
            foreach (FileInfo fileToCompress in fileDirectory.GetFiles()) {

                // Creates a File Stream containing the data in the fileToCompress
                using (FileStream originalFileStream = fileToCompress.OpenRead()) {

                    // Check that the file is not hidden or already a .gz file
                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz") {

                        // Creates a File Stream for the compressed file
                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz")) {

                            // Creates the compression stream
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress)) {

                                // Compresses file
                                originalFileStream.CopyTo(compressionStream);
                            }
                        }
                    }
                }
            }
        }

        // Decompresses a file using GZip
        public static void Decompress(FileInfo fileToDecompress) {
            
            // Creates a FileStream containing the data from fileToDecompress
            using (FileStream originalFileStream = fileToDecompress.OpenRead()) {

                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                // Creates the decompressed file stream
                using (FileStream decompressedFileStream = File.Create(newFileName)) {

                    // Creates the compression stream
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress)) {

                        // Decompresses file
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }
    }
    static class Crypto {
        #region memberVariables
        private static int mIter = 50000;
        private static int mKeyLength = 256;
        private static int mBlockSize = 128;
        #endregion

        //Generates Salt for use with password. 
        public static byte[] SaltGen() {
            byte[] salt = new byte[32];
            using (RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider()) {
                rngCryptoServiceProvider.GetBytes(salt);
            }
            return salt;
        }

        //Takes a file name and password and encrypts the file. 
        public static void EncryptFile(string inFile, string password) {
            byte[] salt = SaltGen();
            byte[] passwords = Encoding.UTF8.GetBytes(password);
            AesManaged AES = new AesManaged();
            AES.KeySize = mKeyLength;
            AES.BlockSize = mBlockSize;
            AES.Padding = PaddingMode.PKCS7;
            var key = new Rfc2898DeriveBytes(passwords, salt, mIter);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            //AES.Mode = CipherMode.CFB;
            try {
                using (FileStream fileCrypto = new FileStream(inFile + ".aes", FileMode.Create)) {
                    fileCrypto.Write(salt, 0, salt.Length);
                    using (CryptoStream cryptoStream = new CryptoStream(fileCrypto, AES.CreateEncryptor(), CryptoStreamMode.Write)) {
                        using (FileStream fileStreamIn = new FileStream(inFile, FileMode.Open)) {
                            byte[] buffer = new byte[1048576];
                            int read;
                            while ((read = fileStreamIn.Read(buffer, 0, buffer.Length)) > 0) {
                                cryptoStream.Write(buffer, 0, read);
                            }
                        }
                    }
                    File.Delete(inFile);
                }
            }
            catch (CryptographicException ex_CryptographicException) {
                Console.WriteLine("CryptograpicException error: " + ex_CryptographicException);
                File.Delete(inFile + ".aes");
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                File.Delete(inFile + ".aes");
            }

        }
        public static void DecryptFile(string inFile, string outFile, string password) {
            byte[] passwords = Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];
            using (FileStream fileCrypto = new FileStream(inFile, FileMode.Open)) {
                fileCrypto.Read(salt, 0, salt.Length);
                AesManaged AES = new AesManaged();
                AES.KeySize = mKeyLength;
                AES.BlockSize = mBlockSize;
                var key = new Rfc2898DeriveBytes(passwords, salt, mIter);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Padding = PaddingMode.PKCS7;
                //AES.Mode = CipherMode.CFB;
                try {
                    using (CryptoStream cryptoStream = new CryptoStream(fileCrypto, AES.CreateDecryptor(), CryptoStreamMode.Read)) {
                        using (FileStream fileStreamOut = new FileStream(outFile, FileMode.Create)) {
                            int read;
                            byte[] buffer = new byte[1048576];
                            while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0) {
                                fileStreamOut.Write(buffer, 0, read);
                            }
                        }
                    }
                    File.Delete(inFile);
                }
                catch (CryptographicException ex_CryptographicException) {
                    Console.WriteLine("CryptograpicException error: " + ex_CryptographicException);
                    File.Delete(outFile);
                }
                catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                    File.Delete(outFile);
                }

            }

        }
    }
}

