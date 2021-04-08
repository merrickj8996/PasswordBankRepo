using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Security;
using System.Runtime.InteropServices;

namespace FirstPass {

    static class Program {

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
}

