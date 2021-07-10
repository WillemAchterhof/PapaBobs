﻿using System;
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
			var openOrders = Domain.OrderManager.GetOpenOrders();

			openOrdersGridView.DataSource = openOrders;
			openOrdersGridView.DataBind();
		}
	}
}