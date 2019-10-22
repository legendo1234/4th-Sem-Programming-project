using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCartCookie();
        }

        public void LoadCartCookie()
        {
            int sum = 0;
            if (Request.Cookies["shoppingcart"] != null)
            {
                LoadHeader();
                string lcookies = Request.Cookies["shoppingcart"].Value;
                string[] cookies = lcookies.Split('|');
                foreach (string cookie in cookies)
                {
                    string[] c = cookie.Split(',');
                    TableCell id = new TableCell { Text = c[0] };
                    TableCell name = new TableCell { Text = c[1] };
                    TableCell quantity = new TableCell { Text = c[2] };
                    TableCell price = new TableCell { Text = c[3] };
                    TableCell totalprice = new TableCell { Text = (int.Parse(c[2]) * int.Parse(c[3])).ToString() };
                    TableRow row = new TableRow();
                    row.Cells.Add(id);
                    row.Cells.Add(name);
                    row.Cells.Add(quantity);
                    row.Cells.Add(price);
                    row.Cells.Add(totalprice);
                    CartProducts.Rows.Add(row);
                    sum += int.Parse(totalprice.Text);
                }
                TableCell info = new TableCell { Text = "Total Order Price:" };
                info.ColumnSpan = 4;
                info.HorizontalAlign = HorizontalAlign.Right;
                TableCell bigprice = new TableCell { Text = sum.ToString() };
                TableFooterRow bottom = new TableFooterRow();
                bottom.Cells.Add(info);
                bottom.Cells.Add(bigprice);
                CartProducts.Rows.Add(bottom);
                HttpCookie total = new HttpCookie("carttotal") { Value = sum.ToString() };
                Response.Cookies.Add(total);
            }
            else
            {
                TableCell status = new TableCell { Text = "Cart is empty" };
                TableRow row = new TableRow();
                row.Cells.Add(status);
                CartProducts.Rows.Add(row);
                EmptyCart.Visible = false;
            }
        }

        public void LoadHeader()
        {
            TableHeaderCell id = new TableHeaderCell { Text = "ID" };
            TableHeaderCell name = new TableHeaderCell { Text = "Product" };
            TableHeaderCell quantity = new TableHeaderCell { Text = "Quantity" };
            TableHeaderCell price = new TableHeaderCell { Text = "Price" };
            TableHeaderCell totalprice = new TableHeaderCell { Text = "Total Price" };
            TableHeaderRow row = new TableHeaderRow();
            row.Cells.Add(id);
            row.Cells.Add(name);
            row.Cells.Add(quantity);
            row.Cells.Add(price);
            row.Cells.Add(totalprice);
            CartProducts.Rows.Add(row);
        }

        protected void EmptyCart_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["shoppingcart"] != null)
            {
                HttpCookie cookie = new HttpCookie("shoppingcart");
                cookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(cookie);
                HttpCookie total = new HttpCookie("carttotal");
                total.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(total);
                Response.Redirect("Cart.aspx");
            }

        }
    }
}