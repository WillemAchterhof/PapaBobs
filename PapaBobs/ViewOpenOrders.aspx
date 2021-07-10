<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOpenOrders.aspx.cs" Inherits="PapaBobs.ViewOpenOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="openOrdersGridView" runat="server" AutoGenerateColumns="False" >
				<Columns>
					<asp:BoundField DataField="Completed" HeaderText="Completed" />
					<asp:BoundField DataField="OrderID" HeaderText="Order ID" />
					<asp:BoundField DataField="PizzaSize" HeaderText="Pizza Size" />
					<asp:BoundField DataField="CrustSize" HeaderText="Crust Size" />
					<asp:BoundField DataField="Sausages" HeaderText="Sausages" />
					<asp:BoundField DataField="Pepperoni" HeaderText="Pepperoni" />
					<asp:BoundField DataField="Onions" HeaderText="Onions" />
					<asp:BoundField DataField="GreenPeppers" HeaderText="Green Peppers" />
					<asp:BoundField DataField="TotalPrize" HeaderText="Total Cost" />
					<asp:BoundField DataField="CustomerName" HeaderText="Name" />
					<asp:BoundField DataField="CustomerAddress" HeaderText="Address" />
					<asp:BoundField DataField="CustomerZip" HeaderText="Zip" />
					<asp:BoundField DataField="CustomerPhone" HeaderText="Phone" />
					<asp:BoundField DataField="PaymentMethod" HeaderText="Payment Type" />
				</Columns>
			</asp:GridView>
        </div>
    </form>
</body>
</html>
