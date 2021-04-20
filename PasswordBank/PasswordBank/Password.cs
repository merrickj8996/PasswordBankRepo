namespace FirstPass {
    using System;
    using System.Security.Cryptography;
    using System.Security;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Runtime.InteropServices;

    static partial class Password {
        public static string randomizePassword(int length, bool includeUppercase, bool includeNumbers, bool includeSymbols, bool includeBrackets) {
            string chars = "abcdefghijklmnopqrstuvwxyz"; //series of lowercase letters
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //series of uppercase letters
            string numbers = "1234567890"; //series of numbers
            string symbols = "~`!@#$%^&*_-+'=.;:?/"; //series of symbols
            string brackets = "(){}[]"; //series of brackets

            string genPass = ""; //blank string to be used as the final generated password

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

        public static SecureString SecureRandomizePassword(int length, bool includeUppercase, bool includeNumbers, bool includeSymbols, bool includeBrackets) {
            string chars = "abcdefghijklmnopqrstuvwxyz"; //series of lowercase letters
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //series of uppercase letters
            string numbers = "1234567890"; //series of numbers
            string symbols = "~`!@#$%^&*_-+'=.;:?/"; //series of symbols
            string brackets = "(){}[]"; //series of brackets

            SecureString genPass = new SecureString(); //blank securely stored string to be used as the final generated password

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

                genPass.AppendChar(chars[value]); //add character at the index of the random number to the genPass variable
            }

            return genPass;
        }

        public static double CheckStrength(string password)
        {
            // Initalizes double to store password strength at sets it to 0.
            double passwordStrength = 0;

            // If the password isn't more than 4 characters the password strength will be 0.
            if (password.Length <= 4)
            {
                return passwordStrength;
            }

            else
            {

                // If the password length is more than 4 it gets a score of at least 1 before multiplier.
                passwordStrength = 1;

                // If the password length is at least 8 it gets a score of at least 2 before multiplier.
                if (password.Length >= 8)
                {
                    passwordStrength = 2;
                }

                // If the password length is at least 12 it gets a score of at least 3 before multiplier.
                if (password.Length >= 12)
                {
                    passwordStrength = 3;
                }

                // If the password length is at tleast 15 it gets a score of at least 4 before multiplier.
                if (password.Length >= 15)
                {
                    passwordStrength = 4;
                }

                // If the password contains a space it gets an increase of 1.
                if (Regex.IsMatch(password, @" "))
                {
                    passwordStrength++;
                }

                // If the password contains a number it gets an increase of 1.
                if (Regex.IsMatch(password, @"\d"))
                {
                    passwordStrength++;
                }

                // If the password contains a upper and lower case letter it gets an increase of 1.
                if (Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"[A-Z]"))
                {
                    passwordStrength++;
                }

                // If the password contains a special character it gets an increase of 1.
                if (Regex.IsMatch(password, @"[`,!,@,#,$,%,^,&,*,_,+,=,;,:,?,/,(,),{,}]"))
                {
                    passwordStrength++;
                }

                // checks the number of unique characters in the password and stores it in uniqueCharacters
                int uniqueCharacters = password.Distinct().Count();

                // multiplier is intialized and set to 0.
                double mulitplier = 0;

                // If there are less than 2 unique characters the password strength is 0.
                if (uniqueCharacters >= 2)
                {
                    mulitplier = .5;
                }

                // If there are less than 5 unique characters, but at least 2 then the password strength
                // will be cut in half.
                if (uniqueCharacters >= 5)
                {
                    mulitplier = 1;
                }

                // If there are less than 8 unique characters, but at least 5 then the password strength
                // will be left the same.
                if (uniqueCharacters >= 8)
                {
                    mulitplier = 1.5;
                }

                // If there are less than 10 unique characters, but at least 8 then the password strength
                // will be increased by 50%.
                // If there are at least 10 unique characters the password strength is doubled.
                if (uniqueCharacters >= 10)
                {
                    mulitplier = 2;
                }

                // Multiplier is applied to password strength.
                passwordStrength *= mulitplier;

                return passwordStrength;
            }
        }

        //!!This method exists for proof of work and concept. SecureString will not be implemented in this program.!!
        public static SecureString ConvertToSecureString(string str)
        {
            SecureString final = new SecureString();

            for (int i = 0; i < str.Length; i++)
            {
                final.AppendChar(str[i]);
            }

            return final;
        }

        //!!This method exists for proof of work and concept. SecureString will not be implemented in this program.!!
        public static bool compare(SecureString compared, SecureString toCompare)
        {
            if (toCompare == null)
            { //if first SecureString is null, throw exception
                throw new ArgumentNullException("toCompareIsNull");
            }
            if (compared == null)
            { //if second SecureString is null, throw exception
                throw new ArgumentNullException("comparedIsNull");
            }

            if (toCompare.Length != compared.Length)
            { //if SecureStrings are not of equal length, return false
                return false;
            }

            IntPtr toComparePtr = IntPtr.Zero; //create pointer for first SecureString
            IntPtr comparedPtr = IntPtr.Zero; //create pointer for second SecureString

            try
            {
                toComparePtr = Marshal.SecureStringToBSTR(toCompare); //set pointer to point to first SecureString
                comparedPtr = Marshal.SecureStringToBSTR(compared); //set pointer to point to second SecureString

                String str1 = Marshal.PtrToStringBSTR(toComparePtr); //make string equal to encrypted value of first SecureString
                String str2 = Marshal.PtrToStringBSTR(comparedPtr); //make string equal to encrypted value of second SecureString

                return str1.Equals(str2); //return if encrypted values of the SecureStrings are equal
            }

            finally
            {
                if (toComparePtr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(toComparePtr); //frees first pointer if needed
                }

                if (comparedPtr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(comparedPtr); //frees second pointer if needed
                }
            }
        }
    }
}
