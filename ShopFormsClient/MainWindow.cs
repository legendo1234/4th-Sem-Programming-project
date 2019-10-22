using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopFormsClient
{
    public partial class MainWindow : Form
    {
        UserWindow userWindow;
        CategoryWindow categoryWindow;
        ProductWindow productWindow;
        OrderWindow orderWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            userWindow = new UserWindow();
            userWindow.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            orderWindow = new OrderWindow();
            orderWindow.Show();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            categoryWindow = new CategoryWindow();
            categoryWindow.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            productWindow = new ProductWindow();
            productWindow.Show();
        }
    }
}
