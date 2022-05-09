<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Assignment_1.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div style="margin-top:10%;">
    
       <asp:HiddenField ID="hiddenPID" runat="server" />

       <div class="form-group">
           <label>Product Name</label>
           <asp:TextBox ID="txtPN" runat="server"></asp:TextBox>
       </div>

       <div class="form-group">
           <label>Brand Name</label>
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
       <div class="form-group">
           <label>Category Name</label>
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
            <Label>Model Year</Label>
            <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        </div>
       <br />
        <div>
            <Label>List Price</Label>
            <asp:TextBox ID="txtList" runat="server"></asp:TextBox>
        </div>
       <br />
       <div class="form-group">
           <asp:Button runat="server" ID="btnSave" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
       </div>

       <div class="form-group">
           <asp:LinkButton runat="server" ID="LinkBtnPro" Text="Return to Products" PostBackUrl="~/ProductMaster.aspx"/>
       </div>
   </div>
</asp:Content>
