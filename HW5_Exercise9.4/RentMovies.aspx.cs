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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private decimal getTotalCost()
        {
            decimal baseCost = 1;
            return 10;
        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            totalCostLabel.Text = "Total Cost: ";
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {

        }
    }
}