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
    public partial class StegExport : Form
    {
        string selectedFileLocation = "";
        public StegExport()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\"; // start search in the C drive
                openFileDialog.Filter = "png file (*.png)|*.png"; // only allow PNG files to be opened
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    this.selectedFileLocation = openFileDialog.FileName.ToString(); // sets the new file location
                    pictureBox8.ImageLocation = openFileDialog.FileName.ToString(); // changes image to display selected image
                    ExportFileTB.Text = openFileDialog.FileName.ToString(); // changes textbox to display file path
                }
            }
        }

        private void ExportFile_Click_1(object sender, EventArgs e) {
            // HERE WE COMPRESS AND ENCRYPT THE DATABASE FILE :)

            // LOAD IMAGE AND USE ALGORITHM TO CREATE IMAGE WITH DATABASE HELD WITHIN
            //Console.WriteLine(File.ReadAllText(FileOP.GetFile()));
            //string data = File.ReadAllText(FileOP.GetFile());

            Bitmap png = new Bitmap(Image.FromFile(this.selectedFileLocation));
            Bitmap stegPng = StegImportExport.embedText(stegTextInfo.Text.ToString(), png);

            

            //----------SAVE STEG IMAGE WHERE SELECTED-----------
            using (SaveFileDialog saveFile = new SaveFileDialog()) {
                saveFile.Filter = "Image Files (*.png) | *.png";
                saveFile.InitialDirectory = "c:\\";

                if (saveFile.ShowDialog() == DialogResult.OK) {
                    stegPng.Save(saveFile.FileName.ToString());
                    
                }
            }
        }

        private void PasswordLabel_Click(object sender, EventArgs e) {

        }

        private void PasswordTB_TextChanged(object sender, EventArgs e) {

        }

        private void ExportFileTB_TextChanged(object sender, EventArgs e) {

        }

        private void stegTextInfo_TextChanged(object sender, EventArgs e) {

        }
    }
}
