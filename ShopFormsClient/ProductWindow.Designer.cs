namespace ShopFormsClient
{
    partial class ProductWindow
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.addedStockBox = new System.Windows.Forms.TextBox();
            this.addStockButton = new System.Windows.Forms.Button();
            this.newCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newPriceBox = new System.Windows.Forms.TextBox();
            this.newDescBox = new System.Windows.Forms.TextBox();
            this.newStockBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.messageExtra = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(72, 65);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(100, 21);
            this.categoryComboBox.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(72, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(72, 39);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(100, 20);
            this.descBox.TabIndex = 1;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(72, 92);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(100, 20);
            this.stockBox.TabIndex = 1;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(72, 118);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.descBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stockBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Location = new System.Drawing.Point(307, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New product";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(9, 144);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create product";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.refreshButton);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.addedStockBox);
            this.groupBox2.Controls.Add(this.addStockButton);
            this.groupBox2.Controls.Add(this.newCategoryComboBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.newNameBox);
            this.groupBox2.Controls.Add(this.productsBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.newPriceBox);
            this.groupBox2.Controls.Add(this.newDescBox);
            this.groupBox2.Controls.Add(this.newStockBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 259);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Units";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(120, 147);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(163, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update product";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(152, 230);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(131, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(152, 199);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(131, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Price";
            // 
            // addedStockBox
            // 
            this.addedStockBox.Location = new System.Drawing.Point(43, 229);
            this.addedStockBox.Name = "addedStockBox";
            this.addedStockBox.Size = new System.Drawing.Size(94, 20);
            this.addedStockBox.TabIndex = 4;
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(6, 199);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(131, 23);
            this.addStockButton.TabIndex = 3;
            this.addStockButton.Text = "Add stock";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // newCategoryComboBox
            // 
            this.newCategoryComboBox.FormattingEnabled = true;
            this.newCategoryComboBox.Location = new System.Drawing.Point(183, 68);
            this.newCategoryComboBox.Name = "newCategoryComboBox";
            this.newCategoryComboBox.Size = new System.Drawing.Size(100, 21);
            this.newCategoryComboBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Stock";
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(183, 16);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(100, 20);
            this.newNameBox.TabIndex = 1;
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(6, 19);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(105, 160);
            this.productsBox.TabIndex = 0;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.productsBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Category";
            // 
            // newPriceBox
            // 
            this.newPriceBox.Location = new System.Drawing.Point(183, 121);
            this.newPriceBox.Name = "newPriceBox";
            this.newPriceBox.Size = new System.Drawing.Size(100, 20);
            this.newPriceBox.TabIndex = 1;
            // 
            // newDescBox
            // 
            this.newDescBox.Location = new System.Drawing.Point(183, 42);
            this.newDescBox.Name = "newDescBox";
            this.newDescBox.Size = new System.Drawing.Size(100, 20);
            this.newDescBox.TabIndex = 1;
            // 
            // newStockBox
            // 
            this.newStockBox.Location = new System.Drawing.Point(183, 95);
            this.newStockBox.Name = "newStockBox";
            this.newStockBox.Size = new System.Drawing.Size(100, 20);
            this.newStockBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Description";
            // 
            // messageExtra
            // 
            this.messageExtra.AutoSize = true;
            this.messageExtra.Location = new System.Drawing.Point(326, 228);
            this.messageExtra.Name = "messageExtra";
            this.messageExtra.Size = new System.Drawing.Size(0, 13);
            this.messageExtra.TabIndex = 5;
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.messageExtra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductWindow";
            this.Text = "Product Management Window";
            this.Load += new System.EventHandler(this.ProductWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addedStockBox;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.ComboBox newCategoryComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.ListBox productsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newPriceBox;
        private System.Windows.Forms.TextBox newDescBox;
        private System.Windows.Forms.TextBox newStockBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label messageExtra;
    }
}