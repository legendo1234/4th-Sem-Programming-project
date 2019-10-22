<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ShopWebFormsClient.Register" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Register</title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
        <table ID="Table1" runat="server" class="auto-style3">
            <tr>
                <td class="auto-style4">
                        <label>Username: </label>
                </td>
                <td class="auto-style2">
                        <asp:TextBox ID="UserBox" runat="server" Width="179px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                        <label>Password: </label>
                </td>
                <td class="auto-style1">
                        <asp:TextBox ID="PasswordBox" TextMode="Password" runat="server" Width="179px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="RegisterButton" runat="server" OnClick="RegisterButton_Click" Text="Register" />
        </p>
    <p>
        <asp:Literal ID="RegStatus" runat="server"></asp:Literal>
    </p>
</asp:Content>