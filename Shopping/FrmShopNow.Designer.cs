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
			this.lvShopProducts = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// btnAddToCart
			// 
			this.btnAddToCart.Location = new System.Drawing.Point(713, 416);
			this.btnAddToCart.Name = "btnAddToCart";
			this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
			this.btnAddToCart.TabIndex = 12;
			this.btnAddToCart.Text = "Add to cart";
			this.btnAddToCart.UseVisualStyleBackColor = true;
			// 
			// lvShopProducts
			// 
			this.lvShopProducts.Location = new System.Drawing.Point(12, 12);
			this.lvShopProducts.Name = "lvShopProducts";
			this.lvShopProducts.Size = new System.Drawing.Size(776, 398);
			this.lvShopProducts.TabIndex = 8;
			this.lvShopProducts.UseCompatibleStateImageBehavior = false;
			// 
			// FrmShopNow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddToCart);
			this.Controls.Add(this.lvShopProducts);
			this.Name = "FrmShopNow";
			this.Text = "Shop products";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnAddToCart;
		private ListView lvShopProducts;
	}
}