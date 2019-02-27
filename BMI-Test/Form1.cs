using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Test
{

    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void peopleLabel_Click(object sender, EventArgs e)
        {

        }

        private void peopleAddButton_Click(object sender, EventArgs e)
        {
            personAddWindow add = new personAddWindow();
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
