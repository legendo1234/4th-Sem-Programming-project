using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class MyAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void LogoutButton_Click(object sender, EventArgs e)
        {

            if (Session["user"] != null)
            {
                Session.Remove("user");
                LogoutStatus.Text = "Successfully logged out";
            }
            else
                LogoutStatus.Text = "Honestly I have no idea how you messed up this bad but to logout you have to login first like how did you even find the button jeez";

        }
    }
}