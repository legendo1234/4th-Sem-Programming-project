namespace ShopFormsClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersButton = new System.Windows.Forms.Button();
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(12, 12);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(115, 23);
            this.UsersButton.TabIndex = 0;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // CategoriesButton
            // 
            this.CategoriesButton.Location = new System.Drawing.Point(205, 12);
            this.CategoriesButton.Name = "CategoriesButton";
            this.CategoriesButton.Size = new System.Drawing.Size(115, 23);
            this.CategoriesButton.TabIndex = 1;
            this.CategoriesButton.Text = "Categories";
            this.CategoriesButton.UseVisualStyleBackColor = true;
            this.CategoriesButton.Click += new System.EventHandler(this.CategoriesButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(205, 41);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(115, 23);
            this.ProductsButton.TabIndex = 2;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(12, 41);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(115, 23);
            this.OrdersButton.TabIndex = 3;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 467);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.CategoriesButton);
            this.Controls.Add(this.UsersButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button CategoriesButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button OrdersButton;
    }
}