using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Product : System.Web.UI.Page
    {
        ProductReference.IProduct prodRef;
        ProductReference.TProduct prod;
        protected void Page_Load(object sender, EventArgs e)
        {
            prodRef = new ProductReference.ProductClient();
            prod = new ProductReference.TProduct();
            LoadProduct();
        }

        public void LoadProduct()
        {
            if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                prod = prodRef.Read(int.Parse(Request.QueryString["id"]));
                labelName.Text = prod.name;
                labelDescription.Text = prod.description;
                labelPrice.Text = prod.price.ToString();
                labelId.Text = prod.id.ToString();
            }
            else
            {
                AddStatus.Text = "Error processing the page";
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            UpdateCartCookie2(Request.QueryString["id"], labelName.Text, int.Parse(quantitySelect.SelectedValue), labelPrice.Text);
            AddStatus.Text = "Added " + quantitySelect.Text + " items to cart";
        }

        public void UpdateCartCookie(string itemId, string name, int quantity, string price)
        {
            string newCookie = itemId.ToString() + "," + name  + "," + quantity.ToString()+ "," + price;
            if(Request.Cookies["shoppingcart"] == null)
                Response.Cookies["shoppingcart"].Value = newCookie;
            else
                Response.Cookies["shoppingcart"].Value = Request.Cookies["shoppingcart"].Value + "|" + newCookie ;
        }

        public void UpdateCartCookie2(string itemId, string name, int quantity, string price)
        {
            bool found = false;
            string newCookie = itemId.ToString() + "," + name + "," + quantity.ToString() + "," + price;
            if (Request.Cookies["shoppingcart"] == null)
                Response.Cookies["shoppingcart"].Value = newCookie;
            else
            {
                int i = 0;
                string s = Request.Cookies["shoppingcart"].Value;
                string[] items = s.Split('|');
                int size = items.Count();
                string[] jItems = new string[size];
                foreach(string item in items)
                {
                    string[] details = item.Split(',');
                    if(details[0] == itemId)
                    {
                        found = true;
                        details[2] = (int.Parse(details[2]) + quantity).ToString();
                    }
                    jItems[i++] = string.Join(",", details);
                }
                if (found == true)
                    Response.Cookies["shoppingcart"].Value = string.Join("|", jItems);
                else
                    Response.Cookies["shoppingcart"].Value = Request.Cookies["shoppingcart"].Value + "|" + newCookie;
            }
        }
    }
}