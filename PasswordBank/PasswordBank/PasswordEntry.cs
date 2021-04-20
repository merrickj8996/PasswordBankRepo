namespace FirstPass {

    /// <summary>
    /// Contains all the data for a password entry.
    /// </summary>
    public class PasswordEntry {

        // Declaration of all the variables corresponding to columns in the data table
        public string Expiration_Date { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string Notes { get; set; }

        public PasswordEntry(string group, string title, string username, string password, string url, string notes) {
            Expiration_Date = group;
            Title = title;
            Username = username;
            Password = password;
            Url = url;
            Notes = notes;
        }
    }
}
