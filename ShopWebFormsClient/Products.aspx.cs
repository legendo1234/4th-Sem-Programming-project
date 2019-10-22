using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Products : System.Web.UI.Page
    {
        ProductReference.IProduct prodRef;
        CategoryReference.ICategory catRef;
        List<ProductReference.TProduct> prods;
        List<CategoryReference.TCategory> cats;
        protected void Page_Load(object sender, EventArgs e)
        {
            Prepare();
            LoadCategories();
            LoadProducts();
        }

        public void Prepare()
        {
            prodRef = new ProductReference.ProductClient();
            catRef = new CategoryReference.CategoryClient();
            prods = new List<ProductReference.TProduct>(prodRef.ReadAll());
            cats = new List<CategoryReference.TCategory>(catRef.ReadAll());
        }

        public void LoadCategories()
        {
            ListItem all = new ListItem("Everything", "all");
            ListCategories.Items.Add(all);
            foreach (CategoryReference.TCategory cat in cats)
            {
                ListItem item = new ListItem(cat.name, cat.id.ToString());
                ListCategories.Items.Add(item);
            }
        }

        public void LoadProducts()
        {
            foreach(ProductReference.TProduct prod in prods)
            {
                TableCell name = new TableCell { Text = prod.name };
                TableCell price = new TableCell { Text = prod.price.ToString() };
                TableCell buy = new TableCell();
                Button view = new Button { Text = "View this product", PostBackUrl = "Product.aspx?id=" + prod.id };
                buy.Controls.Add(view);
                TableRow row = new TableRow();
                row.Cells.Add(name);
                row.Cells.Add(price);
                row.Cells.Add(buy);
                TableProducts.Rows.Add(row);
            }
        }
    }
}
