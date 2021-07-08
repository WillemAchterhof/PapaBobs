using PapaBobs.DTO;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				var dto = GetNewDTO();
				CalculateTotalPrice(dto);
			}
		}
		protected void okButton_Click(object sender, EventArgs e)
		{
			var dto = GetNewDTO();
			Domain.OrderManager.CreateNewOrder(dto);
		}
		protected void CalculateTotalPrice_TextChanged(object sender, EventArgs e)
		{
			var dto = GetNewDTO();
			CalculateTotalPrice(dto);
		}
		private OrderDTO GetNewDTO()
		{
			Enum.TryParse(sizeDropDownList.SelectedValue, out DTO.Enums.SizeType pizzaSize);
			Enum.TryParse(crustDropDownList.SelectedValue, out DTO.Enums.CrustType crustSize);
			bool sausages = sausageCheckBox.Checked;
			bool pepperoni = pepperoniCheckBox.Checked;
			bool onions = onionsCheckBox.Checked;
			bool greenPeppers = greenPeppersCheckBox.Checked;
			decimal.TryParse(totalLabel.Text, NumberStyles.Currency, null, out decimal totalCost);
			string customerName = nameTextBox.Text;
			string customerAddres = addressTextBox.Text;
			string customerZip = zipTextBox.Text;
			string customerPhone = phoneTextBox.Text;

			DTO.Enums.PaymentType paymentType;
			if (cashRadioButton.Checked)
			{ Enum.TryParse("Cash", out paymentType); }
			else
			{ Enum.TryParse("Credit", out paymentType); }

			return Domain.CreateDTO.GetDTO(pizzaSize, crustSize, sausages, pepperoni, onions, greenPeppers, totalCost, customerName, customerAddres, customerZip, customerPhone, paymentType);
		}
		private void CalculateTotalPrice(OrderDTO dto)
		{
			decimal totalCost = Domain.GetPizzaPrize.CalculateNewPrize(dto);
			totalLabel.Text = string.Format($"{totalCost:c}");
		}
	}
}