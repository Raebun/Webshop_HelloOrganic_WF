namespace HelloOrganic_WebshopWF.Products
{
	partial class FrmEditProducts
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
			this.tbProductDescription = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbUnitCost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pageTitle = new System.Windows.Forms.Label();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbProductDescription
			// 
			this.tbProductDescription.Location = new System.Drawing.Point(29, 179);
			this.tbProductDescription.Multiline = true;
			this.tbProductDescription.Name = "tbProductDescription";
			this.tbProductDescription.Size = new System.Drawing.Size(255, 226);
			this.tbProductDescription.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 22;
			this.label5.Text = "Description";
			// 
			// tbUnitCost
			// 
			this.tbUnitCost.Location = new System.Drawing.Point(208, 108);
			this.tbUnitCost.Name = "tbUnitCost";
			this.tbUnitCost.Size = new System.Drawing.Size(76, 23);
			this.tbUnitCost.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(208, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 15);
			this.label3.TabIndex = 20;
			this.label3.Text = "Unitcost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 15);
			this.label2.TabIndex = 19;
			// 
			// pageTitle
			// 
			this.pageTitle.AutoSize = true;
			this.pageTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.pageTitle.Location = new System.Drawing.Point(29, 20);
			this.pageTitle.Name = "pageTitle";
			this.pageTitle.Size = new System.Drawing.Size(86, 28);
			this.pageTitle.TabIndex = 18;
			this.pageTitle.Text = "Product";
			// 
			// tbProductName
			// 
			this.tbProductName.Location = new System.Drawing.Point(29, 108);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(173, 23);
			this.tbProductName.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 16;
			this.label1.Text = "Name";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(29, 411);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// FrmEditProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 450);
			this.Controls.Add(this.tbProductDescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbUnitCost);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pageTitle);
			this.Controls.Add(this.tbProductName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Name = "FrmEditProducts";
			this.Text = "Product Information";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox tbProductDescription;
		private Label label5;
		private TextBox tbUnitCost;
		private Label label3;
		private Label label2;
		private Label pageTitle;
		private TextBox tbProductName;
		private Label label1;
		private Button btnSave;
	}
}