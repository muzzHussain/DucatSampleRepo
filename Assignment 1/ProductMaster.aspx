<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductMaster.aspx.cs" Inherits="Assignment_1.ProductMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-top:5%;">

        

        <div class="form-group">
           <asp:Button runat="server" ID="btnCreate" Text="Create Product" CssClass="btn btn-primary" OnClick="btnCreate_Click"/>
       </div>
       
        <asp:GridView ID="GridProducts" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" OnRowCommand="GridProducts_RowCommand">
           <Columns>
                <asp:TemplateField HeaderText="Product Id">
                    <ItemTemplate>
                        <asp:Label ID="lblProductId" runat="server" Text='<%# Bind("product_id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label ID="lblPName" runat="server" Text='<%# Bind("product_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Category Name">
                    <ItemTemplate>
                        <asp:Label ID="lblCName" runat="server" Text='<%# Bind("category_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Brand Name">
                    <ItemTemplate>
                        <asp:Label ID="lblBName" runat="server" Text='<%# Bind("brand_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="List Price">
                    <ItemTemplate>
                        <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("list_price") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Model Year">
                    <ItemTemplate>
                        <asp:Label ID="lblModelYear" runat="server" Text='<%# Bind("model_year") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnUpdate" runat="server" CommandName="Update" CommandArgument='<%# Bind("product_id") %>' Text="Update" ></asp:Button>
                    </ItemTemplate>

                </asp:TemplateField>

                  <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Bind("product_id") %>' Text="Delete"></asp:Button>
                    </ItemTemplate>

                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <hr />

        <div>
            <div>
                <asp:HiddenField ID="HiddenPId" runat="server" />
            </div>
           <%--<div>
                <label for="ProductName" runat="server">Product Name</label>        
                <asp:TextBox ID="txtPN" runat="server"></asp:TextBox>
            </div>

            <div>
                <label for="CategoryName" runat="server">category Name</label>        
                <asp:DropDownList ID="txtCN" runat="server"></asp:DropDownList>
            </div>

            <div>
                <label for="BrandName" runat="server">Brand Name</label>        
                <asp:TextBox ID="txtBN" runat="server"></asp:TextBox>
            </div>

            <div>
                <label for="ModelYear" runat="server">Model Year</label>        
                <asp:TextBox ID="txtY" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="ListPrice" runat="server">List Price</label>        
                <asp:TextBox ID="txtLP" runat="server"></asp:TextBox>
            </div>


            <div class="btn-group">
                <asp:Button ID="btnSave" runat="server" class="btn-group" Text="Save"/>
            </div>
        </div>--%>
    </div>

</asp:Content>
