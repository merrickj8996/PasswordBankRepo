using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace FirstPass {

    /// <summary>
    /// Contains all the methods for file encryption and decryption
    /// </summary>
    public static class Crypto {

        #region memberVariables
        private static readonly int mIter = 50000;
        private static readonly int mKeyLength = 256;
        private static readonly int mBlockSize = 128;

        //Stores password so it can be automatically used to lock the database after closing the file. 
        //This should be stored as a secure string in the future.
        public static String mPassTemp = "";
        //public static SecureString mPassTemp;
        #endregion

        //Generates Salt for use with password. 
        public static byte[] SaltGen() {
            byte[] salt = new byte[32];
            using (RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider()) {
                rngCryptoServiceProvider.GetBytes(salt);
            }
            return salt;
        }

        //Takes a file name and string password and encrypts the file. 
        public static bool EncryptFile(string inFile, string password) {
            byte[] salt = SaltGen();
            byte[] passwords = Encoding.UTF8.GetBytes(password);
            AesManaged AES = new AesManaged {
                KeySize = mKeyLength,
                BlockSize = mBlockSize,
                Padding = PaddingMode.PKCS7
            };
            var key = new Rfc2898DeriveBytes(passwords, salt, mIter);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            //AES.Mode = CipherMode.CFB;
            try {

                //Creates a new file stream to temporarilty store encrypted data.
                using (FileStream fileCrypto = new FileStream(inFile + ".temp", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None)) {

                    //Writes the salt to the head of the file
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
                    File.Move(inFile + ".temp", inFile);
                    return true;
                }
            }
            catch (CryptographicException ex_CryptographicException) {
                Console.WriteLine("CryptograpicException error: " + ex_CryptographicException);
                File.Delete(inFile + ".temp");
                return false;
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                File.Delete(inFile + ".temp");
                return false;
            }

        }
        public static bool DecryptFile(string inFile, string password) {
            byte[] passwords = Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];
            using (FileStream fileCrypto = new FileStream(inFile, FileMode.Open)) {
                fileCrypto.Read(salt, 0, salt.Length);
                AesManaged AES = new AesManaged {
                    KeySize = mKeyLength,
                    BlockSize = mBlockSize,
                    Padding = PaddingMode.PKCS7
                };
                var key = new Rfc2898DeriveBytes(passwords, salt, mIter);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                //AES.Mode = CipherMode.CFB;
                try {
                    using (CryptoStream cryptoStream = new CryptoStream(fileCrypto, AES.CreateDecryptor(), CryptoStreamMode.Read)) {
                        using (FileStream fileStreamOut = new FileStream(inFile + ".temp", FileMode.Create)) {
                            int read;
                            byte[] buffer = new byte[1048576];
                            while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0) {
                                fileStreamOut.Write(buffer, 0, read);
                            }
                        }
                    }
                    File.Delete(inFile);
                    File.Move(inFile + ".temp", inFile);
                    return true;
                }
                catch (CryptographicException ex_CryptographicException) {
                    Console.WriteLine("CryptograpicException error: " + ex_CryptographicException);
                    File.Delete(inFile + ".temp");
                    return false;
                }
                catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                    File.Delete(inFile + ".temp");
                    return false;
                }

            }

        }
    }
}
