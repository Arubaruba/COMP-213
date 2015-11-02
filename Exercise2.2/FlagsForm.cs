using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2._2
{
    public partial class FlagsForm : Form
    {
        public FlagsForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Sorry, printing has not been implemented yet.");
        }

        private void indiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            countryNameLabel.Text = "India";
            countryFlagPictureBox.BackgroundImage = global::Exercise2._2.FlagImages.india;

        }

        private void usRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            countryNameLabel.Text = "US";
            countryFlagPictureBox.BackgroundImage = global::Exercise2._2.FlagImages.us;
        }

        private void canadaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            countryNameLabel.Text = "Canada";
            countryFlagPictureBox.BackgroundImage = global::Exercise2._2.FlagImages.canada;
        }

        private void kenyaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            countryNameLabel.Text = "Kenya";
            countryFlagPictureBox.BackgroundImage = global::Exercise2._2.FlagImages.kenya;
        }

        private void developerNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Arubaruba");
        }

        private void showFormTitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            formTitleLabel.Visible = showFormTitleCheckBox.Checked;
        }

        private void showCountryLabelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            countryNameLabel.Visible = showCountryLabelCheckBox.Checked;
        }

        private void showProgrammerNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            developerNameLabel.Visible = showProgrammerNameCheckBox.Checked;
        }
    }
}
