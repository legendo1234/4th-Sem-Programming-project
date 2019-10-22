<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShopWebFormsClient.Login" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
        <p>
            <asp:Label ID="UserLabel" runat="server">User</asp:Label><br />
            <asp:TextBox ID="UserBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="PassLabel" runat="server">Password</asp:Label><br />
            <asp:TextBox ID="PasswordBox" TextMode="Password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        </p>
        <p>
            <asp:Label ID="LoginStatus" runat="server" Text="Please login"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Logout" runat="server" Visible = "false" Text ="Logout" OnClick="Logout_Click" />
        </p>
</asp:Content>
