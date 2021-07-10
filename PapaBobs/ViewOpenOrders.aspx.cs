using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs
{
	public partial class ViewOpenOrders : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				GetOpenOrders();
			}
		}
		protected void openOrdersGridView_RowCommand1(object sender, GridViewCommandEventArgs e)
		{
			int index = Convert.ToInt32(e.CommandArgument);
			GridViewRow row = openOrdersGridView.Rows[index];
			var value = row.Cells[1].Text.ToString();
			Guid.TryParse(value, out Guid orderID);

			Domain.OrderManager.CompleteOrder(orderID);
			GetOpenOrders();
		}
		private void GetOpenOrders()
		{
			var openOrders = Domain.OrderManager.GetOpenOrders();

			openOrdersGridView.DataSource = openOrders;
			openOrdersGridView.DataBind();
		}
	}
}