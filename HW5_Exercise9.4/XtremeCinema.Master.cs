using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW5_Exercise9._4
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Retrieve the total rental amount as an amount of money in string form
        /// while also dealing with non existant session values
        /// </summary>
        /// <returns></returns>
        public string getTotalRentalAmount()
        {
            decimal total = (Session["totalRentalAmount"] == null) ? 0 : (decimal)Session["totalRentalAmount"];
            return total.ToString("C");
        }

        /// <summary>
        /// Retrieve the total number of rentals in string form
        /// while also dealing with non existant session values
        /// </summary>
        /// <returns></returns>
        public string getNumOfRentals()
        {
            decimal num = (Session["numOfRentals"] == null) ? 0 : (int)Session["numOfRentals"];
            return num.ToString();
        }
    }
}