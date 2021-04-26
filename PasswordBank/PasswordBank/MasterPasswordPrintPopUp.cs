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

namespace FirstPass {
    /// <summary>
    /// Contains all the methods for printing the master password onto paper
    /// </summary>
    public partial class MasterPasswordPrintPopUp : Form {

        // Member variable containing the master password
        private string m_masterPassword;

        // PrintDocument representing the document being printed
        private PrintDocument masterPasswordDoc = new PrintDocument();

        public List<Control> printPopUpLabels;
        public List<Control> printPopUpButtons;
        public bool printPopUpDarkThemeEnabled;
        public bool printPopUpDefaultTextSizeEnabled;
        public bool printPopUpSmallTextSizeEnabled;
        public bool printPopUpLargeTextSizeEnabled;

        /// <summary>
        /// Initializes the pop up and assigns the master password to a member variable.
        /// </summary>
        /// <param name="masterPassword">Master password.</param>
        public MasterPasswordPrintPopUp(string masterPassword, Color textColor, Color backgroundColor, Color panelColor, bool darkThemeEnabled) {
            m_masterPassword = masterPassword;

            InitializeComponent();
            InitializeControlList();
            SetTheme(textColor, backgroundColor, panelColor);
        }

        /// <summary>
        /// Takes all the components and groups them together in a List<Control>. This is done so themes can be added using loops instead of each component at a time.
        /// </summary>
        private void InitializeControlList() {
            printPopUpLabels = new List<Control>();
            printPopUpButtons = new List<Control>();

            // Stores all labels
            printPopUpLabels.Add(printText);

            // Stores all buttons
            printPopUpButtons.Add(printButton);
            printPopUpButtons.Add(noPrintButton);
        }


        private void SetTheme(Color textColor, Color backgroundColor, Color panelColor) {
            // Apply the theme to the form
            this.BackColor = panelColor;

            // Apply the theme to all of the text boxes
            foreach (Control item in printPopUpLabels) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }

            // Apply the theme to all of the text boxes
            foreach (Control item in printPopUpButtons) {
                item.BackColor = panelColor;
                item.ForeColor = textColor;
            }
        }

        /// <summary>
        /// Handles the print button being pressed.
        /// </summary>
        /// <param name="sender">Button that got pressed.</param>
        /// <param name="e">Event data from button press.</param>
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

        /// <summary>
        /// Sets all the settings for the page being printed.
        /// </summary>
        /// <param name="sender">Button that got pressed.</param>
        /// <param name="e">Event data from button press.</param>
        private void MasterPasswordDoc_PrintPage(object sender, PrintPageEventArgs e) {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Arial", 10);

            // Calculate the number of lines per page.
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            using(StreamReader streamToPrint = new StreamReader("password.txt")) {
                // Print each line of the file.
                while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null)) {
                    yPos = topMargin + (count * printFont.GetHeight(e.Graphics));
                    e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                    count++;
                }
            }

            // If more lines exist, print another page.
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        /// <summary>
        /// Closes the pop-up when user clicks cancel button.
        /// </summary>
        private void noPrintButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
