namespace HelloOrganic_WebshopWF
{
	partial class FrmIndex
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shopNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.discountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.shopNowToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.ordersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// homeToolStripMenuItem
			// 
			this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
			this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.homeToolStripMenuItem.Text = "Home";
			// 
			// shopNowToolStripMenuItem
			// 
			this.shopNowToolStripMenuItem.Name = "shopNowToolStripMenuItem";
			this.shopNowToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.shopNowToolStripMenuItem.Text = "Shop now";
			this.shopNowToolStripMenuItem.Click += new System.EventHandler(this.shopNowToolStripMenuItem_Click);
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.productsToolStripMenuItem.Text = "Products";
			this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
			// 
			// customersToolStripMenuItem
			// 
			this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
			this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.customersToolStripMenuItem.Text = "Customers";
			this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
			// 
			// saleToolStripMenuItem
			// 
			this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discountsToolStripMenuItem});
			this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
			this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.saleToolStripMenuItem.Text = "Sale";
			// 
			// discountsToolStripMenuItem
			// 
			this.discountsToolStripMenuItem.Name = "discountsToolStripMenuItem";
			this.discountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.discountsToolStripMenuItem.Text = "Discounts";
			this.discountsToolStripMenuItem.Click += new System.EventHandler(this.discountsToolStripMenuItem_Click);
			// 
			// ordersToolStripMenuItem
			// 
			this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
			this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.ordersToolStripMenuItem.Text = "Orders";
			this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
			// 
			// FrmIndex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 605);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmIndex";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem homeToolStripMenuItem;
		private ToolStripMenuItem shopNowToolStripMenuItem;
		private ToolStripMenuItem productsToolStripMenuItem;
		private ToolStripMenuItem customersToolStripMenuItem;
		private ToolStripMenuItem saleToolStripMenuItem;
		private ToolStripMenuItem discountsToolStripMenuItem;
		private ToolStripMenuItem ordersToolStripMenuItem;
	}
}