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
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png file (*.png)|*.png";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    this.selectedFileLocation = openFileDialog.FileName.ToString(); // sets the new file location
                    pictureBox8.ImageLocation = openFileDialog.FileName.ToString();
                }
            }
        }

        private void ImportFile_Click_1(object sender, EventArgs e) {
            Bitmap databasePng = new Bitmap(Image.FromFile(this.selectedFileLocation));
            string data = "";
            

            // PULL DATA FROM IMAGE TO STRING
            data = StegImportExport.extractText(databasePng);
            //CONVERT STRING TO ENCRYPTED COMPRESSED FILE
            using (SaveFileDialog saveFile = new SaveFileDialog()) {
                saveFile.Filter = "Password Database Files (*.csv.gz) | *.csv.gz";
                saveFile.InitialDirectory = "c:\\";

                if (saveFile.ShowDialog() == DialogResult.OK) {
                    File.WriteAllText(saveFile.FileName.ToString(), data);
                }
            }
            //SAVE NEW FILE TO BE OPENED WITH APP
        }
    }
}
