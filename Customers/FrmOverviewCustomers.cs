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

namespace HelloOrganic_WebshopWF.Customers
{
	public partial class FrmOverviewCustomers : Form
	{
		CustomerBLL customerBLL = new CustomerBLL();
		CustomerDTO customerDTO = new CustomerDTO();

		public FrmOverviewCustomers()
		{
			InitializeComponent();
		}

		private void FrmOverviewCustomers_Load(object sender, EventArgs e)
		{
			lvCustomers.Columns.Add("ID");
			lvCustomers.Columns.Add("Firstname", 100);
			lvCustomers.Columns.Add("Lastname", 100);
			lvCustomers.Columns.Add("Address", 150);
			lvCustomers.Columns.Add("City", 100);
			lvCustomers.Columns.Add("Postal", 90);
			lvCustomers.Columns.Add("Phone", 90);
			lvCustomers.Columns.Add("Cart");

			lvCustomers.View = View.Details;
			FillListView();
		}

		public void FillListView()
		{
			List<CustomerDTO> customerList = customerBLL.Read();

			lvCustomers.Items.Clear();
			foreach(CustomerDTO x in customerList)
			{
				ListViewItem lvItem = new ListViewItem(x.CustomerId.ToString());
				lvItem.SubItems.Add(x.FirstName);
				lvItem.SubItems.Add(x.LastName);
				lvItem.SubItems.Add(x.Address);
				lvItem.SubItems.Add(x.City);
				lvItem.SubItems.Add(x.PostalCode);
				lvItem.SubItems.Add(x.Phone);
				if (x.ShoppingCart != null)
				{
					lvItem.SubItems.Add(x.ShoppingCart.CartId.ToString());
				}

				lvItem.Tag = x;

				lvCustomers.Items.Add(lvItem);
			}


			/*lvCustomers.Items.Clear();
			foreach(CustomerDTO x in customerBLL.GetAllCustomers())
			{
				ListViewItem lvItem = new ListViewItem(x.CustomerId.ToString());
				lvItem.SubItems.Add(x.FirstName);
				lvItem.SubItems.Add(x.LastName);
				lvItem.SubItems.Add(x.Address);
				lvItem.SubItems.Add(x.City);
				lvItem.SubItems.Add(x.PostalCode);
				lvItem.SubItems.Add(x.Phone);

				lvItem.Tag = x;

				lvCustomers.Items.Add(lvItem);
			}*/
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			CustomerDTO customer = (CustomerDTO)lvCustomers.SelectedItems[0].Tag;
			
			customerBLL.Delete(customer);
			FillListView();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			CustomerDTO updateCustomer = (CustomerDTO)lvCustomers.SelectedItems[0].Tag;
			FrmEditCustomers editCustomerForm = new FrmEditCustomers(updateCustomer);

			editCustomerForm.Show();
			FillListView();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FrmEditCustomers addCustomerForm = new FrmEditCustomers(customerDTO);
			addCustomerForm.Show();
			FillListView();
		}

		private void btnRefreshLv_Click(object sender, EventArgs e)
		{
			FillListView();
		}
	}
}
