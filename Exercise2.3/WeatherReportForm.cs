using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2._3
{
    public partial class WeatherReportForm : Form
    {
        public WeatherReportForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(keyDown);
        }
        /// <summary>
        /// Allow functionality to be triggered through the keyboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The key event</param>
        private void keyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    generateReport_Click(null, null);
                    break;
            }
        }
            
        /// <summary>
        /// Use the given customer name and selected weather type to display customized a message and image.
        /// </summary>
        private void generateReport_Click(object sender, EventArgs e)
        {
            // Search for a selected weather type
            var selectedWeatherType = weatherSelectionGroup.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            bool foundError = false;
            errorLabel.Text = "";

            // Make sure the customer entered their name
            if (customerName.Text.Length == 0)
            {
                errorLabel.Text += "Enter your name. ";
                foundError = true;
            }

            // Make sure a weather type is selected
            if (selectedWeatherType == null)
            {
                errorLabel.Text += "Select a weather Type. ";
                foundError = true;
            }

            // Only continue if no errors have been found
            if (!foundError)
            {
                personalizedWeatherInfo.Text = "Looks like it's " + selectedWeatherType.Text.ToLower() + " today, " + customerName.Text + ".";
            }
        }
    }
}
