using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW5_Exercise9._3
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                nameLabel.Text = (string)Session["name"];
            } else
            {
                nameLabel.Text = "someone";
            }
        }
    }
}