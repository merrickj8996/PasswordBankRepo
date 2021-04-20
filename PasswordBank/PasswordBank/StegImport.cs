using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass
{
    public partial class StegImport : Form
    {
        string selectedFileLocation = "";
        public StegImport()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e) { // when the search button is clicked, open a selected image file
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\"; // start search in the C drive
                openFileDialog.Filter = "png file (*.png)|*.png"; // only allow PNG files to be opened
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    this.selectedFileLocation = openFileDialog.FileName.ToString(); // sets the new file location
                    pictureBox8.ImageLocation = openFileDialog.FileName.ToString(); // changes image to selected image
                    ExportFileTB.Text = openFileDialog.FileName.ToString(); //changes text box to display file path
                }
            }
        }

        private void ImportFile_Click_1(object sender, EventArgs e) {
            Bitmap databasePng = new Bitmap(Image.FromFile(this.selectedFileLocation)); // create Bitmap from the selected image file

            // PULL DATA FROM IMAGE TO STRING
            string data = StegImportExport.extractText(databasePng); // create string which will contain data pulled from image

            stegTextRecieved.Text = data;

            //CONVERT STRING TO ENCRYPTED COMPRESSED DATABASE FILE
            //using (SaveFileDialog saveFile = new SaveFileDialog()) {
            //    saveFile.Filter = "Password Database Files (*.csv.gz) | *.csv.gz"; // save file only as .csv.gz file, which we use for databases
            //    saveFile.InitialDirectory = "c:\\"; // start search in the C drive

            //    if (saveFile.ShowDialog() == DialogResult.OK) {
            //        File.WriteAllText(saveFile.FileName.ToString(), data); // write data to the database file if save is successful
            //    }
            //}
        }

        private void ExportFileTB_TextChanged(object sender, EventArgs e) {

        }
    }
}
