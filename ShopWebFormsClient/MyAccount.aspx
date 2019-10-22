<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="ShopWebFormsClient.MyAccount" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>My page</title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
    <asp:Button ID="LogoutButton" Text="Logout" runat="server" OnClick="LogoutButton_Click"/>
    <asp:Literal ID="LogoutStatus" Text="" runat="server"></asp:Literal>
</asp:Content>