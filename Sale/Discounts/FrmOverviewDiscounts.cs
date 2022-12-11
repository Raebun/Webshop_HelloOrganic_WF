using BusinessLogic;
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

namespace HelloOrganic_WebshopWF.Sale.Discounts
{
	public partial class FrmOverviewDiscounts : Form
	{
		DiscountBLL discountBLL = new DiscountBLL();

		public FrmOverviewDiscounts()
		{
			InitializeComponent();
		}

		private void FrmOverviewDiscounts_Load(object sender, EventArgs e)
		{
			lvDiscount.Columns.Add("ID");
			lvDiscount.Columns.Add("Name");
			lvDiscount.Columns.Add("End");
			lvDiscount.Columns.Add("Percentage");

			lvDiscount.View = View.Details;
			FillListView();
		}

		public void FillListView()
		{
			List<DiscountDTO> discountList = discountBLL.Read();

			lvDiscount.Items.Clear();
			foreach (DiscountDTO x in discountList)
			{
				ListViewItem lvItem = new ListViewItem(x.DiscountId.ToString());
				lvItem.SubItems.Add(x.DiscountName);
				lvItem.SubItems.Add(x.DueTime.ToString());
				lvItem.SubItems.Add(x.DiscountPercentage.ToString());

				lvItem.Tag = x;

				lvDiscount.Items.Add(lvItem);
			}

		}
	}
}
