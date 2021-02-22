using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class MasterPasswordPrintPopUp : Form {


        private string m_masterPassword;

        public MasterPasswordPrintPopUp() {
            InitializeComponent();
        }

        public MasterPasswordPrintPopUp(string masterPassword) {
            InitializeComponent();
            m_masterPassword = masterPassword;
        }

        private PrintDocument masterPasswordDoc = new PrintDocument();

        private void printButton_Click(object sender, EventArgs e) {

            using (StreamWriter passwordFile = new StreamWriter("password.txt")) {
                passwordFile.WriteLine("Password Bank Password: " + m_masterPassword);
            }

            using (StreamReader streamToPrint = new StreamReader("password.txt")) {
                Font printFont = new Font("Arial", 10);
                masterPasswordDoc.PrintPage += new PrintPageEventHandler(this.MasterPasswordDoc_PrintPage);
            }

            masterPasswordPrintDialog.Document = masterPasswordDoc;

            DialogResult result = masterPasswordPrintDialog.ShowDialog();

            if (result == DialogResult.OK)
                masterPasswordDoc.Print();

            File.Delete("password.txt");

            this.Close();
        }

        // The PrintPage event is raised for each page to be printed.
        private void MasterPasswordDoc_PrintPage(object sender, PrintPageEventArgs ev) {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Arial", 10);

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            using(StreamReader streamToPrint = new StreamReader("password.txt")) {
                // Print each line of the file.
                while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null)) {
                    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                    count++;
                }
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void noPrintButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
