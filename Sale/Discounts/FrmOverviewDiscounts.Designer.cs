namespace HelloOrganic_WebshopWF.Sale.Discounts
{
	partial class FrmOverviewDiscounts
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
			this.lvDiscount = new System.Windows.Forms.ListView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvDiscount
			// 
			this.lvDiscount.FullRowSelect = true;
			this.lvDiscount.GridLines = true;
			this.lvDiscount.Location = new System.Drawing.Point(12, 12);
			this.lvDiscount.Name = "lvDiscount";
			this.lvDiscount.Size = new System.Drawing.Size(776, 398);
			this.lvDiscount.TabIndex = 3;
			this.lvDiscount.UseCompatibleStateImageBehavior = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(11, 417);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(712, 416);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(631, 416);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// FrmOverviewDiscounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.lvDiscount);
			this.Name = "FrmOverviewDiscounts";
			this.Text = "Overview discount";
			this.Load += new System.EventHandler(this.FrmOverviewDiscounts_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private ListView lvDiscount;
		private Button btnAdd;
		private Button btnDelete;
		private Button btnEdit;
	}
}