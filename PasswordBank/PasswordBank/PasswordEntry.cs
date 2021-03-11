using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPass {

    /// <summary>
    /// Contains all the data for a password entry.
    /// </summary>
    public class PasswordEntry {
        public string Id { get; set; }
        public string Group { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string Notes { get; set; }

        public PasswordEntry(string id, string group, string title, string username, string password, string url, string notes) {
            Id = id;
            Group = group;
            Title = title;
            Username = username;
            Password = password;
            Url = url;
            Notes = notes;
        }
    }
}
