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
    public partial class UserGuide : Form {
        List<Panel> listPanel = new List<Panel>();
        int index;


        public UserGuide() {
            InitializeComponent();
        }

        /// <summary>
        /// Bring up the previous pannel to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousButton_Click(object sender, EventArgs e) {
            if (index > 0) {
                listPanel[--index].BringToFront();
            }
        }

        /// <summary>
        /// Bring up the next pannel to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPage_Click(object sender, EventArgs e) {
            if (index < listPanel.Count - 1) {
                listPanel[++index].BringToFront();
            }
        }

        /// <summary>
        /// Once the form loads add panels to a list panel and bring up the first panel
        /// </summary>
        private void UserGuide_Load(object sender, EventArgs e) {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            listPanel.Add(panel8);
            listPanel.Add(panel8);
            listPanel[index].BringToFront();
        }
    }
}
