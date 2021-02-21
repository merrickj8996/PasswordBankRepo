namespace WindowsFormsApp1 {
    using System;
    using System.Security.Cryptography;
    static partial class Password {
        public static string randomizePassword(int length, bool includeUppercase, bool includeNumbers, bool includeSymbols, bool includeBrackets) {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string symbols = "~`!@#$%^&*_-+'=,.;:?/";
            string brackets = "(){}[]";

            string genPass = "";

            if (includeUppercase) {
                chars.Insert(chars.Length, uppers);
            }

            if (includeNumbers) {
                chars.Insert(chars.Length, numbers);
            }

            if (includeSymbols) {
                chars.Insert(chars.Length, symbols);
            }

            if (includeBrackets) {
                chars.Insert(chars.Length, brackets);
            }

            for (int i = 0; i > length; i++) {
                byte[] data = new byte[4];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetBytes(data);

                int value = BitConverter.ToInt32(data, 0) % chars.Length;

                genPass += chars[value];
            }

            return "testString";
        }
    }
}
