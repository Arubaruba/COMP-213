using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise7._1
{
    public partial class AddHighSchool : Form
    {
        public string highSchoolName = null;

        public AddHighSchool()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Set high school name so it can be read by parent window
            highSchoolName = highSchoolTextBox.Text;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Set high school name to null to let parent window know we don't want to enter anything
            highSchoolName = null;
            Close();
        }
    }
}
