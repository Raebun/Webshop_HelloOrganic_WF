namespace HelloOrganic_WebshopWF.Shopping
{
	partial class FrmShopNow
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
			this.btnAddToCart = new System.Windows.Forms.Button();
			this.lvShop = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.tbProductDescription = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbProductQuantity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lvShoppingCart = new System.Windows.Forms.ListView();
			this.label14 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Total = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblDelivery = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbSelectCustomer = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAddToCart
			// 
			this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
			this.btnAddToCart.Location = new System.Drawing.Point(13, 201);
			this.btnAddToCart.Name = "btnAddToCart";
			this.btnAddToCart.Size = new System.Drawing.Size(102, 29);
			this.btnAddToCart.TabIndex = 12;
			this.btnAddToCart.Text = "Add to cart";
			this.btnAddToCart.UseVisualStyleBackColor = false;
			this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
			// 
			// lvShop
			// 
			this.lvShop.FullRowSelect = true;
			this.lvShop.GridLines = true;
			this.lvShop.Location = new System.Drawing.Point(12, 333);
			this.lvShop.Name = "lvShop";
			this.lvShop.Size = new System.Drawing.Size(365, 175);
			this.lvShop.TabIndex = 8;
			this.lvShop.UseCompatibleStateImageBehavior = false;
			this.lvShop.SelectedIndexChanged += new System.EventHandler(this.lvShop_SelectedIndexChanged);
			this.lvShop.Click += new System.EventHandler(this.lvShop_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 28);
			this.label1.TabIndex = 13;
			this.label1.Text = "Shop";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.tbProductDescription);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.tbProductQuantity);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.tbProductPrice);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tbProductName);
			this.panel1.Controls.Add(this.btnAddToCart);
			this.panel1.Location = new System.Drawing.Point(12, 57);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(365, 242);
			this.panel1.TabIndex = 14;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label15.Location = new System.Drawing.Point(15, 105);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 15);
			this.label15.TabIndex = 23;
			this.label15.Text = "Description";
			// 
			// tbProductDescription
			// 
			this.tbProductDescription.Enabled = false;
			this.tbProductDescription.Location = new System.Drawing.Point(15, 123);
			this.tbProductDescription.Multiline = true;
			this.tbProductDescription.Name = "tbProductDescription";
			this.tbProductDescription.Size = new System.Drawing.Size(330, 72);
			this.tbProductDescription.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(279, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 15);
			this.label6.TabIndex = 21;
			this.label6.Text = "Quantity";
			// 
			// tbProductQuantity
			// 
			this.tbProductQuantity.Location = new System.Drawing.Point(279, 73);
			this.tbProductQuantity.Name = "tbProductQuantity";
			this.tbProductQuantity.Size = new System.Drawing.Size(66, 23);
			this.tbProductQuantity.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(192, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 15);
			this.label5.TabIndex = 19;
			this.label5.Text = "Price";
			// 
			// tbProductPrice
			// 
			this.tbProductPrice.Enabled = false;
			this.tbProductPrice.Location = new System.Drawing.Point(192, 73);
			this.tbProductPrice.Name = "tbProductPrice";
			this.tbProductPrice.Size = new System.Drawing.Size(81, 23);
			this.tbProductPrice.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(15, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 17;
			this.label4.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(13, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 21);
			this.label3.TabIndex = 16;
			this.label3.Text = "Product";
			// 
			// tbProductName
			// 
			this.tbProductName.Enabled = false;
			this.tbProductName.Location = new System.Drawing.Point(15, 73);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(171, 23);
			this.tbProductName.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 302);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 28);
			this.label2.TabIndex = 15;
			this.label2.Text = "Products";
			// 
			// lvShoppingCart
			// 
			this.lvShoppingCart.FullRowSelect = true;
			this.lvShoppingCart.GridLines = true;
			this.lvShoppingCart.Location = new System.Drawing.Point(405, 57);
			this.lvShoppingCart.Name = "lvShoppingCart";
			this.lvShoppingCart.Size = new System.Drawing.Size(331, 451);
			this.lvShoppingCart.TabIndex = 16;
			this.lvShoppingCart.UseCompatibleStateImageBehavior = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label14.Location = new System.Drawing.Point(405, 9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 28);
			this.label14.TabIndex = 38;
			this.label14.Text = "Cart";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
			this.button1.Location = new System.Drawing.Point(742, 479);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(158, 29);
			this.button1.TabIndex = 22;
			this.button1.Text = "Order";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(111, 144);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(28, 15);
			this.lblTotal.TabIndex = 50;
			this.lblTotal.Text = "0.00";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(92, 144);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 15);
			this.label9.TabIndex = 49;
			this.label9.Text = "€";
			// 
			// Total
			// 
			this.Total.AutoSize = true;
			this.Total.Location = new System.Drawing.Point(13, 144);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(35, 15);
			this.Total.TabIndex = 48;
			this.Total.Text = "Total:";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Location = new System.Drawing.Point(111, 81);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(28, 15);
			this.lblDiscount.TabIndex = 47;
			this.lblDiscount.Text = "0.00";
			// 
			// lblDelivery
			// 
			this.lblDelivery.AutoSize = true;
			this.lblDelivery.Location = new System.Drawing.Point(111, 46);
			this.lblDelivery.Name = "lblDelivery";
			this.lblDelivery.Size = new System.Drawing.Size(28, 15);
			this.lblDelivery.TabIndex = 46;
			this.lblDelivery.Text = "0.00";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(111, 11);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(28, 15);
			this.lblSubtotal.TabIndex = 45;
			this.lblSubtotal.Text = "0.00";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(92, 81);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 15);
			this.label8.TabIndex = 44;
			this.label8.Text = "€";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(92, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 15);
			this.label7.TabIndex = 43;
			this.label7.Text = "€";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(92, 11);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(13, 15);
			this.label10.TabIndex = 42;
			this.label10.Text = "€";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 81);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(57, 15);
			this.label11.TabIndex = 41;
			this.label11.Text = "Discount:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 46);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 15);
			this.label12.TabIndex = 40;
			this.label12.Text = "Delivery:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(13, 11);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(54, 15);
			this.label13.TabIndex = 39;
			this.label13.Text = "Subtotal:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.lblTotal);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.Total);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.lblDiscount);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.lblDelivery);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.lblSubtotal);
			this.panel2.Location = new System.Drawing.Point(742, 57);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(158, 177);
			this.panel2.TabIndex = 51;
			// 
			// cbSelectCustomer
			// 
			this.cbSelectCustomer.FormattingEnabled = true;
			this.cbSelectCustomer.Location = new System.Drawing.Point(78, 17);
			this.cbSelectCustomer.Name = "cbSelectCustomer";
			this.cbSelectCustomer.Size = new System.Drawing.Size(299, 23);
			this.cbSelectCustomer.TabIndex = 52;
			this.cbSelectCustomer.SelectedIndexChanged += new System.EventHandler(this.cbSelectCustomer_SelectedIndexChanged);
			this.cbSelectCustomer.TextUpdate += new System.EventHandler(this.cbSelectCustomer_TextUpdate);
			// 
			// FrmShopNow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 520);
			this.Controls.Add(this.cbSelectCustomer);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.lvShoppingCart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvShop);
			this.Name = "FrmShopNow";
			this.Text = "Hello Organic";
			this.Load += new System.EventHandler(this.FrmShopNow_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnAddToCart;
		private ListView lvShop;
		private Label label1;
		private Panel panel1;
		private Label label6;
		private TextBox tbProductQuantity;
		private Label label5;
		private TextBox tbProductPrice;
		private Label label4;
		private Label label3;
		private TextBox tbProductName;
		private Label label2;
		private ListView lvShoppingCart;
		private Label label14;
		private Button button1;
		private Label lblTotal;
		private Label label9;
		private Label Total;
		private Label lblDiscount;
		private Label lblDelivery;
		private Label lblSubtotal;
		private Label label8;
		private Label label7;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Panel panel2;
		private Label label15;
		private TextBox tbProductDescription;
		private ComboBox cbSelectCustomer;
	}
}