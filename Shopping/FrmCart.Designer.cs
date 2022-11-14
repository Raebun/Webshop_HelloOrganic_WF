namespace HelloOrganic_WebshopWF.Shopping
{
	partial class FrmCart
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
			this.btnQuantity = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.lvCart = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbQuantity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.lblDelivery = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.Total = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnQuantity
			// 
			this.btnQuantity.Location = new System.Drawing.Point(130, 414);
			this.btnQuantity.Name = "btnQuantity";
			this.btnQuantity.Size = new System.Drawing.Size(54, 23);
			this.btnQuantity.TabIndex = 10;
			this.btnQuantity.Text = "Pas toe";
			this.btnQuantity.UseVisualStyleBackColor = true;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(323, 416);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 9;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			// 
			// lvCart
			// 
			this.lvCart.Location = new System.Drawing.Point(12, 12);
			this.lvCart.Name = "lvCart";
			this.lvCart.Size = new System.Drawing.Size(386, 398);
			this.lvCart.TabIndex = 7;
			this.lvCart.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 420);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 15);
			this.label1.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 418);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Quantity";
			// 
			// tbQuantity
			// 
			this.tbQuantity.Location = new System.Drawing.Point(72, 415);
			this.tbQuantity.Name = "tbQuantity";
			this.tbQuantity.Size = new System.Drawing.Size(52, 23);
			this.tbQuantity.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(418, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 15);
			this.label3.TabIndex = 14;
			this.label3.Text = "Subtotal:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(418, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 15);
			this.label4.TabIndex = 15;
			this.label4.Text = "Delivery:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(418, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 15);
			this.label5.TabIndex = 16;
			this.label5.Text = "Discount:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(497, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 15);
			this.label6.TabIndex = 17;
			this.label6.Text = "€";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(497, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 15);
			this.label7.TabIndex = 18;
			this.label7.Text = "€";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(497, 91);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "€";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(516, 21);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(28, 15);
			this.lblSubtotal.TabIndex = 20;
			this.lblSubtotal.Text = "0.00";
			// 
			// lblDelivery
			// 
			this.lblDelivery.AutoSize = true;
			this.lblDelivery.Location = new System.Drawing.Point(516, 56);
			this.lblDelivery.Name = "lblDelivery";
			this.lblDelivery.Size = new System.Drawing.Size(28, 15);
			this.lblDelivery.TabIndex = 21;
			this.lblDelivery.Text = "0.00";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Location = new System.Drawing.Point(516, 91);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(28, 15);
			this.lblDiscount.TabIndex = 22;
			this.lblDiscount.Text = "0.00";
			// 
			// Total
			// 
			this.Total.AutoSize = true;
			this.Total.Location = new System.Drawing.Point(418, 154);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(35, 15);
			this.Total.TabIndex = 23;
			this.Total.Text = "Total:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(497, 154);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 15);
			this.label9.TabIndex = 24;
			this.label9.Text = "€";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(516, 154);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(28, 15);
			this.lblTotal.TabIndex = 25;
			this.lblTotal.Text = "0.00";
			// 
			// FrmCart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 450);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.lblDiscount);
			this.Controls.Add(this.lblDelivery);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbQuantity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnQuantity);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.lvCart);
			this.Name = "FrmCart";
			this.Text = "Shopping Cart";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnQuantity;
		private Button btnRemove;
		private ListView lvCart;
		private Label label1;
		private Label label2;
		private TextBox tbQuantity;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label lblSubtotal;
		private Label lblDelivery;
		private Label lblDiscount;
		private Label Total;
		private Label label9;
		private Label lblTotal;
	}
}