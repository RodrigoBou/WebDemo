<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataListEjemplo.aspx.cs" Inherits="ManejodeDatos_DataListEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" SelectCommand="SELECT * FROM [UserDetails]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyField="UserName" DataSourceID="SqlDataSource1" ForeColor="Black">
            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <FooterTemplate>
                fin lista
            </FooterTemplate>
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <HeaderTemplate>
                Lista Usuarios
            </HeaderTemplate>
            <ItemTemplate>
                UserName:
                <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                <br />
                Password:
                <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Country:
                <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
