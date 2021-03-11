namespace FirstPass {
    using System;
    using System.Security.Cryptography;
    using System.Security;
    static partial class Password {
        public static String randomizePassword(int length, bool includeUppercase, bool includeNumbers, bool includeSymbols, bool includeBrackets) {
            string chars = "abcdefghijklmnopqrstuvwxyz"; //series of lowercase letters
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //series of uppercase letters
            string numbers = "1234567890"; //series of numbers
            string symbols = "~`!@#$%^&*_-+'=.;:?/"; //series of symbols
            string brackets = "(){}[]"; //series of brackets

            String genPass = ""; //blank string to be used as the final generated password

            if (includeUppercase) { //if passed in that the consumer wants uppercase letters, append "uppercase" to the chars string 
                chars += uppers;
            }

            if (includeNumbers) { //if passed in that the consumer wants numbers, append "uppercase" to the chars string 
                chars += numbers;
            }

            if (includeSymbols) { //if passed in that the consumer wants symbols, append "uppercase" to the chars string 
                chars += symbols;
            }

            if (includeBrackets) { //if passed in that the consumer wants brackets, append "uppercase" to the chars string 
                chars += brackets;
            }

            for (int i = 0; i < length; i++) { //loops grabbing a random character and appending to genPass a number of times equal to the requested length
                byte[] data = new byte[4]; //creates a temporary byte for the rng variable to use in the randomization process
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider(); //creates temporary rng variable
                rng.GetBytes(data); //connects the rng variable to the data variable

                int value = Math.Abs(BitConverter.ToInt32(data, 0) % chars.Length); //take random number generated (mod the length of the chars string) to append

                genPass += (chars[value]); //add character at the index of the random number to the genPass variable
            }

            return genPass;
        }
    }
}
