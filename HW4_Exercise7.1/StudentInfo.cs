using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise7._1
{
    public partial class StudentInfo : Form
    {
        string studentLevel = "Freshman";

        public StudentInfo()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addHighSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addHighSchool = new AddHighSchool();
            addHighSchool.ShowDialog();

            // If the high school name property of the AddHighSchool form is not null it mean the user entered a name and clicked ok
            if (addHighSchool.highSchoolName != null && addHighSchool.highSchoolName != "")
            {
                highSchoolComboBox.Items.Add(addHighSchool.highSchoolName);
            }
        }

        /// <summary>
        /// Show print preview dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printButton_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                var printDialog = new PrintPreviewDialog();
                var printDocument= new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(onPrint);
                printDialog.Document = printDocument;
                printDialog.ShowDialog();
            }
        }

        private void onPrint(object sender, PrintPageEventArgs ev)
        {
            // Convert the values of all inputs to strings and format them as a report
            string printString =
                "Name: " + studentNameTextBox.Text + "\n" +
                "Level: " + studentLevel + "\n" +
                "High School: " + highSchoolComboBox.Text + "\n" +
                "Major: " + majorComboBox.Text + "\n" +
                "Units Completed: " + unitsCompletedNumericUpDown.Value + "\n" +
                "Dean's List: " + ((deansListCheckBox.Checked) ? "yes" : "no") + "\n";

            ev.Graphics.DrawString(printString, new Font("Arial", 20), Brushes.Black, 0, 0);
        }

        /// <summary>
        /// Reset all inputs to their initial state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                studentNameTextBox.Text = "";
                studentLevel = "Freshman";
                freshmanRadioButton.Select();
                highSchoolComboBox.Text = "";
                majorComboBox.Text = "";
                unitsCompletedNumericUpDown.Value = 0;
                deansListCheckBox.Checked = false;
            }
        }

        /// <summary>
        /// Make sure no input fields are empty
        /// </summary>
        /// <returns>True no fields are empty; pops up an error dialog and returns false if some fields are empty.</returns>
        private bool validateFields()
        {
            string errorMessage = null;

            if (studentNameTextBox.Text == "") errorMessage = "Please enter a student name.";
            else if (highSchoolComboBox.Text == "") errorMessage = "Please select a high school.";
            else if (majorComboBox.Text == "") errorMessage = "Please select a major.";

            if (errorMessage == null)
            {
                return true;
            } else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // BELOW: Events to set the value of studentLevel when a radio button is selected

        private void freshmanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            studentLevel = "Freshman";
        }
        private void sophmoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            studentLevel = "Sophmore";
        }
        private void juniorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            studentLevel = "Junior";
        }
        private void seniorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            studentLevel = "Senior";
        }

        private void printSchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trigger the same event as when the print button is clicked
            printButton_Click(null, null);
        }
    }
}
