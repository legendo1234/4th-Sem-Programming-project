using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Register : System.Web.UI.Page
    {
        UserReference.IUser userRef;
        UserReference.TUser newUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            userRef = new UserReference.UserClient();
            newUser = new UserReference.TUser();
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UserBox.Text.Length > 0 && PasswordBox.Text.Length > 0)
            {
                newUser.userid = 0;
                newUser.username = UserBox.Text;
                newUser.pass = PasswordBox.Text;
                if (userRef.Create(newUser))
                    RegStatus.Text = "Succesfully registered";
                else
                    RegStatus.Text = "That username already exists";
            }
            else
                RegStatus.Text = "Please fill in all details";
        }
    }
}