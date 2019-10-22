<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master"  AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ShopWebFormsClient.Cart" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Shopping cart</title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
        <div>
            <h2>Your cart</h2>
            <h4>Items</h4>
            <asp:Table ID="CartProducts" runat="server">
            </asp:Table>
        </div>
        <asp:Button ID="EmptyCart" runat="server" OnClick="EmptyCart_Click" Text="Empty cart" /><br /><br />

</asp:Content>