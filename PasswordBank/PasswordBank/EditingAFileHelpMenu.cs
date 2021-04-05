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

        /// <summary>
        /// goes to the next pannel/page/part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e) {
            if (index < listPanel.Count - 1) {
                listPanel[++index].BringToFront();
            }
        }

        /// <summary>
        /// Adds the pannel to a list pannel group and displays the first pannel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserGuide_Load(object sender, EventArgs e) {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            listPanel.Add(panel8);
            listPanel[index].BringToFront();
        }
        /// <summary>
        /// goes to the previous pannel/page/part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousButton_Click(object sender, EventArgs e) {
            if (index > 0) {
                listPanel[--index].BringToFront();
            }
        }
    }
}
