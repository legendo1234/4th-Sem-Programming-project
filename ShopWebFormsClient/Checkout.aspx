<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ShopWebFormsClient.Checkout" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title></title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
        <div>
            <h2>Checkout cart</h2>
            <h4>Order details</h4>
            <asp:Literal ID="OrderDetails" runat="server" Text=""></asp:Literal><br /><br />
            <asp:TextBox ID="CardInput" runat="server"></asp:TextBox><br />
            <asp:Button ID="PlaceOrder" runat="server" Text="Pay and place order" OnClick="PlaceOrder_Click" /><br /><br />
            <asp:Label ID="OrderStatus" runat="server" Text=""></asp:Label><br /> <br /><br />
        </div>
</asp:Content>