using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Main : System.Web.UI.Page
    {
        UserReference.IUser userRef;
        protected void Page_Load(object sender, EventArgs e)
        {
            userRef = new UserReference.UserClient();
            InitWelcomeMessage();
        }

        public void InitWelcomeMessage()
        {
            if (Session["user"] != null)
                UserStatus.Text = "Hello " + (Session["user"].ToString());
            else
            {
                UserStatus.Text = "You are not logged in. Please login or register.";
                LoginLink.Visible = true;
                RegisterLink.Visible = true;
            }
        }
    }
}