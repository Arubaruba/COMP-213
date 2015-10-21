using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1_Orderform
{
    public partial class OrderForm : Form
    {
        int orderCount = 0;
        int totalOrderQuantity = 0;
        decimal totalOrderPrice = 0;
        public OrderForm()
        {
            InitializeComponent();
            updateDailyTotals();
        }

        private decimal calculateTotalPrice()
        {
            decimal totalPrice = 0;
            try {
                totalPrice = decimal.Parse(priceTextBox.Text) * decimal.Parse(quantityTextBox.Text);
            } catch { 
                //TODO
            }
            return totalPrice;
        }



        private void updateTotalPrice(object sender, EventArgs e)
        {
            decimal totalPrice = calculateTotalPrice();

            totalPriceTextBox.Text = (totalPrice == 0) ? "N/A" : totalPrice.ToString("C");
            buyButton.Enabled = (totalPrice > 0);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearTextBoxes(orderGroupBox);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            // Update total order information
            orderCount++;
            totalOrderPrice += calculateTotalPrice();
            totalOrderQuantity += int.Parse(quantityTextBox.Text);
            // Update the display of the total order info
            updateDailyTotals();
            // Reset the order input fields
            clearTextBoxes(orderGroupBox);
        }

        // Clear the order form textboxes
        private void clearTextBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control.GetType() == typeof(TextBox)) ((TextBox)control).Clear();
            }
        }

        // Update the daily total textboxes to reflect the order totals
        private void updateDailyTotals()
        {
            totalDailyAmountTextBox.Text = totalOrderPrice.ToString("C");
            totalDailyQuantityTextBox.Text = orderCount.ToString();

            averageOrderAmountTextBox.Text = (totalOrderQuantity == 0) ? (0m).ToString("C") : (totalOrderPrice / totalOrderQuantity).ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetDailyTotalsButton_Click(object sender, EventArgs e)
        {
            orderCount = 0;
            totalOrderPrice = 0;
            totalOrderQuantity = 0;
            updateDailyTotals();
        }
    }
}
