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

namespace HW4_Exercise8._3
{
    public partial class SeatingPrice : Form
    {
        int orchestraTotal = 0;
        int mezzanineTotal = 0;
        int generalTotal = 0;
        int balconyTotal = 0;

        public SeatingPrice()
        {
            InitializeComponent();

            // Make sure the seat select does not start out empty
            seatingPositionComboBox.Text = seatingPositionComboBox.Items[0].ToString();

            // update the displayed price to reflect the initial value
            seatingPositionComboBox_SelectedIndexChanged(null, null);
        }

        /// <summary>
        /// When the prices button is clicked this function will create a popup
        /// displaying the prices of all seating positions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priceButton_Click(object sender, EventArgs e)
        {
            string prices = "Orchestra 40.00\nMezzanine 27.50\nGeneral 15.00\nBalcony 10.00";
            MessageBox.Show(prices, "Prices");
        }

        private void printSummaryButton_Click(object sender, EventArgs e)
        {
            // Boilerplate so we can show the print preview dialog
            var printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(onPrint);

            var printDialog = new PrintPreviewDialog();
            printDialog.Document = printDocument;
            printDialog.ShowDialog();
        }

        /// <summary>
        /// Draws a string when printSummaryButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onPrint(object sender, PrintPageEventArgs e)
        {
            string summary = "Summary of Tickets bought:\n\nOrchestra " + orchestraTotal +
                "\nMezzanine " + mezzanineTotal +
                "\nGeneral " + generalTotal +
                "\nBalcony " + balconyTotal;

            e.Graphics.DrawString(summary, new Font("Arial", 20), Brushes.Black, 0, 0);
        }

        /// <summary>
        /// Update the summary to reflect the bought tickets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyTicketButton_Click(object sender, EventArgs e)
        {
            switch (seatingPositionComboBox.Text)
            {
                case "Orchestra": orchestraTotal++; break;
                case "Mezzanine": mezzanineTotal++; break;
                case "General": generalTotal++; break;
                case "Balcony": balconyTotal++; break;
            }

            MessageBox.Show("Ticket for " + seatingPositionComboBox.Text + " seat purchased", "Success");
        }

        private void seatingPositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal price = 0;

            switch (seatingPositionComboBox.Text)
            {
                case "Orchestra": price = 40; break;
                case "Mezzanine": price = 27.50M; break;
                case "General": price = 15; break;
                case "Balcony": price = 10; break;
            }

            priceTextBox.Text = price.ToString("C");
        }
    }
}
