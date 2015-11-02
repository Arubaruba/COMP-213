using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3._2
{
    

    public partial class recordingStudioForm : Form
    {
        Decimal totalCharge = 0;
        int numberOfCharges = 0;

        const decimal costPerHour = 200;

        public recordingStudioForm()
        {

            InitializeComponent();
        }

        private void timeSpentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var timeSpent = Decimal.Parse(timeSpentTextBox.Text);
                if (timeSpent < 0)
                {
                    timeSpent = Math.Abs(timeSpent);
                    timeSpentTextBox.Text = timeSpent.ToString();
                }
                sessionCostTextBox.Text = (timeSpent * costPerHour).ToString("C");
                addSessionButton.Enabled = true;
            }
            catch (System.Exception) {
                sessionCostTextBox.Text = "";
                addSessionButton.Enabled = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset the form to it's original state
            sessionCostTextBox.Text = "";
            timeSpentTextBox.Text = "";
            groupNameTextBox.Text = "";
            addSessionButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset the add session group
            clearButton_Click(null, null);

            // Reset the session totals group
            totalCharge = 0;
            numberOfCharges = 0;
            recalculateTotals();
        }

        void recalculateTotals()
        {
            if (numberOfCharges == 0)
            {
                totalChargeTextBox.Text = "";
                averageChargeTextBox.Text = "";
                numberOfChargesTextBox.Text = "";
            }
            else
            {
                totalChargeTextBox.Text = totalCharge.ToString("C");
                averageChargeTextBox.Text = (totalCharge / numberOfCharges).ToString("C");
                numberOfChargesTextBox.Text = numberOfCharges.ToString();
            }
        }

        private void addSessionButton_Click(object sender, EventArgs e)
        {
            // We know this will succeed because the button would not be enabled if the text was not valid
            totalCharge += Decimal.Parse(timeSpentTextBox.Text) * costPerHour;
            numberOfCharges++;

            recalculateTotals();
            clearButton_Click(null, null);
        }
    }
}
