using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW5_Exercise9._4
{
    public partial class RentMovies : System.Web.UI.Page
    {
        const double membershipDiscount = 0.10;
        const decimal bluerayPrice = 5.0M;
        const decimal dvdPrice = 4.5M;
        const decimal newReleaseExtraCost = 1;

        /// <summary>
        /// The final price of the rental
        /// </summary>
        /// <returns></returns>
        private decimal getTotalPrice()
        {
            // Start calculating the price based on the movie format
            decimal price = (dvdFormat.Checked) ? dvdPrice : bluerayPrice;
            // Additional costs for new releases
            if (newReleaseCheckBox.Checked) price += newReleaseExtraCost;
            // Member discount
            if (membershipCheckBox.Checked) price *= 1 - (decimal)membershipDiscount;

            return price;
        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            // The movie title is the only control we need to validate
            // If it's not valid we simply reset the total amount displayed
            movieTitleRequiredFieldValidator.Validate();

            if (movieTitleRequiredFieldValidator.IsValid)
            {
                // Display the total cost
                totalCostLabel.Text = "Total Cost: " + getTotalPrice().ToString("C");
            }
            else
            {
                totalCostLabel.Text = "";
            }
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            movieTitleRequiredFieldValidator.Validate();

            if (movieTitleRequiredFieldValidator.IsValid)
            {
                // Initialize session variables if necessary
                if (Session["numOfRentals"] == null) Session["numOfRentals"] = 0;
                if (Session["totalRentalAmount"] == null) Session["totalRentalAmount"] = 0M;

                Session["numOfRentals"] = 1 + ((int)Session["numOfRentals"]);
                Session["totalRentalAmount"] = getTotalPrice() + ((decimal)Session["totalRentalAmount"]);

                // Reset the form
                clearButton_Click(null, null);
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            // Reset all the fields to their original state
            totalCostLabel.Text = "";
            movieTitleTextBox.Text = "";
            dvdFormat.Checked = true;
            bluerayFormat.Checked = false;

            newReleaseCheckBox.Checked = false;
            membershipCheckBox.Checked = false;
        }
    }
}