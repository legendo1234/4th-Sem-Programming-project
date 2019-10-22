<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ShopWebFormsClient.Main" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Main</title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
    <div>
        <h2>Welcome to the webshop!</h2>
        <asp:Literal ID="UserStatus" runat="server"></asp:Literal><br />
        <asp:HyperLink ID="LoginLink" NavigateUrl="~/Login.aspx" Visible="false" runat="server">Login</asp:HyperLink><br />
        <asp:HyperLink ID="RegisterLink" NavigateUrl="~/Register.aspx" Visible="false" runat="server">Register</asp:HyperLink><br />
        <p>Use the links above to navigate our site</p>
        <p>Browse our products</p>
        <p>View your shopping cart</p>
        <p>Checkout and complete your order</p>
        <p>View your account page</p>
    </div>
</asp:Content>
