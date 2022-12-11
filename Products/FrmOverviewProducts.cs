using BusinessLogic;
using DataAccess;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloOrganic_WebshopWF.Products
{
	public partial class FrmOverviewProducts : Form
	{
		ProductBLL productBLL = new ProductBLL();

		public FrmOverviewProducts()
		{
			InitializeComponent();
		}

		private void FrmOverviewProducts_Load(object sender, EventArgs e)
		{
			lvProducts.Columns.Add("ID");
			lvProducts.Columns.Add("Name", 150);
			lvProducts.Columns.Add("Description", 200);
			lvProducts.Columns.Add("unitCost", 60);
			lvProducts.Columns.Add("Discount", 100);

			lvProducts.View = View.Details;
			FillListView();
		}

		public void FillListView()
		{
			List<ProductDTO> productList = productBLL.Read();

			lvProducts.Items.Clear();
			foreach (ProductDTO x in productList)
			{
				ListViewItem lvItem = new ListViewItem(x.ProductId.ToString());
				lvItem.SubItems.Add(x.ProductName);
				lvItem.SubItems.Add(x.ProductDescription);
				lvItem.SubItems.Add(x.UnitCost.ToString());
				if (x.Discount != null)
				{
					lvItem.SubItems.Add(x.Discount.DiscountPercentage.ToString() + "% discount");
				}

				lvItem.Tag = x;

				lvProducts.Items.Add(lvItem);
			}

		}
	}
}
