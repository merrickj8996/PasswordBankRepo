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

        /// <summary>
        /// Go to the next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e) {
            if (index < listPanel.Count - 1) {
                listPanel[++index].BringToFront();
            }
        }

        /// <summary>
        /// Add panels to a list panel control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpeningAFileHelpMenu_Load(object sender, EventArgs e) {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel[index].BringToFront();
        }

        /// <summary>
        /// Brings back the previous panel
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
