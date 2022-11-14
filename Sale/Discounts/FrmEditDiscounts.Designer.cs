namespace HelloOrganic_WebshopWF.Sale.Discounts
{
	partial class FrmEditDiscounts
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
			this.label5 = new System.Windows.Forms.Label();
			this.tbDiscountPercentage = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pageTitle = new System.Windows.Forms.Label();
			this.tbDiscountName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.dtpDiscountDue = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 31;
			this.label5.Text = "Description";
			// 
			// tbDiscountPercentage
			// 
			this.tbDiscountPercentage.Location = new System.Drawing.Point(201, 106);
			this.tbDiscountPercentage.Name = "tbDiscountPercentage";
			this.tbDiscountPercentage.Size = new System.Drawing.Size(76, 23);
			this.tbDiscountPercentage.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 29;
			this.label3.Text = "Discount %";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 15);
			this.label2.TabIndex = 28;
			// 
			// pageTitle
			// 
			this.pageTitle.AutoSize = true;
			this.pageTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.pageTitle.Location = new System.Drawing.Point(22, 18);
			this.pageTitle.Name = "pageTitle";
			this.pageTitle.Size = new System.Drawing.Size(96, 28);
			this.pageTitle.TabIndex = 27;
			this.pageTitle.Text = "Discount";
			// 
			// tbDiscountName
			// 
			this.tbDiscountName.Location = new System.Drawing.Point(22, 106);
			this.tbDiscountName.Name = "tbDiscountName";
			this.tbDiscountName.Size = new System.Drawing.Size(173, 23);
			this.tbDiscountName.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 25;
			this.label1.Text = "Name";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(22, 233);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// dtpDiscountDue
			// 
			this.dtpDiscountDue.Location = new System.Drawing.Point(22, 177);
			this.dtpDiscountDue.Name = "dtpDiscountDue";
			this.dtpDiscountDue.Size = new System.Drawing.Size(255, 23);
			this.dtpDiscountDue.TabIndex = 33;
			// 
			// FrmEditDiscounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 268);
			this.Controls.Add(this.dtpDiscountDue);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbDiscountPercentage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pageTitle);
			this.Controls.Add(this.tbDiscountName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Name = "FrmEditDiscounts";
			this.Text = "Discount";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label5;
		private TextBox tbDiscountPercentage;
		private Label label3;
		private Label label2;
		private Label pageTitle;
		private TextBox tbDiscountName;
		private Label label1;
		private Button btnSave;
		private DateTimePicker dtpDiscountDue;
	}
}