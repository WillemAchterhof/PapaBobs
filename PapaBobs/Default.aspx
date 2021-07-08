<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobs.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
	<a href="PlacedOrders.aspx">Placed Orders</a>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header">
               <h1>Papa Bob's Pizza</h1> 
                <p class="lead">Pizza to Code Bye</p>
                <hr />
            </div>

            <div class="form-group">
                <label>Size</label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="CalculateTotalPrice_TextChanged">
                    <asp:ListItem Text="Small (12 inch - $12)" Value ="Small" />
                    <asp:ListItem Text="Medium (14 inch - $14)" Value ="Medium" Selected="True"  />
                    <asp:ListItem Text="Large (16 inch - $16)" Value ="Large"  />
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Crust:</label>
                <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="CalculateTotalPrice_TextChanged">
                    <asp:ListItem Text="Thin" Value ="Thin"  />
                    <asp:ListItem Text="Regular" Value ="Regular" Selected="True" />
                    <asp:ListItem Text="Thick (+ $2)" Value ="Thick"  />
                </asp:DropDownList>

                <br />
                <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="CalculateTotalPrice_TextChanged" />Sausage</label></div>
                <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="CalculateTotalPrice_TextChanged" />Pepperoni</label></div>
                <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="CalculateTotalPrice_TextChanged" />Onions</label></div>
                <div class="checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="CalculateTotalPrice_TextChanged" />Green Peppers</label></div>


            </div>
            <br />
              <div class="form-group">
                  <h3>Deliver To:</h3>
                  <label>Name: </label>
                  <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control" />
                  <label>Address: </label>
                  <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control" />
                  <label>Zip: </label>
                  <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control" />
                  <label>Phone: </label>
                  <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control" />
              </div>
            
            <h3>Payment:</h3>
            <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="PaymentGroup" Checked="true" />Cash</label></div>
            <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="PaymentGroup" Checked="false" />Credit</label></div>

            <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" OnClick="orderButton_Click" />
            <p>&nbsp;</p>
            <asp:Label ID="validationLabel" runat="server" Text="" Visible="false" CssClass="bg-danger"></asp:Label>
            <h3>Total Cost: <asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            
        </div>
    </form>
	<script src="Scripts/jquery-3.6.0.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
