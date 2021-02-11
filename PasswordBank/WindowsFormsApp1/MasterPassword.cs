using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class passwordOptions : Form
    {
        public passwordOptions()
        {
            InitializeComponent();
        }

        private static string computeSha256Hash(String data)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //compute the hash. store in byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((PassEntry1.Text == PassEntry2.Text) && PassEntry1 != null && PassEntry2 !=null)
            {
                Stream myStream;
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "Text File (.txt) |*.txt",
                    Title = "Save password for DB"
                };
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = save.OpenFile()) != null)
                    {
                        myStream.Close();
                    }
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(save.FileName, true))
                    {
                        file.WriteLine(computeSha256Hash(PassEntry1.Text));
                    }
                    this.Close();
                }
            }
            else
            {
                string message = "Your passwords do not match. Please try entering them again";
                string title = "Pass Keeper";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                _ = MessageBox.Show(message, title, buttons);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
            MasterForm frm = new MasterForm();
            this.Close();
            frm.Show();
         
        }
    }
}
