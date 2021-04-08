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
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png file (*.png)|*.png";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    this.selectedFileLocation = openFileDialog.FileName.ToString();
                    pictureBox8.ImageLocation = openFileDialog.FileName.ToString();
                }
            }
        }

        private void ExportFile_Click_1(object sender, EventArgs e) {
            // HERE WE COMPRESS AND ENCRYPT THE DATABASE FILE :)

            // LOAD IMAGE AND USE ALGORITHM TO CREATE IMAGE WITH DATABASE HELD WITHIN
            Console.WriteLine(FileOP.mFileName);
            string data = File.ReadAllText(FileOP.mFileName);
            Bitmap png = new Bitmap(Image.FromFile(this.selectedFileLocation));
            Bitmap stegPng = StegImportExport.embedText(data, png);

            

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
    }
}
