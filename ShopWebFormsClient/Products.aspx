<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ShopWebFormsClient.Products" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title></title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
    <div>
        <h2>Products for sale</h2>
        <h4>Categories</h4>
        <asp:DropDownList ID="ListCategories" runat="server"></asp:DropDownList>
        <asp:Panel ID="PanelProducts" runat="server"></asp:Panel>
        <asp:Table ID="TableProducts" runat="server"></asp:Table>
    </div>
</asp:Content>