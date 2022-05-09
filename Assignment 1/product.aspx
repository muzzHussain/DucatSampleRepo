<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Assignment_1.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtProduct" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblBrandName" runat="server" Text="Brand Name"></asp:Label>
            <asp:DropDownList ID="ddBrand" runat="server">
                <asp:ListItem Value="">--Select--</asp:ListItem>
                <asp:ListItem Value="1">Electra</asp:ListItem>
                <asp:ListItem Value="2">Haro</asp:ListItem>
                <asp:ListItem Value="3">Heller</asp:ListItem>
                <asp:ListItem Value="4">Pure Cycles</asp:ListItem>
                <asp:ListItem Value="5">Ritchey</asp:ListItem>
                <asp:ListItem Value="6">Strider</asp:ListItem>
                <asp:ListItem Value="7">Sun Bicycles</asp:ListItem>
                <asp:ListItem Value="8">Surly</asp:ListItem>
                <asp:ListItem Value="9">Trek</asp:ListItem>
                <asp:ListItem Value="11">Reebok</asp:ListItem>
                <asp:ListItem Value="12">Nike</asp:ListItem>
                
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="lblCategoryName" runat="server" Text="Category Name"></asp:Label>
            <asp:DropDownList ID="ddCategory" runat="server">
                <asp:ListItem Value="">--Select--</asp:ListItem> 
                <asp:ListItem Value="1">Children Bicycles</asp:ListItem> 
                <asp:ListItem Value="2">Comfort Bicycles</asp:ListItem> 
                <asp:ListItem Value="3">Cruisers Bicycles</asp:ListItem> 
                <asp:ListItem Value="4">Cyclocross Bicycles</asp:ListItem> 
                <asp:ListItem Value="5">Electric Bikes</asp:ListItem> 
                <asp:ListItem Value="6">Mountain Bikes</asp:ListItem> 
                <asp:ListItem Value="7">Road Bikes</asp:ListItem> 
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="lblModelYear" runat="server" Text="Model Year" ></asp:Label>
            <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblListPrice" runat="server" Text="List Price"></asp:Label>
            <asp:TextBox ID="txtList" runat="server"></asp:TextBox>
        </div>



        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
        <hr />
        <div>
            <asp:GridView ID="GridProduct" runat="server"></asp:GridView>
            <hr />
        </div>
        
    </form>
</body>
</html>
