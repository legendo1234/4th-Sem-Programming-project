namespace ShopFormsClient
{
    partial class OrderWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderItemsBox = new System.Windows.Forms.ListBox();
            this.ordersBox = new System.Windows.Forms.ListBox();
            this.quantityValue = new System.Windows.Forms.NumericUpDown();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isDelivered = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changeQtyButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.markDeliveredButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.removeOrderButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.orderItemsBox);
            this.groupBox1.Controls.Add(this.ordersBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orders";
            // 
            // orderItemsBox
            // 
            this.orderItemsBox.FormattingEnabled = true;
            this.orderItemsBox.Location = new System.Drawing.Point(116, 38);
            this.orderItemsBox.Name = "orderItemsBox";
            this.orderItemsBox.Size = new System.Drawing.Size(104, 186);
            this.orderItemsBox.TabIndex = 1;
            this.orderItemsBox.SelectedIndexChanged += new System.EventHandler(this.orderItemsBox_SelectedIndexChanged);
            // 
            // ordersBox
            // 
            this.ordersBox.FormattingEnabled = true;
            this.ordersBox.Location = new System.Drawing.Point(6, 38);
            this.ordersBox.Name = "ordersBox";
            this.ordersBox.Size = new System.Drawing.Size(104, 186);
            this.ordersBox.TabIndex = 0;
            this.ordersBox.SelectedIndexChanged += new System.EventHandler(this.ordersBox_SelectedIndexChanged);
            // 
            // quantityValue
            // 
            this.quantityValue.Location = new System.Drawing.Point(58, 178);
            this.quantityValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityValue.Name = "quantityValue";
            this.quantityValue.Size = new System.Drawing.Size(136, 20);
            this.quantityValue.TabIndex = 2;
            this.quantityValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(6, 38);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(188, 134);
            this.productsBox.TabIndex = 3;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.productsBox_SelectedIndexChanged);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(6, 204);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(188, 23);
            this.addToOrderButton.TabIndex = 4;
            this.addToOrderButton.Text = "Add to order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.productsBox);
            this.groupBox2.Controls.Add(this.addToOrderButton);
            this.groupBox2.Controls.Add(this.quantityValue);
            this.groupBox2.Location = new System.Drawing.Point(245, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 230);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add new item to order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Products";
            // 
            // isDelivered
            // 
            this.isDelivered.AutoSize = true;
            this.isDelivered.Location = new System.Drawing.Point(116, 114);
            this.isDelivered.Name = "isDelivered";
            this.isDelivered.Size = new System.Drawing.Size(71, 17);
            this.isDelivered.TabIndex = 6;
            this.isDelivered.Text = "Delivered";
            this.isDelivered.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.refreshButton);
            this.groupBox3.Controls.Add(this.changeQtyButton);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.dateLabel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.priceLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.addressLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.userLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.markDeliveredButton);
            this.groupBox3.Controls.Add(this.removeItemButton);
            this.groupBox3.Controls.Add(this.isDelivered);
            this.groupBox3.Controls.Add(this.removeOrderButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 166);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other actions";
            // 
            // changeQtyButton
            // 
            this.changeQtyButton.Location = new System.Drawing.Point(6, 82);
            this.changeQtyButton.Name = "changeQtyButton";
            this.changeQtyButton.Size = new System.Drawing.Size(104, 23);
            this.changeQtyButton.TabIndex = 17;
            this.changeQtyButton.Text = "Change quantity";
            this.changeQtyButton.UseVisualStyleBackColor = true;
            this.changeQtyButton.Click += new System.EventHandler(this.changeQtyButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 84);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(342, 133);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "today";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Date";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(342, 111);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(13, 13);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total price";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(279, 87);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(28, 13);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "addr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(279, 51);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(27, 13);
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "user";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "User";
            // 
            // markDeliveredButton
            // 
            this.markDeliveredButton.Location = new System.Drawing.Point(6, 111);
            this.markDeliveredButton.Name = "markDeliveredButton";
            this.markDeliveredButton.Size = new System.Drawing.Size(104, 23);
            this.markDeliveredButton.TabIndex = 7;
            this.markDeliveredButton.Text = "Mark delivered";
            this.markDeliveredButton.UseVisualStyleBackColor = true;
            this.markDeliveredButton.Click += new System.EventHandler(this.markDeliveredButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(116, 19);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(104, 23);
            this.removeItemButton.TabIndex = 1;
            this.removeItemButton.Text = "Remove item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // removeOrderButton
            // 
            this.removeOrderButton.Location = new System.Drawing.Point(6, 19);
            this.removeOrderButton.Name = "removeOrderButton";
            this.removeOrderButton.Size = new System.Drawing.Size(104, 23);
            this.removeOrderButton.TabIndex = 0;
            this.removeOrderButton.Text = "Remove order";
            this.removeOrderButton.UseVisualStyleBackColor = true;
            this.removeOrderButton.Click += new System.EventHandler(this.removeOrderButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(6, 137);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(104, 23);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderWindow";
            this.Text = "OrderWindow";
            this.Load += new System.EventHandler(this.OrderWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orderItemsBox;
        private System.Windows.Forms.ListBox ordersBox;
        private System.Windows.Forms.NumericUpDown quantityValue;
        private System.Windows.Forms.ListBox productsBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isDelivered;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button markDeliveredButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button removeOrderButton;
        private System.Windows.Forms.Button changeQtyButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button refreshButton;
    }
}