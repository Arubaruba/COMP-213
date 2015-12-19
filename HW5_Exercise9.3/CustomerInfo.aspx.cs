using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW5_Exercise9._3
{
    public partial class CustomerInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void addCustomerButton_Click(object sender, EventArgs e)
        {
            // Clear the password fields

            // Manually validate password fields to make sure they match
            if (passwordTextBox.Text == repeatPasswordTextBox.Text)
            {
                Session["name"] = nameTextBox.Text;
                Response.Redirect("welcome.aspx");
            } else
            {
                passwordTextBox.Text = "";
                repeatPasswordTextBox.Text = "";
                passwordsNotMatchingLabel.Visible = true;
            }
        }
    }
}