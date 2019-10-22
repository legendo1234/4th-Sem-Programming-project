using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ShopService.Transporter;

namespace ShopFormsClient
{
    public partial class ProductWindow : Form
    {
        ProductReference.IProduct productRef;
        CategoryReference.ICategory categoryRef;
        TProduct selected_product;
        public ProductWindow()
        {
            InitializeComponent();
            selected_product = new TProduct();
        }

        void prepareComboBoxes()
        {
            //newCategoryComboBox.DataSource = categoryRef.ReadAll();
            //categoryComboBox.DataSource = categoryRef.ReadAll();
            List<TCategory> cats = new List<TCategory>(categoryRef.ReadAll());
            foreach (TCategory cat in cats)
            {
                newCategoryComboBox.Items.Add(cat);
                categoryComboBox.Items.Add(cat);
            }
        }

        private void ProductWindow_Load(object sender, EventArgs e)
        {
            productRef = new ProductReference.ProductClient();
            categoryRef = new CategoryReference.CategoryClient();
            prepareComboBoxes();
            refreshButton.PerformClick();
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            productsBox.Items.Clear();
            productsBox.Items.AddRange(productRef.ReadAll());

            newNameBox.Clear();
            newDescBox.Clear();
            newCategoryComboBox.Text = "";
            newStockBox.Clear();
            newPriceBox.Clear();

            nameBox.Clear();
            descBox.Clear();
            categoryComboBox.Text = "";
            stockBox.Clear();
            priceBox.Clear();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            TProduct new_product = new TProduct
            {
                id = 0,
                name = nameBox.Text,
                description = descBox.Text,
                category = ((TCategory)categoryComboBox.SelectedItem).id,
                stock = int.Parse(stockBox.Text),
                price = decimal.Parse(priceBox.Text),
                timestamp = 0
            };
            if (productRef.Create(new_product))
                messageExtra.Text = "Product succesfully created";
            else
                messageExtra.Text = "Error, please check input details";
            refreshButton.PerformClick();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            selected_product.name = newNameBox.Text;
            selected_product.description = newDescBox.Text;
            selected_product.category = ((TCategory)newCategoryComboBox.SelectedItem).id;
            selected_product.stock = int.Parse(newStockBox.Text);
            selected_product.price = decimal.Parse(newPriceBox.Text);
            if (productRef.Update(selected_product))
                messageExtra.Text = "Product succesfully updated!";
            else
                messageExtra.Text = "Error in updating product";
            refreshButton.PerformClick();
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            if (productRef.Restock(selected_product, int.Parse(addedStockBox.Text)))
                messageExtra.Text = "Stock added succesfully";
            else
                messageExtra.Text = "Error adding new stock";
            refreshButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productRef.Delete(selected_product))
                messageExtra.Text = "Product succesfully deleted";
            else
                messageExtra.Text = "Error deleting";
            refreshButton.PerformClick();
        }

        private void productsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsBox.SelectedItem != null)
            {
                TProduct p = (TProduct)productsBox.SelectedItem;
                selected_product = (TProduct)productsBox.SelectedItem;
                newNameBox.Text = selected_product.name;
                newDescBox.Text = selected_product.description;
                newCategoryComboBox.Text = categoryRef.Read(selected_product.category).ToString();
                newStockBox.Text = selected_product.stock.ToString();
                newPriceBox.Text = selected_product.price.ToString();
            }
        }
    }
}
