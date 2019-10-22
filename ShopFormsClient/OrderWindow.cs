using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopService.Transporter;

namespace ShopFormsClient
{
    public partial class OrderWindow : Form
    {
        OrderReference.IOrder orderRef;
        ProductReference.IProduct prodRef;
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void OrderWindow_Load(object sender, EventArgs e)
        {
            orderRef = new OrderReference.OrderClient();
            prodRef = new ProductReference.ProductClient();
            refreshButton.PerformClick();
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {

        }

        private void changeQtyButton_Click(object sender, EventArgs e)
        {

        }

        private void markDeliveredButton_Click(object sender, EventArgs e)
        {

        }

        private void ordersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderItemsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            productsBox.DataSource = null;
            productsBox.DataSource = prodRef.ReadAll();
        }
    }
}
