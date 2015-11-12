namespace VP_Lab2_final
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Products = new System.Windows.Forms.ListBox();
            this.lb_Cart = new System.Windows.Forms.ListBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.nud_Amount = new System.Windows.Forms.NumericUpDown();
            this.btn_AddtoCart = new System.Windows.Forms.Button();
            this.btn_DeleteFromCart = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_ClearProducts = new System.Windows.Forms.Button();
            this.btn_ClearCart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категорија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кошничка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вкупно";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.tb_Category);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(216, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(6, 110);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.ReadOnly = true;
            this.tb_Price.Size = new System.Drawing.Size(142, 20);
            this.tb_Price.TabIndex = 6;
            // 
            // tb_Category
            // 
            this.tb_Category.Location = new System.Drawing.Point(6, 71);
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.ReadOnly = true;
            this.tb_Category.Size = new System.Drawing.Size(203, 20);
            this.tb_Category.TabIndex = 5;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(6, 32);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(203, 20);
            this.tb_Name.TabIndex = 4;
            // 
            // lb_Products
            // 
            this.lb_Products.FormattingEnabled = true;
            this.lb_Products.Location = new System.Drawing.Point(12, 25);
            this.lb_Products.Name = "lb_Products";
            this.lb_Products.Size = new System.Drawing.Size(198, 316);
            this.lb_Products.TabIndex = 0;
            this.lb_Products.SelectedIndexChanged += new System.EventHandler(this.lb_Products_SelectedIndexChanged);
            // 
            // lb_Cart
            // 
            this.lb_Cart.FormattingEnabled = true;
            this.lb_Cart.Location = new System.Drawing.Point(440, 25);
            this.lb_Cart.Name = "lb_Cart";
            this.lb_Cart.Size = new System.Drawing.Size(198, 290);
            this.lb_Cart.TabIndex = 7;
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(486, 319);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.ReadOnly = true;
            this.tb_Total.Size = new System.Drawing.Size(152, 20);
            this.tb_Total.TabIndex = 7;
            // 
            // nud_Amount
            // 
            this.nud_Amount.Location = new System.Drawing.Point(379, 188);
            this.nud_Amount.Name = "nud_Amount";
            this.nud_Amount.Size = new System.Drawing.Size(55, 20);
            this.nud_Amount.TabIndex = 7;
            this.nud_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_Amount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_AddtoCart
            // 
            this.btn_AddtoCart.Location = new System.Drawing.Point(225, 185);
            this.btn_AddtoCart.Name = "btn_AddtoCart";
            this.btn_AddtoCart.Size = new System.Drawing.Size(148, 23);
            this.btn_AddtoCart.TabIndex = 8;
            this.btn_AddtoCart.Text = "Додади во кошничка >>";
            this.btn_AddtoCart.UseVisualStyleBackColor = true;
            this.btn_AddtoCart.Click += new System.EventHandler(this.btn_AddtoCart_Click);
            // 
            // btn_DeleteFromCart
            // 
            this.btn_DeleteFromCart.Location = new System.Drawing.Point(225, 228);
            this.btn_DeleteFromCart.Name = "btn_DeleteFromCart";
            this.btn_DeleteFromCart.Size = new System.Drawing.Size(209, 23);
            this.btn_DeleteFromCart.TabIndex = 9;
            this.btn_DeleteFromCart.Text = "Избриши од кошничка";
            this.btn_DeleteFromCart.UseVisualStyleBackColor = true;
            this.btn_DeleteFromCart.Click += new System.EventHandler(this.btn_DeleteFromCart_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(225, 273);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(209, 23);
            this.btn_AddProduct.TabIndex = 10;
            this.btn_AddProduct.Text = "Додади нов продукт";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(225, 316);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(209, 23);
            this.btn_DeleteProduct.TabIndex = 11;
            this.btn_DeleteProduct.Text = "Избриши продукт";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // btn_ClearProducts
            // 
            this.btn_ClearProducts.Location = new System.Drawing.Point(15, 345);
            this.btn_ClearProducts.Name = "btn_ClearProducts";
            this.btn_ClearProducts.Size = new System.Drawing.Size(195, 23);
            this.btn_ClearProducts.TabIndex = 12;
            this.btn_ClearProducts.Text = "Испразни ја листата со продукти?";
            this.btn_ClearProducts.UseVisualStyleBackColor = true;
            this.btn_ClearProducts.Click += new System.EventHandler(this.btn_ClearProducts_Click);
            // 
            // btn_ClearCart
            // 
            this.btn_ClearCart.Location = new System.Drawing.Point(440, 345);
            this.btn_ClearCart.Name = "btn_ClearCart";
            this.btn_ClearCart.Size = new System.Drawing.Size(198, 23);
            this.btn_ClearCart.TabIndex = 13;
            this.btn_ClearCart.Text = "Испразни ја кошничката?";
            this.btn_ClearCart.UseVisualStyleBackColor = true;
            this.btn_ClearCart.Click += new System.EventHandler(this.btn_ClearCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.btn_ClearCart);
            this.Controls.Add(this.btn_ClearProducts);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.btn_DeleteFromCart);
            this.Controls.Add(this.btn_AddtoCart);
            this.Controls.Add(this.nud_Amount);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.lb_Cart);
            this.Controls.Add(this.lb_Products);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ListBox lb_Products;
        private System.Windows.Forms.ListBox lb_Cart;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.NumericUpDown nud_Amount;
        private System.Windows.Forms.Button btn_AddtoCart;
        private System.Windows.Forms.Button btn_DeleteFromCart;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_ClearProducts;
        private System.Windows.Forms.Button btn_ClearCart;
    }
}

