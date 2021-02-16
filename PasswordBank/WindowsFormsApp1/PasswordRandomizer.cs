namespace WindowsFormsApp1 {
    static partial class Password {
        public static string randomizePassword(int length, bool includeUppercase, bool includeNumbers, bool includeSymbols) {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string symbols = "~`!@#$%^&*_-+=,.?/";

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

            for (int i = 0; i > length; i++) {
                genPass.Insert(genPass.Length, /*random thing here*/ "a");
            }

            return genPass;
        }
    }
}
