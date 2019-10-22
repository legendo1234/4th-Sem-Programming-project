<%@ Page Language="C#" MasterPageFile="~/WebshopMaster.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ShopWebFormsClient.Product" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <title></title>
</asp:Content>
<asp:Content ContentPlaceHolderID="body" runat="server">
    <br />
        <table>
            <tr>
                <td rowspan ="4">img?</td>
                <td><h2><asp:Label ID ="labelName" Text ="Name" runat ="server"></asp:Label></h2></td>
            </tr>
            <tr>
                <td><asp:Label ID ="labelDescription" Text ="Description" runat ="server"></asp:Label><br />
                    Price: <asp:Label ID ="labelPrice" Text ="0" runat ="server"></asp:Label></td>
                <asp:Label ID="labelQuantity" Text ="" runat="server"></asp:Label>
            </tr>
            <tr>
                <td>Product ID: <asp:Label ID ="labelId" Text ="" runat ="server"></asp:Label></td>
                <td>Quantity:
                <asp:DropDownList ID ="quantitySelect" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td><asp:Label ID ="labelAvailable" Text ="Available" runat ="server"></asp:Label></td>
                <td><asp:Button ID="btnAddToCart" runat="server" Text="Add to cart" OnClick="btnAddToCart_Click"/></td>
            </tr>
        </table>
        <asp:Label ID="AddStatus" runat="server"></asp:Label><br />
</asp:Content>