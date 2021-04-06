using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // PULL DATA FROM IMAGE TO STRING
            Console.WriteLine(StegImportExport.extractText(databasePng));
            //CONVERT STRING TO ENCRYPTED COMPRESSED FILE

            //SAVE NEW FILE TO BE OPENED WITH APP
        }
    }
}
