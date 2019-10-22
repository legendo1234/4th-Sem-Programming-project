namespace ShopFormsClient
{
    partial class UserWindow
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
            this.usersBox = new System.Windows.Forms.ListBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ordersBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.numberOfItemsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemsBox = new System.Windows.Forms.ListBox();
            this.messageDelete = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersBox
            // 
            this.usersBox.FormattingEnabled = true;
            this.usersBox.Location = new System.Drawing.Point(6, 19);
            this.usersBox.Name = "usersBox";
            this.usersBox.Size = new System.Drawing.Size(120, 173);
            this.usersBox.TabIndex = 0;
            this.usersBox.SelectedIndexChanged += new System.EventHandler(this.usersBox_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(186, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(180, 20);
            this.nameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(186, 46);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(180, 20);
            this.emailBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageDelete);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.usersBox);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.phoneBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(138, 130);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(251, 130);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(115, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(186, 71);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(180, 20);
            this.addressBox.TabIndex = 1;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(186, 98);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.ReadOnly = true;
            this.phoneBox.Size = new System.Drawing.Size(180, 20);
            this.phoneBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ordersBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 159);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders by user";
            // 
            // ordersBox
            // 
            this.ordersBox.FormattingEnabled = true;
            this.ordersBox.Location = new System.Drawing.Point(6, 19);
            this.ordersBox.Name = "ordersBox";
            this.ordersBox.Size = new System.Drawing.Size(120, 134);
            this.ordersBox.TabIndex = 0;
            this.ordersBox.SelectedIndexChanged += new System.EventHandler(this.ordersBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.costLabel);
            this.groupBox3.Controls.Add(this.numberOfItemsLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.itemsBox);
            this.groupBox3.Location = new System.Drawing.Point(151, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 159);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items in selected order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total cost:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(135, 97);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(35, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "label6";
            // 
            // numberOfItemsLabel
            // 
            this.numberOfItemsLabel.AutoSize = true;
            this.numberOfItemsLabel.Location = new System.Drawing.Point(135, 36);
            this.numberOfItemsLabel.Name = "numberOfItemsLabel";
            this.numberOfItemsLabel.Size = new System.Drawing.Size(35, 13);
            this.numberOfItemsLabel.TabIndex = 2;
            this.numberOfItemsLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Number of items:";
            // 
            // itemsBox
            // 
            this.itemsBox.FormattingEnabled = true;
            this.itemsBox.Location = new System.Drawing.Point(6, 19);
            this.itemsBox.Name = "itemsBox";
            this.itemsBox.Size = new System.Drawing.Size(120, 134);
            this.itemsBox.TabIndex = 0;
            this.itemsBox.SelectedIndexChanged += new System.EventHandler(this.itemsBox_SelectedIndexChanged);
            // 
            // messageDelete
            // 
            this.messageDelete.AutoSize = true;
            this.messageDelete.Location = new System.Drawing.Point(163, 167);
            this.messageDelete.Name = "messageDelete";
            this.messageDelete.Size = new System.Drawing.Size(0, 13);
            this.messageDelete.TabIndex = 5;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserWindow";
            this.Text = "UserWindow";
            this.Load += new System.EventHandler(this.UserWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox usersBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ordersBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label numberOfItemsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox itemsBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label messageDelete;
    }
}