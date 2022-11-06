namespace HelloOrganic_WebshopWF
{
	public partial class FrmIndex : Form
	{
		public FrmIndex()
		{
			InitializeComponent();
		}

/*		private void formExists<T>() where T : Form, new()
		{
			bool foundForm = false;
			
			foreach(Form x in MdiChildren)
			{
				if (x.GetType() == typeof(T))
				{
					x.WindowState = FormWindowState.Normal;
					foundForm = true;
				}
			}
			if (!foundForm)
			{
				(new T { MdiParent = this }).Show();
			}
		}*/

		private void shopNowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TestBO testBO = new TestBO();
			bool foundForm = false;

			foreach (Form x in MdiChildren)
			{
				if (x.GetType() == typeof(Shopping.FrmShopNow))
				{
					x.WindowState = FormWindowState.Normal;
					foundForm = true;
				}
			}
			if (!foundForm)
			{
				Shopping.FrmShopNow form = new Shopping.FrmShopNow();// parameter testBo
				form.MdiParent = this;
				form.Show();
			}
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TestBO testBO = new TestBO();
			bool foundForm = false;

			foreach (Form x in MdiChildren)
			{
				if (x.GetType() == typeof(Products.FrmOverviewProducts))
				{
					x.WindowState = FormWindowState.Normal;
					foundForm = true;
				}
			}
			if (!foundForm)
			{
				Products.FrmOverviewProducts form = new Products.FrmOverviewProducts();// parameter testBo
				form.MdiParent = this;
				form.Show();
			}
		}

		private void customersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// CustomerDTO customer = new CustomerDTO();
			bool foundForm = false;

			foreach (Form x in MdiChildren)
			{
				if (x.GetType() == typeof(Customers.FrmOverviewCustomers))
				{
					x.WindowState = FormWindowState.Normal;
					foundForm = true;
				}
			}
			if (!foundForm)
			{
				Customers.FrmOverviewCustomers form = new Customers.FrmOverviewCustomers();// parameter testBo
				form.MdiParent = this;
				form.Show();
			}
		}

		private void discountsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TestBO testBO = new TestBO();
			bool foundForm = false;

			foreach (Form x in MdiChildren)
			{
				if (x.GetType() == typeof(Sale.Discounts.FrmOverviewDiscounts))
				{
					x.WindowState = FormWindowState.Normal;
					foundForm = true;
				}
			}
			if (!foundForm)
			{
				Sale.Discounts.FrmOverviewDiscounts form = new Sale.Discounts.FrmOverviewDiscounts();// parameter testBo
				form.MdiParent = this;
				form.Show();
			}
		}

		private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TestBO testBO = new TestBO();
			bool foundForm = false;

			foreach (Form x in MdiChildren)
			{
				if (x.GetType() == typeof(Orders.FrmOverviewOrders))
				{
					x.WindowState = FormWindowState.Normal;
					foundForm = true;
				}
			}
			if (!foundForm)
			{
				Orders.FrmOverviewOrders form = new Orders.FrmOverviewOrders();// parameter testBo
				form.MdiParent = this;
				form.Show();
			}
		}
	}
}