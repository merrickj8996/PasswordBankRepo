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

    public static class Password
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
}
