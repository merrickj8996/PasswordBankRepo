using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPass {
    public partial class OpeningAFileHelpMenu : Form {

        List<Panel> listPanel = new List<Panel>();
        int index;

        public OpeningAFileHelpMenu() {
            InitializeComponent();
        }

        //go to the next page
        private void NextButton_Click(object sender, EventArgs e) {
            if (index < listPanel.Count - 1) {
                listPanel[++index].BringToFront();
            }
        }
        //add panels to a list panel control.
        private void OpeningAFileHelpMenu_Load(object sender, EventArgs e) {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel[index].BringToFront();
        }

        private void PreviousButton_Click(object sender, EventArgs e) {
            if (index > 0) {
                listPanel[--index].BringToFront();
            }
        }
    }
}
