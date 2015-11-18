using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6._2
{
    public partial class AutoShop : Form
    {
        public AutoShop()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hoursOfLaborTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var inputs = new string[] { jobNumberTextBox.Text, customerNameTextBox.Text, amountChargedTextBox.Text, hoursOfLaborTextBox.Text };
            if (inputs.Contains(""))
            {
                MessageBox.Show("Empty fields found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            jobNumberTextBox.Text = "";
            customerNameTextBox.Text = "";
            amountChargedTextBox.Text = "";
            hoursOfLaborTextBox.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(null, null);
        }

        private void calculateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calculateButton_Click(null, null);
        }

    }
}
