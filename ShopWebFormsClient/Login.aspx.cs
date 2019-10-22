using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Login : System.Web.UI.Page
    {
        UserReference.IUser userRef;
        UserReference.TUser user;
        protected void Page_Load(object sender, EventArgs e)
        {
            userRef = new UserReference.UserClient();
            user = new UserReference.TUser();
            if(Session["user"] != null)
            {
                UserLabel.Visible = false;
                UserBox.Visible = false;
                PassLabel.Visible = false;
                PasswordBox.Visible = false;
                LoginButton.Visible = false;
                LoginStatus.Text = "You are already logged in";
                Logout.Visible = true;
            }
            else
            { }
                
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserBox.Text.Length > 0 && PasswordBox.Text.Length > 0)
            {
                if (userRef.Login(UserBox.Text, PasswordBox.Text))
                {
                    Session["user"] = UserBox.Text;
                    LoginStatus.Text = "Successfully logged in";
                    Response.Redirect("Main.aspx");
                }
                else
                    LoginStatus.Text = "Error, please try again";
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session.Remove("user");
                LoginStatus.Text = "Successfully logged out";
            }
            else
                LoginStatus.Text = "Honestly I have no idea how you messed up this bad but to logout you have to login first like how did you even find the button jeez";
        }
    }
}