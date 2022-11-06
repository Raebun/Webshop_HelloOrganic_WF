using BusinessLogic;
using DataAccess.DTO;

namespace HelloOrganic_WebshopWF.Customers
{
	public partial class FrmEditCustomers : Form
	{
		CustomerDTO customer;
		public FrmEditCustomers(CustomerDTO customerCurrent)
		{
			InitializeComponent();

			customer = customerCurrent;

			if (customerCurrent.CustomerId == 0)
			{
				pageTitle.Text = "Add new customer";
			}
			else
			{
				pageTitle.Text = "Edit customer";
				tbFirstName.Text = customer.FirstName;
				tbLastName.Text = customer.LastName;
				tbAddress.Text = customer.Address;
				tbCity.Text = customer.City;
				tbPostal.Text = customer.PostalCode;
				tbPhoneNumber.Text = customer.Phone;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (tbFirstName.Text != "" && tbLastName.Text != "" && tbAddress.Text != "" && tbCity.Text != "" && tbPostal.Text != "" && tbPhoneNumber.Text != "")
			{
				customer.FirstName = tbFirstName.Text;
				customer.LastName = tbLastName.Text;
				customer.Address = tbAddress.Text;
				customer.City = tbCity.Text;
				customer.PostalCode = tbPostal.Text;
				customer.Phone = tbPhoneNumber.Text;

				CustomerBLL customerBLL = new CustomerBLL();
				if (customer.CustomerId == 0)
				{
					customerBLL.Create(customer);
				}
				else
				{
					customerBLL.Update(customer);
				}

				this.Close();
			}
			else
			{
				MessageBox.Show("Vul alle velden in!");
			}
		}
	}
}
