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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace HelloOrganic_WebshopWF.Shopping
{
	public partial class FrmShopNow : Form
	{
		ProductBLL productBLL = new ProductBLL();
		ShoppingCartBLL shoppingCartBLL = new ShoppingCartBLL();
		ShoppingCartDTO shoppingCartDTO = new ShoppingCartDTO();
		CartItemBLL cartItemBLL = new CartItemBLL();
		CartItemDTO cartItem = new CartItemDTO();
		CustomerBLL customerBLL = new CustomerBLL();

		public FrmShopNow()
		{
			InitializeComponent();

			cbSelectCustomer.Text = "--Select Customer--";
			
			List<CustomerDTO> customerList = customerBLL.Read();
			foreach (CustomerDTO x in customerList)
			{
				//cbSelectCustomer.Items.Add("("+x.CustomerId +") "+ x.FirstName +" "+ x.LastName);
				cbSelectCustomer.Items.Add(x);
			}
		}

		private void FrmShopNow_Load(object sender, EventArgs e)
		{
			/*lvShop.Enabled = false;
			lvShoppingCart.Enabled = false;*/

			lvShop.Columns.Add("ID");
			lvShop.Columns.Add("Name", 150);
			lvShop.Columns.Add("Description", 200);
			lvShop.Columns.Add("unitCost", 60);
			lvShop.Columns.Add("Discount", 100);

			lvShop.View = View.Details;
			FillListViewProducts();

			lvShoppingCart.Columns.Add("cartitem");
			lvShoppingCart.Columns.Add("Product", 150);
			lvShoppingCart.Columns.Add("Quantity");
			lvShoppingCart.Columns.Add("Unitcost");

			lvShoppingCart.View = View.Details;			
		}

		public void FillListViewProducts()
		{
			List<ProductDTO> productList = productBLL.Read();

			lvShop.Items.Clear();
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

				lvShop.Items.Add(lvItem);
			}
		}

		public void FillListViewShoppingCart()
		{
			CustomerDTO selectedCustomer = (CustomerDTO)cbSelectCustomer.SelectedItem;

			List<CartItemDTO> cartItemsBelongingToCustomer = new List<CartItemDTO>();
			foreach (CartItemDTO cartItem in cartItemBLL.Read())
			{
				if (selectedCustomer != null)
				{
					if (selectedCustomer.ShoppingCart != null)
					{
						if (cartItem.ShoppingCart.CartId == selectedCustomer.ShoppingCart.CartId)
						{
							cartItemsBelongingToCustomer.Add(cartItem);
						}
					}
				}
			}

			lvShoppingCart.Items.Clear();
			foreach (CartItemDTO cartItem in cartItemsBelongingToCustomer)
			{
				ListViewItem lvItem = new ListViewItem(cartItem.ShoppingCart.CartId.ToString());
				lvItem.SubItems.Add(cartItem.Product.ProductName);
				lvItem.SubItems.Add(cartItem.Quantity.ToString());
				lvItem.SubItems.Add(cartItem.Product.UnitCost.ToString());

				lvItem.Tag = cartItem;

				lvShoppingCart.Items.Add(lvItem);
			}
		}

		private void btnAddToCart_Click(object sender, EventArgs e)
		{
			CustomerDTO selectedCustomer = (CustomerDTO)cbSelectCustomer.SelectedItem;

			// Add product and cart to cartitem
			if (tbProductName.Text != "")
			{
				if (selectedCustomer == null)
				{
					MessageBox.Show("Select a customer first");
				}
				else
				{
					// Check if customer has shopping cart
					if (selectedCustomer.ShoppingCart == null)
					{
						int cartId = shoppingCartBLL.Create(shoppingCartDTO);
						selectedCustomer.ShoppingCart = shoppingCartBLL.getShoppingCartId(cartId);
						shoppingCartBLL.AddShoppingCartToCustomer(selectedCustomer);
					}

					ProductDTO selectedProduct = (ProductDTO)lvShop.SelectedItems[0].Tag;

					cartItem.Product = selectedProduct;
					cartItem.Quantity = Convert.ToInt32(tbProductQuantity.Text);
					cartItem.ShoppingCart = selectedCustomer.ShoppingCart;

					cartItemBLL.Create(cartItem);
					FillListViewShoppingCart();
				}
			}
			else
			{
				MessageBox.Show("Select a product");
			}

			FillListViewShoppingCart();
		}

		private void lvShop_Click(object sender, EventArgs e)
		{
			ProductDTO selectedProduct = (ProductDTO)lvShop.SelectedItems[0].Tag;
			tbProductName.Text = selectedProduct.ProductName;
			tbProductPrice.Text = selectedProduct.UnitCost.ToString();
			tbProductDescription.Text = selectedProduct.ProductDescription;
			tbProductQuantity.Text = "1";
		}

		private void lvShop_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void cbSelectCustomer_TextUpdate(object sender, EventArgs e)
		{
			if (cbSelectCustomer.SelectedItem == null)
			{
				lvShop.Enabled = true;
				lvShoppingCart.Enabled = true;
			}
		}

		private void cbSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomerDTO selectedCustomer = (CustomerDTO)cbSelectCustomer.SelectedItem;
			if (selectedCustomer != null)
			{
				MessageBox.Show("You are shopping as " + selectedCustomer.FirstName);
				FillListViewShoppingCart();
			}
		}
	}
}
