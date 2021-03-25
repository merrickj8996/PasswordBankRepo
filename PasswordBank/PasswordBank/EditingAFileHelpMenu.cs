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
    public partial class EditingAFileHelpMenu : Form {

        List<Panel> listPanel = new List<Panel>();
        int index;

        public EditingAFileHelpMenu() {
            InitializeComponent();
        }

        // goes to the next pannel/page/part
        private void NextButton_Click(object sender, EventArgs e) {
            if (index < listPanel.Count - 1) {
                listPanel[++index].BringToFront();
            }
        }
        // Adds the pannel to a list pannel group and displays the first pannel
        private void UserGuide_Load(object sender, EventArgs e) {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel[index].BringToFront();
        }

        // goes to the previous pannel/page/part
        private void PreviousButton_Click(object sender, EventArgs e) {
            if (index > 0) {
                listPanel[--index].BringToFront();
            }
        }
    }
}
