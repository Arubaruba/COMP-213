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
        const decimal laborCostPerHour = 50;
        const decimal salesTax = 0.08M;
        public AutoShop()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        void displayParseError(string fieldName, string requiredDataType)
        {
            MessageBox.Show(fieldName + " field does not contain a valid " + requiredDataType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // When all fields have text, try to parse all of the numeric fields

                decimal amountChargedForParts = 0;
                int hoursOfLabor = 0;

                // Job Number
                try
                {
                    int.Parse(jobNumberTextBox.Text);
                }
                catch
                {
                    displayParseError("Job Number", "Integer");
                    return;
                }

                // Amount Charged
                try
                {
                    amountChargedForParts = int.Parse(amountChargedTextBox.Text);
                }
                catch
                {
                    displayParseError("Hours of Labor", "Integer");
                    return;
                }

                // Hours of Labor
                try
                {
                    hoursOfLabor = int.Parse(hoursOfLaborTextBox.Text);
                }
                catch
                {
                    displayParseError("Amount Parsed", "Integer");
                    return;
                }

                subtotalTextBox.Text = (hoursOfLabor * laborCostPerHour + amountChargedForParts).ToString("C");
                salesTaxTextBox.Text = (amountChargedForParts * salesTax).ToString("C");
                totalTextBox.Text = (hoursOfLabor * laborCostPerHour + amountChargedForParts * (1 + salesTax)).ToString("C");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            jobNumberTextBox.Text = "";
            customerNameTextBox.Text = "";
            amountChargedTextBox.Text = "";
            hoursOfLaborTextBox.Text = "";

            subtotalTextBox.Text = "";
            salesTaxTextBox.Text = "";
            totalTextBox.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(null, null);
        }

        private void calculateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calculateButton_Click(null, null);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAutoRepairShop about = new AboutAutoRepairShop();
            about.ShowDialog();
        }

    }
}
